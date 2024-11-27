#include "splashkit.h"

int main(){
    // Create a Window and bitmap for the map
window = new Window("Rectangle on Bitmap", 400, 400);
bitmap = new Bitmap("bricks", 400, 400);

            // Clear the bitmap with a base color (representing the brick wall)
Clear(Color.Gray);
    for (int y = 0; y < 400; y += 50) // Each brick row
            {
                for (int x = (y / 50) % 2 == 0 ? 0 : 25; x < 400; x += 50) // Offset every other row
                {
                    bitmap.DrawRectangle(brickColor, x, y, 50, 25);
                }
            }

            // Draw a grid of rectangles to simulate bricks
    // Add some surface details with smaller circles
     for (int i = 0; i < 15; i++)
    {
                double x = rand(50, 350);  // Random X position
                double y = rand(50, 350);  // Random Y position
                double width = rand(20, 50); // Random width
                double height = rand(20, 50); // Random height

        color randomColor = rgb_color(rand() % 255, rand() % 255, rand() % 255);

        draw_rectangle(randomColor, x, y, width, height);
    }


    while (!window_close_requested(window))
    {
        process_events();
        // Draw the bitmap to the window
        draw_bitmap(bricks, 0, 0);
        // Refresh the window
        refresh_screen();
    }

    free_bitmap(bricks);
    return 0;
}
