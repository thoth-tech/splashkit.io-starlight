from splashkit import *

# Open and store the window object
window = open_window("Line Intersects Rect", 800, 600)

# Define draggable line endpoints
start_pt = point_at(100, 100)
end_pt = point_at(700, 500)

# Define a static rectangle
rect = rectangle_from(300, 200, 200, 150)

while not window_close_requested(window):
    process_events()

    # Drag line endpoints if mouse is down
    if mouse_down(MouseButton.left_button):
        if point_in_circle(mouse_position(), circle_at(start_pt, 10)):
            start_pt = mouse_position()
        elif point_in_circle(mouse_position(), circle_at(end_pt, 10)):
            end_pt = mouse_position()

    # Update the line using current point positions
    l = line_from(start_pt.x, start_pt.y, end_pt.x, end_pt.y)

    # Check for intersection with rectangle
    intersects = line_intersects_rect(l, rect)

    clear_screen(color_white())

    # Draw rectangle
    draw_rectangle(color_blue(),300,200,200,150)

    # Draw the line
    draw_line(color_black(),start_pt.x, start_pt.y, end_pt.x, end_pt.y )

    # Draw draggable endpoints
    draw_circle(color_green(), start_pt.x, start_pt.y, 5)
    draw_circle(color_green(), end_pt.x, end_pt.y, 5)

    # Show message if intersecting
    if intersects:
        draw_text("Intersecting", color_red(), "arial", 20, 10, 10)

    refresh_screen()
