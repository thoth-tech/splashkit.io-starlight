#include "splashkit.h"

int main()
{
    open_window("Text Width", 800, 600);
    clear_screen();

    // Load a font
    load_font("my_font", "arial.ttf");

    string text = "Text Width!";
    //Calculate the text height with size = 16
    int textHeight = text_height(text, "my_font", 16);

    //Calculate the x and y position to make the text align it vertically in the window
    int x_position = 200;
    int y_position = (600-textHeight)/2;
    
    // Display the text align it vertically in the window
    draw_text(text, COLOR_BLACK, x_position, y_position); 
    
    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}