#include "splashkit.h"

int main()
{
    // Declare Variables
    circle ball;
    int height = display_height(display_details(0));
    double acceleration = 0.8;
    double damping = 0.5;
    double velocity = 0;
    double ball_y = 0;
    int radius = 50;

    open_window("DisplayHeightExample", 800, height) ;

    while  (!quit_requested()){
        clear_screen(color_white());

        // Set ball details and draw
        ball = circle_at(400,ball_y,radius);
        fill_circle(color_blue(),ball);
        
        // Set acceleration and velocity for ball
        ball_y += velocity;
        velocity += acceleration;

        // Check if ball has hit bottom of window to trigger bounce
        if (ball_y + radius >= height){
            // Keep ball in window
            ball_y = height - radius;
            // Reverse velocity and apply damping
            velocity = -velocity * damping;
            // Halt velocity to stop ball bouncing 
            if (abs(velocity) < 3){
                velocity = 0;
            }
        }
        refresh_screen(60);
        process_events();
    }
    return 0;
}