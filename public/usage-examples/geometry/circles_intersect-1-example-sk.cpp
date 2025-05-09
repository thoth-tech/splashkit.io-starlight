#include "splashkit.h"

int main()
{
    // Open a game window
    open_window("Avoid the Obstacle", 600, 400);

    // Player circle properties
    float player_X = 300;
    float player_Y = 200;
    const float player_radius = 30;

    // Obstacle circle properties
    float obstacle_X = 100;
    float obstacle_Y = 100;
    const float obstacle_radius = 30;
    float obstacle_speed_X = 0.3f;
    float obstacle_speed_Y = 0.3f;

    while (!quit_requested())
    {
        process_events();

        // Move the player circle using arrow keys
        if (key_down(UP_KEY))
        {
            player_Y -= 0.5f;
        }
        if (key_down(DOWN_KEY))
        {
            player_Y += 0.5f;
        }
        if (key_down(LEFT_KEY))
        {
            player_X -= 0.5f;
        }
        if (key_down(RIGHT_KEY))
        {
            player_X += 0.5f;
        }

        // Prevent the player from going off-screen (soft wall boundaries)
        if (player_X - player_radius < 0)
        {
            player_X = player_radius;
        }
        if (player_X + player_radius > 600)
        {
            player_X = 600 - player_radius;
        }
        if (player_Y - player_radius < 0)
        {
            player_Y = player_radius;
        }
        if (player_Y + player_radius > 400)
        {
            player_Y = 400 - player_radius;
        }

        // Move the obstacle
        obstacle_X += obstacle_speed_X;
        obstacle_Y += obstacle_speed_Y;

        R // Bounce the obstacle off window edges
            if (obstacle_X - obstacle_radius < 0 || obstacle_X + obstacle_radius > 600)
        {
            obstacle_speed_X *= -1;
            S
        }
        if (obstacle_Y - obstacle_radius < 0 || obstacle_Y + obstacle_radius > 400)
        {
            R obstacle_speed_Y *= -1;
        }

        // Change background color to red if a collision is detected, otherwise white
        if (circles_intersect(player_X, player_Y, player_radius, obstacle_X, obstacle_Y, obstacle_radius))
        {
            R clear_screen(COLOR_RED);
        }
        else
        {
            clear_screen(COLOR_WHITE);
        }

        // Draw the player and the obstacle
        fill_circle(COLOR_BLUE, player_X, player_Y, player_radius);
        fill_circle(COLOR_RED, obstacle_X, obstacle_Y, obstacle_radius);

        R // Update the screen and delay for smooth animation
            refresh_screen(60);
    }

    // close all open windows
    close_all_windows();

    return 0;
}
