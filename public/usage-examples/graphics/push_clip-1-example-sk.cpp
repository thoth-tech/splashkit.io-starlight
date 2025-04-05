#include "SplashKit.h"

int main()
{

    open_window("Push Clip Example", 800, 600);

    clear_screen(COLOR_WHITE);
    fill_circle(COLOR_GOLDENROD, 400, 300, 200);
    fill_circle(COLOR_SWINBURNE_RED, 400, 300, 180);
    refresh_screen();
    delay(1000);

    clear_screen(COLOR_WHITE);
    fill_circle(COLOR_GOLDENROD, 400, 300, 200);
    fill_circle(COLOR_SWINBURNE_RED, 400, 300, 180);

    rectangle clip_rect = rectangle_from(400, 95, 205, 410);
    draw_rectangle(COLOR_ROYAL_BLUE, clip_rect);

    draw_text("First Clipping Rectangle", COLOR_BLACK, 100, 550);
    refresh_screen();
    delay(2000);

    clear_screen(COLOR_WHITE);
    fill_circle(COLOR_GOLDENROD, 400, 300, 200);
    fill_circle(COLOR_SWINBURNE_RED, 400, 300, 180);

    rectangle corner_rect = rectangle_from(195, 295, 410, 210);
    draw_rectangle(COLOR_ROYAL_BLUE, corner_rect);

    draw_text("Second Clipping Rectangle", COLOR_BLACK, 100, 550);
    refresh_screen();
    delay(2000);

    clear_screen(COLOR_WHITE);
    fill_circle(COLOR_GOLDENROD, 400, 300, 200);
    fill_circle(COLOR_SWINBURNE_RED, 400, 300, 180);
    refresh_screen();
    delay(100);

    clear_screen(COLOR_WHITE);
    fill_circle(COLOR_GOLDENROD, 400, 300, 200);
    fill_circle(COLOR_SWINBURNE_RED, 400, 300, 180);

    draw_rectangle(COLOR_ROYAL_BLUE, clip_rect);
    draw_rectangle(COLOR_ROYAL_BLUE, corner_rect);

    draw_text("Intersection of Both Rectangles", COLOR_BLACK, 100, 550);
    refresh_screen();
    delay(2000);

    push_clip(clip_rect);
    clear_screen(COLOR_WHITE);
    fill_circle(COLOR_GOLDENROD, 400, 300, 200);
    fill_circle(COLOR_SWINBURNE_RED, 400, 300, 180);
    pop_clip();
    draw_text("First Push Clip", COLOR_BLACK, 100, 550);
    refresh_screen();
    delay(2000);

    push_clip(clip_rect);
    push_clip(corner_rect);
    clear_screen(COLOR_WHITE);
    fill_circle(COLOR_GOLDENROD, 400, 300, 200);
    fill_circle(COLOR_SWINBURNE_RED, 400, 300, 180);
    pop_clip();
    pop_clip();
    draw_text("Final Result After Second Push Clip", COLOR_BLACK, 100, 550);
    refresh_screen();
    delay(4000);



    close_all_windows();

    return 0;
}
