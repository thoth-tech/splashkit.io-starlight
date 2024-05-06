---
title:  Install SplashKit Globally
sidebar:
  attrs:
    class: windows
  label: "4. Install SplashKit Globally"
---

Finally, you will need to install the SplashKit Global Libraries. This will install the SplashKit libraries and library include files into the system's default global locations so that the compiler can find these files when building (compiling) programs created with SplashKit.

To install SplashKit globally on your WSL, copy and paste the following command into your WSL Terminal window:

```bash
skm global install
```

![Gif showing skm installing globally in WSL Terminal](./src/assets/gifs/setup-windows/wsl-install-global.gif)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

:::note[What does this command do specifically?]
The command above will add the **SplashKit libraries** into the `/usr/local/lib/` folder, and the required **SplashKit library include files** into the `/usr/local/include` folder.
:::