#include "splashkit.h"

int main()
{
    // JSON string to be converted
    string json_string = "{\"name\": \"Breezy\", \"age\": 25}";

    // Create a JSON object from the string
    json json_obj = json_from_string(json_string);

    // Display the JSON object as a string
    write_line("JSON from String: " + json_to_string(json_obj));

    // Free the JSON object
    free_json(json_obj);

    return 0;
}
