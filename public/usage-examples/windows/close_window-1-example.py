from splashkit import *

# open a window
window = open_window("Close Window Example", 400, 200)

countdown_started = False
countdown = 5
countdown_timer = create_timer("countdown")

# main loop
while not window_close_requested(window):
    # get user events
    process_events()
    
    # clear screen
    clear_window(window, color_white())
    
    if not countdown_started:
        # Show the button before countdown starts
        if button_at_position("Click Me!", rectangle_from(150, 85, 100, 30)):
            countdown_started = True
            start_timer(countdown_timer)
    else:
        # Display countdown
        draw_text_font_as_string(f"This window will close in {countdown}", color_black(), "arial", 18, 50, 85)
        
        # Check if 1 second has passed
        if timer_ticks(countdown_timer) > 1000:
            countdown -= 1
            reset_timer(countdown_timer)
            
            if countdown <= 0:
                close_window(window)
                break
    
    # draw interface and refresh
    draw_interface()
    refresh_screen()

# close all open windows
close_all_windows()