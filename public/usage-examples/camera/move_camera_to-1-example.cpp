#include "splashkit.h"

int main()
{
    // Open a window
    open_window("Move Camera To Example", 800, 600);

    // Create a player bitmap and sprite
    // This allows us to have an object to follow in the world
    bitmap player_bmp = create_bitmap("player", 40, 40);
    clear_bitmap(player_bmp, COLOR_BRIGHT_GREEN);
    sprite player = create_sprite(player_bmp);
    
    // Position the player further out in the game world
    sprite_set_x(player, 1000);
    sprite_set_y(player, 1000);

    while (!quit_requested())
    {
        // Handle input to move the player
        process_events();

        if (key_down(LEFT_KEY)) sprite_set_x(player, sprite_x(player) - 5);
        if (key_down(RIGHT_KEY)) sprite_set_x(player, sprite_x(player) + 5);
        if (key_down(UP_KEY)) sprite_set_y(player, sprite_y(player) - 5);
        if (key_down(DOWN_KEY)) sprite_set_y(player, sprite_y(player) + 5);

        // Center camera on player when SPACE is pressed
        if (key_typed(SPACE_KEY))
        {
            // Calculate the top-left position for the camera to center the player
            double target_x = sprite_x(player) + sprite_width(player) / 2 - screen_width() / 2;
            double target_y = sprite_y(player) + sprite_height(player) / 2 - screen_height() / 2;
            
            // Move the camera to the calculated point
            move_camera_to(target_x, target_y);
        }

        // Reset camera to origin when M is pressed
        if (key_typed(M_KEY))
        {
            move_camera_to(0, 0);
        }

        // Clear the screen
        clear_screen(COLOR_BLACK);

        // Draw some world markers to visualize the camera move
        fill_rectangle(COLOR_WHITE, 0, 0, 20, 20);
        draw_text("World (0,0)", COLOR_WHITE, 5, 25);

        fill_rectangle(COLOR_RED, 1000, 1000, 20, 20);
        draw_text("World (1000,1000)", COLOR_RED, 1000, 1025);

        // Draw the sprite (automatically uses camera offset)
        draw_sprite(player);

        // Draw HUD (Heads-Up Display) directly to the screen
        fill_rectangle(COLOR_DIM_GRAY, 0, 0, 260, 80, option_to_screen());
        draw_text("Camera Position: " + point_to_string(camera_position()), COLOR_WHITE, 10, 10, option_to_screen());
        draw_text("Player World Pos: (" + std::to_string((int)sprite_x(player)) + ", " + std::to_string((int)sprite_y(player)) + ")", COLOR_WHITE, 10, 30, option_to_screen());
        draw_text("Press SPACE to center on player", COLOR_WHITE, 10, 50, option_to_screen());
        draw_text("Press M to move camera to (0,0)", COLOR_WHITE, 10, 65, option_to_screen());

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
