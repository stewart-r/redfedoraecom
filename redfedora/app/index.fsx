module App

#load "angular.fsx"
#r "../node_modules/fable-core/Fable.Core.dll"

open Fable.Core
open Fable.Core.JsInterop
open Angular.angular

let y = Angular.x + 1
let app = angular.``module`` "app" [||] 

