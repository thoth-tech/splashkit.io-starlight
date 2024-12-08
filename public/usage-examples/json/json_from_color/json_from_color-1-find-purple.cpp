#include "splashkit.h"

int main()
{
    // Create a color
    color clr = COLOR_PURPLE;

    // Convert the color to a JSON object
    json json_obj = json_from_color(clr);

    // Display the JSON object as a string
    write_line("JSON from Color: " + json_to_string(json_obj));

    // Free the JSON object
    free_json(json_obj);

    return 0;
}
