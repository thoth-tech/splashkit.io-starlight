#include "splashkit.h"

int main()
{
    // Create a JSON object 
    json json_obj = create_json();
    json_set_number(json_obj, "grade", 100);

    // Read the integer value
    int grade = json_read_number_as_int(json_obj, "grade");

    // Display the integer value
    write_line("Grade: " + std::to_string(grade));

    return 0;
}