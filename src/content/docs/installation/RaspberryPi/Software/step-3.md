---
title:  Setup Raspberry Pi OS
sidebar:
  attrs:
    class: pi
  label: "3. Setup Raspberry Pi OS"
---

*Let's get your Raspberry Pi ready to start coding*.

This section will go through all the steps to install the required Applications and Tools that you will need to code in C# and C++ with SplashKit.
To make things easier we have an automated script for fresh installs that will install all the required tools and applications for you or you can follow the manual steps below.

:::note[How do I open the Terminal on my Pi?]
Click the Terminal icon in the task bar or press `Ctrl + Alt + T`.

![Image Showing the Terminal Icon](./src/assets/images/setup-pi/1-2-setup-pi-Terminal_Icon.png)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>
:::

### Automated Setup

This script will install the following applications and tools:

- Visual Studio Code
  - C/C++ Extension
  - C# Extension
- .NET SDK
- SplashKit
  - SplashKit Global
- wget
- git
- curl
- clang

Open the Terminal and run the following command:

```bash
curl -s "https://programmers.guide/resources/Linux_Pi_InstallScript.sh" | bash /dev/stdin
```

:::note
This script will take a while to run (approx. 12-15 mins).
:::

Once the automated script has finished running, close and reopen the Terminal.

Run the command `skm` to check SplashKit is installed correctly.

:::tip[Using options with the script]
The linux_pi_install script supports a number of options that can be used to customise the installation.  
They can be added to the end of the command.

The example below will display the help menu which lists the available options (scroll the command across to see the end):

```bash
curl -s "https://programmers.guide/resources/Linux_Pi_InstallScript.sh"| bash /dev/stdin --help
```

:::