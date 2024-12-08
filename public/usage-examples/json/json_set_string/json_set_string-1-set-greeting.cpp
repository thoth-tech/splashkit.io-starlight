#include "splashkit.h"

int main()
{
    // Create a JSON object
    json json_obj = create_json();

    // Set a string value
    json_set_string(json_obj, "greeting", "Hello, SplashKit!");

    // Display the JSON object
    write_line("JSON: " + json_to_string(json_obj));

    // Free the JSON object
    free_json(json_obj);

    return 0;
}
