#include "splashkit.h"

int main()
{
    write_line("Progress Bar Simulation:");
    write("Loading: [");

    for (int i = 0; i <= 15; i++) // Simulate progress in 15 steps
    {
        delay(150); // Pause for 150 milliseconds
        write("="); // Append to the progress bar
    }

    write("] Complete!\n");
}
