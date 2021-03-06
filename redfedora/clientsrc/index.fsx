module Main

#r "../node_modules/fable-core/Fable.Core.dll"
#load "angularFable.fsx"
#load "app.fsx"
#load "./products/grid.fsx"
#load "./products/gridViewCell.fsx"

open Fable.Core
open Fable.Core.JsInterop
open AngularFable.NgFable
open Microsoft.FSharp.Quotations
open App
open GridCellView
open GridView


app.controller("gridCellCtrl",GridCellCtrl.Factory)
app.directive("gridCell",GridCellDirective.GetInstance)
app.controller("gridCtrl",GridCtrl.Factory)
app.directive ("grid",GridDirective.GetInstance)