#include "SplashKit.h"

int main()
{

    open_window("Push Clip Example", 800, 600);
    
    rectangle clipRect = rectangle_from(400, 100, 200, 400);
    push_clip(clipRect);

    rectangle cornerClipRect = rectangle_from(200, 300, 400, 200);
    push_clip(cornerClipRect);

    clear_screen(color_white());
    fill_circle(color_red(), 400, 300, 200);
    refresh_screen();


    refresh_screen();

    delay(4000);


    close_all_windows();

    return 0;
}
