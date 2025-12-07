from splashkit import *

open_window("Update Animation Example", 800, 600)

# Load animation script and create animation
script = load_animation_script("kermit", "kermit.txt")
anim = create_animation(script, "SplashKitOnlineDemo")

# Animation loop
while not quit_requested() and not animation_ended(anim):
    process_events()

    clear_screen(color_white())

    # Display current animation state
    draw_text_no_font_no_size("Update Animation Demo", color_black(), 300, 100)
    draw_text_no_font_no_size(f"Current Cell: {animation_current_cell(anim)}", color_blue(), 300, 200)
    draw_text_no_font_no_size(f"Frame Time: {animation_frame_time(anim)}", color_green(), 300, 250)
    draw_text_no_font_no_size(f"Animation Ended: {'Yes' if animation_ended(anim) else 'No'}", color_purple(), 300, 300)
    draw_text_no_font_no_size("Press ESC to exit", color_gray(), 320, 500)

    # Update the animation
    update_animation(anim)

    refresh_screen_with_target_fps(60)

# Free resources
free_animation(anim)
free_animation_script(script)

close_all_windows()
