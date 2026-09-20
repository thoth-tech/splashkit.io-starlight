#include "splashkit.h"

int main()
{
    open_window("File Permission Bits", 640, 400);

    // Each octal digit of a Unix permission code is three bits: read, write and execute
    string permission_code = "754";
    string bits = oct_to_bin(permission_code);

    string who_names[] = {"Owner", "Group", "Others"};
    string permission_names[] = {"Read", "Write", "Execute"};

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);

        draw_text("Permission code: " + permission_code, COLOR_BLACK, 40, 30);
        draw_text("As bits: " + bits, COLOR_BLACK, 40, 60);

        for (int column = 0; column < 3; column++)
        {
            draw_text(permission_names[column], COLOR_BLACK, 230 + column * 130, 115);
        }

        for (int row = 0; row < 3; row++)
        {
            draw_text(who_names[row], COLOR_BLACK, 60, 165 + row * 70);
        }

        // 754 has no leading zero digit, so all nine bits come back
        for (int position = 0; position < 9; position++)
        {
            double box_x = 200 + (position % 3) * 130;
            double box_y = 140 + (position / 3) * 70;

            if (bits[position] == '1')
            {
                fill_rectangle(COLOR_GREEN, box_x, box_y, 100, 50);
            }
            else
            {
                fill_rectangle(COLOR_LIGHT_GRAY, box_x, box_y, 100, 50);
            }

            draw_rectangle(COLOR_BLACK, box_x, box_y, 100, 50);
        }

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}
