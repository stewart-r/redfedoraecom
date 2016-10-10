module ReadFile

type Product = {
    Name:string;
    Descriprion:string;
    Category:string;
    Brand:string;
    Colour:string;
    Material:Option<string>;
    Attributes:array<string>;
    Price:decimal;
    Rrp:decimal;
}

open OfficeOpenXml
open System
open System.IO

let toStringOption s = 
    if (isNull s) then 
        None 
    else
        Some (s.ToString())

let getVal r c (ws:ExcelWorksheet) = 
    ws.Cells.[r,c].Value
    |> toStringOption

let getCol c (ws:ExcelWorksheet) = 
    let endRow = ws.Dimension.End.Row
    [1..endRow]
    |> Seq.map (fun i -> getVal i c ws)
    |> Seq.filter (fun x -> x.IsSome)
    |> Seq.filter (fun x -> x.Value.Trim().Length > 0)
    |> Seq.map(fun x -> x.Value)

let products = 
    let fInfo = new FileInfo("productgen.xlsx")
    use xl = new ExcelPackage(fInfo)
    let ws = xl.Workbook.Worksheets.["Sheet1"]
    
    let brands = getCol 1 ws
    let categories = getCol 2 ws
    let colours = getCol 3 ws
    let materials = getCol 4 ws
    let attrs = getCol 5 ws

    [brands;categories;colours;materials;attrs]
    |> getCombinations


        





