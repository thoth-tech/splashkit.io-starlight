/**
 * Usage Example: moving sprite to
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

        // if right key typed, execute move player to the right
        if (key_typed(RIGHT_KEY))
        {
            move_sprite_to(player_sprite, 500, 300);
        }

    }

    return 0;
}