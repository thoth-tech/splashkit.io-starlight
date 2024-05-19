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

Copy and paste the following command into your WSL Terminal to download and run the SplashKit installer:

```bash
bash <(curl -s https://raw.githubusercontent.com/splashkit/skm/master/install-scripts/skm-install.sh)
```

![Gif showing skm installing in WSL Terminal](/gifs/setup-windows/wsl-skm-install.gif)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

:::tip[Troubleshooting tip:]
If you have issues installing the SplashKit SDK, go to the [No response when running SplashKit installation command](/book/part-0-getting-started/2-computer-use/0-installation/3-0-troubleshooting-install/#no-response-when-running-splashkit-installation-command) section in the Installation Troubleshooting page for an alternative installation process.
:::

Close and reopen the WSL Terminal, then run the command below to build SplashKit:

```bash
skm linux install
```

:::note
If prompted, enter your password, type `y`, and press enter to confirm the installation.

This may take a while (approx. 10 mins).

Command above being run in WSL terminal is shown in the next section below.
:::
