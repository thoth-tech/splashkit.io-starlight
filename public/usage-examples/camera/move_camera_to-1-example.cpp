#include "splashkit.h"

int main()
{
    const int screen_width = 800;
    const int screen_height = 600;
    const int world_width = 1600;
    const int world_height = 1000;

    const double player_size = 40;
    const double movement_speed = 5;

    open_window("Move Camera To Example", screen_width, screen_height);

    double player_x = 380;
    double player_y = 280;

    while (!quit_requested())
    {
        process_events();

        if (key_down(LEFT_KEY) || key_down(A_KEY))
        {
            player_x -= movement_speed;
        }

        if (key_down(RIGHT_KEY) || key_down(D_KEY))
        {
            player_x += movement_speed;
        }

        if (key_down(UP_KEY) || key_down(W_KEY))
        {
            player_y -= movement_speed;
        }

        if (key_down(DOWN_KEY) || key_down(S_KEY))
        {
            player_y += movement_speed;
        }

        // Keep the player within the world.
        if (player_x < 0)
        {
            player_x = 0;
        }

        if (player_x > world_width - player_size)
        {
            player_x = world_width - player_size;
        }

        if (player_y < 0)
        {
            player_y = 0;
        }

        if (player_y > world_height - player_size)
        {
            player_y = world_height - player_size;
        }

        // Centre the camera on the player.
        double camera_x =
            player_x + player_size / 2.0 - screen_width / 2.0;

        double camera_y =
            player_y + player_size / 2.0 - screen_height / 2.0;

        // Keep the camera within the world.
        if (camera_x < 0)
        {
            camera_x = 0;
        }

        if (camera_x > world_width - screen_width)
        {
            camera_x = world_width - screen_width;
        }

        if (camera_y < 0)
        {
            camera_y = 0;
        }

        if (camera_y > world_height - screen_height)
        {
            camera_y = world_height - screen_height;
        }

        // Move the camera to the calculated world position.
        move_camera_to(camera_x, camera_y);

        clear_screen(COLOR_WHITE);

        // Draw a simple grid to show camera movement.
        for (int x = 0; x <= world_width; x += 200)
        {
            draw_line(COLOR_LIGHT_GRAY, x, 0, x, world_height);
        }

        for (int y = 0; y <= world_height; y += 200)
        {
            draw_line(COLOR_LIGHT_GRAY, 0, y, world_width, y);
        }

        // Draw simple landmarks within the world.
        fill_rectangle(COLOR_GREEN, 100, 100, 180, 120);
        fill_circle(COLOR_RED, 800, 450, 70);
        fill_rectangle(COLOR_ORANGE, 1300, 750, 180, 120);

        // Draw the world boundary and player.
        draw_rectangle(COLOR_BLACK, 0, 0, world_width, world_height);
        fill_rectangle(
            COLOR_BLUE,
            player_x,
            player_y,
            player_size,
            player_size
        );

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}