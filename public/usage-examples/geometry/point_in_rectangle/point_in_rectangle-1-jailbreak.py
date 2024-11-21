from splashkit import *



    #Variable declarations
boundary = rectangle_from(150,150,300,100)


open_window("point in rectangle", 600, 600)


while not quit_requested():

    
    # get mouse position and draw boundary to screen
    mouse_point = mouse_position()
    clear_screen(color_green())
    fill_rectangle_record(color_white(), boundary)

    # Check if mouse is in the boundary
    while not point_in_rectangle(mouse_point,boundary):

        #flash screen red and blue if mouse has escaped boundary
        clear_screen(color_red())
        fill_rectangle_record(color_white(), boundary)
        draw_text_no_font_no_size("JAILBREAK",color_black(),250.0,400.0)
        refresh_screen_with_target_fps(10)
        clear_screen(color_blue())
        fill_rectangle_record(color_white(), boundary)
        refresh_screen_with_target_fps(10)
        mouse_point = mouse_position()
        
        process_events()
        if quit_requested(): 
            break
    
    
    process_events()
    refresh_screen()
    
    
