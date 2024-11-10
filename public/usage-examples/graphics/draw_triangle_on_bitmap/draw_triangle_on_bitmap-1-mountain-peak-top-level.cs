using static SplashKitSDK.SplashKit;

// Create a bitmap for the mountain scene
Bitmap bitmap = CreateBitmap("mountain", 400, 300);

// Fill background with light color
ClearBitmap(bitmap, ColorWhite());

// Draw right peak (smallest)
DrawTriangleOnBitmap(bitmap, ColorGray(), 
                     175, 250,   // Left base
                     275, 175,   // Peak
                     375, 250);  // Right base

// Draw left peak (medium)
DrawTriangleOnBitmap(bitmap, ColorGray(),
                     25, 250,    // Left base
                     125, 125,   // Peak
                     225, 250);  // Right base

// Draw center peak (tallest)
DrawTriangleOnBitmap(bitmap, ColorGray(),
                     100, 250,   // Left base
                     200, 100,   // Peak
                     300, 250);  // Right base

// Save and free the bitmap
SaveBitmap(bitmap, "mountain_peaks");
FreeBitmap(bitmap);