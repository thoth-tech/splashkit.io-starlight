from splashkit import *

# Declare Variables
# -80 to account for title bar and task bar
height = display_height(display_details(0)) - 80
acceleration = 0.8
damping = 0.5
velocity = 0
ball_y = 0
radius = 50

# Open window with the height of the display
open_window("Bouncing Ball", 800, height) 

while not quit_requested():
    clear_screen(color_white())

    draw_text_no_font_no_size(f"Display Height: {display_height(display_details(0))} Pixels", color_black(),25,25)
    # Set ball details and draw
    ball = circle_at_from_points(400,ball_y,radius)
    fill_circle_record(color_blue(),ball)
    
    # Set acceleration and velocity for ball
    ball_y += velocity
    velocity += acceleration

    # Check if ball has hit bottom of window to trigger bounce
    if ball_y + radius >= height:
        # Keep ball in window
        ball_y = height - radius  
        # Reverse velocity and apply damping
        velocity = -velocity * damping

        # Halt velocity to stop ball bouncing 
        if abs(velocity) < 3:
            velocity = 0
    refresh_screen_with_target_fps(60)
    process_events()
close_all_windows()
