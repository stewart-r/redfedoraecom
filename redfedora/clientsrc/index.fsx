module App

#load "angularFable.fsx"
#r "../node_modules/fable-core/Fable.Core.dll"

open Fable.Core
open Fable.Core.JsInterop
open AngularFable.NgFable

let app = AngularFable.NgFable.angular.``module`` "app" [||] 

type TestCtrl() = 
    member this.Val1() = "boom";



app?controller("test", TestCtrl)

