#include "splashkit.h"

int main()
{
open_window("HSB Color", 800, 600);

double hue = 1.0;
double saturation = 1.0;
double brightness = 1.0;

while (!window_close_requested("HSB Color"))
    {
        process_events();

        vector_2d scroll = mouse_wheel_scroll();
        vector_2d movement = mouse_movement();

        // Adjust hue by dragging with left mouse button
        if (mouse_down(LEFT_BUTTON))
        {
            hue += movement.x / screen_width();   
        }

        // Adjust saturation with mouse scroll
        saturation += scroll.y / 10.0;
        

        fill_circle(hsb_color(hue, saturation, brightness), 400, 300, 300);
        refresh_screen(60);
    }

close_all_windows();
return 0;
}



