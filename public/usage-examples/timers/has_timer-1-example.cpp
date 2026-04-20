#include "splashkit.h"

int main()
{
    string timer_name = "GameTimer";

    write_line("Does '" + timer_name + "' exist? " + (has_timer(timer_name) ? "true" : "false"));

    create_timer(timer_name);
    write_line("Created timer '" + timer_name + "'");

    write_line("Does '" + timer_name + "' exist? " + (has_timer(timer_name) ? "true" : "false"));

    free_timer(timer_name);
    write_line("Freed timer '" + timer_name + "'");

    write_line("Does '" + timer_name + "' exist? " + (has_timer(timer_name) ? "true" : "false"));

    return 0;
}
