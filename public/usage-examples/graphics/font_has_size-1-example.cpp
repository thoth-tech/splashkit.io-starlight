#include "splashkit.h"
#include <string>

std::string availability_text(bool available)
{
    if (available)
    {
        return "Available";
    }

    return "Not Available";
}

int main()
{
    open_window("Font Size Checker", 900, 650);

    font arial_font = load_font("arial font", "arial.ttf");

    int unused_size = 16;
    int checked_size = 32;

    bool before_16 = font_has_size(arial_font, unused_size);
    bool before_32 = font_has_size(arial_font, checked_size);

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        draw_text(
            "font_has_size checks if a font has already been loaded at a selected size.",
            COLOR_BLACK,
            arial_font,
            24,
            20,
            20
        );

        draw_text(
            "Before using Arial at size 32:",
            COLOR_BLUE,
            arial_font,
            20,
            20,
            90
        );

        draw_text(
            "Size 16: " + availability_text(before_16),
            COLOR_BLACK,
            arial_font,
            20,
            40,
            130
        );

        draw_text(
            "Size 32: " + availability_text(before_32),
            COLOR_BLACK,
            arial_font,
            20,
            40,
            165
        );

        draw_text(
            "This line is drawn using Arial at size 32.",
            COLOR_RED,
            arial_font,
            checked_size,
            20,
            250
        );

        bool after_16 = font_has_size(arial_font, unused_size);
        bool after_32 = font_has_size(arial_font, checked_size);

        draw_text(
            "After drawing text using Arial at size 32:",
            COLOR_BLUE,
            arial_font,
            20,
            20,
            340
        );

        draw_text(
            "Size 16: " + availability_text(after_16),
            COLOR_BLACK,
            arial_font,
            20,
            40,
            380
        );

        draw_text(
            "Size 32: " + availability_text(after_32),
            COLOR_BLACK,
            arial_font,
            20,
            40,
            415
        );

        draw_text(
            "The size used for drawing becomes available, while the unused size remains unavailable.",
            COLOR_DARK_GRAY,
            arial_font,
            20,
            20,
            520
        );

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
