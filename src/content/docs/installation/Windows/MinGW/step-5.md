---
title:  Install Visual Studio Code
sidebar:
  attrs:
    class: windows
  label: "5. Install Visual Studio Code"
---

Visual Studio Code, also commonly known as *VS Code* or just *Code*, is a powerful and versatile code editor that enables efficient coding, debugging, and collaboration for your SplashKit projects!

:::note[VS Code has it all!]
Once you have your code project set up, Visual Studio Code will be the main program you will use to write, build, run and debug your code.
:::

Download and run the installer from: [code.visualstudio.com/Download](https://code.visualstudio.com/Download).

![Gif showing Visual Studio Code installation](./src/assets/gifs/setup-windows/install-vscode.gif)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

:::tip[Open Code from Terminal]
You can open Visual Studio Code from the MINGW64 terminal by typing `code` and pressing enter. `code .` will open the current folder in Visual Studio Code.

*You will need to close and reopen any currently open terminal windows after installing VS Code for the above commands to work.*
:::

### Setup VS Code Terminal

Visual Studio Code has a built-in Terminal that you can use instead of needing to switch back and forth between VS Code and your MINGW64 terminal window. You will need to update some settings to get this working with your MINGW64 terminal.

Open Visual Studio Code, then press `Ctrl` + `Shift` + `P` to open the [Command Palette](https://code.visualstudio.com/docs/getstarted/userinterface#_command-palette).

Start typing "Open user..." and then select **Open User Settings (JSON)** (shown in the orange box in the image below):

![Image showing Command palette use to open User Setting (JSON) in VS Code window](./src/assets/images/setup-windows/vscode-open-user-settings-json.png)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

This will open the **settings.json** file that you can now edit.

Create a new line just before the last closing curly brace `}` at the end of the file, and then copy and paste the text below into that line:

```json
    "terminal.integrated.profiles.windows": {
        "PowerShell": {
            "source": "PowerShell",
            "icon": "terminal-powershell"
        },
        "Command Prompt": {
            "path": [
                "${env:windir}\\Sysnative\\cmd.exe",
                "${env:windir}\\System32\\cmd.exe"
            ],
            "args": [],
            "icon": "terminal-cmd"
        },
        "MSYS2": {
            "path": "C:\\msys64\\usr\\bin\\bash.exe",
            "args": [
                "--login",
                "-i"
            ],
            "env": {
                "MSYSTEM": "MINGW64",
                "CHERE_INVOKING": "1"
            }
        }
    },
    "terminal.integrated.defaultProfile.windows": "MSYS2",
    "terminal.integrated.env.windows": {
        "MSYSTEM": "MINGW64",
        "CHERE_INVOKING": "1"
    },
```

:::note

- If you already have some settings included in this file, you will need to add a comma `,` after the closing curly brace `}` on the line above your new line.
- If you already see code that looks similar to the code above, you may need to copy only small parts to match the code above.
- The last line of the code above will set your default profile, so that it will automatically use the MSYS2 (MINGW64) terminal. You can also read this [article](https://code.visualstudio.com/docs/terminal/profiles) to see other ways to set the default terminal.

:::

Save the file for these changes to take effect.

Now you can open a new Terminal in VS Code with: ***Terminal* > *New Terminal*** (as shown below):

![Image showing opening a new terminal in VS Code window](./src/assets/images/setup-windows/new-terminal-vscode.png)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

### Recommended Extensions

The final step to complete the setup of VS Code is to install a few *Extensions* in VS Code:

[**Set up my VS Code Extensions**](/book/part-0-getting-started/2-computer-use/0-installation/2-7-setup-vscode)

Go to the page linked above, follow the steps to install both the C# and C/C++ recommended extensions, and then come back here and continue to the next step. *You can use the "Back button" in your browser to return to this page.*