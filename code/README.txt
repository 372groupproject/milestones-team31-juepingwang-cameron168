Milestone1:
    helloWorld.fs    - Prints out hello world.
    somethingElse.fs - prints out integer division by 2 of an odd number, and also creates a mutable variable.

Milestone2:
    p2_if.fs    - includes demonstration of if-statement, if-else statement, if-elif-else statement and Pattern Matching
    p2-loops.fs - includes demonstration of for-loop and while-loop

Milestone3:
    p3feature.fs - Demonstrates different data types Given a two dimensional grade list and the list type is string. In each row, the first 4 data demonstrates the midterm grades and the last grade represents final grade. This programming will convert string list to float list. Then, it will drop the lowest midterm grade. 

Milestone4:
    internalModules.fs - Demonstrates using modules within the same file.
    externalModules.fs - Demonstrates using modules that exist outside of the current file.
    classes.fs         - Demonstrates the basics of a class in F#

Milestone5:
    p5feature.fs    - Demonstrates using Option Type. Performs squart operation on each element from a given float list and returns a list of real number. If the element is negative, then it will be skipped.
    
program:
    Final project has its own README file. please check the program folder
    
----------------------------------------------------------------------------------------------------------------------------
About Makefile:
    Before you run Makefile, make sure you install ".NET Core".
    The Makefile only supports Linux Ubuntu. It will not support to MacOS and Windows.

----------------------------------------------------------------------------------------------------------------------------
Install F# on Linux Ubuntu: 

    1. Command of check ".NET Core" version
        
        dotnet --version
        
        If nothing show up after enter the command, please see the Installation.
       
    2. Installation
        For Ubuntu 18.04: 
        Open a terminal and run the following commands:
        
        wget https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
            
        sudo dpkg -i packages-microsoft-prod.deb
            
        sudo apt-get update
            
        sudo apt-get install apt-transport-https
            
        sudo apt-get update
            
        sudo apt-get install dotnet-sdk-3.1
            
        More installation information: https://dotnet.microsoft.com/download

