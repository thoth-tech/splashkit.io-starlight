#include "splashkit.h"

int main()
{
    // Create a JSON object
    json json_obj = create_json();

    // Set a boolean value
    json_set_bool(json_obj, "is_active", true);

    // Display the JSON object
    write_line("JSON: " + json_to_string(json_obj));

    // Free the JSON object
    free_json(json_obj);

    return 0;
}
