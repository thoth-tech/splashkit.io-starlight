using SplashKitSDK;
using static SplashKitSDK.SplashKit;

bool audioClosed = false;

OpenWindow("Audio Control Demonstration", 700, 420);
OpenAudio();

while (!QuitRequested())
{
    ProcessEvents();

    // Close the audio system once when the user requests it.
    if (KeyTyped(KeyCode.SpaceKey) && !audioClosed)
    {
        CloseAudio();
        audioClosed = true;
    }

    ClearScreen(Color.RGBColor(242, 246, 252));
    FillRectangle(Color.RGBColor(31, 45, 72), 0, 0, 700, 90);
    DrawText("Close Audio Demonstration", Color.White, 215, 35);

    DrawText("Press SPACE to close the SplashKit audio system.", Color.Black, 180, 135);
    FillRectangle(Color.White, 170, 190, 360, 110);

    if (audioClosed)
    {
        FillCircle(Color.RGBColor(211, 47, 47), 225, 245, 18);
        DrawText("Audio status: CLOSED", Color.RGBColor(211, 47, 47), 265, 238);
        DrawText("All audio has been stopped.", Color.Black, 250, 270);
    }
    else
    {
        FillCircle(Color.RGBColor(46, 125, 50), 225, 245, 18);
        DrawText("Audio status: READY", Color.RGBColor(46, 125, 50), 265, 238);
        DrawText("The audio system is available.", Color.Black, 245, 270);
    }

    DrawText("Close the window to finish.", Color.RGBColor(80, 90, 105), 260, 350);
    RefreshScreen(60);
}

// Release the audio system if the window was closed before Space was pressed.
if (!audioClosed)
{
    CloseAudio();
}
