#include "splashkit.h"

// Global sprite and tracking info
sprite current_sprite;
string loaded_sprite = "";

// Load sprite from image
void load_sprite(const string &sprite_id, const string &filename)
{
    // If this sprite is not already loaded, create it
    if (loaded_sprite != sprite_id)
    {
        free_all_sprites(); // Remove previous sprite

        // Load the bitmap if not already loaded
        if (!has_bitmap(sprite_id))
        {
            load_bitmap(sprite_id, filename);
        }

        // Create a sprite from the bitmap
        current_sprite = create_sprite(bitmap_named(sprite_id));
        loaded_sprite = sprite_id;

        // Center the sprite
        sprite_set_position(current_sprite, point_at(400, 300));
    }
}

// Handle keyboard input for movement and switching
void handle_input()
{
    vector_2d velocity = vector_to(0, 0);

    if (key_down(UP_KEY))    velocity.y = -3;
    if (key_down(DOWN_KEY))  velocity.y = 3;
    if (key_down(LEFT_KEY))  velocity.x = -3;
    if (key_down(RIGHT_KEY)) velocity.x = 3;

    sprite_set_velocity(current_sprite, velocity);

    // Switch to player1.png
    if (key_typed(NUM_1_KEY))
    {
        load_sprite("player1", "player1.png");
    }

    // Switch to player2.png
    if (key_typed(NUM_2_KEY))
    {
        load_sprite("player2", "player2.png");
    }
}

int main()
{
    window game_window = open_window("Sprite Switcher", 800, 600);

    // Load the default sprite
    load_sprite("player1", "player1.png");

    while (!window_close_requested(game_window))
    {
        process_events();
        handle_input();

        update_sprite(current_sprite);
        move_sprite(current_sprite);

        clear_screen(COLOR_WHITE);
        draw_sprite(current_sprite);
        draw_text("Use arrow keys to move. Press 1 or 2 to switch characters..", COLOR_BLACK, 10, 10);
        refresh_screen(60);
    }

    return 0;
}
