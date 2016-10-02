// include Fake libs
#r "./packages/FAKE/tools/FakeLib.dll"

open Fake
open System

// Directories
let buildDir  = "./build/"
let deployDir = "./deploy/"
let portNumber = 8901


// Filesets
let appReferences  =
    !! "/**/*.csproj"
    ++ "/**/*.fsproj"

// version info
let version = "0.1"  // or retrieve from CI server

let copyAppFolder () =
    System.IO.File.WriteAllText(@"C:\temp\" + Guid.NewGuid().ToString(),DateTime.Now.ToString())
    CopyDir  (buildDir </> "app") ("redfedora" </> "app") (fun f -> true)

// Targets
Target "Clean" (fun _ ->
    CleanDirs [buildDir; deployDir]
)

Target "CopyAppFolder" (fun _ ->
    copyAppFolder()
)

Target "Build" (fun _ ->
    // compile all projects below src/app/
    MSBuildDebug buildDir "Build" appReferences
    |> Log "AppBuild-Output: "
)   

Target "Deploy" (fun _ ->
    !! (buildDir + "/**/*.*")
    -- "*.zip"
    |> Zip buildDir (deployDir + "ApplicationName." + version + ".zip")
)

Target "Run" (fun _ -> 
    let timeOut = TimeSpan.FromMinutes 3.0
    let procInf (info:Diagnostics.ProcessStartInfo) =
        info.FileName <- buildDir </> "redfedora.exe"
        info.Arguments <- portNumber.ToString()
    //let res = ExecProcess procInf timeOut
    fireAndForget procInf
    
    let startPage = sprintf "http://127.0.0.1:%d" portNumber 
    Diagnostics.Process.Start(startPage) |> ignore
    use watcher = !! "redfedora/app/**/*.*" |> WatchChanges (fun c -> copyAppFolder())
    System.Console.Read() |> ignore
    ()
)




"Build" 
    ==> "Run"

// Build order
"Clean"
  ==> "CopyAppFolder"
  ==> "Build"
  ==> "Deploy"

// start build
RunTargetOrDefault "Build"
