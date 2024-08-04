---

title: Installing python on macOS
draft: true
sidebar:
  hidden: true
  attrs:
    class: apple
---
<!-- TODO: Update for python install with homebrew -->
## Steps

1. Firstly, we need to install the [Homebrew Package Manager](https://brew.sh).
   Copy and paste the command given on the website into your terminal.

    ![Installing Homebrew](/gifs/macos/install-brew.gif)

    You will need to enter in your password into the terminal to install
    Homebrew. Whilst you may type into the keyboard, no password characters
    will appear for security reasons.

1. Now use `brew` from your terminal to to install the .NET Core SDK:

    ```shell
    brew install dotnet-sdk --cask
    ```

    You will also need to link the `dotnet` command into `/usr/local/bin`:

    ```shell
    ln -s /usr/local/share/dotnet/dotnet /usr/local/bin
    ```

1. To test if the .NET Core was installed successfully, see if the `dotnet` command exists.

    ```shell
    dotnet
    ```

    If you're seeing `command not found`, you may you can execute the following command
    to fix it:

    ```shell
    ln -s /usr/local/share/dotnet/dotnet /usr/local/bin
    ```

    ![Known issues with dotnet install](/gifs/macos/dotnet-known-issues.gif)

    Should you have any other installation issues, review the .NET core [release notes](https://github.com/dotnet/core/tree/master/release-notes)
    or raise an issue on [GitHub](https://github.com/splashkit/splashkit-macos/issues).

1. In Visual Studio Code you should install the following extensions:
    - [C#](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)
    - [C# XML Documentation Comments](https://marketplace.visualstudio.com/items?itemName=k--kato.docomment)
    - [vscode-icons](https://marketplace.visualstudio.com/items?itemName=vscode-icons-team.vscode-icons)

    You can do this from the command line by executing:

    ```shell
    code --install-extension ms-vscode.csharp
    code --install-extension k--kato.docomment
    code --install-extension vscode-icons
    ```

    You can also search for them by opening up the extensions panel.
    You can use the <kbd>⌘+x</kbd> to open the panel. Then search for the name
    and click install:

    ![Installing VSCode C# Extensions](/gifs/macos/extensions.gif)
