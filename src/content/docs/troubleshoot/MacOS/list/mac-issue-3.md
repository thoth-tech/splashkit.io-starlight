---
title: ln -s /usr/local.... command not working
description: A reference page in my new Starlight docs site.
sidebar:
  label: 3. Local bin Error
  attrs:
    class: apple
---

<h1> Issue : MacOS </h1>

### `ln -s /usr/local/share/dotnet/dotnet /usr/local/bin` command not working

![-](https://i.imgur.com/MJgfrXW.png)

## Solution  

Run the following command, and then enter your password:

```shell
sudo ln -s /usr/local/share/dotnet/dotnet /usr/local/bin
```

*The `sudo` command temporarily gives you system (root) privileges.*

**Note:** If you get a “`zsh: permission denied: dotnet`” error at any point, open Finder and
navigate to the “`/usr/local/bin`” folder. (*You can do this by clicking “Go” at the top of the
screen, then click on “Go to Folder…” and type the folder path here.*)

Delete the “`dotnet`” file in that folder, and then run the command shown at the top of this
Solution in a new Terminal window.
