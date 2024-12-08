#include "splashkit.h"

int main()
{
    // Create a JSON object with a float number
    json json_obj = create_json();
    json_set_number(json_obj, "temperature", 36);

    // Read the number value from the JSON object
    float temperature = json_read_number(json_obj, "temperature");

    // Display the number value
    write_line("Temperature: " + std::to_string(temperature));

    // Free the JSON object
    free_json(json_obj);

    return 0;
}
