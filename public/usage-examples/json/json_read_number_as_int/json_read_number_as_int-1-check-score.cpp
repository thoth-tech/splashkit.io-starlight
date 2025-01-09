#include "splashkit.h"

int main()
{
    // Create a JSON object with an integer value
    json json_obj = create_json();
    json_set_number(json_obj, "score", 100);

    // Read the integer value from the JSON object
    int score = json_read_number_as_int(json_obj, "score");

    // Display the integer value
    write_line("Score: " + std::to_string(score));

    // Free the JSON object
    free_json(json_obj);

    return 0;
}
