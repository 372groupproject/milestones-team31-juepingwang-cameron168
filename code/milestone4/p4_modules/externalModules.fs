
//This is the explicit declaration of the module.
module externalModules

//When the explicit declaration is absent, there is an implicit declarion which is just the file name minus .fs i.e. files.fs would be module files

//The order the files are present in a project and compiled matters in f#.
//A file that is compiled after a certain point cannot be called before it is compiled.
//In this project externalModules can open internalModules, but not vice-versa due to the order or compilation.

printfn " \n\n EXTERNAL MODULE TESTING \n"

//Using qualifying names for the external folder:
printfn "Value3 in internalModules: %d \n" InternalModules.value3

//Going two levels deep into external/internal modules
printfn "Value2 in internalModules %d \n" InternalModules.example2.value2

//Opening the module
open InternalModules
printfn "Value3 again is : %d \n" value3;

printfn "Using the func1 in internalModules with 4: %d \n" (example1.func1 4)

printfn " \n\n INTERNAL MODULE TESTING \n"

//Testing out internal modules now.
printfn "  \n Calling internal modules in the other file now: \n\n"
testRun.func2

printfn "Finished with module testing \n"






