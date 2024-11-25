from splashkit import *

# Open a new window
wnd = open_window("Line Game", 800, 600)

# Define start and end points of line
pnt1 = point_at(0, 400)
pnt2 = point_at(800, 400)

# Create a line 
lne = line_from_point_to_point(pnt1, pnt2)
clear_screen_to_white()

# Draw the line to make it visible
draw_line_on_window_record(wnd, color_black(), lne)

# Draw circles to indicate start and finish
fill_circle_on_window(wnd, color_green(), 15, 400, 3)
fill_circle_on_window(wnd, color_red(), 785, 400, 3)

# Load font and draw instructions text 
font1 = load_font("NunitoSans", "NunitoSans.ttf")
draw_text_on_window(wnd, "Put your cursor on the line and move from the green to red dot without straying from the line", color_black(), font1, 14,120, 200)
refresh_screen()
delay(3000) # Wait 3 seconds

# While window is open 
while not quit_requested():
    process_events()

    # Define user's mouse position 
    user = mouse_position()

    # Get distance between cursor and line 
    distance = point_line_distance(user, lne)

    #  Print to terminal
    write_line_double(distance)
    delay(300)

    # If distance is 3 or more 
    if distance >= 3:
        write_line("Game Over")
        # Break loop 
        break 

# Close all opened windows 
free_font(font1)
close_all_windows()