#include "splashkit.h"
#include <iostream>

int main()
{
    timer myTimer = create_timer("MyTimer");
    start_timer(myTimer);
    delay(2000);

    // Pause the timer
    pause_timer(myTimer);

    delay(2000);
    double elapsedSeconds = timer_ticks(myTimer) / 1000.0;
    std::cout << "Elapsed time (after pausing): " << elapsedSeconds << " seconds" << std::endl;
    free_all_timers();

    return 0;
}
