free_all_fonts Usage example

Here is the task where my goal was to create a small program that uses the least number
of lines possible to demonstrate the given function in different programming languages. 
So, here I have demonstrated how free_all_fonts loaded in those languages.  


Why we should use free_all_fonts:
whenever you are loading fonts into a program, they take up memeory, which can also lead into 
a memeory leak. so we call free_all_fonts function that will make sure that all the fonts that
are loaded in the program get removed from the memeory. This helps in more memory efficient
programs, and help reduce crashes. 

Usage Example: 
First we run the program in a particular language, and then the program will open a window
which will display a message, in my case: Hello, This is a Usage example. and then once
we close the window, all the loaded fonts will be freed.


Languages: 
1. C++
2. C# OOP
3. C# Top Level
4. Python

How to Run the Program for each language: 
1. C++ :  
  - first compile the code:
   skm clang++ usage-examples/free_all_fonts/cpp/free_all_fonts_example.cpp -o free_all_fonts_example
    
 - and then run it
  ./free_all_fonts_example

2. C# OOP: 
  - get in the right directory 
  cd usage-examples/free_all_fonts/csharpOOP/free_all_fonts_example
  
  - build the project
   skm dotnet build

  - run the program
    skm dotnet run

3. C# Top Level:
    -Same as C# OOP

4. Python:
    - Run the Program
    skm python3 usage-examples/free_all_fonts/python/free_all_fonts_example.py