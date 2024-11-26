#include "splashkit.h"

int main()
{
    open_window("Has Font", 800, 600);
    clear_screen();

    //Check if the font exit or not
    bool fontCheck = has_font("NORMAL_FONT");
    // Display the text to show the result
    
    if(fontCheck)
    {
        draw_text("Font find!", COLOR_BLACK, 300, 300);
    }else
    {
        draw_text("Font not find!", COLOR_BLACK, 300, 300);
    }

    refresh_screen();
    delay(4000);
    close_all_windows();

}