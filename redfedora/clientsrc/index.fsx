module App

#load "angularFable.fsx"
#r "../node_modules/fable-core/Fable.Core.dll"

open Fable.Core
open Fable.Core.JsInterop


let app = AngularFable.NgFable.angular.``module``("app",[||])

type TestCtrl() = 
    
    member this.Val1() = "boom";

let f1 () = 
    1

let someRefTof1 = f1

let f2 f (x:int) = 
    let a = f()
    a * a

let value1 = f2 f1 1

//app?controller("test", t2)

