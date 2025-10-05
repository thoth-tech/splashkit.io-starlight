#include "splashkit.h"

int main()
{
    open_window("Greatest Common Divisor Example", 600, 400);

    // I am setting up two example numbers
    int a = 48;
    int b = 18;

    // I am calculating the GCD using the built-in SplashKit function
    int gcd_value = greatest_common_divisor(a, b);

    // I am clearing the screen and showing the results
    clear_screen(COLOR_WHITE);
    draw_text("Calculating the Greatest Common Divisor (GCD)", COLOR_NAVY, 60, 60);
    draw_text("Number A: " + std::to_string(a), COLOR_BLACK, 60, 120);
    draw_text("Number B: " + std::to_string(b), COLOR_BLACK, 60, 150);
    draw_text("GCD Result: " + std::to_string(gcd_value), COLOR_RED, 60, 200);

    draw_text("Press ESC to exit", COLOR_GRAY, 400, 360);
    refresh_screen();

    // Wait for ESC key to exit
    while (!quit_requested())
    {
        process_events();
        if (key_typed(ESCAPE_KEY)) break;
    }

    close_all_windows();
    return 0;
}