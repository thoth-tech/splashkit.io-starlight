#include "splashkit.h"
#include <string>

int main()
{
    open_window("Color Workshop", 960, 540);

    const int segment_count = 16;
    const int strip_x = 40;
    const int strip_y = 90;
    const int strip_width = 880;
    const int strip_height = 220;
    const int segment_width = strip_width / segment_count;

    const int start_red = 255;
    const int start_green = 120;
    const int start_blue = 40;

    const int end_red = 30;
    const int end_green = 110;
    const int end_blue = 255;

    int frame_count = 0;

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_BLACK);

        for (int i = 0; i < segment_count; i++)
        {
            double t = static_cast<double>(i) / (segment_count - 1);

            // Interpolation formula: value = start + t * (end - start).
            int red = static_cast<int>(start_red + t * (end_red - start_red));
            int green = static_cast<int>(start_green + t * (end_green - start_green));
            int blue = static_cast<int>(start_blue + t * (end_blue - start_blue));

            color gradient_color = rgb_color(red, green, blue);
            int x = strip_x + i * segment_width;

            // Draw one gradient bar for this segment.
            draw_rectangle(gradient_color, x, strip_y, segment_width, strip_height);

            // Show channel values in the HUD every fourth segment.
            if (i % 4 == 0)
            {
                std::string label = "[" + std::to_string(i) + "] R" + std::to_string(red) + " G" + std::to_string(green) + " B" + std::to_string(blue);
                draw_text(label, COLOR_WHITE, x, strip_y + strip_height + 14);
            }
        }

        int selected_index = (frame_count / 20) % segment_count;
        double selected_t = static_cast<double>(selected_index) / (segment_count - 1);

        int selected_red = static_cast<int>(start_red + selected_t * (end_red - start_red));
        int selected_green = static_cast<int>(start_green + selected_t * (end_green - start_green));
        int selected_blue = static_cast<int>(start_blue + selected_t * (end_blue - start_blue));

        color selected_color = rgb_color(selected_red, selected_green, selected_blue);
        int selected_x = strip_x + selected_index * segment_width;

        // Highlight one segment and print its RGB channels.
        draw_rectangle(COLOR_WHITE, selected_x - 2, strip_y - 2, segment_width + 4, strip_height + 4);
        draw_rectangle(selected_color, selected_x, strip_y, segment_width, strip_height);

        std::string formula_text = "value = start + t(end - start)";
        std::string hud_text = "Segment " + std::to_string(selected_index) + " -> R " + std::to_string(selected_red) + ", G " + std::to_string(selected_green) + ", B " + std::to_string(selected_blue);

        draw_text("Color Workshop - Gradient Composer", COLOR_WHITE, 40, 36);
        draw_text(formula_text, COLOR_WHITE, 40, 346);
        draw_text(hud_text, COLOR_WHITE, 40, 378);

        refresh_screen(60);
        frame_count++;
    }

    close_all_windows();
    return 0;
}
