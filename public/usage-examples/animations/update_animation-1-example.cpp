#include "splashkit.h"

int main()
{
    open_window("Color Cycle Animation", 400, 400);

    // Build a 4-frame sprite sheet in memory (each cell is 64x64)
    bitmap sheet = create_bitmap("sheet", 256, 64);
    fill_rectangle_on_bitmap(sheet, COLOR_RED, 0, 0, 64, 64);
    fill_rectangle_on_bitmap(sheet, COLOR_GREEN, 64, 0, 64, 64);
    fill_rectangle_on_bitmap(sheet, COLOR_BLUE, 128, 0, 64, 64);
    fill_rectangle_on_bitmap(sheet, COLOR_YELLOW, 192, 0, 64, 64);
    bitmap_set_cell_details(sheet, 64, 64, 4, 1, 4);

    // Load the animation script and create the animation
    animation_script script = load_animation_script("color_cycle", "color_cycle.txt");
    animation anim = create_animation(script, "ColorCycle");

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        // Draw the current animation frame centered on the window
        draw_bitmap(sheet, 168, 168, option_with_animation(anim));

        // Advance the animation to the next frame
        update_animation(anim);

        refresh_screen(60);
    }

    // Release resources
    free_animation(anim);
    free_animation_script(script);
    close_all_windows();

    return 0;
}
