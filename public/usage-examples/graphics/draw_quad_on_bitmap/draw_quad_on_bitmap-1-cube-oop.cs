using SplashKitSDK;

namespace DrawQuadOnBitmap
{
    public class Program
    {
        public static void Main()
        {
            // Create a bitmap to draw on (800x600)
            Bitmap bitmap = new Bitmap("cube", 800, 600);

            // Fill background with light color
            bitmap.ClearBitmap(Color.White);

            // Define the color for the cube
            Color cubeColor = Color.Blue;

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
            bitmap.DrawQuadOnBitmap(cubeColor, frontFace);
            bitmap.DrawQuadOnBitmap(cubeColor, backFace);

            // Connect the front and back faces for the 3D effect
            bitmap.DrawLineOnBitmap(cubeColor, 300, 200, 350, 150);
            bitmap.DrawLineOnBitmap(cubeColor, 500, 200, 550, 150);
            bitmap.DrawLineOnBitmap(cubeColor, 300, 400, 350, 350);
            bitmap.DrawLineOnBitmap(cubeColor, 500, 400, 550, 350);

            // Save the bitmap as a PNG file
            bitmap.SaveBitmap("cube");
            bitmap.FreeBitmap();
        }
    }
}