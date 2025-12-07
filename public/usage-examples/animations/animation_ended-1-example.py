from splashkit import *

open_window("Animation Ended Example", 800, 600)

# Load animation script and create animation
script = load_animation_script("kermit", "kermit.txt")
anim = create_animation(script, "SplashKitOnlineDemo")

while not quit_requested():
    process_events()

    clear_screen(color_white())

    # Display animation state
    draw_text_no_font_no_size("Animation Ended Example", color_black(), 280, 100)
    draw_text_no_font_no_size(f"Current Cell: {animation_current_cell(anim)}", color_blue(), 300, 200)

    # Check if animation has ended using animation_ended
    if animation_ended(anim):
        draw_text_no_font_no_size("Animation Status: ENDED", color_red(), 300, 250)
        draw_text_no_font_no_size("Press R to restart", color_orange(), 310, 350)

        if key_typed(KeyCode.r_key):
            restart_animation(anim)
    else:
        draw_text_no_font_no_size("Animation Status: RUNNING", color_green(), 300, 250)
        update_animation(anim)

    draw_text_no_font_no_size("Press ESC to exit", color_gray(), 320, 500)

    refresh_screen_with_target_fps(60)

# Free resources
free_animation(anim)
free_animation_script(script)

close_all_windows()
