#include "splashkit.h"

int main()
{
    open_window("Move the Sprite into the Triangle", 800, 600);

    // Create a visible bitmap and prepare its pixels for collision testing
    bitmap sprite_bitmap = create_bitmap("blue square", 40, 40);
    clear_bitmap(sprite_bitmap, COLOR_BLUE);
    setup_collision_mask(sprite_bitmap);
    sprite test_sprite = create_sprite(sprite_bitmap);

    triangle collision_area = triangle_from(400, 120, 650, 500, 150, 500);
    point_2d mouse_location;
    string status_text;
    color triangle_color;

    while (!quit_requested())
    {
        process_events();

        // Let the user test the triangle area by moving the sprite
        mouse_location = mouse_position();
        sprite_set_position(test_sprite, mouse_location);

        if (sprite_triangle_collision(test_sprite, collision_area))
        {
            triangle_color = COLOR_GREEN;
            status_text = "Collision detected!";
        }
        else
        {
            triangle_color = COLOR_RED;
            status_text = "No collision detected.";
        }

        clear_screen(COLOR_WHITE);
        fill_triangle(triangle_color, collision_area);
        draw_sprite(test_sprite);
        draw_text("Move the blue sprite into the triangle", COLOR_BLACK, 20, 20);
        draw_text(status_text, COLOR_BLACK, 20, 50);
        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}
