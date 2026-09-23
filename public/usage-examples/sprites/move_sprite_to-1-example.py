from splashkit import *

open_window("Move Sprite To Example", 600, 600)

player_bitmap = load_bitmap("player_bitmap", "player.png")
player_sprite = create_sprite(player_bitmap)

sprite_set_position(player_sprite, point_at(100, 300))

while not quit_requested():
    process_events()

    # Move the sprite toward the position clicked by the user.
    if mouse_clicked(MouseButton.left_button):
        move_sprite_to(
            player_sprite,
            mouse_x(),
            mouse_y()
        )

    update_sprite(player_sprite)

    clear_screen(color_black())

    draw_text_no_font_no_size(
        "Click anywhere to move the sprite",
        color_white(),
        150,
        40
    )

    draw_sprite(player_sprite)

    refresh_screen_with_target_fps(60)

free_sprite(player_sprite)
free_bitmap(player_bitmap)

close_all_windows()