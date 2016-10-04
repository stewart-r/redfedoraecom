#r "../node_modules/fable-core/Fable.Core.dll"
open Fable.Core

let x =1

[<Import("*","angular")>]
module angular = 
    type IAngularStatic = 
        abstract member ``module``: string -> array<string> -> obj

    let angular :IAngularStatic = jsNative
    

