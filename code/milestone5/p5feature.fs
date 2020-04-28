// Learn more about F# at http://fsharp.org


let mySqrt num = 
    match num with
        | num when num <= 0.0 -> None
        | _ -> Some(sqrt num)

let sqrtList mySqrt list =
    list 
    |> List.choose (fun x -> (mySqrt x))

let numbers = [25.0; -4.0; -1.0; 4.0; -8.0; 9.0;]

printfn "Original List: %A"  numbers
printfn "SqrtList: %A"  (sqrtList mySqrt numbers)