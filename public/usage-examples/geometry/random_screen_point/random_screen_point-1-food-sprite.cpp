#include "splashkit.h"

int main()
{
    // Create Window
    open_window("Food Generator", 600, 600);
    
    load_bitmap("food", "food.png");
    sprite food_sprite = create_sprite(bitmap_named("food"));

    // Set random food location
    sprite_set_position(food_sprite, random_screen_point());

    clear_screen(color_black());

    // Draw the sprite
    draw_sprite(food_sprite);

    refresh_screen();
    delay(5000);
    close_all_windows();

    return 0;
}
