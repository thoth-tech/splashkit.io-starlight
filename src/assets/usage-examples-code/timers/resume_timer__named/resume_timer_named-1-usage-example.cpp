#include <iostream>
#include "splashkit.h"

int main()
{
    std::string timerName = "myTimer";
    timer myTimer = create_timer(timerName);

    for (int i = 4; i > 0; --i)
    {
        std::cout << i << " seconds remaining..." << std::endl;
        delay(1000);
        if (i == 3)
        {
            pause_timer(myTimer);
            std::cout << "Timer paused at 3 seconds." << std::endl;
        }
    }

    // Resume the timer
    std::cout << "Timer resumed..." << std::endl;
    resume_timer(myTimer);

    return 0;
}
