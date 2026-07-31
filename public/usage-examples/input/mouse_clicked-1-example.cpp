#include "splashkit.h"

int main()
{
    open_window("Circle Click Display", 800, 600);

    string clicked_circle = "None";
    int click_count = 0;

    while (!quit_requested())
    {
        process_events();

        if (mouse_clicked(LEFT_BUTTON))
        {
            point_2d mouse_point = mouse_position();

            if (point_in_circle(mouse_point, circle_at(180, 250, 60)))
            {
                clicked_circle = "Red";
                click_count++;
            }
            else if (point_in_circle(mouse_point, circle_at(400, 250, 60)))
            {
                clicked_circle = "Blue";
                click_count++;
            }
            else if (point_in_circle(mouse_point, circle_at(620, 250, 60)))
            {
                clicked_circle = "Green";
                click_count++;
            }
        }

        clear_screen(COLOR_WHITE);

        draw_text("Click a circle to see which one was selected.", COLOR_BLACK, 20, 20);
        draw_text("Last clicked: " + clicked_circle, COLOR_BLACK, 20, 60);
        draw_text("Total clicks: " + to_string(click_count), COLOR_BLACK, 20, 100);

        fill_circle(COLOR_RED, 180, 250, 60);
        draw_circle(COLOR_BLACK, 180, 250, 60);

        fill_circle(COLOR_BLUE, 400, 250, 60);
        draw_circle(COLOR_BLACK, 400, 250, 60);

        fill_circle(COLOR_GREEN, 620, 250, 60);
        draw_circle(COLOR_BLACK, 620, 250, 60);

        draw_text("Red", COLOR_BLACK, 155, 330);
        draw_text("Blue", COLOR_BLACK, 375, 330);
        draw_text("Green", COLOR_BLACK, 590, 330);

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}