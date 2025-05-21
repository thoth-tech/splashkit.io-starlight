from splashkit import *

open_window("Current Clip Example", 400, 400)

#Clip the window to a 200×200 region at (100,100)
region = rectangle_from(100, 100, 200, 200)

while not quit_requested():

    process_events()
    clear_screen(Color.WHITE)
    #Fill that region with red (with a rectangle)
    set_clip(region)
    fill_rectangle(Color.RED, region)

    #Retrieve the clip bounds
    clip = current_clip()

    #Exit out of the clip
    pop_clip()

    #Outline the old clip in green as a rectangle
    draw_rectangle(Color.GREEN,clip.x, clip.y, clip.width, clip.height)

    refresh_screen()

close_window("Current Clip Example")

