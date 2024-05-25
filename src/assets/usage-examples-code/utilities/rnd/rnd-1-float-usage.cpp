#include "splashkit.h"
#include <string>  // Include the string header

int main()
{
    float random_float = rnd();

    write_line("Random float between 0 and 1: " + std::to_string(random_float));

    return 0;
}
