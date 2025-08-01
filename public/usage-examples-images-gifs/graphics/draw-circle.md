---
title: Draw Circle
description: A tiny program that draws a red circle in the center of the screen.  
function: draw_circle  
---

## When would you use this?

I would use `draw_circle` when I want simple shapes on the screen, like a marker in a game or a quick highlight.  
It’s an easy way to add basic graphics without needing images.

---

### C++ Version

```cpp
// In this small program, I am showing you how I draw a simple red circle in the middle of the window.
// I am keeping it minimal so it’s easy to understand.

#include "splashkit.h"

int main()
{
    open_window("Colorful Spotlight", 800, 600);       // I am opening a window with width 800 and height 600
    clear_screen(COLOR_WHITE);                         // I am clearing the screen to white so it’s clean
    draw_circle(COLOR_RED, 400, 300, 100);             // I am drawing a red circle in the center with a radius of 100
    refresh_screen();                                  // I am refreshing the screen so the circle actually appears
    delay(3000);                                       // I am waiting 3 seconds before the program closes
    return 0;                                          // I am finishing the program
}
```

---

### C# Version

```csharp
// In this small program, I am showing you how I draw a simple red circle in the middle of the window.
// I am keeping it minimal so it’s easy to understand.

using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window window = new Window("Colorful Spotlight", 800, 600); // I am opening a window with width 800 and height 600
        SplashKit.ClearScreen(Color.White);                         // I am clearing the screen to white so it’s clean
        SplashKit.DrawCircle(Color.Red, 400, 300, 100);             // I am drawing a red circle in the center with a radius of 100
        SplashKit.RefreshScreen();                                  // I am refreshing the screen so the circle actually appears
        SplashKit.Delay(3000);                                      // I am waiting 3 seconds before the program closes
        window.Close();                                             // I am closing the window
    }
}
```

---

### Python Version

```python
# In this small program, I am showing you how I draw a simple red circle in the middle of the window.
# I am keeping it minimal so it’s easy to understand.

from splashkit import *

def main():
    open_window("Colorful Spotlight", 800, 600)        # I am opening a window with width 800 and height 600
    clear_screen(color_white())                        # I am clearing the screen to white so it’s clean
    draw_circle(color_red(), 400, 300, 100)            # I am drawing a red circle in the center with a radius of 100
    refresh_screen()                                   # I am refreshing the screen so the circle actually appears
    delay(3000)                                        # I am waiting 3 seconds before the program closes

main()
```