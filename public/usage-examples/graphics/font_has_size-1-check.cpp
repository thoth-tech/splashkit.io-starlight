#include "splashkit.h"
#include <string>

int main()
{
    open_window("Font Has Size", 900, 650);

    font arial_font = load_font("arial font", "arial.ttf");
    font roboto_font = load_font("roboto font", "Roboto-Regular.ttf");

    int size1 = 16;
    int size2 = 32;
    int size3 = 64;

    bool arial_has_16 = font_has_size(arial_font, size1);
    bool arial_has_32 = font_has_size(arial_font, size2);
    bool arial_has_64 = font_has_size(arial_font, size3);

    bool roboto_has_16 = font_has_size(roboto_font, size1);
    bool roboto_has_32 = font_has_size(roboto_font, size2);
    bool roboto_has_64 = font_has_size(roboto_font, size3);

    std::string arial_result_16 = "Not Available";
    std::string arial_result_32 = "Not Available";
    std::string arial_result_64 = "Not Available";

    std::string roboto_result_16 = "Not Available";
    std::string roboto_result_32 = "Not Available";
    std::string roboto_result_64 = "Not Available";

    if (arial_has_16) arial_result_16 = "Available";
    if (arial_has_32) arial_result_32 = "Available";
    if (arial_has_64) arial_result_64 = "Available";

    if (roboto_has_16) roboto_result_16 = "Available";
    if (roboto_has_32) roboto_result_32 = "Available";
    if (roboto_has_64) roboto_result_64 = "Available";

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        draw_text("FontHasSize can be used to compare supported font sizes.", COLOR_BLACK, arial_font, 24, 20, 20);

        draw_text("Font: Arial", COLOR_BLUE, arial_font, 22, 20, 80);
        draw_text("Size 16: " + arial_result_16, COLOR_BLACK, arial_font, 20, 40, 120);
        draw_text("Size 32: " + arial_result_32, COLOR_BLACK, arial_font, 20, 40, 155);
        draw_text("Size 64: " + arial_result_64, COLOR_BLACK, arial_font, 20, 40, 190);

        draw_text("Font: Roboto", COLOR_RED, arial_font, 22, 20, 280);
        draw_text("Size 16: " + roboto_result_16, COLOR_BLACK, arial_font, 20, 40, 320);
        draw_text("Size 32: " + roboto_result_32, COLOR_BLACK, arial_font, 20, 40, 355);
        draw_text("Size 64: " + roboto_result_64, COLOR_BLACK, arial_font, 20, 40, 390);

        draw_text("Different fonts may support different sizes.", COLOR_DARK_GRAY, arial_font, 20, 20, 500);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}