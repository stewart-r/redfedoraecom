module GridCellView

#load "../app.fsx"
#load "../angularFable.fsx"
#load "product.fsx"
open App
open AngularFable.NgFable
open Product


type GridCellDirective() =
    
    member val templateUrl = "products/gridCell.html" with get, set

    interface IDirective with 
        member val restrict = "EA" with get, set

    static member Factory:array<obj> = [|"",GridCellDirective.GetInstance|]
    static member GetInstance() = GridCellDirective() :> IDirective


type GridCellCtrl(scope:IProductScope) = 
    member val Scope = scope with get,set 
    static member Factory:array<obj> = [|"$scope"; GridCellCtrl.GetInstance|]
    static member GetInstance (scope:IProductScope) = 
        let ret = GridCellCtrl(scope)
        ret.Scope.product <- Product("My Title","My Description")
        ret







