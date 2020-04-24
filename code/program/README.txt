HTML Parser is able to create a UofA Computer Science department directory. This program will extract all peoples’ information from the following links:
https://www.cs.arizona.edu/about/faculty
https://www.cs.arizona.edu/about/staff
https://www.cs.arizona.edu/about/graduate-students

The program will have two main functionalities, data extraction and data cleaning. The input of the program will be the above three links that are defined as the global variables. The output will have two parts. First, the Console will display the number of faculties, staff and graduate students. Second, there is a csv file that will be create after the program finishes. The csv file contains all the peoples’ information that arranged by office floor. For each floor, the information will be sorted by the peoples’ first name. In addition, the program has around 400 lines. 

----------------------------------------------------------------------------------------------------------------------------
Important notes:
Make sure you connect to the Interenet before you run the codes

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
