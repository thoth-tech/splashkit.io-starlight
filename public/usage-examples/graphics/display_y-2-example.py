from splashkit import *

# Load Font
font = load_font("font", "RobotoSlab.ttf")

# Set number of displays
disp_count = number_of_displays() 

# Array for storing display details
disp_store = []

# Create variables for offset
min_x = 0
min_y = 0

# Loop through displays collect details
for i in range(disp_count):

    # Set details for display
    disp_details = display_details(i)

    # Get coordinate info for display
    disp_x = display_x(disp_details)
    disp_y = display_y(disp_details)

    # Get resolution for display
    disp_width = display_width(disp_details)
    disp_height = display_height(disp_details)

    # Get name for display
    disp_name = display_name(disp_details)
    
    # Add details to display store
    disp_store.append([disp_x,disp_y,disp_width,disp_height,disp_name])

    # Set min coordinate offset for drawing
    if min_x > disp_x:
        min_x = disp_x 
    if min_y > disp_y:
        min_y = disp_y 

wind = open_window("Display Y", 800, 600)

for i, display in enumerate(disp_store):
    # Set Display Variables
    origin_x, origin_y, len_w, len_h, name = display

    # Create strings for display
    display_name_string = f"Name: {name}"
    display_num_string = f"Display Number: {i + 1}"
    display_coord_string = f"Display Coordinates: ({origin_x}, {origin_y})"

    # Refactor size and normalize for 300,300 origin in window
    origin_x = (origin_x - min_x + 300)/8
    origin_y = (origin_y - min_y + 400)/8
    len_w = len_w/8
    len_h = len_h/8
    
    # Draw Display setup to screen and label
    disp = rectangle_from(origin_x, origin_y, len_w, len_h)
    draw_rectangle_on_window_record(wind,color_black(),disp)
    draw_text_on_window(wind, display_name_string, color_black(), font, 10, origin_x + 5, origin_y + 5)
    draw_text_on_window(wind, display_num_string, color_black(), font, 10, origin_x + 5, origin_y + 20)
    draw_text_on_window(wind, display_coord_string, color_black(), font, 10, origin_x + 5, origin_y + 35)
    refresh_screen()

draw_text_on_window(wind, "Display Y value represents the vertical offset of a display,", color_black(), font, 16, 10, 10)
draw_text_on_window(wind, "where 0,0 is the top left corner of the main display.", color_black(), font, 16, 10, 30)
refresh_screen()
 
while not quit_requested():
    process_events()