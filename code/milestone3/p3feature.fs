open System.Net
open System.IO

// Integer
printfn "--------integer--------"
let a = 10
let b = 3
printfn "int a = %d" a
printfn "int b = %d" b
printfn "int (a / b) = %d" (a/b)
printfn ""

// float
printfn "--------float--------"
let a_f : float = (float 10)
let b_f : float = (float 3)
printfn "float a = %f" a_f
printfn "float b = %f" b_f
printfn "float (a / b) = %f" (a_f / b_f)
printfn ""

// String
printfn "--------string--------"
let s1 : string = "csc"
let s2 : string = "372"
let s3 : string = s1 + " " + s2
printfn "Welcome to %s" s3
printfn ""

// Boolean 
printfn "--------boolean--------"
printfn "false and true <=> %b" (false && true) 
printfn ""

// compile error
//let error x : float = 1000 


// Part 3
printfn "--------small-ish program--------"
let rec toNumericList stringList = 
    match stringList with
        | [] -> []
        | _  -> (float stringList.Head) :: (toNumericList stringList.Tail)

let rec removeLowest gradeList lowestGrade =
    match gradeList with
        | [] -> []
        | _  ->  if (lowestGrade = gradeList.Head) then 
                        (removeLowest gradeList.Tail lowestGrade)
                 else
                        (gradeList.Head) :: (removeLowest gradeList.Tail lowestGrade)

let midtermGrades gradeList = 
    let numericList = toNumericList gradeList
    let lowestGrade = Seq.min numericList
    (removeLowest numericList lowestGrade)


let data = [["90"; "90"; "80"; "100"];
            ["100"; "22"; "100"; "60"];
            ["40"; "70"; "50"; "90"] 
           ]

let result = 
    for i in data do
        printfn "%A" (midtermGrades i)

