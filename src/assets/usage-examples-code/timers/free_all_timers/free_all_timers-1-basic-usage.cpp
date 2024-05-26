#include "splashkit.h"
#include <string> // Include this to use std::to_string

int main()
{
    timer timer1 = create_timer("Timer1");
    timer timer2 = create_timer("Timer2");

    start_timer(timer1);
    start_timer(timer2);

    delay(2000); 

    write_line("Timer1: " + std::to_string(timer_ticks(timer1)) + " ticks");
    write_line("Timer2: " + std::to_string(timer_ticks(timer2)) + " ticks");

    // Free all timers
    free_all_timers();

    write_line("All timers have been freed.");

    return 0;
}
