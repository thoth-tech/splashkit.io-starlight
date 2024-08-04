---
title: dotnet command not found
description: A reference page in my new Starlight docs site.
sidebar:
  label: 5. Dotnet not found
  attrs:
    class: windows
---

<h1> Issue : Windows </h1>

## “`dotnet: command not found`”

![-](https://i.imgur.com/gzi30bu.png)

## Solution

You might need to add the dotnet folder path to your “Path” environment variable.
Firstly, go through Steps 1 – 3 shown in the “Update your system “Path” variable” section [here](/troubleshoot/windows/list/win-issue-7).

Then come back here for the Next Step.
**Next Step:** In the “Edit environment variable” window, click "New" (Red box), then add the
path shown in the Green box:

![-](https://i.imgur.com/T6wIBWt.png)

Once it is added, click “`OK`” on all the windows, open a **new** MINGW64 terminal and try running the program again.
