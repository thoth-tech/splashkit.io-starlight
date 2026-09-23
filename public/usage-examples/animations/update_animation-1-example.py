from splashkit import *

open_window("Color Cycle Animation", 400, 400)

# Build a 4-frame sprite sheet in memory (each cell is 64x64)
sheet = create_bitmap("sheet", 256, 64)
fill_rectangle_on_bitmap(sheet, color_red(), 0, 0, 64, 64)
fill_rectangle_on_bitmap(sheet, color_green(), 64, 0, 64, 64)
fill_rectangle_on_bitmap(sheet, color_blue(), 128, 0, 64, 64)
fill_rectangle_on_bitmap(sheet, color_yellow(), 192, 0, 64, 64)
bitmap_set_cell_details(sheet, 64, 64, 4, 1, 4)

# Load the animation script and create the animation
script = load_animation_script("color_cycle", "color_cycle.txt")
anim = create_animation(script, "ColorCycle")

while not quit_requested():
    process_events()
    clear_screen_to_white()

    # Draw the current animation frame centered on the window
    draw_bitmap_with_options(sheet, 168, 168, option_with_animation(anim))

    # Advance the animation to the next frame
    update_animation(anim)

    refresh_screen_with_target_fps(60)

# Release resources
free_animation(anim)
free_animation_script(script)
close_all_windows()
