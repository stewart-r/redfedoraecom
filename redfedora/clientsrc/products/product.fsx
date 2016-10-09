module Product
#load "../app.fsx"
#load "../angularFable.fsx"

open App
open AngularFable.NgFable


type Product(title:string, desc:string, imgUrl:string) = 
    member this.Title = title
    member this.Description = desc
    member this.imageUrl = imgUrl

type IProductScope = 
    inherit IScope
    abstract member product:Product with get,set
