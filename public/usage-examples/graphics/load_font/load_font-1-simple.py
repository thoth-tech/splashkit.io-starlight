from splashkit import *

open_window("Load Font Example", 800, 600)

# Import font and draw text
my_font = load_font("my_font", "RobotoSlab.ttf")
draw_text("Hello, SplashKit!", color_black(), my_font, 40, 250, 270)
refresh_screen()

delay(5000)
close_all_windows()
