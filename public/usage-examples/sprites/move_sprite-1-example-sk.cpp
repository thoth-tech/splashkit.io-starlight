#include "splashkit.h"

int main()
{
    open_window("Ball Throw with Mouse", 800, 600);

    // Load the ball bitmap
    bitmap ball_bitmap = load_bitmap("ball", "ball_sprite.png");
    sprite ball = create_sprite(ball_bitmap);

    // Place the ball on the bottom left
    sprite_set_x(ball, 0);
    sprite_set_y(ball, 350);

    vector_2d velocity = vector_to(0, 0);

    while (!quit_requested())
    {
        process_events();

        // Throw the ball toward the mouse when clicked
        if (mouse_clicked(LEFT_BUTTON))
        {
            point_2d ball_pos = sprite_center_point(ball);
            point_2d target = mouse_position();
            vector_2d direction = unit_vector(vector_point_to_point(ball_pos, target));

            velocity = vector_multiply(direction, 8); // adjust throw strength
        }

        // Move the ball with current velocity
        move_sprite(ball, velocity);

        clear_screen(COLOR_WHITE);
        draw_sprite(ball);
        refresh_screen(60);
    }

    return 0;
}
