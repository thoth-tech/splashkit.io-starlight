#include "splashkit.h"

//Method to get the maximum length for the circle to still be on screen
int get_val(int rand, int large)
{
    int base = 0;

    if (rand > (large - rand))
    {
        base = large - rand;
    }
    else
    {
        base = rand;
    }

    return base;
}

//Method that retrieves a random circle position
circle get_circle()
{
    int random_value = rnd(300);
    int start_value = get_val(random_value, 600);
    circle circle = circle_at(rnd(0 + start_value, 800 - start_value), rnd(start_value, 600 - start_value), random_value);
    return circle;
}

int main()
{
    circle circle_1 = get_circle();
    circle circle_2 = get_circle();

    open_window("Circle X", 800, 600);

    // Draw the Circle and x coordinate on window
    clear_screen(color_white());
    draw_circle(COLOR_RED, circle_1);
    draw_circle(COLOR_GREEN, circle_2);
    
    //Checks if the circles intersect or not
    bool circle_intersect = circles_intersect(circle_1, circle_2);
    string val = circle_intersect ? "true" : "false";
    draw_text("Circle X intersecting with Circle Y is " + val , COLOR_BLACK, 100, 100);
    refresh_screen();

    delay(4000);
    close_all_windows();
}