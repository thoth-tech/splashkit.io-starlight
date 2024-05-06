---
title: 3. Optional Steps
sidebar:
  attrs:
    class: linux
---

### Setup zsh shell

When using the terminal, you are actually interacting with a shell, where the default is **bash**, but other shells are available.

Here, we will install ***zsh*** and ***oh-my-zsh*** to customise the terminal. These will give you a more user-friendly terminal experience with themes and plugin support.

**To install zsh**, run the following command in your Terminal:

```bash
sudo apt install zsh -y
```

**To install oh-my-zsh**, run the following command in your Terminal:

```bash
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"
```

![gif showing the installation of oh=my=zsh](./src/assets/gifs/setup-pi/1-2-setup-pi-OMZ-Install.gif)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

Answer `y` to the question `Do you want to change your default shell to zsh?`

Add SplashKit and dotnet to the PATHs to zsh

```bash
echo 'export PATH=$PATH:$HOME/.dotnet' >> ~/.zshrc
echo 'export DOTNET_ROOT=$HOME/.dotnet' >> ~/.zshrc
echo 'export PATH=$PATH:$HOME/.splashkit' >> ~/.zshrc
source ~/.zshrc
```

:::note[You may need to restart the system for the terminal to update]
:::

### Plugins

:::tip[What is nano?]
Nano is a command line text editor that is already installed on Debian. As a quick start, these are the most important commands

- To edit a file in nano use `nano [filename]`
- navigate the cursor using the arrow keys
- `Ctrl + O` to save the file
- `Ctrl + X` to exit the editor

:::

Several plugins are available for **oh-my-zsh** that add additional functionality to the terminal.  
[This article](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins) has a list of pre-installed plugins, although there are others available as well.

To install a plugin, add it to the plugin list in the `~/.zshrc` file.

Using `autojump` as an example:

![gif showing the installation of autojump](./src/assets/gifs/setup-pi/1-2-setup-pi-AutoJump.gif)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

First, you will install it with:

```bash
sudo apt install autojump -y
```

Then add it to the plugins list in `~/.zshrc`

```bash
nano ~/.zshrc
```

Navigate to the plugins line and add `autojump` to the list. `git` will be listed already.  
Use a space to separate the plugins as shown below:

```bash
plugins=(git autojump)
```

Save and close the file.
Then run the following command to update the terminal:

```bash
source ~/.zshrc
```

### Add Shortcut for the Programmers Field Guide

To add the Programmers Field Guide to the menu, run the following commands in the Terminal:

```bash
    echo "Adding Programers Feild guide to Menu"
    sudo curl -s "https://raw.githubusercontent.com/splashkit/the-programmers-field-guide/main/public/favicon.svg" -o /usr/share/pixmaps/feildguide.svg

    touch ~/programmers-field-guide.desktop
    echo "[Desktop Entry]" >> ~/programmers-field-guide.desktop
    echo "Type=Application" >> ~/programmers-field-guide.desktop
    echo "Name=Programmers Field Guide" >> ~/programmers-field-guide.desktop
    echo "TryExec=/usr/bin/x-www-browser" >> ~/programmers-field-guide.desktop
    echo "Exec=/usr/bin/x-www-browser https://programmers.guide/" >> ~/programmers-field-guide.desktop
    echo "Icon=/usr/share/pixmaps/feildguide.svg" >> ~/programmers-field-guide.desktop
    echo "Categories=Development;" >> ~/programmers-field-guide.desktop
    sudo mv ~/programmers-field-guide.desktop /usr/share/applications/programmers-field-guide.desktop
```

### Desktop Background

To customise the desktop background, right-click anywhere on the desktop and select Change Background (**Properties on the Raspberry Pi**).
Then, select the image or theme you want to use as your background.

![image showing the appearance menu](./src/assets/images/setup-linux/AppearanceMenu.png)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

You can toggle dark mode by clicking on the icon in the top right of the screen and selecting the mode you want to use.

![image showing quick setting with dark mode selected](./src/assets/images/setup-linux/QuickSettingMenu.png)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>


