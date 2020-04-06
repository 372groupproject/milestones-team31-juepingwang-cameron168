printfn @"5/2 = %d when working with integers." (5/2)
printfn """The line "let x = 9" makes x immutable in f# unless the special binding of mutable is added, so variables are immutable by default."""
let mutable y = 9
y <- 7 // <- assigns the value of 7 to y.
