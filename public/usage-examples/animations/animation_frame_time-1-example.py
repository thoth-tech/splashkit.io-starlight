from splashkit import *

open_window("Animation Frame Time Example", 800, 600)

# Load animation script and create animation
script = load_animation_script("kermit", "kermit.txt")
anim = create_animation(script, "SplashKitOnlineDemo")

while not quit_requested():
    process_events()

    clear_screen(color_white())

    # Display animation frame time
    draw_text_no_font_no_size("Animation Frame Time Example", color_black(), 270, 100)
    draw_text_no_font_no_size(f"Current Cell: {animation_current_cell(anim)}", color_blue(), 300, 200)

    # Get and display frame time using animation_frame_time
    frame_time = animation_frame_time(anim)
    draw_text_no_font_no_size(f"Frame Time: {frame_time} ms", color_green(), 300, 250)

    # Display instructions
    draw_text_no_font_no_size("Frame time shows how long this frame lasts", color_purple(), 230, 350)
    draw_text_no_font_no_size("Press R to restart animation", color_orange(), 280, 450)
    draw_text_no_font_no_size("Press ESC to exit", color_gray(), 320, 500)

    if key_typed(KeyCode.r_key):
        restart_animation(anim)

    # Only update if animation hasn't ended
    if not animation_ended(anim):
        update_animation(anim)

    refresh_screen_with_target_fps(60)

# Free resources
free_animation(anim)
free_animation_script(script)

close_all_windows()
