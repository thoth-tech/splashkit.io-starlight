#include "splashkit.h"

int main()
{
    open_window("Sprite Circle Collision", 540, 380);

    bitmap sprite_bitmap = load_bitmap("player", "skbox.png");

    sprite player = create_sprite(sprite_bitmap);
    sprite_set_position(player, point_at(70, 90));

    circle collision_circle = circle_at(120, 140, 70);
    circle clear_circle = circle_at(460, 290, 40);

    clear_screen(COLOR_WHITE);

    fill_circle(COLOR_GREEN, collision_circle);
    fill_circle(COLOR_RED, clear_circle);
    draw_sprite(player);

    draw_text("Green circle: collision area", COLOR_BLACK, 20, 20);
    draw_text("Red circle: no collision", COLOR_BLACK, 20, 45);

    bool green_collision = sprite_circle_collision(player, collision_circle);
    bool red_collision = sprite_circle_collision(player, clear_circle);

    if (green_collision)
    {
        write_line("Green Circle Collision");
        draw_text("Collision detected", COLOR_DARK_GREEN, 20, 335);
    }

    if (!red_collision)
    {
        write_line("No Red Circle Collision");
    }

    refresh_screen();
    delay(4000);

    free_sprite(player);
    free_bitmap(sprite_bitmap);
    close_all_windows();

    return 0;
}
