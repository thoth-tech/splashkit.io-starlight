#include "splashkit.h"
#include <iostream>

int main()
{
    timer myTimer = create_timer("MyTimer");

    // Check if SplashKit has a timer named "MyTimer"
    bool hasMyTimer = has_timer("MyTimer");

    std::cout << "SplashKit have a timer named 'MyTimer'? " << std::boolalpha << hasMyTimer << std::endl;
    free_all_timers();

    return 0;
}
