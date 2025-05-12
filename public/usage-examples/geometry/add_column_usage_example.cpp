#include "splashkit.h"

// Helper function to center text in a column
float center_text_x(const char* text, int column_x, int column_width, int font_size)
{
    int text_w = text_width(text, "Arial", font_size);
    return column_x + (column_width - text_w) / 2.0f;
}

int main()
{
    window my_window = open_window("Add Column Example", 600, 400);

    int start_x = 50, start_y = 50, column_height = 300;
    int column_widths[] = {100, 200, 300};
    const char* column_labels[] = {"Small", "Medium", "Large"};
    int font_size = 20;

    load_font("Arial", "Arial.ttf"); // Ensure Arial.ttf is present in the directory

    while (!window_close_requested(my_window))
    {
        process_events();
        clear_screen(COLOR_WHITE);

        int current_x = start_x;
        for (int i = 0; i < 3; ++i)
        {
            // Draw column background
            fill_rectangle(COLOR_LIGHT_GRAY, current_x, start_y, column_widths[i], column_height);

            // Center text horizontally in each column
            float text_x = center_text_x(column_labels[i], current_x, column_widths[i], font_size);
            draw_text(column_labels[i], COLOR_BLACK, "Arial", font_size, text_x, start_y + 10);

            // Optional: Draw a border to visually separate columns
            draw_rectangle(COLOR_BLACK, current_x, start_y, column_widths[i], column_height);

            current_x += column_widths[i];
        }

        refresh_screen(60);
    }

    return 0;
}