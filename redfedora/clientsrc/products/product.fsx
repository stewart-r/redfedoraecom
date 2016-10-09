module Product
#load "../app.fsx"
#load "../angularFable.fsx"

open App
open AngularFable.NgFable


type Product(title:string, desc:string) = 
    member this.Title = title
    member this.Description = desc

type IProductScope = 
    inherit IScope
    abstract member product:Product with get,set
