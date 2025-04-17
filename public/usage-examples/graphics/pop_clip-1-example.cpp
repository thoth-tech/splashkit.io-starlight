#include "splashkit.h"

int main()
{
    //Create a new window with width and height of 400 called "Pop Clip Example"
    open_window("Pop Clip Example", 400, 400);

    //Clip region to centre width and height of the same
    set_clip(rectangle_from(200, 200, 200, 200));

    //Draw a red circle position x and y and redius
    fill_circle(COLOR_RED, 200, 200, 50);

    //Remove the clip
    pop_clip();

    //Draw a green circle in the full window
    fill_circle(COLOR_GREEN, 100, 200, 100);

    refresh_screen();
    delay(5000);
    return 0;
}
