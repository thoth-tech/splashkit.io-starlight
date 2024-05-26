#include <iostream>
#include <splashkit.h>

int main()
{
    timer myTimer = create_timer("my_timer");
    start_timer(myTimer);
    std::cout << "Timer started\n";
    pause_timer(myTimer);
    std::cout << "Timer paused\n";

    // Resume the paused timer
    resume_timer(myTimer);
    std::cout << "Timer resumed\n";

    return 0;
}
