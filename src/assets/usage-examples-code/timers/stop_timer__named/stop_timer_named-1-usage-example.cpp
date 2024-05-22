#include <iostream>
#include "splashkit.h"

int main()
{
    timer myTimer = create_timer("MyTimer");
    start_timer(myTimer);
    delay(5000);
    double elapsedSeconds = timer_ticks(myTimer) / 1000.0;

    // Stop the timer
    stop_timer(myTimer);

    int elapsedSecondsInt = static_cast<int>(elapsedSeconds);
    std::cout << "The timer stopped at " << elapsedSecondsInt << " seconds" << std::endl;

    return 0;
}
