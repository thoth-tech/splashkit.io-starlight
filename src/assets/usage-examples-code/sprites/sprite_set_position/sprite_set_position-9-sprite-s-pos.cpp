#include "splashkit.h"

int main()
{
    // window to draw the sprite on
    window start = open_window("sprite_set_position", 600, 600);

    // bitmap for creating a sprite
    bitmap player = load_bitmap("playerBmp", "protSpriteSheet-R.png");

    // creating the player sprite
    sprite player_sprite = create_sprite(player);

    // setting the x co-ordinates in refrence to the window
    sprite_set_x(player_sprite, 200);
    sprite_set_y(player_sprite, 300);

    clear_screen(COLOR_BLACK);
    draw_sprite(player_sprite);
    refresh_screen();
    delay(4000);

    // point 2d object which stores the new co-ordinates
    point_2d pos = point_at(450,300);

    // set the new sprite position
    sprite_set_position(player_sprite, pos);
    clear_screen(COLOR_BLACK);
    draw_sprite(player_sprite);
    refresh_screen();
    delay(10000);

    return 0;
}
