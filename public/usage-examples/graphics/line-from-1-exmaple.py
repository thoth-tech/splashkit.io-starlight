from splashkit import *

def draw_edge(edge, color):
    draw_line(color,
              edge.start_point.x, edge.start_point.y,
              edge.end_point.x, edge.end_point.y)

def main():
    window = open_window("Lines From Rectangle Example", 800, 600)

    # Colors
    normal_colors = [color_red(), color_lime_green(), color_blue(), color_orange()]
    hover_colors = [color_white(), color_white(), color_white(), color_white()]

    # Center the rectangle
    rect_x = (800 - 300) / 2
    rect_y = (600 - 200) / 2
    my_rect = rectangle_from(rect_x, rect_y, 300, 200)

    while not window_close_requested(window):
        process_events()
        clear_screen(color_dark_slate_gray())

        # Draw rectangle background
        fill_rectangle(color_black(), my_rect.x, my_rect.y, my_rect.width, my_rect.height)

        # Get edges and mouse position
        edges = lines_from_rectangle(my_rect)
        mouse = mouse_position()

        for i in range(4):
            if point_on_line(mouse, edges[i]):
                draw_edge(edges[i], hover_colors[i])
            else:
                draw_edge(edges[i], normal_colors[i])

        refresh_screen()

    close_window(window)

main()