#include "splashkit.h"

int main()
{
    // JSON string to convert to a JSON object
    string json_string = "{\"name\": \"Breezy\", \"age\": 25}";

    // Create a JSON object from the string
    json json_obj = create_json(json_string);

    // Read and display values from the JSON object
    write_line("Name: " + json_read_string(json_obj, "name"));
    write_line("Age: " + std::to_string(json_read_number(json_obj, "age")));

    return 0;
}
