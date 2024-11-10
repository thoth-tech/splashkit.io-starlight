using static SplashKitSDK.SplashKit;

// Create a bitmap to draw on (800x600)
Bitmap bitmap = CreateBitmap("cube", 800, 600);

// Fill background with light color
ClearBitmap(bitmap, ColorWhite());

// Define the color for the cube
Color cubeColor = ColorBlue();

// Define the coordinates of the front and back faces of the cube
Quad frontFace = QuadFrom(
    300, 200,    // Top-left
    500, 200,    // Top-right
    300, 400,    // Bottom-left
    500, 400     // Bottom-right
);

Quad backFace = QuadFrom(
    350, 150,    // Top-left
    550, 150,    // Top-right
    350, 350,    // Bottom-left
    550, 350     // Bottom-right
);

// Draw the faces of the cube
DrawQuadOnBitmap(bitmap, cubeColor, frontFace);
DrawQuadOnBitmap(bitmap, cubeColor, backFace);

// Connect the front and back faces for the 3D effect
DrawLineOnBitmap(bitmap, cubeColor, 300, 200, 350, 150);
DrawLineOnBitmap(bitmap, cubeColor, 500, 200, 550, 150);
DrawLineOnBitmap(bitmap, cubeColor, 300, 400, 350, 350);
DrawLineOnBitmap(bitmap, cubeColor, 500, 400, 550, 350);

// Save the bitmap as a PNG file
SaveBitmap(bitmap, "cube");
FreeBitmap(bitmap);