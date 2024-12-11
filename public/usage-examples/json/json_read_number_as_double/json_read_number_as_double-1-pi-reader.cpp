#include "splashkit.h"

int main()
{
    // Create a JSON object with a double number
    json json_obj = create_json();
    json_set_number(json_obj, "pi", 3.14159);

    // Read the double value from the JSON object
    double pi = json_read_number_as_double(json_obj, "pi");

    // Display the double value
    write_line("Pi: " + std::to_string(pi));

    // Free the JSON object
    free_json(json_obj);

    return 0;
}
