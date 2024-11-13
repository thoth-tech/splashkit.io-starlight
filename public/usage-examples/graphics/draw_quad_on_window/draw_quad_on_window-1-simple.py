from splashkit import *

# Initialise quad coords
q1_corners = ([400,200],[300, 300],[300,0],[200,200])
q2_corners = ([400,210],[310, 300],[600,300],[400,390])
q3_corners = ([200,400],[300, 300],[300,600],[400,400])
q4_corners = ([200,390],[290, 300],[0,300],[200,210])

q1 = Quad()
q2 = Quad()
q3 = Quad()
q4 = Quad()

# set coords
for i in range(4):
    q1._points[i] = point_at(q1_corners[i][0],q1_corners[i][1])
    q2._points[i] = point_at(q2_corners[i][0],q2_corners[i][1])
    q3._points[i] = point_at(q3_corners[i][0],q3_corners[i][1])
    q4._points[i] = point_at(q4_corners[i][0],q4_corners[i][1])
    

# Create Window

window1 = open_window("Draw Quad", 600, 600)
window2 = open_window("Draw Quad", 600, 600)
clear_screen(color_white())


draw_quad_on_window(window1, color_black(), q1)
draw_quad_on_window(window1, color_green(), q2)
draw_quad_on_window(window2, color_red(), q3)
draw_quad_on_window(window2, color_blue(), q4)

refresh_screen()
delay(5000)
close_all_windows()