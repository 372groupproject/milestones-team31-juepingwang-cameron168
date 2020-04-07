// if statement
let condition : bool = true
printfn "* if statement *"
if condition then
    printfn "test-expression is ture, so I am runing."
printfn ""


// if-else statement
printfn "* if-else statement *"
let x : int = 3
if x % 2 = 1 then
    printfn "x is odd."
else
    printfn "x is even."
printfn ""


// if-elif-else statement
printfn "* if-elif-else statement *"
let find_gpa (x : char) =
    if   x = 'A' then 4.0
    elif x = 'B' then 3.0
    elif x = 'C' then 2.0
    elif x = 'F' then 0.0
    else -1.0
printfn "Grade A has GPA = %.2f" (find_gpa 'A')
printfn "Grade B has GPA = %.2f" (find_gpa 'B')
printfn "Grade C has GPA = %.2f" (find_gpa 'C')
printfn "Grade F has GPA = %.2f" (find_gpa 'F')
printfn "Grade Z has GPA = %.2f" (find_gpa 'Z')
printfn ""


// Pattern Matching
printfn "* Pattern Matching *"
let find_gpa2 (x : char) =
    match x with
    // The following line contains literal patterns combined with an OR pattern.
    | 'A' -> printfn "Grade A has GPA = 4.0"
    | 'B' -> printfn "Grade B has GPA = 3.0"
    | 'C' -> printfn "Grade C has GPA = 2.0"
    | 'F' -> printfn "Grade F has GPA = 0.0"
    |  _  -> printfn "Input error"
find_gpa2 'A'
find_gpa2 'B'
find_gpa2 'C'
find_gpa2 'F'
find_gpa2 'G'
printfn ""
