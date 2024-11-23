#include "splashkit.h"

int main()
{
    // Display a dialog to the user
    display_dialog("Welcome!", "Hello, this is a simple dialog message.", get_system_font(), 20);

    // Display another dialog with a different message and font size
    display_dialog("Second Message", "This is another dialog with a different message.", get_system_font(), 25);

    // Display a dialog with a different title and message
    display_dialog("Third Message", "This is a dialog with BIG TEXT!", get_system_font(), 40);
}
