#include "splashkit.h"

int main()
{
    // Open a window for the game
    open_window("Stay Close to the Line", 800, 600);

    // Define the line
    point_2d line_start = point_at(100, 300);
    point_2d line_end = point_at(700, 300);
    line path_line = line_from(line_start, line_end);

    // Define the player point
    point_2d player = point_at(400, 300);
    double max_distance = 50;

    while (!window_close_requested("Stay Close to the Line"))
    {
        process_events();

        // Move the player with arrow keys
        if (key_down(UP_KEY)) player.y -= 5;
        if (key_down(DOWN_KEY)) player.y += 5;
        if (key_down(LEFT_KEY)) player.x -= 5;
        if (key_down(RIGHT_KEY)) player.x += 5;

        // Calculate distance from player to the line
        double distance = point_line_distance(player, path_line);

        clear_screen(COLOR_WHITE);
        draw_line(COLOR_BLACK, line_start, line_end);
        fill_circle(COLOR_GREEN, player.x, player.y, 5);

        // End the game if the player strays too far
        if (distance > max_distance)
        {
            draw_text("Game Over - Too Far from the Line", COLOR_RED, 200, 50);
            refresh_screen();
            delay(2000);
            break;
        }

        refresh_screen(60);
    }

    return 0;
}