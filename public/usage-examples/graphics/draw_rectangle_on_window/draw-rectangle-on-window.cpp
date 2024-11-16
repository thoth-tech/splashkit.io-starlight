#include "splashkit.h"

int main()
{
    const int window_width = 800, window_height = 600, rows = 8, cols = 8, rect_size = 60;
    float offset_x = (window_width - cols * rect_size) / 2.0, offset_y = (window_height - rows * rect_size) / 2.0;
    window my_window = open_window("Checkerboard", window_width, window_height);

    while (!window_close_requested(my_window))
    {
        clear_window(my_window, COLOR_WHITE);
        for (int r = 0; r < rows; r++)
            for (int c = 0; c < cols; c++)
            {
                float x = offset_x + c * rect_size, y = offset_y + r * rect_size;
                color fill = ((r + c) % 2 == 0) ? COLOR_BLACK : COLOR_LIGHT_GRAY;
                draw_rectangle_on_window(my_window, fill, x, y, rect_size, rect_size);
                draw_rectangle_on_window(my_window, COLOR_BLUE, x, y, rect_size, rect_size);
            }
        refresh_window(my_window);
    }
    close_window(my_window);
    return 0;
}
