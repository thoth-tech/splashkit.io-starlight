---
title:  Install SplashKit SDK
sidebar:
  attrs:
    class: windows
  label: "3. Install SplashKit SDK"
---
SplashKit is a beginner's all-purpose software toolkit that will allow you to create fun and exciting programs more easily, especially for Graphical User Interface (GUI) programs.

:::tip[Curious to know more?]
The **SplashKit SDK** is installed using the `skm-install.sh` shell script which is stored in the [**skm**](https://github.com/splashkit/skm) GitHub repository (in the **install-scripts** folder).

It will also add the required paths to your PATH environment variable.
:::

Copy and paste the following command into your MINGW64 terminal to download and run the SplashKit installer:

```bash
bash <(curl -s https://raw.githubusercontent.com/splashkit/skm/master/install-scripts/skm-install.sh)
```

*For this step*, you can use any of the terminal environments provided by MSYS2, such as the **MSYS** terminal shown here:

![MSYS SKM Install](/gifs/setup-windows/msys-skm-install.gif)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

:::tip[Troubleshooting tip:]
If you have issues installing the SplashKit SDK, go to the [No response when running SplashKit installation command](/book/part-0-getting-started/2-computer-use/0-installation/3-0-troubleshooting-install/#no-response-when-running-splashkit-installation-command) section in the Installation Troubleshooting page for an alternative installation process.
:::