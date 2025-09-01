from splashkit import *

# open a window
wind = open_window("Colour Changer", 600, 200)

# main loop
while not quit_requested():
    # get user events
    process_events()
    
    # clear screen
    clear_window(wind, color_white())
    
    if button_at_position("Red!", rectangle_from(75, 85, 100, 30)):
        clear_window(wind, color_red())
        refresh_window(wind)
        delay(1000)
        continue
    
    if button_at_position("Green!", rectangle_from(250, 85, 100, 30)):
        clear_window(wind, color_green())
        refresh_window(wind)
        delay(1000)
        continue
    
    if button_at_position("Blue!", rectangle_from(425, 85, 100, 30)):
        clear_window(wind, color_blue())
        refresh_window(wind)
        delay(1000)
        continue
    
    # finally draw interface, then refresh screen
    draw_interface()
    refresh_window(wind)

# close all open windows
close_all_windows()