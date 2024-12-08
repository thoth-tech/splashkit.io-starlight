#include "splashkit.h"

int main()
{
    // Create a JSON object with a color string
    json json_obj = create_json();
    json_set_string(json_obj, "color", "#8040FFFF"); // Purple

    // Convert the JSON object to a color
    color clr = json_to_color(json_obj);

    // Display the color components
    write_line("Color created from JSON:");
    write_line("Red: " + std::to_string(red_of(clr)));
    write_line("Green: " + std::to_string(green_of(clr)));
    write_line("Blue: " + std::to_string(blue_of(clr)));
    write_line("Alpha: " + std::to_string(alpha_of(clr)));

    // Free the JSON object
    free_json(json_obj);

    return 0;
}
