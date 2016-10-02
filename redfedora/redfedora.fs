module webserver
open Suave
open Suave.Sockets
open Suave.Sockets.Control
open Suave.WebSocket
open Suave.Operators
open Suave.Filters
open System
open System.Net
open System.IO


[<EntryPoint>]
let main [| port |] =
    let localHome = @"C:\Users\stewa_000\Source\Repos\SlAccount\.build\webserver\output"
    let remoteHome = @"D:\home\site\wwwroot\output"
    let home = 
        if (not (Directory.Exists remoteHome))
        then localHome
        else remoteHome

    let config =
        { defaultConfig with
                bindings = [ HttpBinding.mk HTTP IPAddress.Loopback (uint16 port) ]
                listenTimeout = TimeSpan.FromMilliseconds 3000.
                homeFolder = Some home
                }

    let app : WebPart =
        choose [
            Filters.GET >=> choose [ 
                    Filters.path "/" >=> Files.file "output/index.html"
                    Files.browseHome  ]
            RequestErrors.NOT_FOUND "Grr - Page not found." 
            ]
    startWebServer config app
    0 // return an integer exit code