#include "splashkit.h"

int main()
{
    // Create an empty JSON object
    json json_obj = create_json();

    // Add some data to the JSON object
    json_set_string(json_obj, "name", "Breezy");
    json_set_number(json_obj, "age", 25);

    // Display the JSON object as a string
    write_line("Created JSON: " + json_to_string(json_obj));

    return 0;
}
