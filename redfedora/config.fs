module Config
open Suave
open System
open System.IO
open Suave



let private localHome = Path.Combine( Directory.GetCurrentDirectory(), "build","app")
let private remoteHome = @"D:\home\site\wwwroot\app"
let Home = 
    if (not (Directory.Exists remoteHome))
    then localHome
    else remoteHome