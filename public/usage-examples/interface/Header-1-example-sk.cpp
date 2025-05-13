#include "splashkit.h"

// Calculate horizontal center position for text
float calculate_center_x(const string &text, const string &font_name, int font_size, float area_width)
{
    font loaded_font = load_font(font_name, font_name + ".ttf");
    int text_width_px = text_width(text, loaded_font, font_size);
    return (area_width - text_width_px) / 2.0f;
}

int main()
{
    const int window_width = 600;
    const int window_height = 400;

    open_window("Header Interactive Example", window_width, window_height);

    // Preload the font (Arial.ttf is in the working directory)
    load_font("Arial", "Arial.ttf");

    string display_message = "Click the button!";

    while (!window_close_requested("Header Interactive Example"))
    {
        process_events();
        clear_screen(COLOR_WHITE);

        // Draw header section background
        fill_rectangle(COLOR_DARK_ORANGE, 0, 0, window_width, 80);

        // Centered header text
        float header_x = calculate_center_x("Welcome to SplashKit UI", "Arial", 24, window_width);
        draw_text("Welcome to SplashKit", COLOR_WHITE, "Arial", 24, header_x, 25);

        // Draw separator line below header
        draw_line(COLOR_BLACK, 0, 80, window_width, 80);

        // Display centered message text
        float message_x = calculate_center_x(display_message, "Arial", 20, window_width);
        draw_text(display_message, COLOR_BLACK, "Arial", 20, message_x, 120);

        // Draw centered button
        const int button_width = 160;
        const int button_height = 50;
        const int button_x = (window_width - button_width) / 2;
        const int button_y = 180;

        fill_rectangle(COLOR_DARK_TURQUOISE, button_x, button_y, button_width, button_height);

        float button_text_x = calculate_center_x("Click Me!", "Arial", 20, window_width);
        draw_text("Click Me!", COLOR_WHITE, "Arial", 20, button_text_x, button_y + 15);

        // Handle mouse click events for the button
        if (mouse_clicked(LEFT_BUTTON))
        {
            point_2d mouse_position_data = mouse_position();

            if (mouse_position_data.x >= button_x && mouse_position_data.x <= button_x + button_width &&
                mouse_position_data.y >= button_y && mouse_position_data.y <= button_y + button_height)
            {
                display_message = "Button Clicked!";
            }
        }

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}