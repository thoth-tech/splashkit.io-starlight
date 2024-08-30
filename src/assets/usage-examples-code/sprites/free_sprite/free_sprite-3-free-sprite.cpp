#include "splashkit.h"

int main()
{
    // Window to draw the sprite on
    window start = open_window("create_sprite", 600, 600);

    // Bitmap for creating a sprite
    bitmap player = load_bitmap("playerBmp", "protSpriteSheet.png");
    bitmap_set_cell_details(player, 31, 32, 4, 3, 12);

    // Creating the player sprite
    sprite player_sprite = create_sprite(player);

    // Setting the coordinates in reference to the window
    sprite_set_x(player_sprite, 300);
    sprite_set_y(player_sprite, 300);

    // Game loop
    bool sprite_exists = true; // Track if the sprite exists
    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_BLACK);

        if (sprite_exists)
        {
            draw_sprite(player_sprite);
            update_sprite(player_sprite);
        }

        refresh_screen();

        // If UP key is typed, the sprite is removed
        if (sprite_exists && key_typed(UP_KEY))
        {
            free_sprite(player_sprite);
            sprite_exists = false; // Set bool to false to stop drawing/updating
        }
    }

    // Cleanup
    if (sprite_exists) 
    {
        free_sprite(player_sprite);
    }
    
    close_window(start);
    return 0;
}