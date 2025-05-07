#include "splashkit.h"

int main()
{
    //Open a 400×400 window
    open_window("Current Clip Example", 400, 400);

    //Clip the window to a 200×200 region at (100,100)
    set_clip(rectangle_from(100, 100, 200, 200));

    //Fill that region with red (with a rectangle)
    fill_rectangle(COLOR_RED, 100, 100, 200, 200);

    //Retrieve the clip bounds
    rectangle clip_rect = current_clip();

    //Exit out of the clip
    pop_clip();

    //Outline the old clip in green as a rectangle
    draw_rectangle(COLOR_GREEN,
                   clip_rect.x, clip_rect.y,
                   clip_rect.width, clip_rect.height);

    refresh_screen();
    delay(5000);
    return 0;
}
