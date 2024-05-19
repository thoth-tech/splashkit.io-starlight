---
title:  Install git and clang Command Line Tools
sidebar:
  attrs:
    class: windows
  label: "2. Install git and clang Command Line Tools"
---

To install SplashKit, you will firstly need to install **Git** and a compiler which is used to test the install.

Copy and paste the following command into your **MINGW64** terminal window to install the `git` and `clang` command-line tool:

```bash
pacman -S git mingw-w64-{x86_64,i686}-clang --noconfirm --disable-download-timeout
```

:::caution[Paste commands into MINGW64 Terminal]
Unfortunately, you won't be able to use `Ctrl` + `V` to paste.

Instead, right-click anywhere in the terminal window and then select **Paste**.
:::




