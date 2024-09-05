#include "splashkit.h"

int main()
{
    // Window to draw the sprite on
    window start = open_window("sprite-set-velocity", 600, 600);

    // Bitmap for creating a sprite
    bitmap player = load_bitmap("playerBmp", "protSpriteSheet-R.png");

    // Creating the player sprite
    sprite player_sprite = create_sprite(player);

    // Setting the coordinates in reference to the window
    sprite_set_x(player_sprite, 300);
    sprite_set_y(player_sprite, 300);

    // set sprite's velocity using as a vector 2d object
    vector_2d vel = vector_to(0.01,0);
    

    // Game loop
    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_BLACK);
        // setting sprite velocity
        sprite_set_velocity(player_sprite, vel);
        draw_sprite(player_sprite);
        update_sprite(player_sprite);
        refresh_screen();

    }
    
    close_window(start);
    
    return 0;
}
