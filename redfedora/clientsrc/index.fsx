module App

#load "angularFable.fsx"
#r "../node_modules/fable-core/Fable.Core.dll"

open Fable.Core
open Fable.Core.JsInterop
open AngularFable.NgFable
open Microsoft.FSharp.Quotations

//Angular App
let app = AngularFable.NgFable.angular.``module``("app",[||])

//Angular Controller
type TestCtrl(http) =
    let mutable str = "not retrieved yet" 
    member this.Http = http
    member this.Val1() = "boom";
    member this.Val2() = str;

    member this.Fetch() = 
        this.Http
            ?get("/api/ss")
            ?``then``(fun r -> str <- (r?data.ToString()))

    //CTOR & dependencies. (in typescript these would be injected through $inject service but this requires js decorator support)
    static member Factory:array<obj> = [|"$http"; TestCtrl.GetInstance|]
    static member GetInstance (http) = 
        TestCtrl(http)

//Angular directive
type TestDirective() =
    
    member val template = "<b>Im coming from the directive!</b>" with get, set

    interface IDirective with 
        member val restrict = "EA" with get, set

    static member Factory:array<obj> = [|"",TestCtrl.GetInstance|]
    static member GetInstance() = TestDirective() :> IDirective


app.controller("test",TestCtrl.Factory)
app.directive("testDirective",TestDirective.GetInstance)

