#include "splashkit.h"

int main()
{
    // Create a bitmap for the mountain scene
    bitmap bitmap = create_bitmap("mountain", 400, 300);
    
    // Fill background with light color
    clear_bitmap(bitmap, COLOR_WHITE);
    
    // Draw right peak (smallest)
    draw_triangle_on_bitmap(bitmap, COLOR_GRAY, 
                          175, 250,   // Left base
                          275, 175,   // Peak
                          375, 250);  // Right base
    
    // Draw left peak (medium)
    draw_triangle_on_bitmap(bitmap, COLOR_GRAY,
                          25, 250,    // Left base
                          125, 125,   // Peak
                          225, 250);  // Right base
    
    // Draw center peak (tallest)
    draw_triangle_on_bitmap(bitmap, COLOR_GRAY,
                          100, 250,   // Left base
                          200, 100,   // Peak
                          300, 250);  // Right base
    
    // Save and free the bitmap
    save_bitmap(bitmap, "mountain_peaks");
    free_bitmap(bitmap);
    
    return 0;
}