#include "splashkit.h"

int main()
{
    open_window("Move Sprite To Example", 600, 600);

    bitmap player_bitmap = load_bitmap("player_bitmap", "player.png");
    sprite player_sprite = create_sprite(player_bitmap);

    sprite_set_position(player_sprite, point_at(100, 300));

    while (!quit_requested())
    {
        process_events();

        // Move the sprite toward the position clicked by the user.
        if (mouse_clicked(LEFT_BUTTON))
        {
            move_sprite_to(
                player_sprite,
                mouse_x(),
                mouse_y()
            );
        }

        update_sprite(player_sprite);

        clear_screen(COLOR_BLACK);

        draw_text(
            "Click anywhere to move the sprite",
            COLOR_WHITE,
            150,
            40
        );

        draw_sprite(player_sprite);

        refresh_screen(60);
    }

    free_sprite(player_sprite);
    free_bitmap(player_bitmap);

    return 0;
}