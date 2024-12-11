#include "splashkit.h"

int main()
{
    // Create a JSON object
    json json_obj = create_json();
    json_set_string(json_obj, "name", "Breezy");
    json_set_number(json_obj, "age", 25);
    json_set_bool(json_obj, "is_active", true);

    // Convert the JSON object to a string
    string json_string = json_to_string(json_obj);

    // Display the JSON string
    write_line("JSON Object as String:");
    write_line(json_string);

    // Free the JSON object
    free_json(json_obj);

    return 0;
}
