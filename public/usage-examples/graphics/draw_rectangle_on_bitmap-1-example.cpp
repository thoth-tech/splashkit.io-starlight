#include "splashkit.h"

int main()
{
    open_window("Bitmap Canvas", 800, 600);

    bitmap canvas = create_bitmap("canvas", 500, 300);

    clear_bitmap(canvas, COLOR_WHITE);

    draw_rectangle_on_bitmap(canvas, COLOR_RED, 20, 20, 120, 80);
    draw_rectangle_on_bitmap(canvas, COLOR_BLUE, 170, 50, 150, 100);
    draw_rectangle_on_bitmap(canvas, COLOR_GREEN, 360, 30, 100, 200);

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_LIGHT_GRAY);

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

        draw_bitmap(canvas, 150, 180);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
