using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Key Released", 800, 600);

int releaseCount = 0;
string status = "Waiting...";

while (!QuitRequested())
{
    ProcessEvents();

    if (KeyDown(KeyCode.SpaceKey))
    {
        status = "Holding Space...";
    }

    // KeyReleased returns true only once per release event
    if (KeyReleased(KeyCode.SpaceKey))
    {
        releaseCount++;
        status = "Space released!";
    }

    ClearScreen(ColorWhite());
    DrawText("Press and hold [SPACE], then release it", ColorBlack(), "Arial", 18, 200, 220);
    DrawText("Status: " + status, ColorDarkGray(), "Arial", 18, 200, 270);
    DrawText("Times released: " + releaseCount.ToString(), ColorBlue(), "Arial", 24, 200, 320);
    RefreshScreen(60);
}

CloseAllWindows();
