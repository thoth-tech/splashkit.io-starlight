
#include "splashkit.h"

int main()
{
    // window to draw the sprite on
    window start = open_window("sprite_set_x", 600, 600);

    // bitmap for creating a sprite
    bitmap player = load_bitmap("playerBmp", "protSpriteSheet-R.png");

    // creating the player sprite
    sprite player_sprite = create_sprite(player);

    // setting the x co-ordinates in refrence to the window
    sprite_set_x(player_sprite, 300);

    clear_screen(COLOR_BLACK);
    draw_sprite(player_sprite);
    refresh_screen();
    delay(10000);

    return 0;
}