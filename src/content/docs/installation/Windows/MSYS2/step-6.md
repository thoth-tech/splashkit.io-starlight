---
title:  Install Language Specific Tools
sidebar:
  attrs:
    class: windows
  label: "6. Install Language Specific Tools"
---

Some coding languages require specific tools/frameworks to be installed to be able to build and run your code files.  
As you will be coding in C# and C++ in this book, let's look at the tools needed for these languages:

### C# Tools

For coding in C#, you will need to install the `.NET` SDK which will allow you to use the *dotnet* terminal command to create, build, and run your C# project code.

Download the latest version of the .NET SDK for Windows from the official .NET website: [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

Run the downloaded installer and follow on-screen instructions.

### C/C++ Tools

For coding in C++, you will need to have a C++ compiler installed to build your C++ code into a file you can use to run your program. Commonly used C++ compilers are `g++` and `clang++`, which can be installed with **GCC** (**G**NU **C**ompiler **C**ollection).

You will also need to install **GDB** (**G**NU **D**e**b**ugger), which you can use when debugging C++ programs.

To install GCC and GDB, copy and paste the following commands into your MINGW64 terminal window:

```bash
pacman -S mingw-w64-x86_64-gcc --noconfirm --disable-download-timeout
pacman -S mingw-w64-x86_64-gdb --noconfirm --disable-download-timeout
```

These commands will install the necessary C/C++ compilers and debuggers for your development environment.

Your Windows machine is now set up with MSYS2, Visual Studio Code, and SplashKit, ready for C# and C++ development. Happy coding!

## Using MSYS2

MSYS installs a minimal Linux environment on top of Windows. This will give you easy access to all of your Windows files and folder. The one challenge is that MSYS2 has its own home folder that does not map to your Windows home folder. If you want to access your Windows home folder you will need to use the `cd` command to move into that folder. Each of your system drives (C: for example) is mapped to a folder with the drive name in the root of the file system. So `C:` is `/c/` in MSYS. To access my Windows Documents folder, I can use the path `/c/Users/andrew/Documents`. You will need to change `andrew` to be your username, so the path will be in the format `/c/Users/<username>/Documents`. The following commands open my Documents folder.

```bash
# Move to my C drive
cd /c/

# Move to my Documents folder
cd /c/Users/andrew/Documents
```

Using these commands you should be able to save your projects either in your Windows Documents folder for easy access.

If you want to find where your MSYS2 home folder is on your Windows machine, you can use the `pwd` command with a `-W` option to say you want the "Windows" path for the current folder. You can also use the `explorer.exe` program to open a folder in the File Explorer.

```bash
# Move into my MSYS home folder
cd ~
# Output my home folder's Windows path
pwd -W
# Open the current directory in File Explorer
explorer .
```