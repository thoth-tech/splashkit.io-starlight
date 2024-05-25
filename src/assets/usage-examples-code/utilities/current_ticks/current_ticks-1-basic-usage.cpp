#include "splashkit.h"
#include <string>  // Include the string header

int main()
{
    // Start a timer to demonstrate the use of current_ticks
    timer my_timer = create_timer("My Timer");
    start_timer(my_timer);

    // Wait for a short duration
    delay(1000); // Delay for 1 second (1000 milliseconds)

    unsigned int ticks = current_ticks();

    write_line("Milliseconds since the program started: " + std::to_string(ticks));

    return 0;
}
