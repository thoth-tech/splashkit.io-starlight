using static SplashKitSDK.SplashKit;

// Create a bitmap for the map
Bitmap bitmap = CreateBitmap("map", 400, 300);

// Fill background with light beige for map background
ClearBitmap(bitmap, ColorWhite());

// Draw the route line in white
DrawLineOnBitmap(bitmap, ColorGreen(), 
                100, 80,    // Starting point (x1, y1)
                300, 220);  // End point (x2, y2)

// Add points at start and end
FillCircleOnBitmap(bitmap, ColorRed(), 100, 80, 5);    // Start point
FillCircleOnBitmap(bitmap, ColorRed(), 300, 220, 5);   // End point

// Save and free the bitmap
SaveBitmap(bitmap, "map_route");
FreeBitmap(bitmap);