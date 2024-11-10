#include "splashkit.h"

int main()
{
    // Create a bitmap for the water surface
    bitmap bitmap = create_bitmap("water", 400, 300);
    
    // Fill background with light blue
    clear_bitmap(bitmap, rgba_color(200, 230, 255, 255));
    
    // Create different blue tones for ripples (from most opaque to most transparent)
    color ripple_colors[] = {
        rgba_color(100, 150, 255, 100),
        rgba_color(120, 170, 255, 80),
        rgba_color(140, 190, 255, 60),
        rgba_color(160, 210, 255, 40),
        rgba_color(180, 230, 255, 20)
    };
    
    // Create ripple effect with concentric ellipses
    double center_x = 200;  // Center of the bitmap
    double center_y = 150;
    for(int i = 0; i < 5; i++)
    {
        // Larger ellipses with decreasing size from center
        fill_ellipse_on_bitmap(bitmap, ripple_colors[i],
                             center_x - (100 + i*30),  // x gets further from center
                             center_y - (75 + i*20),   // y gets further from center
                             200 + i*60,               // width increases for outer ripples
                             150 + i*40);              // height increases for outer ripples
    }
    
    // Save and free the bitmap
    save_bitmap(bitmap, "water_ripples.png");
    free_bitmap(bitmap);
    
    return 0;
}