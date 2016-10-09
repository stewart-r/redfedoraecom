module App

#load "angularFable.fsx"
#r "../node_modules/fable-core/Fable.Core.dll"

open Fable.Core
open Fable.Core.JsInterop
open AngularFable.NgFable
open Microsoft.FSharp.Quotations

//Angular App
let app = AngularFable.NgFable.angular.``module``("app",[||])