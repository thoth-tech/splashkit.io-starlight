#include "SplashKit.h"

int main()
{
    open_window("Push Clip Example", 800, 600);

    //Define clipping rectangles to be used later for push_clip
    rectangle corner_rect = rectangle_from(195, 295, 410, 210);
    rectangle clip_rect = rectangle_from(400, 95, 205, 410);

    //Draw our pie we are slicing with clipping rectangles
    clear_screen(COLOR_WHITE);
    fill_circle(COLOR_GOLDENROD, 400, 300, 200);
    fill_circle(COLOR_SWINBURNE_RED, 400, 300, 180);
    refresh_screen();
    delay(1000);

    //Redraw our pie with demonstration of where clip_rect will cut
    clear_screen(COLOR_WHITE);
    fill_circle(COLOR_GOLDENROD, 400, 300, 200);
    fill_circle(COLOR_SWINBURNE_RED, 400, 300, 180);    
    draw_rectangle(COLOR_ROYAL_BLUE, clip_rect);
    draw_text("First Clipping Rectangle", COLOR_BLACK, 100, 550);
    refresh_screen();
    delay(2000);

    //Redraw our pie with demonstration of where corner_rect will cut
    clear_screen(COLOR_WHITE);
    fill_circle(COLOR_GOLDENROD, 400, 300, 200);
    fill_circle(COLOR_SWINBURNE_RED, 400, 300, 180);    
    draw_rectangle(COLOR_ROYAL_BLUE, corner_rect);
    draw_text("Second Clipping Rectangle", COLOR_BLACK, 100, 550);
    refresh_screen();
    delay(2000);

    //Short Intermediate frame of just pie before showing intersection
    clear_screen(COLOR_WHITE);
    fill_circle(COLOR_GOLDENROD, 400, 300, 200);
    fill_circle(COLOR_SWINBURNE_RED, 400, 300, 180);
    refresh_screen();
    delay(100);

    //Redraw our pie with both rectangles shown to visualize intersection
    clear_screen(COLOR_WHITE);
    fill_circle(COLOR_GOLDENROD, 400, 300, 200);
    fill_circle(COLOR_SWINBURNE_RED, 400, 300, 180);
    draw_rectangle(COLOR_ROYAL_BLUE, clip_rect);
    draw_rectangle(COLOR_ROYAL_BLUE, corner_rect);
    draw_text("Intersection of Both Rectangles", COLOR_BLACK, 100, 550);
    refresh_screen();
    delay(2000);

    //Pushed first rectangle and redraw the pie
    push_clip(clip_rect);
    clear_screen(COLOR_WHITE);
    fill_circle(COLOR_GOLDENROD, 400, 300, 200);
    fill_circle(COLOR_SWINBURNE_RED, 400, 300, 180);
    //Popped the rectangle so we can now draw our text without interferance
    pop_clip();
    draw_text("First Push Clip", COLOR_BLACK, 100, 550);
    refresh_screen();
    delay(2000);

    //Pushed both rectangles and redraw the pie
    push_clip(clip_rect);
    push_clip(corner_rect);
    clear_screen(COLOR_WHITE);
    fill_circle(COLOR_GOLDENROD, 400, 300, 200);
    fill_circle(COLOR_SWINBURNE_RED, 400, 300, 180);
    //opped both rectangle so we can now draw our text without interferance
    pop_clip();
    pop_clip();
    draw_text("Final Result After Second Push Clip", COLOR_BLACK, 100, 550);
    refresh_screen();
    delay(4000);

    close_all_windows();
    return 0;
}
