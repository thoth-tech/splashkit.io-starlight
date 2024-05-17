/**
 * Usage Example: creating a sprite
 **/

#include "splashkit.h"

int main()
{
    // widow to draw the sprite on
    window start = open_window("create_sprite", 600, 600);

    // bitmap for creating a sprite
    bitmap player = load_bitmap("playerBmp", "protSpriteSheet.png");
    bitmap_set_cell_details(player, 31, 32, 4, 3, 12);

    // creating the player sprite
    sprite player_sprite = create_sprite(player);

    // setting the co-ordinates in refrence to the window
    sprite_set_x(player_sprite, 300);
    sprite_set_y(player_sprite, 300);
    
    // creating game loop
    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_BLACK);
        draw_sprite(player_sprite);
        refresh_screen();

        // if up key is typed, the sprite is removed
        if (key_typed(UP_KEY))
        {
            free_sprite(player_sprite);
        }

        update_sprite(player_sprite);
        
    }

    return 0;
}