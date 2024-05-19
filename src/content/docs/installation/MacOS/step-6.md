---

title: 6. Optional Setup Steps
description: Optional Setup Steps
sidebar:
  attrs:
    class: apple
---

## 6. Optional Steps

### Check Environment Variables

Through this installation process, some steps *should* have edited your computer's environment variables, or your "Shell Profile" file.

To ensure the required *paths* will be added to your **PATH** environment variable each time you open a new Terminal shell, you will need to check that your **"Shell Profile" file** contains the following lines:

```bash
export PATH="$HOME/.splashkit:$PATH"
export PATH="/usr/local/share/dotnet:$PATH"
export PATH="$PATH:/Applications/Visual Studio Code.app/Contents/Resources/app/bin"
```

:::tip[Shell Profiles]
The two most common shell profiles are **zsh** (Default shell since macOS Catalina) and **bash**:

- If you are using `zsh` (Z Shell) then the *"Shell Profile"* files are: `.zshrc` or `.zprofile`.
- If you are using `bash` (Bash Shell) then the *"Shell Profile"* files are: `.bash_profile` or `.bashrc`.

:::

If you are missing any of the lines above, you can edit your "Shell Profile" file in a few ways:

### Using '*nano*' in the Terminal

To open the file in the "nano" shell, copy and paste the following command in your Terminal:

```bash
nano .zshrc
```

The result of the command above will look similar to this:

![Terminal window showing nano opening .zshrc file](./src/assets/images/setup-macos/nano-zshrc.png)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

Now, to edit the file directly inside the **nano** terminal window, you can just move the cursor down to the last line and paste the missing command.  
Once you're finished, press ***Control*** (^) + ***X*** to exit **nano** and follow the prompts to save the changes.

For example, if the last line was missing:

![Gif showing .zshrc file being edited using nano command](/gifs/setup-macos/nano-edit-zshrc.gif)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

### Using 'code' to open .zshrc file in Visual Studio Code

You can open your `.zshrc` file in Visual Studio Code using the `code` command, to edit and add any missing lines.

To do this, copy and paste the following command in your Terminal:

```bash
code ~/.zshrc
```

![Gif showing 'code ~/.zshrc' command opening file in VS Code](/gifs/setup-macos/code-zshrc-open.gif)
<div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

