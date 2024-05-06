---
title: 1. Automated Setup
sidebar:
  attrs:
    class: linux
---
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
The linux_pi_install script supports several options that can be used to customise the installation; these can be added to the end of the command.

The example below will display the help menu, which lists the available options (scroll the command across to see the end):

```bash
curl -s "https://programmers.guide/resources/Linux_Pi_InstallScript.sh"| bash /dev/stdin --help
```

:::


