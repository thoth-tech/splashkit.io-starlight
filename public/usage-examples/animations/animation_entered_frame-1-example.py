from splashkit import *

open_window("Animation Entered Frame Example", 800, 600)

# Load animation script and create animation
script = load_animation_script("kermit", "kermit.txt")
anim = create_animation(script, "SplashKitOnlineDemo")

frame_enter_count = 0

while not quit_requested():
    process_events()

    clear_screen(color_white())

    # Display animation state
    draw_text_no_font_no_size("Animation Entered Frame Example", color_black(), 260, 100)
    draw_text_no_font_no_size(f"Current Cell: {animation_current_cell(anim)}", color_blue(), 300, 200)

    # Check if animation entered a new frame using animation_entered_frame
    if animation_entered_frame(anim):
        frame_enter_count += 1
        draw_text_no_font_no_size("Just entered NEW FRAME!", color_green(), 290, 280)
    else:
        draw_text_no_font_no_size("Same frame as before", color_gray(), 310, 280)

    draw_text_no_font_no_size(f"Frame Entry Count: {frame_enter_count}", color_purple(), 300, 340)

    # Display instructions
    draw_text_no_font_no_size("Press R to restart animation", color_orange(), 280, 450)
    draw_text_no_font_no_size("Press ESC to exit", color_gray(), 320, 500)

    if key_typed(KeyCode.r_key):
        restart_animation(anim)
        frame_enter_count = 0

    # Only update if animation hasn't ended
    if not animation_ended(anim):
        update_animation(anim)

    refresh_screen_with_target_fps(60)

# Free resources
free_animation(anim)
free_animation_script(script)

close_all_windows()
