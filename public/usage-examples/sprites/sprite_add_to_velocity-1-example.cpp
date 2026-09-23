#include "splashkit.h"

int main()
{
    open_window("Sprite Add To Velocity Example", 400, 300);

    // Create a small bitmap and draw a circle onto it to act as our sprite
    bitmap ball_bitmap = create_bitmap("BallBitmap", 30, 30);
    fill_circle_on_bitmap(ball_bitmap, COLOR_RED, 15, 15, 15);

    // Create the sprite using the bitmap, starting at the center of the window
    sprite ball = create_sprite(ball_bitmap);
    sprite_set_position(ball, point_at(185, 135));

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);

        // Add a small amount of velocity in the direction of whichever arrow key is held
        if (key_down(UP_KEY))
        {
            sprite_add_to_velocity(ball, vector_to(0, -0.05));
        }
        if (key_down(DOWN_KEY))
        {
            sprite_add_to_velocity(ball, vector_to(0, 0.05));
        }
        if (key_down(LEFT_KEY))
        {
            sprite_add_to_velocity(ball, vector_to(-0.05, 0));
        }
        if (key_down(RIGHT_KEY))
        {
            sprite_add_to_velocity(ball, vector_to(0.05, 0));
        }

        update_sprite(ball);
        draw_sprite(ball);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}