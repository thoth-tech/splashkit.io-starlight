#include "splashkit.h"

int main()
{
    // Open a window with the specified title and dimensions
    open_window("Fill Triangle", 800, 600);

    // Draw 50 random filled triangles on the window
    for (int i = 0; i < 50; i++)
    {
        // Generate random coordinates for the three vertices of the triangle
        int x1 = rand() % 800;
        int y1 = rand() % 600;
        int x2 = rand() % 800;
        int y2 = rand() % 600;
        int x3 = rand() % 800;
        int y3 = rand() % 600;

        // Generate a random color for the triangle
        color randomColor = rgb_color(rand() % 255, rand() % 255, rand() % 255);

        // Draw a filled triangle with the random color and vertices
        fill_triangle(randomColor, x1, y1, x2, y2, x3, y3);
    }

    // Refresh the screen to display the drawn triangles
    refresh_screen();

    // Delay to keep the window open for 4 seconds
    delay(4000);

    // Close all open windows
    close_all_windows();

    return 0;
}
