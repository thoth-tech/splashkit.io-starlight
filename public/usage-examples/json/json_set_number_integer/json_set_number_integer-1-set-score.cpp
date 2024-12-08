#include "splashkit.h"

int main()
{
    // Create a JSON object
    json json_obj = create_json();

    // Set an integer value
    json_set_number(json_obj, "score", 100);

    // Display the JSON object
    write_line("JSON: " + json_to_string(json_obj));

    // Free the JSON object
    free_json(json_obj);

    return 0;
}
