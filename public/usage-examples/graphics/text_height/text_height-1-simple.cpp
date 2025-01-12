#include "splashkit.h"

int main()
{   
    //Let user enter the text
    write_line("Type some text: ");
    string text = read_line();

    //Let user enter the size
    write_line("Enter the size for the text: ");
    int size = convert_to_integer(read_line());

    open_window("Text Height", 800, 600);
    clear_screen();

    // Load font
    load_font("my_font", "arial.ttf");

    // Calculate the text height with size enter by user
    int textHeight = text_height(text, "my_font", size);

    // Display the height of text
    write_line("The height of the text is: " + std::to_string(textHeight));
    
    // Display the text in the window
    draw_text(text, COLOR_BLACK, "my_font", size, 100, 100);

    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}