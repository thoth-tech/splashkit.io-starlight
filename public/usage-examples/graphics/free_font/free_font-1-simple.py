from splashkit import *

# Load first font
wnd = open_window("Font Styles", 600, 500)
clear_screen_to_white()

# Draw text with font
font1 =  load_font("BebasNeue", "BebasNeue.ttf")

draw_text_on_window(wnd, "This font is called Bebas Neue", color_black(), font1, 30, 150, 210)
draw_text_on_window(wnd, "The font style is Regular 400", color_black(), font1, 30, 150, 240)
refresh_screen()

delay(3000)

# Free font1
free_font(font1)

# Clear Screen 
clear_screen_to_white()

# Load second font
font2 = load_font("NunitoSans", "NunitoSans.ttf")

# Draw text with font
draw_text_on_window(wnd, "This font is called Nunito Sans", color_black(), font2, 30, 120, 210)
draw_text_on_window(wnd, "The font style is Extra Light 200", color_black(), font2, 30, 120, 240)
refresh_screen()

delay(3000)

# Free font2
free_font(font2)

# Close window
close_all_windows()
