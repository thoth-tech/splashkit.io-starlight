#include "splashkit.h"

int main()
{
    // Create a bitmap to draw on
    bitmap planet = create_bitmap("planet", 400, 400);
    
    // Fill background with dark color
    clear_bitmap(planet, COLOR_BLACK);
    
    // Create color
    color red = COLOR_RED;
    
    // Draw the main planet circle
    fill_circle_on_bitmap(planet, rgba_color(180, 0, 0, 255), 200, 200, 150);
    draw_circle_on_bitmap(planet, red, 200, 200, 150);
    
    // Add some surface details with smaller circles
    for(int i = 0; i < 15; i++)
    {
        double x = rnd(100, 300);  // Random between 100 and 300
        double y = rnd(100, 300);  // Random between 100 and 300
        double size = rnd(10, 30); // Random between 10 and 30
        draw_circle_on_bitmap(planet, red, x, y, size);
    }
    
    // Save and free the bitmap
    save_bitmap(planet, "draw_circle_on_bitmap-1-red-planet");
    free_bitmap(planet);
    
    return 0;
}