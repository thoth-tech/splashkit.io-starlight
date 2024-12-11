#include "splashkit.h"

int main()
{
    // Create a single JSON object
    json json = create_json();

    // Add some data to the JSON object
    json_set_string(json, "name", "Breezy");
    write_line("Json1: " + json_to_string(json));

    // Free the JSON object
    write_line("Freeing the JSON object...");    
    free_json(json);

    // These should now display a warning of an invalid JSON object
    // Attempting to use json after this would be invalid    
    write_line("Json: " + json_to_string(json));

    write_line("The JSON object has been freed.");

    return 0;
}
