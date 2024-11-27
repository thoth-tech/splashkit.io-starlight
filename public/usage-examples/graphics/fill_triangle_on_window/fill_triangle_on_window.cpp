#include "splashkit.h"

int main() {
    open_window("Abstract Mosaic", 800, 600);
    for (int x = 0; x < 8; x++) {
        for (int y = 0; y < 6; y++) {
            fill_triangle(random_color(), x*100, y*100, x*100+50, y*100+50, x*100+100, y*100);
        }
    }
    refresh_screen();
    delay(5000);
    close_all_windows();
    return 0;
}
