#include "splashkit.h"

int main()
{
    // Create a JSON object
    json json_obj = create_json();
    json_set_string(json_obj, "name", "Breezy");
    json_set_number(json_obj, "age", 25);
    json_set_bool(json_obj, "is_active", true);

    // Save the JSON object to the file
    write_line("Saving JSON to file...");
    json_to_file(json_obj, "example.json");

    // Free the JSON object
    free_json(json_obj);
    write_line("JSON object freed.");

    return 0;
}
