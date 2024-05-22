#include <iostream>
#include "splashkit.h"

void pause_timer(string name);

int main()
{
    timer myTimer = create_timer("myTimer");
    start_timer(myTimer);

    delay(5000); 

    pause_timer(myTimer);

    unsigned long long ticks = timer_ticks(myTimer);
    int seconds = static_cast<int>(ticks / 1000);

    std::cout << "Timer paused after " << seconds << " seconds" << std::endl;

    return 0;
}
