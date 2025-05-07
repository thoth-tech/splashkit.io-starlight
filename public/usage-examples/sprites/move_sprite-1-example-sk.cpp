#include "splashkit.h"

int main()
{
    // Open the main game window
    open_window("2D Player movement", 800, 600);

    // Load the player bitmap from file
    bitmap player_bitmap = load_bitmap("player", "player_sprite.png");

    // Create a sprite for the player
    sprite player_sprite = create_sprite(player_bitmap);

    // Position the sprite in the center of the window
    sprite_set_x(player_sprite, 400);
    sprite_set_y(player_sprite, 300);

    while (!quit_requested())
    {
        process_events();

        // Move the sprite based on key input
        vector_2d movement_vector = vector_to(0, 0);

        if (key_down(W_KEY))
        {
            movement_vector.y -= 5;
        }
        if (key_down(S_KEY))
        {
            movement_vector.y += 5;
        }
        if (key_down(A_KEY))
        {
            movement_vector.x -= 5;
        }
        if (key_down(D_KEY))
        {
            movement_vector.x += 5;
        }

        move_sprite(player_sprite, movement_vector);

        clear_screen(COLOR_WHITE);
        draw_sprite(player_sprite);
        refresh_screen(60);
    }

    return 0;
}
