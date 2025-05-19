from splashkit import *

open_window("Lines From Triangle", 400, 400)

#Define the three corner points
p1 = point_at(100, 100)
p2 = point_at(200,  80)
p3 = point_at(150, 200)

#touch circle radius
R = 10

while not quit_requested():
    process_events()
    clear_screen(color_white())

    #Mouse coords
    mx, my = mouse_x(), mouse_y()

    #List of edges as point-pairs
    edges = [(p1, p2), (p2, p3), (p3, p1)]

    for idx, (a, b) in enumerate(edges):
        x1, y1 = a.x, a.y
        x2, y2 = b.x, b.y

        #A simple “touch zone” around the line plus radius
        left,  right  = min(x1, x2) - R, max(x1, x2) + R
        top,   bottom = min(y1, y2) - R, max(y1, y2) + R

        overlap      = (left <= mx <= right) and (top <= my <= bottom)

        #highlight colour blue if overlap or not in red
        col = color_blue() if overlap else color_red()
        draw_line(col, x1, y1, x2, y2)

        #Draw the index at the midpoint
        mid_x, mid_y = (x1 + x2) * 0.5, (y1 + y2) * 0.5
        draw_text_no_font_no_size(str(idx), color_black(), mid_x, mid_y)

    #Draw a little circle around the mouse
    draw_circle(color_green(), mx, my, R)

    refresh_screen()

close_all_windows()



