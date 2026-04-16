#include "splashkit.h"

int main()
{
    open_window("Draw Rectangle On Bitmap", 800, 600);

    // Create a bitmap that will act as a drawing canvas
    bitmap canvas = create_bitmap("canvas", 500, 300);

    // Fill the bitmap so it stands out from the window background
    clear_bitmap(canvas, COLOR_WHITE);

    // Draw rectangles onto the bitmap
    draw_rectangle_on_bitmap(canvas, COLOR_RED, 20, 20, 120, 80);
    draw_rectangle_on_bitmap(canvas, COLOR_BLUE, 170, 50, 150, 100);
    draw_rectangle_on_bitmap(canvas, COLOR_GREEN, 360, 30, 100, 200);

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_LIGHT_GRAY);

        // Explain what the example is showing
        draw_text(
            "These rectangles were drawn onto a bitmap first.",
            COLOR_BLACK,
            20,
            20
        );
        draw_text(
            "The bitmap is then drawn to the window.",
            COLOR_BLACK,
            20,
            50
        );

        // Display the bitmap on the screen
        draw_bitmap(canvas, 150, 180);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
