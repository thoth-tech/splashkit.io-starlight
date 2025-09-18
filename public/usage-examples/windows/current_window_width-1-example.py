import random
from splashkit import *

random_number = rnd_range(275, 800)

open_window("Random Window Width", random_number, 100)

clear_screen(color_white())
draw_text_no_font_no_size(f"This window is {current_window_width()} pixels wide", color_black(), 20, 20)

refresh_screen()

delay(5000)

close_all_windows()