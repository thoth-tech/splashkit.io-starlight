---
title:  Install Command Line Tools
sidebar:
  attrs:
    class: windows
  label: "2. Install Command Line Tools"
---
To install SplashKit on WSL, you will firstly need to install the `git`, `curl`, and `clang` tools using the `apt` command, which works with Ubuntu's **A**dvanced **P**ackaging **T**ool.

Open your WSL Terminal. You can do this by using the Windows Terminal app if you followed the steps above, by searching for "WSL" in the Windows Start menu and then select the **WSL** App, or by using the app for the Linux distribution you installed, such as **Ubuntu**, which is installed by default.

Update the package lists by running the following command in your **WSL Terminal**:

```bash
sudo apt update
```

Next, install the `git` and `curl` tools by running the following command:

```bash
sudo apt install git curl clang
```

![Gif showing command above being run in WSL Terminal](./src/assets/gifs/setup-windows/wsl-git-curl.gif)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

