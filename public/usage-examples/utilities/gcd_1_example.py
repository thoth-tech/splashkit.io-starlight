from splashkit import *

# open a window with the same title and dimensions
open_window("Greatest Common Divisor Example", 640, 360)

# define two numbers
num_a = 48
num_b = 18

# use splashkit's gcd function
result = gcd(num_a, num_b)

# main loop
while not quit_requested():
    process_events()

    clear_screen(color_white())

    # heading text
    draw_text("Calculating the Greatest Common Divisor (GCD)", color_blue(), 60, 40)

    # numbers being used
    draw_text(f"Number A: {num_a}", color_black(), 80, 100)
    draw_text(f"Number B: {num_b}", color_black(), 80, 140)

    # result in red
    draw_text(f"GCD Result: {result}", color_red(), 80, 200)

    # exit instructions
    draw_text("Press ESC to exit", color_gray(), 420, 330)

    refresh_screen()

close_all_windows()
