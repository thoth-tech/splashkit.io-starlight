from splashkit import *

open_window("Alpha Of", 800, 450)

alphas = [50, 100, 150, 200, 255]
rect_width = 120
rect_height = 200
start_x = 60
start_y = 140
gap = 20

clear_screen(color_white())

# Draw a background stripe so transparency is visible
fill_rectangle(color_light_blue(), 0, start_y, 800, rect_height)

draw_text_no_font_no_size("Transparency Layers", color_black(), 300, 55)
draw_text_no_font_no_size("Same colour at different alpha values (light blue shows through)", color_black(), 155, 80)

for i in range(5):
    c = rgba_color(200, 50, 50, alphas[i])
    x = start_x + i * (rect_width + gap)

    fill_rectangle(c, x, start_y, rect_width, rect_height)

    # Function used here ↓
    a = alpha_of(c)
    draw_text_no_font_no_size("Alpha: " + str(a), color_black(), x + 22, start_y + rect_height + 12)

refresh_screen()
delay(5000)

close_all_windows()
