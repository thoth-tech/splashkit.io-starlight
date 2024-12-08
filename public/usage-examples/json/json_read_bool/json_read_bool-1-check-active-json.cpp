#include "splashkit.h"

int main()
{
    // Create a JSON object with a boolean value
    json json_obj = create_json();
    json_set_bool(json_obj, "is_active", true);

    // Read the boolean value from the JSON object
    bool is_active = json_read_bool(json_obj, "is_active");

    // Display the boolean value
    write_line("Is Active: " + std::to_string(is_active));

    // Free the JSON object
    free_json(json_obj);

    return 0;
}
