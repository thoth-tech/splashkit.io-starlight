---
title:  Install Windows Subsystem for Linux (WSL)
sidebar:
  attrs:
    class: windows
  label: "1. Install Windows Subsystem for Linux (WSL)"
---

Windows Subsystem for Linux (WSL) is a feature of Windows that allows you to run a Linux environment on your Windows machine, without the need for a separate virtual machine or dual booting.

:::note[WSL 1 vs WSL 2]
*WSL 2 (recommended) is the default version, but you can look at [this article](https://learn.microsoft.com/en-us/windows/wsl/install-manual) if you have issues, or if you are using an older Windows 10 version.*
:::

### Method 1: Command Line

You can install both WSL and Ubuntu from the command-line using the following steps that have been adapted from the instructions provided in the official Microsoft documentation: [Install Windows Subsystem for Linux (WSL)](https://learn.microsoft.com/en-us/windows/wsl/install). This is the recommended method.

Open Terminal, PowerShell or Windows Command Prompt in *administrator mode* by right-clicking and selecting "Run as administrator", then copy and paste the following command to install WSL and Ubuntu:

```bash
wsl --install
```

![Gif showing WSL terminal running wsl --install commands](./src/assets/gifs/setup-windows/wsl-terminal.gif)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

### Method 2: Microsoft Store

Alternatively, you can install WSL (and Ubuntu) directly from the Microsoft Store if you have this on your Windows computer.

To do this, search "WSL" in the Microsoft Store app (as shown below), or [click this link](https://apps.microsoft.com/store/detail/9P9TQF7MRM4R).

![Gif showing WSL being installed from Microsoft store](./src/assets/gifs/setup-windows/install-wsl.gif)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

You will also need to download **Ubuntu** from the Microsoft Store. Search "Ubuntu" in the Microsoft Store app, or [click this link](https://apps.microsoft.com/store/detail/9PDXGNCFSCZV).

### Create Ubuntu User Account

Firstly, you need to **Restart** your computer if you haven't done so already.

A terminal window installing Ubuntu should pop up automatically, otherwise open the WSL or Ubuntu app for this window to open.

When prompted, enter your new UNIX username and password.  
For example, with the username "**default-user**", your terminal would look like this:

![Image showing WSL terminal with ubuntu user account set up](./src/assets/images/setup-windows/terminal-ubuntu-user-account.png)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

You can see in the image above where the "**default-user**" username was first entered (shown in the pink box), and the same username being used with the terminal prompt (shown in the orange box).

:::tip[Troubleshooting tip:]
If you have issues installing the WSL with Ubuntu, go to the [Issues creating Ubuntu user account](/book/part-0-getting-started/2-computer-use/0-installation/3-0-troubleshooting-install/#issues-creating-ubuntu-user-account) section in the Installation Troubleshooting page for a way to reset the Ubuntu installation and user account setup.
:::

WSL is now setup and ready to use!

### Configure 'Windows Terminal'

Note: This step is *optional*.

If you want to be able to have your 'Windows **Terminal**' app automatically open with WSL, you can change the *Default profile* to use WSL (with Ubuntu) using the steps below:

Firstly, open the Terminal app, and click the drop-down arrow at the top of the window (shown in the green box in the image below), then click on "Settings" (shown in the orange box):

![Image showing Terminal App with how to open settings](./src/assets/images/setup-windows/windows-terminal-settings.png)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

Next, click on the drop-down menu within the *Default profile* section and select either of the **Ubuntu** profiles. *If you're unsure, select the one with the Linux penguin icon* (shown in the pink box):

![Image showing Terminal App with how to change default profile in settings](./src/assets/images/setup-windows/windows-terminal-default-profile.png)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

Click **Save**. (Don't forget this!)

Now your Terminal app will automatically use the WSL/Ubuntu command line when you open it.

:::note
Don't worry if you have different profiles in your Settings, as long as you can see at least one profile that has "Ubuntu" in the name (if you are using the default setup from [step 1](#1-install-windows-subsystem-for-linux-wsl)).
:::

:::tip[Pin it!]
To make it easier to open each time, you can pin your Terminal to the Taskbar.

- Open the Terminal App.
- Right-click on the Terminal App icon in the taskbar (shown in the orange box in the image below).
- Select "Pin to taskbar" (shown in the pink box):

![Image showing Terminal App pinning to taskbar](./src/assets/images/setup-windows/terminal-pin-taskbar.png)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>
:::
