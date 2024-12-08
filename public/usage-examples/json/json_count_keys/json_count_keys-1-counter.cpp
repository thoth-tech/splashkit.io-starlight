#include "splashkit.h"

int main()
{
    // Create a JSON object
    json json_obj = create_json();

    // Add some data to the JSON object
    json_set_string(json_obj, "name", "Breezy");
    json_set_number(json_obj, "age", 25);
    json_set_string(json_obj, "hobby", "Coding");

    // Count the keys in the JSON object
    int key_count = json_count_keys(json_obj);

    // Display the count of keys
    write_line("The JSON object has " + std::to_string(key_count) + " keys.");

    // Free the JSON object
    free_json(json_obj);

    return 0;
}
