#include "splashkit.h"

int main()
{
    // Create a window and bitmap for the window
    window window = open_window("Glass Window", 400, 300);
    bitmap bitmap = create_bitmap("window", 400, 300);
    
    // Fill background with white
    clear_bitmap(bitmap, COLOR_WHITE);
    
    // Create color
    color color = rgba_color(100, 150, 255, 128);
    
    // Size and spacing for squares
    double size = 80;
    double gap = 10;
    double start_x = 110;
    double start_y = 60;
    
    // Draw the four Window panels
    quad panels[] = {
        quad_from(
            start_x, start_y,
            start_x + size, start_y,
            start_x, start_y + size,
            start_x + size, start_y + size
        ),
        quad_from(
            start_x + size + gap, start_y,
            start_x + size*2 + gap, start_y,
            start_x + size + gap, start_y + size,
            start_x + size*2 + gap, start_y + size
        ),
        quad_from(
            start_x, start_y + size + gap,
            start_x + size, start_y + size + gap,
            start_x, start_y + size*2 + gap,
            start_x + size, start_y + size*2 + gap
        ),
        quad_from(
            start_x + size + gap, start_y + size + gap,
            start_x + size*2 + gap, start_y + size + gap,
            start_x + size + gap, start_y + size*2 + gap,
            start_x + size*2 + gap, start_y + size*2 + gap
        )
    };
    
    // Draw each panel
    for(int i = 0; i < 4; i++)
    {
        fill_quad_on_bitmap(bitmap, color, panels[i]);
    }
    
    while (!window_close_requested(window))
    {
        process_events();
        // Draw the bitmap to the window
        draw_bitmap(bitmap, 0, 0);
        // Refresh the window
        refresh_screen();
    }
    
    free_bitmap(bitmap);
    return 0;
}