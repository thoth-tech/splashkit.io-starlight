#include <iostream>
#include "splashkit.h"

int main()
{
    timer myTimer = create_timer("my_timer");

    // Start the timer
    start_timer(myTimer);

    std::cout << "Timer started." << std::endl;
    return 0;
}
