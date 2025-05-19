#include "splashkit.h"

int main()
{
    open_window("Sprite Pack Simulation", 800, 600);

    // Load bitmaps for two characters
    bitmap gliese_bitmap = load_bitmap("gliese", "Gliese.png");
    bitmap aquarii_bitmap = load_bitmap("aquarii", "Aquarii.png");

    // Create sprites
    sprite gliese_sprite = create_sprite(gliese_bitmap);
    sprite aquarii_sprite = create_sprite(aquarii_bitmap);

    // Start both at the center
    sprite_set_x(gliese_sprite, 400);
    sprite_set_y(gliese_sprite, 300);
    sprite_set_x(aquarii_sprite, 400);
    sprite_set_y(aquarii_sprite, 300);

    // Active sprite flag (true = Gliese, false = Aquarii)
    bool use_gliese = true;

    while (!quit_requested())
    {
        process_events();

        // Switch control with keys
        if (key_typed(NUM_1_KEY)) use_gliese = true;
        if (key_typed(NUM_2_KEY)) use_gliese = false;

        // Move the active sprite (left/right arrows)
        if (use_gliese)
        {
            if (key_down(LEFT_KEY))  sprite_set_x(gliese_sprite, sprite_x(gliese_sprite) - 5);
            if (key_down(RIGHT_KEY)) sprite_set_x(gliese_sprite, sprite_x(gliese_sprite) + 5);
        }
        else
        {
            if (key_down(LEFT_KEY))  sprite_set_x(aquarii_sprite, sprite_x(aquarii_sprite) - 5);
            if (key_down(RIGHT_KEY)) sprite_set_x(aquarii_sprite, sprite_x(aquarii_sprite) + 5);
        }

        // Draw everything
        clear_screen(color_black());
        if (use_gliese)
        {
            draw_sprite(gliese_sprite);
            draw_text("Active: Gliese (Press 2 for Aquarii)", color_white(), 10, 10);
        }
        else
        {
            draw_sprite(aquarii_sprite);
            draw_text("Active: Aquarii (Press 1 for Gliese)", color_white(), 10, 10);
        }
        draw_text("Use LEFT/RIGHT arrows to move", color_white(), 10, 40);

        refresh_screen();
    }

    close_all_windows();
    return 0;
}