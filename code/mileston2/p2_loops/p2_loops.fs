// find factorial by using for loop
printfn "for-loop: "
let mutable res = 1
let factorial (x:int) = 
    for i = 1 to x do
        res <- res * i

factorial 5
printfn "5! = %d" res
printfn ""

// find sum of 1 to 10
printfn "While-loop: "
let mutable i = 1
let mutable s = 0
while (i <= 10) do
   s <- s + i
   i <- i + 1
printfn "1 + 2 + 3 +...+ 10 = %d" s
printfn ""