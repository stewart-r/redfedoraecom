module Api
open Suave
open System

let WebApi config () = 
    DateTime.Now.ToString()
    |> sprintf "Server timestamp: %s"
    |> Successful.OK