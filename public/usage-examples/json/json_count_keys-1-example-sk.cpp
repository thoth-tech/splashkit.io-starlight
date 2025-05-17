#include "splashkit.h"

int main()
{
    // Create a JSON object
    json json_object = create_json();

    // Add some data to the JSON object
    json_set_string(json_object, "frist_name", "Lam");
    json_set_string(json_object, "last_name", "Huynh");

    // Count the keys in the JSON object
    int key_count = json_count_keys(json_object);

    // Display the count of keys
    write_line("The JSON object has " + std::to_string(key_count) + " keys.");
}