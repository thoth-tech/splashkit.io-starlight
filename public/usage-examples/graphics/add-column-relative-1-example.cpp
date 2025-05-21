#include "splashkit.h"

// Mock implementation to draw a colored column representing a relative width
void add_column_relative(double width, int &x, int container_width, int height, color col)
{
    int col_width = (int)(container_width * width);
    fill_rectangle(col, x, 0, col_width, height);
    x += col_width;
}

int main()
{
    int window_width = 600, window_height = 200;
    open_window("Columns with Increasing Percentage Width", window_width, window_height);

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        int x = 0;
        // 10% width
        add_column_relative(0.10, x, window_width, window_height, COLOR_LIGHT_BLUE);
        // 20% width
        add_column_relative(0.20, x, window_width, window_height, COLOR_LIGHT_GREEN);
        // 30% width
        add_column_relative(0.30, x, window_width, window_height, COLOR_LIGHT_YELLOW);
        // 40% width
        add_column_relative(0.40, x, window_width, window_height, COLOR_LIGHT_PINK);

        draw_text("Columns: 10% | 20% | 30% | 40%", COLOR_BLACK, 10, window_height - 30);

        refresh_screen();
    }

    return 0;
}
