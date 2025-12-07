from splashkit import *

open_window("Load Animation Script", 800, 600)

# Load an animation script from file
kermit_script = load_animation_script("kermit", "kermit.txt")

# Check if the script was loaded successfully
if has_animation_script("kermit"):
    clear_screen(color_white())
    draw_text_no_font_no_size("Animation Script Loaded Successfully!", color_green(), 250, 280)
    draw_text_no_font_no_size("Script Name: kermit", color_black(), 300, 320)
    draw_text_no_font_no_size(f"Animation Count: {animation_count(kermit_script)}", color_blue(), 280, 360)
    refresh_screen()

delay(5000)

# Free the animation script when done
free_animation_script(kermit_script)

close_all_windows()
