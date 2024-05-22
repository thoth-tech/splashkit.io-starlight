#include <iostream>
#include "splashkit.h"

void start_timer(string name);

int main()
{
    timer myTimer = create_timer("MyTimer");

    // Start the timer
    start_timer(myTimer);

    delay(5000);

    double elapsedSeconds = timer_ticks(myTimer) / 1000.0;
    int elapsedSecondsInt = static_cast<int>(elapsedSeconds);
    std::cout << "Elapsed time: " << elapsedSecondsInt << " seconds" << std::endl;

    return 0;
}
