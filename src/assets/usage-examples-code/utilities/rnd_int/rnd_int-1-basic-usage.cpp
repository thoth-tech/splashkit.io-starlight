#include "splashkit.h"
#include <string>  // Include the string header

int main()
{
    int upper_bound = 10;
    int random_number = rnd(upper_bound);

    write_line("Random number between 0 and " + std::to_string(upper_bound) + ": " + std::to_string(random_number));

    return 0;
}
