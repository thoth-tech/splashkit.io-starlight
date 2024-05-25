#include "splashkit.h"
#include <string>  // Include the string header

int main()
{
    write_line("Start delay...");
    
    int milliseconds = 2000; // Delay for 2000 milliseconds (2 seconds)
    delay(milliseconds);

    write_line("End delay after " + std::to_string(milliseconds) + " milliseconds.");

    return 0;
}
