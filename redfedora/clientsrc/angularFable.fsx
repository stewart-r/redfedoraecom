#r "../node_modules/fable-core/Fable.Core.dll"
open Fable.Core
open Fable.Import
open System

module NgFable =

    
    type NgModelMap(mapType:string) = 
        member this.ngModel = mapType 
    
    type IScope = 
        abstract member ``$parent``:IScope with get,set

    type IDirective = 
        abstract member restrict :string with get,set
        
        
        
    type IAngularApp =
        abstract member directive : name:string * fn:(unit -> IDirective)  -> IDirective
        abstract member controller : name:string * dependencies:array<obj> -> obj
    
    type IAngularStatic = 
        abstract member ``module`` : name:string * ?requires:array<string> * ?fn:obj -> IAngularApp
        

    [<Import("*","angular")>]    
    let angular :IAngularStatic = jsNative
    

    

