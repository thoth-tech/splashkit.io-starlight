from splashkit import *

# Variable Declarations
bar_x = 100
slider = line_from(100, 300, 500, 300)
bar = line_from(bar_x, 310, bar_x, 290)
percent = 0
volume = "Volume: "

# Create window and draw initial lines
window = open_window("point on line", 600, 600)
clear_screen(color_white())

draw_line_record(color_black(), slider)
draw_line_record(color_black(), bar)
draw_text_no_font_no_size(volume + str(percent), color_black(), 200, 450)
refresh_screen()

while not quit_requested():
    process_events()

    # Check if user is holding click on the bar line
    while mouse_down(MouseButton.left_button) and point_on_line(mouse_position(), bar):
        clear_screen(color_white())
        bar_x = mouse_position().x  # sets bar_x value to mouse x value
        percent = ((bar_x - 100) / (500 - 100)) * 100  # convert bar_x position to percent value
        bar = line_from(bar_x, 310, bar_x, 290)
        
        # redraw lines and volume text
        draw_line_record(color_black(), bar)
        draw_line_record(color_black(), slider)
        draw_text_no_font_no_size(volume + str(percent), color_black(), 200, 450)
        refresh_screen()
        process_events()

close_window(window)
