import random
from splashkit import *

open_window("Random Window Width", random.randint(275, 800), 100)

clear_screen(color_white())
draw_text_no_font_no_size(f"This window is {current_window_width()} pixels wide", color_black(), 20, 20)

refresh_screen()

delay(5000)

close_all_windows()