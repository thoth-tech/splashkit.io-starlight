using System;
using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Load Font
Font font = LoadFont("font", "RobotoSlab.ttf");

// Set number of displays
int dispCount = NumberOfDisplays();

// Arrays for storing display details
int[,] dispStore = new int[dispCount, 4];
string[] dispNames = new string[dispCount];

// Create variables for offset
int minX = 0, minY = 0;

// Loop through displays collect details
for (uint i = 0; i < dispCount; i++)
{
    // Set details for display
    Display dispDetails = DisplayDetails(i);

    // Get coordinate info for display
    int dispX = DisplayX(dispDetails);
    int dispY = DisplayY(dispDetails);

    // Get resolution for display
    int dispWidth = DisplayWidth(dispDetails);
    int dispHeight = DisplayHeight(dispDetails);

    // Get name for display
    string dispName = DisplayName(dispDetails);

    // Add details to display store
    dispStore[i, 0] = dispX;
    dispStore[i, 1] = dispY;
    dispStore[i, 2] = dispWidth;
    dispStore[i, 3] = dispHeight;
    dispNames[i] = dispName;

    // Set min coordinate offset for drawing
    if (dispX < minX) minX = dispX;
    if (dispY < minY) minY = dispY;
}

Window wind = OpenWindow("Display setup", 800, 600);

for (int i = 0; i < dispCount; i++)
{
    // Set Display Variables
    int originX = dispStore[i, 0];
    int originY = dispStore[i, 1];
    int lenX = dispStore[i, 2];
    int lenY = dispStore[i, 3];

    // Create strings for display
    string displayNameString = $"Name: {dispNames[i]}";
    string displayNumString = $"Display Number: {i + 1}";
    string displayCoordString = $"Display Coordinates: ({originX}, {originY})";
    string displayResolutionString = $"Resolution: {lenX}x{lenY}";

    // Refactor size and normalize for 300,300 origin in window
    originX = (originX - minX + 300) / 8;
    originY = (originY - minY + 300) / 8;
    lenX = lenX / 8;
    lenY = lenY / 8;

    // Draw Display setup to screen and label
    Rectangle disp = RectangleFrom(originX, originY, lenX, lenY);
    DrawRectangleOnWindow(wind, Color.Black, disp);
    DrawTextOnWindow(wind, displayNameString, ColorBlack(), font, 10, originX + 5, originY + 5);
    DrawTextOnWindow(wind, displayNumString, ColorBlack(), font, 10, originX + 5, originY + 20);
    DrawTextOnWindow(wind, displayCoordString, ColorBlack(), font, 10, originX + 5, originY + 35);
    DrawTextOnWindow(wind, displayResolutionString, ColorBlack(), font, 10, originX + 5, originY + 50);
    RefreshScreen();
}
while (!QuitRequested())
{
    ProcessEvents();
}
