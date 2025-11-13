from splashkit import *

open_window("Load Font Example", 800, 600)

my_font = load_font("my_font", "RobotoSlab.ttf")

# Set font style to bold
set_font_style(my_font, FontStyle.bold_font)
draw_text("Hello, SplashKit!", color_black(), my_font, 40, 250, 270)
refresh_screen()

delay(5000)
close_all_windows()
