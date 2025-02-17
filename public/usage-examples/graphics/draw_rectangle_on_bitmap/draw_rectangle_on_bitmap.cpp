#include "splashkit.h"

int main(){
    // Open a window
    open_window("Rectangle on Bitmap", 400, 400);
    // Create a bitmap
    bitmap bmp = create_bitmap("bricks", 400, 400);

    // Draw 50 random rectangles on the bitmap
     for (int i = 0; i < 50; i++)
    {
                double x = rand()%350;  
                double y = rand()%350;  
                double width = rand()%50; 
                double height = rand()%50; 
        // Generate a random color
        color randomColor = rgb_color(rand() % 255, rand() % 255, rand() % 255);
        // Draw the rectangle with the random color on the bitmap
        draw_rectangle_on_bitmap(bmp, randomColor, x, y, width, height);
    }
    // Draw the bitmap onto the window
    draw_bitmap(bmp, 0,0);
    // Refresh the screen
    refresh_screen();
    // Delay to keep the window open for 5 seconds
    delay(5000);
    // Close all open windows
    close_all_windows();

    return 0;
}
