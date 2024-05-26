#include <iostream>
#include "splashkit.h"

void start_timer(string name); 

int main()
{
    // Create the timer
    timer myTimer = create_timer("MyTimer");

    start_timer(myTimer);

    double elapsedSeconds = timer_ticks(myTimer) / 1000.0;
    int elapsedSecondsInt = static_cast<int>(elapsedSeconds);
    std::cout << "Elapsed time: " << elapsedSecondsInt << " seconds" << std::endl;

    return 0;
}
