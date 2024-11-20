using SplashKitSDK;
using static SplashKitSDK.SplashKit;


// Variable Declaration
string click = "Mouse clicked at ";
string mouse_pos = "";

// Open Window
OpenWindow("point to string", 600, 600);
ClearScreen(ColorGhostWhite());

while(!QuitRequested())
{
    // check for mouse click
    if(MouseClicked(MouseButton.LeftButton))
    { 
        mouse_pos = PointToString(MousePosition());
        ClearScreen(ColorGhostWhite());
    }

    // Print mouse position to screen
    DrawText(click + mouse_pos,ColorBlack(),100,300);
    ProcessEvents();
    RefreshScreen();
}
