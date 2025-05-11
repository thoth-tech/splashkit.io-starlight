from splashkit import *

open_window("Lines From Triangle", 400, 400)

#Create a triangle with three defined points
created_triangle = triangle_from(100, 100, 200, 80, 150, 200)


#Loop through each edge line of the triangle and draw it individually
for new_line in lines_from_triangle(created_triangle):
    clear_screen(ColorWhite)
    draw_line(ColorRed, new_line)
    refresh_screen()
    delay(800)

#Pause briefly at the end
delay(1000)
