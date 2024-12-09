#include "splashkit.h"

int main()
{
    // Open new window
    window wnd = open_window("Font Styles", 600, 500);
    clear_screen();

    // Load first font
    font font1 = load_font("BebasNeue", "BebasNeue.ttf");

    // Draw text with font 
    draw_text_on_window(wnd, "This font is called Bebas Neue", COLOR_BLACK, font1, 30, 150, 210);
    draw_text_on_window(wnd, "The font style is Regular 400", COLOR_BLACK, font1, 30, 150, 240);
    refresh_screen();

    delay(3000);

    // Free font1
    free_font(font1);

    // Clear Screen 
    clear_screen();

    // Load second font
    font font2 = load_font("NunitoSans", "NunitoSans.ttf");

    // Draw text with font
    draw_text_on_window(wnd, "This font is called Nunito Sans", COLOR_BLACK, font2, 30, 120, 210);
    draw_text_on_window(wnd, "The font style is Extra Light 200", COLOR_BLACK, font2, 30, 120, 240);
    refresh_screen();

    delay(3000);

    // Free font2
    free_font(font2);
    
    // Close window
    close_all_windows();  

}