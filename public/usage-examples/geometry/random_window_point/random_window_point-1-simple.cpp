#include "splashkit.h"

int main()
{
    

    //Create Window
    window window = open_window("portal", 600, 600);
    

    // load portal sprites
    load_bitmap("bluePortal", "bluePortal.png");
    load_bitmap("orangePortal", "orangePortal.png");
    sprite blue_portal = create_sprite(bitmap_named("bluePortal"));
    sprite orange_portal = create_sprite(bitmap_named("orangePortal"));

    //set random portal location
    sprite_set_position(blue_portal, random_window_point(window));
    sprite_set_position(orange_portal, random_window_point(window));

    clear_window(window, color_black());

    //Draw the sprite
    draw_sprite(blue_portal);
    draw_sprite(orange_portal);

    refresh_screen();
    delay(5000);
    close_all_windows();

    return 0;
}