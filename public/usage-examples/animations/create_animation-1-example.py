from splashkit import *

open_window("Create Animation Example", 800, 600)

# Load the animation script
script = load_animation_script("kermit", "kermit.txt")

# Create an animation from the script
anim = create_animation(script, "SplashKitOnlineDemo")

# Display animation information
clear_screen(color_white())
draw_text_no_font_no_size("Animation Created Successfully!", color_green(), 280, 200)
draw_text_no_font_no_size("Animation Name: SplashKitOnlineDemo", color_black(), 260, 250)
draw_text_no_font_no_size(f"Current Cell: {animation_current_cell(anim)}", color_blue(), 300, 300)
draw_text_no_font_no_size(f"Animation Ended: {'Yes' if animation_ended(anim) else 'No'}", color_purple(), 300, 350)
draw_text_no_font_no_size(f"Frame Time: {animation_frame_time(anim)}", color_orange(), 300, 400)
refresh_screen()

delay(5000)

# Free resources
free_animation(anim)
free_animation_script(script)

close_all_windows()
