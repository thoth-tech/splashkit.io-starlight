#include "splashkit.h"
#include <string> 

int main()
{
    timer my_timer = create_timer("MyTimer");

    start_timer(my_timer);

    delay(2000); 

    write_line("MyTimer: " + std::to_string(timer_ticks(my_timer)) + " ticks");

    // Free the timer
    free_timer(my_timer);

    write_line("The timer has been freed.");

    return 0;
}
