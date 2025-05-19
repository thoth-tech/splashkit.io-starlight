from splashkit import *

open_window("Sprite Pack Simulation", 800, 600)

# Load the bitmaps for creating sprites
gliese = load_bitmap("gliese", "Gliese.png")
aquarii = load_bitmap("aquarii", "Aquarii.png")

# Create the sprites
gliese_sprite = create_sprite(gliese)
aquarii_sprite = create_sprite(aquarii)

# Set starting position (center)
sprite_set_x(gliese_sprite, 400)
sprite_set_y(gliese_sprite, 300)
sprite_set_x(aquarii_sprite, 400)
sprite_set_y(aquarii_sprite, 300)

# Active sprite flag (True = Gliese, False = Aquarii)
use_gliese = True

while not quit_requested():
    process_events()

    # Switch control with keys
    if key_typed(num_1_key()):
        use_gliese = True
    if key_typed(num_2_key()):
        use_gliese = False

    # Move the active sprite (left/right arrows)
    if use_gliese:
        if key_down(left_key()):
            sprite_set_x(gliese_sprite, sprite_x(gliese_sprite) - 5)
        if key_down(right_key()):
            sprite_set_x(gliese_sprite, sprite_x(gliese_sprite) + 5)
    else:
        if key_down(left_key()):
            sprite_set_x(aquarii_sprite, sprite_x(aquarii_sprite) - 5)
        if key_down(right_key()):
            sprite_set_x(aquarii_sprite, sprite_x(aquarii_sprite) + 5)

    clear_screen(color_black())
    if use_gliese:
        draw_sprite(gliese_sprite)
        draw_text("Active: Gliese (Press 2 for Aquarii)", color_white(), 10, 10)
    else:
        draw_sprite(aquarii_sprite)
        draw_text("Active: Aquarii (Press 1 for Gliese)", color_white(), 10, 10)
    draw_text("Use LEFT/RIGHT arrows to move", color_white(), 10, 40)

    refresh_screen()

close_all_windows()
