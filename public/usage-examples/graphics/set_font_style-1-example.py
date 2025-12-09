from splashkit import *

open_window("Choose Your Font", 800, 600)

# Different fonts can be added to the fonts folder and used below ↓
font = font_named("Century.ttf")
rectangle = rectangle_from(100, 200, 150, 30)

while not quit_requested():
    process_events()
    
    if reading_text() == 0:
        start_reading_text(rectangle)
        
    # Function used here ↓
    if text_input() == "1":
        set_font_style(font, FontStyle.bold_font)
    elif text_input() == "2":
        set_font_style(font, FontStyle.italic_font)
    elif text_input() == "3":
        set_font_style(font, FontStyle.underline_font)
    else:
        set_font_style(font, FontStyle.normal_font)
    
    clear_screen_to_white()
    draw_text("Please select your desired font style (type numbers 1-3):", color_black(), font, 15, 100, 60)
    draw_text("1 - Bold", color_black(), font, 15, 100, 90)
    draw_text("2 - Italic", color_black(), font, 15, 100, 120)
    draw_text("3 - Underline", color_black(), font, 15, 100, 150)
    draw_rectangle(color_black(), 100, 200, 150, 30)
    draw_text_no_font_no_size(text_input(), color_black(), 110, 210)
    refresh_screen()

close_all_windows()