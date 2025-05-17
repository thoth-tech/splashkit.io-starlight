from splashkit import *

hue = 0.8
saturation = 0.8
brightness = 0.8

window = open_window("Hsb Color", 800, 600)

while not window_close_requested(window):

        process_events()

        # Get the mouse movement
        movement = mouse_movement()
        scroll = mouse_wheel_scroll()
        # Update hue and saturation based on mouse movement
        if mouse_down(MouseButton.left_button):
            # Adjust hue based on horizontal mouse movement
            hue = (hue + movement.x / window_width(window)) % 1.0

        saturation += scroll.y / 10.0
                  
        
fill_circle(hsb_color(hue, saturation, brightness), 400, 300, 300)
refresh_screen()


close_window(window)
