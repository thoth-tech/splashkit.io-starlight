from splashkit import *

open_window("Point At", 800, 600)
clear_screen(color_white())


for i in range(30):

    x1 = rnd_range(0,800)
    y1 = rnd_range(0,600)
    
    # Create a point at position (x1, y1)
    point = point_at(x1, y1)

    random_color = rgb_color(
        rnd_range(0,255), rnd_range(0,255), rnd_range(0,255)   
    )
    # Create circle at the point
    fill_circle(random_color, point.x, point.y, 4)
    fill_circle(random_color, point.x + 20, point.y, 4)
    fill_rectangle(random_color, point.x + 10, point.y + 10, 10, 10)

# Create a point at middle of the screen
pointMiddle = point_at(400, 300)

# Draw the point
fill_circle(color_red(), pointMiddle.x, pointMiddle.y, 4)
draw_text("Center Point", color_black(), 0, 10, pointMiddle.x - 20, pointMiddle.y - 20)

refresh_screen()
delay(4000)
close_all_windows()




