#include "splashkit.h"

int main()
{
    window wind = open_window("Refresh Window Example", 800, 600);

    write_line("Refreshing the window...");

    clear_window(wind, COLOR_WHITE);
    draw_text("Window will be refreshed.", COLOR_BLACK, 50, 50);
    refresh_window(wind);

    write_line("Window refreshed.");

    delay(3000); // Delay to keep the window open for 3 seconds

    return 0;
}
