#include "splashkit.h"

int main()
{
    // Create parent and child JSON objects
    json parent_json = create_json();
    json child_json = create_json();

    // Set data in the child JSON object
    json_set_string(child_json, "name", "Breezy");

    // Add the child JSON to the parent JSON
    json_set_object(parent_json, "user", child_json);

    // Display the parent JSON object
    write_line("JSON: " + json_to_string(parent_json));

    // Free the JSON objects
    free_json(parent_json);
    free_json(child_json);

    return 0;
}
