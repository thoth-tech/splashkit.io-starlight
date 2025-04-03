from splashkit import *

# Open window
window = open_window("Basic Line Drawing", 300, 300)
# Initialise start and end points for line
start = point_at_origin()
end = point_at_origin()

while not window_close_requested(window):
    process_events()
    # Get start point from cursor on left click and end point on right click
    if mouse_clicked(MouseButton.left_button):
        start = mouse_position()
    elif mouse_clicked(MouseButton.right_button):
        end = mouse_position()
    # Create a line between the points
    line = line_from_point_to_point(start, end)
    # Draw the line in red
    clear_screen_to_white()
    draw_line_record(color_red(), line)
    refresh_screen()

close_all_windows()