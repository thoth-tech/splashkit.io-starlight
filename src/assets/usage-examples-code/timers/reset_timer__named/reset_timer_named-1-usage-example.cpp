#include <iostream>
#include "splashkit.h"
#include <chrono>
#include <thread>

void reset_timer(string name);

int main()
{
    std::string timerName = "myTimer";

    for (int i = 3; i > 0; --i)
    {
        std::cout << i << " seconds remaining..." << std::endl;
        std::this_thread::sleep_for(std::chrono::seconds(1)); // Wait for 1 second
    }

    // Reset the timer
    reset_timer(timerName);

    return 0;
}

void reset_timer(string name)
{
    std::cout << "Resetting timer: " << name << std::endl;
}
