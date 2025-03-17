#include "splashkit.h"

int main()
{
    open_window("Text Height", 680, 200);
    clear_screen(COLOR_WHITE);

    load_font("LOTR", "lotr.TTF");
    set_font_style("LOTR", BOLD_FONT);
    draw_text("Ringbearer", COLOR_BLACK, "LOTR", 100, 30, 20);
    
    int height = text_height("Ringbearer", "LOTR", 100);
    fill_rectangle(COLOR_BLACK, 20, 20, 10, height);
    refresh_screen();

    delay(5000);
    close_all_windows();

    return 0;
}