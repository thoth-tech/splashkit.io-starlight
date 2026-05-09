#include "splashkit.h"

int main()
{
    open_window("Move Mouse To Point", 800, 600);

    // Define five target points using point_at to create point_2d values
    // These represent the four corners and the center of the window
    point_2d top_left     = point_at(100, 100);
    point_2d top_right    = point_at(700, 100);
    point_2d bottom_left  = point_at(100, 500);
    point_2d bottom_right = point_at(700, 500);
    point_2d center       = point_at(400, 300);

    while (!quit_requested())
    {
        process_events();

        // move_mouse repositions the cursor to the given point_2d location
        // Each key press snaps the mouse to the corresponding target point
        if (key_typed(Q_KEY))
            move_mouse(top_left);
        if (key_typed(E_KEY))
            move_mouse(top_right);
        if (key_typed(A_KEY))
            move_mouse(bottom_left);
        if (key_typed(D_KEY))
            move_mouse(bottom_right);
        if (key_typed(SPACE_KEY))
            move_mouse(center);

        clear_screen(COLOR_WHITE);

        // Draw a coloured circle at each target point so the user can see where the mouse will snap
        fill_circle(COLOR_RED,    top_left.x,     top_left.y,     12);
        fill_circle(COLOR_BLUE,   top_right.x,    top_right.y,    12);
        fill_circle(COLOR_GREEN,  bottom_left.x,  bottom_left.y,  12);
        fill_circle(COLOR_ORANGE, bottom_right.x, bottom_right.y, 12);
        fill_circle(COLOR_PURPLE, center.x,        center.y,        12);

        // Label each target with its corresponding key
        draw_text("[Q]",     COLOR_RED,    "Arial", 16, top_left.x - 12,     top_left.y + 18);
        draw_text("[E]",     COLOR_BLUE,   "Arial", 16, top_right.x - 12,    top_right.y + 18);
        draw_text("[A]",     COLOR_GREEN,  "Arial", 16, bottom_left.x - 12,  bottom_left.y + 18);
        draw_text("[D]",     COLOR_ORANGE, "Arial", 16, bottom_right.x - 12, bottom_right.y + 18);
        draw_text("[SPACE]", COLOR_PURPLE, "Arial", 16, center.x - 28,        center.y + 18);

        draw_text("Press a key to move the mouse to that point", COLOR_BLACK, "Arial", 18, 185, 260);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
