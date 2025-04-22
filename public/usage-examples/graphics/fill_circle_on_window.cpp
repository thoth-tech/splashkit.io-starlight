#include "splashkit.h"

// Draw a traffic light using fill_circle_on_window
void draw_traffic_light(window win)
{
    // Red light
    fill_circle_on_window(win, COLOR_RED, 400, 100, 50);

    // Yellow light
    fill_circle_on_window(win, COLOR_YELLOW, 400, 250, 50);

    // Green light
    fill_circle_on_window(win, COLOR_GREEN, 400, 400, 50);
}

int main()
{
    // Create a window and assign it to a variable
    window traffic_window = open_window("Traffic Lights - v2", 800, 600);

    // Set the current window to target it for clear_screen and refresh
    set_current_window(traffic_window);
    clear_screen(COLOR_WHITE);

    // Draw the traffic lights
    draw_traffic_light(traffic_window);

    // Show the result
    refresh_screen();

    // Wait for 5 seconds
    delay(5000);

    // Close the window
    close_all_windows();

    return 0;
}
