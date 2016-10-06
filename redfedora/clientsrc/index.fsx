module App

#load "angularFable.fsx"
#r "../node_modules/fable-core/Fable.Core.dll"

open Fable.Core
open Fable.Core.JsInterop
open Microsoft.FSharp.Quotations

let app = AngularFable.NgFable.angular.``module``("app",[||])

type TestCtrl() =
    
    member this.Val1() = "boom";

    
    [<Emit("TestCtrl")>]
    static member Factory () = 
        TestCtrl()

// let f1 () =  
//     1

// let f2 = System.Func<int>(fun _ -> 1)

// let someRefTof1:unit -> int = f1



app?controller("test", TestCtrl.Factory())

