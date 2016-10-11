// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

[<EntryPoint>]
let main argv = 
    let prods = ReadFile.products
    WriteXml.writeProds prods
    
    0 // return an integer exit code
