#include "splashkit.h"
#include <string>  // Include the string header

int main()
{
    int min = 1;
    int max = 10;
    int random_number = rnd(min, max);

    write_line("Random number between " + std::to_string(min) + " and " + std::to_string(max) + ": " + std::to_string(random_number));

    return 0;
}
