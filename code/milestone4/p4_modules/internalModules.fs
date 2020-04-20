
module InternalModules

//Example internal module nested inside the InternalModules module
module example1 = 
    let value1  = 25
    let func1 num1 = 
        num1 + 3

//Another example internal module.
module example2 = 
    let value2 = 12
    let func2 num2 = 
        num2 + 8

//Internal module used to test other internal modules
module testRun = 
    //Cannot open module in a function. It must be done before function call.
    open example2
    let func2 =
        let mutable x = 16
        printfn "Original value: %d \n" x

        //Using qualifying names.
        let modVal1 = example1.value1
        printfn "Value stored in module example1 (25): %d \n" modVal1
        x <- example1.func1 x
        printfn "Modified value using example1 module (add3): %d \n" x

        //Opening the module instead of using qualifying names
        let modVal2 = value2
        printfn "Value stored in module example2 (12): %d \n " modVal2
        x <- func2 x
        printfn "Modified value using example2 module (add8): %d \n" x

let value3 = 45
