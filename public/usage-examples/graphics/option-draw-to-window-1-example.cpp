#include "splashkit.h"

int main()
{
    // 1. Open a window and store the reference
    window win = open_window("Bubbles", 800, 600);

    // 2. Clear the screen of the window (current window, since you just opened one)
    clear_screen(COLOR_WHITE);

    // 3. Draw 50 random circles using option_draw_to to ensure we draw to 'win'
    for (int i = 0; i < 50; i++)
    {
        double x = rnd(800);
        double y = rnd(600);
        double radius = rnd(10, 50); // Avoid zero-size circles!
        color randomColor = rgb_color(rnd(255), rnd(255), rnd(255));

        // Draw to the specified window
        draw_circle(randomColor, x, y, radius, option_draw_to(win));
    }

    // 4. Refresh that window so your circles show up
    refresh_window(win);

    // 5. Wait a bit so the user can see
    delay(4000);

    // 6. Clean up
    close_all_windows();

    return 0;
}
