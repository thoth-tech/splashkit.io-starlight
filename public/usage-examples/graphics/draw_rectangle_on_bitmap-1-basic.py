from splashkit import *

open_window("Draw Rectangle On Bitmap", 800, 600)

# Load a font (required for draw_text in this binding)
font = load_font("arial", "arial.ttf")

# Create a bitmap that will act as a drawing canvas
canvas = create_bitmap("canvas", 500, 300)

# Fill the bitmap so it stands out from the window background
clear_bitmap(canvas, color_white())

# Draw rectangles onto the bitmap
draw_rectangle_on_bitmap(canvas, color_red(), 20, 20, 120, 80)
draw_rectangle_on_bitmap(canvas, color_blue(), 170, 50, 150, 100)
draw_rectangle_on_bitmap(canvas, color_green(), 360, 30, 100, 200)

while not quit_requested():
    process_events()
    clear_screen(color_light_gray())

    # Explain what the example is showing
    draw_text(
        "These rectangles were drawn onto a bitmap first.",
        color_black(),
        font,
        20,
        20,
        20
    )
    draw_text(
        "The bitmap is then drawn to the window.",
        color_black(),
        font,
        20,
        20,
        50
    )

    # Display the bitmap on the screen
    draw_bitmap(canvas, 150, 180)

    refresh_screen_with_target_fps(60)

close_all_windows()