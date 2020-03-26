In order to get the f sharp programs to work on windows the following steps must be taken:
- Download visual studio
- Create a new project
- Look for F# under languages and select Console App (.NET Core)
- (If not available) If this is not available, there should be a prompt once the language has been set to F# that says "Install more tools and Features". Press this.
- (If not available) Check the .NET desktop development under Desktop and mobile, and press update/modify in the bottom right of the screen.
- Once this is done, open and name the project.
- You can either copy the contents of the file into the default .fs file, or delete this file and add the new file.
- Once you have done this, press "ctrl + f5" to run the program.

Current issues trying to get f sharp to run on ubuntu terminal in windows.
If trying to run on ubuntu, the steps take were to:
- enter the command "sudo apt-get update"
- enter the command "sude apt-get install fsharp"
- Once this is done, run the compiler on the .fs file by entering "fsharpc helloWorld.fs"
- This should have created a .exe file.
- Error occurred when trying to enter ./helloWorld.exe
