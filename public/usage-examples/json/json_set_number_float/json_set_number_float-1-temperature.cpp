#include "splashkit.h"

int main()
{
    // Create a JSON object
    json json_obj = create_json();

    // Set a float value
    json_set_number(json_obj, "temperature", 36.6f);

    // Display the JSON object
    write_line("JSON: " + json_to_string(json_obj));

    // Free the JSON object
    free_json(json_obj);

    return 0;
}
