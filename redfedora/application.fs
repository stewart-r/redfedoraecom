module WebApplication

open Suave
open Config
open System.IO
open Successful
open Suave.Operators

let replacePlaceholder (ph:string) (template:string) replacement = 
    template.Replace(ph,replacement)

let replaceTitle title template =
    replacePlaceholder "{title}" template title

let replaceBody body template = 
    replacePlaceholder "{body}" template body

let buildFromTemplate title body templatePath= 
    File.ReadAllText templatePath
    |> replaceTitle title
    |> replaceBody body

let index =
    let template = Home + "_template.html"
    let ret = buildFromTemplate "Red Fedora" "some body text" template
    ret

let WebApp config =
    choose [
        Filters.path "/" >=> Successful.OK index
        Files.browseHome
    ]
    
    