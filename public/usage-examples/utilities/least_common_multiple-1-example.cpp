#include "splashkit.h"
#include <string>

int main()
{
    open_window("Least Common Multiple Demo", 640, 400);

    int num1 = 12, num2 = 18;

    while (!quit_requested())
    {
        process_events();

        // controls
        if (key_typed(UP_KEY))    num1++;
        if (key_typed(DOWN_KEY))  num1 = (num1 > 1) ? num1 - 1 : 1;
        if (key_typed(RIGHT_KEY)) num2++;
        if (key_typed(LEFT_KEY))  num2 = (num2 > 1) ? num2 - 1 : 1;
        if (key_typed(R_KEY))     { num1 = 12; num2 = 18; }

        int result = least_common_multiple(num1, num2);

        clear_screen(COLOR_WHITE);

        // title
        draw_text("LCM CALCULATOR", COLOR_BLUE, "arial", 28, 190, 40);

        // display numbers
        draw_text("Number 1: " + std::to_string(num1), COLOR_BLACK, "arial", 22, 180, 140);
        draw_text("Number 2: " + std::to_string(num2), COLOR_BLACK, "arial", 22, 180, 180);

        // display result
        draw_text("LCM: " + std::to_string(result), COLOR_RED, "arial", 24, 180, 230);

        // instructions
        draw_text("Controls: UP/DOWN for Number 1,  LEFT/RIGHT for Number 2,  R = reset",
          COLOR_GRAY, "arial", 16, 40, 330);

        refresh_screen();
    }

    close_all_windows();
    return 0;
}
