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
    [2..endRow]
    |> Seq.map (fun i -> getVal i c ws)
    |> Seq.filter (fun x -> x.IsSome)
    |> Seq.filter (fun x -> x.Value.Trim().Length > 0)
    |> Seq.map(fun x -> x.Value)

let rnd = Random()

let prices = [ 29.99m; 39.99m; 99.99m; 44.59m;]

let generateProduct b (c:string) (m:string) cl (attrs:List<string>) = 
    let rnd1 = rnd.Next(0,3)
    if rnd1 > 0 then
        let attrRnd = rnd.Next(0,4)
        let attrAttr = 
            match attrRnd with
            | 0 -> [attrs |> List.head]
            | 1 -> [attrs |> List.skip 1 |> List.head]
            | 2 -> attrs
            | 3 -> []
        let material = 
            if m.Trim().Length > 0 then Some m else None  
        let price = prices |> List.minBy(fun s -> Guid.NewGuid())
        let cat = c.Split('>') |> Seq.skip 1 |> Seq.head |> (fun st -> st.Trim()) |> (fun st -> st.Remove(st.Length - 1))
        let rrp = price + ((attrRnd |> decimal) * 10.0m)
        let ret = {
            Name = sprintf "%s %s" b cat
            Descriprion = sprintf "Look great with a stylish %s %s from the Red Fedora hat store!" b cat
            Category = c
            Brand = b
            Colour = cl
            Material = material
            Attributes = attrAttr |> Array.ofSeq
            Price = price
            Rrp = rrp
        }
        Some ret
    else 
        None

let products = 
    let fInfo = new FileInfo("productgen.xlsx")
    use xl = new ExcelPackage(fInfo)
    let ws = xl.Workbook.Worksheets.["Sheet1"]
    
    let brands = getCol 1 ws
    let categories = getCol 2 ws
    let colours = getCol 3 ws
    let materials = getCol 4 ws |> Seq.append [""]
    let attrs = getCol 5 ws |> List.ofSeq

    let ret = 
        [   for b in brands do
            for c in categories do
            for m in materials do
            for cl in colours do
            yield generateProduct b c m cl attrs ]
        |> List.filter(fun p -> p.IsSome)
        |> List.map(fun p -> p.Value)
    ret
    


        





