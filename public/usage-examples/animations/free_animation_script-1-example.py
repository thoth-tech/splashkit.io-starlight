from splashkit import *

open_window("Free Animation Script Example", 800, 600)

# Load animation script
script = load_animation_script("kermit", "kermit.txt")
script_loaded = True

anim = create_animation(script, "SplashKitOnlineDemo")
animation_exists = True

while not quit_requested():
    process_events()

    clear_screen(color_white())

    # Display instructions
    draw_text_no_font_no_size("Free Animation Script Demo", color_black(), 280, 100)

    if script_loaded:
        draw_text_no_font_no_size("Script Status: LOADED", color_green(), 300, 200)

        if animation_exists:
            draw_text_no_font_no_size(f"Animation Cell: {animation_current_cell(anim)}", color_blue(), 300, 250)
            update_animation(anim)

        draw_text_no_font_no_size("Press F to free animation script", color_orange(), 260, 400)
        draw_text_no_font_no_size("(Will also free the animation)", color_gray(), 280, 430)

        if key_typed(KeyCode.f_key):
            # First free the animation that uses this script
            if animation_exists:
                free_animation(anim)
                animation_exists = False
            # Then free the animation script
            free_animation_script(script)
            script_loaded = False
    else:
        draw_text_no_font_no_size("Script Status: FREED", color_red(), 300, 200)
        draw_text_no_font_no_size("Press L to load new script", color_orange(), 280, 400)

        if key_typed(KeyCode.l_key):
            script = load_animation_script("kermit", "kermit.txt")
            script_loaded = True
            anim = create_animation(script, "SplashKitOnlineDemo")
            animation_exists = True

    draw_text_no_font_no_size("Press ESC to exit", color_gray(), 320, 500)

    refresh_screen_with_target_fps(60)

# Final cleanup
if animation_exists:
    free_animation(anim)
if script_loaded:
    free_animation_script(script)

close_all_windows()
