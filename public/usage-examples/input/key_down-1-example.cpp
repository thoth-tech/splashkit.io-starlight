#include "splashkit.h"

void draw_key_state(string key_name, bool is_pressed, double x, double y)
{
    color circle_color;

    if (is_pressed)
    {
        circle_color = COLOR_GREEN;
    }
    else
    {
        circle_color = COLOR_GRAY;
    }

    fill_circle(circle_color, x + 15, y + 15, 15);
    draw_circle(COLOR_BLACK, x + 15, y + 15, 15);

    if (is_pressed)
    {
        draw_text(key_name + ": Pressed", COLOR_BLACK, x + 40, y);
    }
    else
    {
        draw_text(key_name + ": Released", COLOR_BLACK, x + 40, y);
    }
}

int main()
{
    open_window("Live Key Press Display", 800, 400);

    while (!quit_requested())
    {
        process_events();

        bool space_pressed = key_down(SPACE_KEY);
        bool left_pressed = key_down(LEFT_KEY);
        bool right_pressed = key_down(RIGHT_KEY);
        bool up_pressed = key_down(UP_KEY);
        bool down_pressed = key_down(DOWN_KEY);

        clear_screen(COLOR_WHITE);

        draw_text("Hold the keys to see their current state.", COLOR_BLACK, 20, 20);

        draw_key_state("Space", space_pressed, 20, 80);
        draw_key_state("Left", left_pressed, 20, 130);
        draw_key_state("Right", right_pressed, 20, 180);
        draw_key_state("Up", up_pressed, 20, 230);
        draw_key_state("Down", down_pressed, 20, 280);

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
} 
