#include <iostream>
#include "splashkit.h"

int main()
{
    timer myTimer = create_timer("my_timer");
    start_timer(myTimer);
    std::cout << "Timer started." << std::endl;
    delay(2000); 

    // Stop the timer
    stop_timer(myTimer);
    std::cout << "Timer stopped." << std::endl;

    delay(3000); 
    reset_timer(myTimer);
    std::cout << "Timer reset." << std::endl;
    delay(1000);
    start_timer(myTimer);
    std::cout << "Timer restarted." << std::endl;
    delay(500); 
    free_timer(myTimer);
    std::cout << "Timer resource freed." << std::endl;

    return 0;
}
