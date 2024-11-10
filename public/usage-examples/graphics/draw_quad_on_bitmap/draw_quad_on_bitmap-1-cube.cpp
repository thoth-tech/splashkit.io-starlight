#include "splashkit.h"

int main()
{
    // Create a bitmap to draw on (800x600)
    bitmap bitmap = create_bitmap("cube", 800, 600);
    
    // Fill background with light color
    clear_bitmap(bitmap, COLOR_WHITE);
    
    // Define the color for the cube
    color cube_color = COLOR_BLUE;
    
    // Define the coordinates of the front and back faces of the cube
    quad front_face = quad_from(
        300, 200,    // Top-left
        500, 200,    // Top-right
        300, 400,    // Bottom-left
        500, 400     // Bottom-right
    );
    
    quad back_face = quad_from(
        350, 150,    // Top-left
        550, 150,    // Top-right
        350, 350,    // Bottom-left
        550, 350     // Bottom-right
    );
    
    // Draw the faces of the cube
    draw_quad_on_bitmap(bitmap, cube_color, front_face);
    draw_quad_on_bitmap(bitmap, cube_color, back_face);
    
    // Connect the front and back faces for the 3D effect
    draw_line_on_bitmap(bitmap, cube_color, 300, 200, 350, 150);
    draw_line_on_bitmap(bitmap, cube_color, 500, 200, 550, 150);
    draw_line_on_bitmap(bitmap, cube_color, 300, 400, 350, 350);
    draw_line_on_bitmap(bitmap, cube_color, 500, 400, 550, 350);
    
    // Save the bitmap as a PNG file
    save_bitmap(bitmap, "cube");
    free_bitmap(bitmap);
    
    return 0;
}