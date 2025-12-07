from splashkit import *

open_window("Restart Animation Example", 800, 600)

# Load animation script and create animation
script = load_animation_script("kermit", "kermit.txt")
anim = create_animation(script, "SplashKitOnlineDemo")

restart_count = 0

while not quit_requested():
    process_events()

    clear_screen(color_white())

    # Display animation state
    draw_text_no_font_no_size("Restart Animation Demo", color_black(), 300, 100)
    draw_text_no_font_no_size(f"Current Cell: {animation_current_cell(anim)}", color_blue(), 300, 200)
    draw_text_no_font_no_size(f"Restart Count: {restart_count}", color_green(), 300, 250)
    draw_text_no_font_no_size(f"Animation Ended: {'Yes' if animation_ended(anim) else 'No'}", color_purple(), 300, 300)
    draw_text_no_font_no_size("Press SPACE to restart animation", color_orange(), 250, 400)
    draw_text_no_font_no_size("Press ESC to exit", color_gray(), 320, 500)

    # Restart animation when space is pressed
    if key_typed(KeyCode.space_key):
        restart_animation(anim)
        restart_count += 1

    update_animation(anim)
    refresh_screen_with_target_fps(60)

# Free resources
free_animation(anim)
free_animation_script(script)

close_all_windows()
