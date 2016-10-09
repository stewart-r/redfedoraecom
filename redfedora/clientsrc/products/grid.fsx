module GridView

#load "../app.fsx"
#load "../angularFable.fsx"
#load "product.fsx"
open App
open AngularFable.NgFable
open Product

type GridDirective() =
    
    member val templateUrl = "products/grid.html" with get, set

    interface IDirective with 
        member val restrict = "EA" with get, set

    static member Factory:array<obj> = [|"",GridDirective.GetInstance|]
    static member GetInstance() = GridDirective() :> IDirective

type GridCtrl(http) = 
    let products = 
        [|for i in 1 .. 26 -> 
            let name = sprintf "product%d" i
            let desc = sprintf "some description of %d" i
            let imgUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcS6CmRDXEWsVbQ7xwJV1fj7Bci_WxMAsj2nwxglWu-SG5K8dFjbCsE8ss4"
            Product(name,desc,imgUrl)|]

    let _rows = 
        [|for i in 0 .. (products.Length / 3 + 1) -> 
            products |> Array.skip (i * 3) |> Array.take 3|]
    member val Http = http with get,set 
    member this.rows () = _rows

    static member Factory:array<obj> = [|"$http"; GridCtrl.GetInstance|]
    static member GetInstance (http) = 
        GridCtrl(http)
        