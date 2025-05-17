#include "splashkit.h"

int main()
{
    // Create a color
    color clr = COLOR_BLACK;

    // Convert the color to a JSON object
    json json_object = json_from_color(clr);

    // Display the JSON object as a string
    write_line("JSON from Color: " + json_to_string(json_object));

    return 0;
}