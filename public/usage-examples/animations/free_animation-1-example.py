from splashkit import *

open_window("Free Animation Example", 800, 600)

# Load animation script
script = load_animation_script("kermit", "kermit.txt")

# Create animation
anim = create_animation(script, "SplashKitOnlineDemo")
animation_exists = True

while not quit_requested():
    process_events()

    clear_screen(color_white())

    # Display instructions
    draw_text_no_font_no_size("Free Animation Demo", color_black(), 300, 100)

    if animation_exists:
        draw_text_no_font_no_size(f"Current Cell: {animation_current_cell(anim)}", color_blue(), 300, 200)
        draw_text_no_font_no_size("Animation Status: Active", color_green(), 300, 250)
        draw_text_no_font_no_size("Press F to FREE the animation", color_orange(), 270, 400)

        update_animation(anim)
    else:
        draw_text_no_font_no_size("Animation Status: Freed", color_red(), 300, 250)
        draw_text_no_font_no_size("Press C to CREATE new animation", color_orange(), 260, 400)

    draw_text_no_font_no_size("Press ESC to exit", color_gray(), 320, 500)

    # Free animation when F is pressed
    if key_typed(KeyCode.f_key) and animation_exists:
        free_animation(anim)
        animation_exists = False

    # Create new animation when C is pressed
    if key_typed(KeyCode.c_key) and not animation_exists:
        anim = create_animation(script, "SplashKitOnlineDemo")
        animation_exists = True

    refresh_screen_with_target_fps(60)

# Final cleanup
if animation_exists:
    free_animation(anim)
free_animation_script(script)

close_all_windows()
