from splashkit import *

def blend_colors(c1, c2, t):
    # linear interpolation for RGB channels
    r = int((1 - t) * red_of(c1) + t * red_of(c2))
    g = int((1 - t) * green_of(c1) + t * green_of(c2))
    b = int((1 - t) * blue_of(c1) + t * blue_of(c2))
    return rgb_color(r, g, b)

open_window("Split Text Example", 800, 400)

# I am defining the text to split
text = "apple,banana,carrot"

# I am splitting the string into parts using SplashKit's split() function
parts = split(text, ',')

# I am drawing a gradient background manually
top = rgb_color(245, 251, 255)
bottom = rgb_color(200, 230, 255)

for y in range(400):
    t = y / 400
    blended = blend_colors(top, bottom, t)
    draw_line(blended, 0, y, 800, y)

draw_text("Original string:", color_dark_blue(), "arial", 20, 60, 50)
draw_text(text, color_black(), "arial", 20, 280, 50)

# I am printing each token from the split result
y = 130
for s in parts:
    draw_text("Token: " + s, color_black(), "arial", 18, 60, y)
    y += 40

draw_text("Press ESC to exit", color_gray(), "arial", 14, 620, 360)
refresh_screen()

# wait for quit event
while not quit_requested():
    process_events()
    if key_typed(KeyCode.escape_key):
        break

close_all_windows()