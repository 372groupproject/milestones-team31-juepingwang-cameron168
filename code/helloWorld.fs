// Learn more about F# at http://fsharp.org

// Sources:
// Hello world program provided in Visual Studio when opening it up.
// Console.readline was taken from a tutorial found here: https://sachabarbs.wordpress.com/2014/02/25/f-1-hello-world/

open System

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    Console.ReadLine() |> ignore  //Added for visual studio.
    0 // return an integer exit code
