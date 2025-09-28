from splashkit import *

open_window("Font Named", 800, 600)

font = None
rectangle = rectangle_from(100, 200, 150, 30)

while not quit_requested():
    process_events()
    
    if reading_text() == 0:
        start_reading_text(rectangle)
        
    # User's string input is converted to a font variable via the font_named function
    # In this example, the .tff extension is automatically applied to the string for better usability
    # Alagard.ttf, Century.ttf and RobotoSlab.ttf as part of the program resources
    font = font_named(text_input() + ".ttf")
   
    clear_screen_to_white()

    draw_text("Please input the name of the font you would like to use:", color_black(), font, 15, 100, 60)
    draw_text("- Alagard", color_black(), font, 15, 100, 90)
    draw_text("- Century", color_black(), font, 15, 100, 120)
    draw_text("- RobotoSlab", color_black(), font, 15, 100, 150)
    draw_rectangle(color_black(), 100, 200, 150, 30)
    draw_text(text_input(), color_black(), font, 15, 105, 205)
    refresh_screen()

close_all_windows()