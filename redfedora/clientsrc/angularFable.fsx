#r "../node_modules/fable-core/Fable.Core.dll"
open Fable.Core
open Fable.Import
open System

module NgFable =
    
    type IAngularStatic = 
        // abstract member ``module``() name:string -> ?requires:array<string> -> ?fn:obj -> obj
        abstract member ``module`` : name:string * ?requires:array<string> * ?fn:obj -> int
        

    [<Import("*","angular")>]    
    let angular :IAngularStatic = jsNative
    

