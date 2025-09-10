using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Mouse Wheel Scroll", 800, 600);

int x_scroll_counter = 0;
int y_scroll_counter = 0;
Font font = FontNamed("Century.ttf");

while (!QuitRequested())
{
    x_scroll_counter += (int)MouseWheelScroll().X;
    y_scroll_counter += (int)MouseWheelScroll().Y;

    ProcessEvents();

    ClearScreen(ColorWhite());
    DrawText(x_scroll_counter + ", " + y_scroll_counter, ColorBlack(), font, 200, 400 - TextWidth(x_scroll_counter + ", " + y_scroll_counter, font, 200) / 2, 90);
    DrawText("Reading is affected by moving the scroll wheel", ColorBlack(), font, 15, 248, 400);
    RefreshScreen();
}
CloseAllWindows();