from splashkit import *

# declare variables
trail_length = 50
pixel_point = point_at(-10,-10)
mouse_history = [pixel_point for _ in range(50)]
color_list = [color_blue(),color_red(),color_green(),color_yellow(),color_pink()]


open_window("draw pixel", 600, 600)


while not quit_requested():


    mouse_point = mouse_position()
    clear_screen(color_black())
    # set mouse position history 
    for i in range(trail_length - 1):        
        # shuffle forward
        mouse_history[i] = mouse_history[i + 1]
    
    mouse_history[trail_length - 1] = mouse_point
    # draw mouse trail
    for i in range(0, trail_length):     
        draw_pixel_at_point(color_list[i%5],mouse_history[i])

    process_events()
    refresh_screen_with_target_fps(60)
    
close_all_windows()



