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

To install the .NET SDK, open your WSL terminal and run the following commands:

```bash
# Get Ubuntu version
declare repo_version=$(if command -v lsb_release &> /dev/null; then lsb_release -r -s; else grep -oP '(?<=^VERSION_ID=).+' /etc/os-release | tr -d '"'; fi)

# Download Microsoft signing key and repository
wget https://packages.microsoft.com/config/ubuntu/$repo_version/packages-microsoft-prod.deb -O packages-microsoft-prod.deb

# Install Microsoft signing key and repository
sudo dpkg -i packages-microsoft-prod.deb

# Clean up
rm packages-microsoft-prod.deb

# Update packages
sudo apt update

# Install .NET 8.0
sudo apt-get install dotnet-sdk-8.0 dotnet-runtime-8.0
```

:::caution
Make sure that each of these steps works successfully. Paste in the commands one at a time, and check that the output does not indicate there were any errors. You will need to resolve errors as you go, as the later commands will not succeed if the earlier ones fail.

If you have trouble with this, you can try to follow the official instructions for installing this: see the [Install .NET on Linux](https://learn.microsoft.com/en-us/dotnet/core/install/linux) guide.
:::

The script above will install .NET 8.0, but if you want to install an earlier version, you can update the last line with your preferred version.  
*For example*, if you want to use .NET 7.0: `sudo apt install dotnet-sdk-7.0`

:::note
If prompted, enter your password, type `y`, and press enter to confirm the installation.

This may take a while (approx. 10 mins).
:::

:::note[Which SDK version?]
We recommend using *.NET 8.0*, but you can use *.NET 7.0*, or *.NET 6.0* if you have issues with .NET 8.0.
:::

### C/C++ Tools

For coding in C++, you will need a C++ compiler and debugger. WSL comes with GCC (GNU Compiler Collection) and GDB (GNU Debugger) by default, so these may already be installed. The following command will check and install these tools for you:

```bash
sudo apt-get install g++ clang gdb
```

This command installs the necessary C/C++ compilers and debuggers for your development environment if they haven't been installed already.

Your Windows machine is now set up with WSL, Visual Studio Code, and SplashKit, ready for C# and C++ development. Happy coding!

## Using WSL

When you are using WSL, you have a Linux environment running in parallel with Windows. This is why you had to set up a new user account. You were setting up the account within the Linux environment. When you are working in this way, one of the challenges you will have is thinking about where the files are that you are working on, as your Windows and Linux environments will each have their files and folders. To help you get started with this, let's consider how you can access the files in the different environments.

### Accessing Windows Files and Folders from WSL

When you are in the Linux environment, your home directory is not mapped to your Windows home directory. If you want to access files from Windows, you can access this in the **/mnt/c** folder.

```bash
# Output the path to my Linux home
pwd

# Move into my C: on Windows
cd /mnt/c
# Move into my Home (change to use your username!)
cd /mnt/c/Users/andrew/Documents
```

The shell is now in the `C:\Users\andrew\Documents` folder, so I can access the different things I have saved here. When you use this, replace `andrew` with your username. So it will be in the format: `/mnt/c/Users/<username>/Documents`.

:::caution

When you are working in WSL, you are best to keep your projects within the Linux environment and then access these from the Windows environment as described below. Being able to access your Windows files will be useful if you want to copy things from there into your programming projects.

:::

### Accessing WSL Files and Folders from WSL

If you have been working on your projects in WSL, you can access these from Windows using the `\\wsl$` path in the File Explorer. When you access this folder you will see a list of the distributions you have installed in WSL. If you navigate into the `Ubuntu` folder you will have access to the root of your Linux environment. So I can access my Linux home folder using the path `\\wsl$\Ubuntu\home\andrew\Documents`. You will need to change `andrew` to the name of the user you created in Ubuntu, so it will be in the format: `\\wsl$\Ubuntu\home\<username>\Documents`.

One convenient way of accessing your files is to run the `explorer.exe` program from within your WSL terminal. When you do this, you can open a File Explorer and give it a path to open. Running the following commands at the WSL Terminal will let me open my Linux Documents folder in File Explorer.

```bash
# Move to my Documents folder in Linux
cd ~/Documents

# Open the current folder in Explorer
explorer.exe .
```

Using this option you can work within your Linux files for your programming projects, and then access these from the File Explorer when needed.
