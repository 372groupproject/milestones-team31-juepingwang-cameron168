Milestone1:
    helloWorld.fs    - Prints out hello world.
    somethingElse.fs - prints out integer division by 2 of an odd number, and also creates a mutable variable.

Milestone2:
    p2_if.fs    - includes demonstration of if-statement, if-else statement, if-elif-else statement and Pattern Matching
    p2-loops.fs - includes demonstration of for-loop and while-loop
 
The Makefile only supports Linux Ubuntu. It will not support to MacOS and Windows 
Before you run Makefile, make sure you install ".NET Core".

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

