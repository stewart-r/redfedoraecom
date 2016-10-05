#r "../node_modules/fable-core/Fable.Core.dll"
open Fable.Core
open Fable.Import


module NgFable =
    
    type IAngularStatic = 
        abstract member ``module``: string -> array<string> -> obj

    [<Import("*","angular")>]    
    let angular :IAngularStatic = jsNative
    

