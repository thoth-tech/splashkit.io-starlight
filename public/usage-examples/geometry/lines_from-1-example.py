from splashkit import *

def draw_edge(edge, color):
    draw_line(color,
              edge.start_point.x, edge.start_point.y,
              edge.end_point.x, edge.end_point.y)

def main():
    window = open_window("Interactive Rectangle Edges", 800, 600)

    normal_colors = [
        color_red(),
        color_lime_green(),
        color_blue(),
        color_orange()
    ]

    hover_colors = [color_white()] * 4

    while not window_close_requested(window):
        process_events()
        clear_screen(color_dark_slate_gray())

        # Rectangle dimensions
        x = (800 - 300) / 2
        y = (600 - 200) / 2
        w = 300
        h = 200

        # Draw filled rectangle
        fill_rectangle(color_black(), x, y, w, h)

        # Create 4 edges manually using coordinates(LinesFrom function)
        top_edge    = line_from(x, y, x + w, y)
        right_edge  = line_from(x + w, y, x + w, y + h)
        bottom_edge = line_from(x + w, y + h, x, y + h)
        left_edge   = line_from(x, y + h, x, y)

        sorted_edges = [top_edge, right_edge, bottom_edge, left_edge]

        mouse = mouse_position()

        for i in range(4):
            edge = sorted_edges[i]
            is_hovered = point_on_line(mouse, edge)
            color = hover_colors[i] if is_hovered else normal_colors[i]
            draw_edge(edge, color)

        refresh_screen_with_target_fps(60)

    close_window(window)

main()