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
    int displayYValues = DisplayY(dispDetails);

    // Get resolution for display
    int dispWidth = DisplayWidth(dispDetails);
    int dispHeight = DisplayHeight(dispDetails);

    // Get name for display
    string dispName = DisplayName(dispDetails);

    // Add details to display store
    dispStore[i, 0] = dispX;
    dispStore[i, 1] = displayYValues;
    dispStore[i, 2] = dispWidth;
    dispStore[i, 3] = dispHeight;
    dispNames[i] = dispName;

    // Calculate offset to handle negative coordinates for drawing 
    if (dispX < minX) minX = dispX;
    if (displayYValues < minY) minY = displayYValues;
}

Window wind = OpenWindow("Display Y", 800, 600);

for (int i = 0; i < dispCount; i++)
{
    // Set Display Variables
    int originX = dispStore[i, 0];
    int originY = dispStore[i, 1];
    int lenX = dispStore[i, 2];
    int lenY = dispStore[i, 3];

    // Create labels for each display
    string displayNameString = $"Name: {dispNames[i]}";
    string displayNumString = $"Display Number: {i + 1}";
    string displayCoordString = $"Display Coordinates: ({originX}, {originY})";

    // Refactor size and normalize for 300,300 origin in window
    originX = (originX - minX + 300) / 8;
    originY = (originY - minY + 400) / 8;
    lenX = lenX / 8;
    lenY = lenY / 8;

    // Refresh screen after drawing each display and its labels
    Rectangle disp = RectangleFrom(originX, originY, lenX, lenY);
    DrawRectangle(ColorBlack(), disp);
    DrawTextOnWindow(wind, displayNameString, ColorBlack(), font, 10, originX + 5, originY + 5);
    DrawTextOnWindow(wind, displayNumString, ColorBlack(), font, 10, originX + 5, originY + 20);
    DrawTextOnWindow(wind, displayCoordString, ColorBlack(), font, 10, originX + 5, originY + 35);
    RefreshScreen();
}
DrawTextOnWindow(wind, "Display Y value represents the vertical offset of a display,", ColorBlack(), font, 16, 10, 10);
DrawTextOnWindow(wind, "where 0,0 is the top left corner of the main display.", ColorBlack(), font, 16, 10, 30);
RefreshScreen();

while (!QuitRequested())
{
    ProcessEvents();
}

