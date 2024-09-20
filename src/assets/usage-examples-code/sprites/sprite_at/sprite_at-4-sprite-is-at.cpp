#include "splashkit.h"
#include <iostream>
#include <string> 


//  paused as of 5th september 

int main()
{
    // Window to draw the sprite on
    window start = open_window("create_sprite", 600, 600);

    // Bitmap for creating a sprite
    bitmap player = load_bitmap("playerBmp", "protSpriteSheet-C.png");
    bitmap_set_cell_details(player, 31, 32, 4, 3, 12);

    // Creating the player sprite
    sprite player_sprite = create_sprite(player);

    // Setting the coordinates in reference to the window
    sprite_set_x(player_sprite, 300);
    sprite_set_y(player_sprite, 300);

    // point 2d object to check weather the sprite is at that point
    
    point_2d target = point_at(300.00, 300.00);
    
    // set sprite's velocity so that it can reach at that point 
    //vector_2d vel = vector_to(0.01,0);
    


    // Game loop
    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_BLACK);
        //sprite_set_velocity(player_sprite, vel);
        draw_sprite(player_sprite);
        update_sprite(player_sprite);

        point_2d sprite_pos = sprite_position(player_sprite);
        write_line("sprite x: " + sprite_pos.x);
        std::string x_as_string = std::to_string(sprite_pos.x);
        //std::string y_as_string = std::to_string(sprite_pos.y);

        std::cout << " x pos" << x_as_string << std::endl;
        //std::cout << " y pos" << y_as_string << std::endl;

        bool val = sprite_at(player_sprite, target); 

        if (val == true)
        {
            draw_text("true", COLOR_WHITE, 300,100);
        }else 
        {
            draw_text("false", COLOR_WHITE, 300,100);
        }

        refresh_screen();

    }
    
    close_window(start);
    
    return 0;
}


// errors encountered, its on pause right now