using SplashKitSDK;
using static SplashKitSDK.SplashKit;

string imageUrl =
    "https://programmers.guide/resources/code-examples/part-0/earth.png";

// Download the bitmap from the web server
Bitmap earth = DownloadBitmap("Earth", imageUrl, 443);

OpenWindow("Downloaded Bitmap", 700, 500);

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(ColorWhite());

    DrawText(
        "Bitmap downloaded from the internet",
        ColorBlack(),
        170,
        40
    );

    // Draw the downloaded bitmap
    DrawBitmap(earth, 220, 100);

    RefreshScreen(60);
}

CloseAllWindows();