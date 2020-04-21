
//Constructor that takes 3 arguments.
type PersonClass(inputFirstName: string, inputLastName: string, inputAge: int) as self = 
    let mutable firstName = inputFirstName
    let mutable lastName = inputLastName
    let mutable age = inputAge
    do
        printfn "New Person Recorded: \n"
        self.PrintPerson()

    //Constructor for a PersonClass that takes no arguments.
    new() = PersonClass("John", "Doe", 0)

    //Class methods follow below.

    member this.PrintPerson() =
        printfn "Name: %s, %s  Age: %d \n" lastName firstName age

    member this.getName() = 
        lastName + ", " + firstName

    member this.setName(inputFirstName: string, inputLastName: string) = 
        lastName <- inputLastName 
        firstName <- inputFirstName

    member this.getAge() = 
        age

    member this.hadBirthday() = 
        age <- age + 1


printfn " \n\n Testing out the PersonClass constructors \n"

printfn "Empty constructor: \n"
let unk1 = PersonClass()

printfn "Regular  constructor: \n"
let kaz = PersonClass("Cam", "Kaz", 30)

printfn " \n\n Testing class methods \n"

unk1.PrintPerson()
unk1.hadBirthday()
printfn "New age of John after 1 birthday: %d \n" (unk1.getAge())
printfn "Name: %s \n" (unk1.getName())
kaz.PrintPerson()
kaz.setName("Cameron", "KazyManazy")
kaz.hadBirthday()
kaz.hadBirthday()
kaz.PrintPerson()


