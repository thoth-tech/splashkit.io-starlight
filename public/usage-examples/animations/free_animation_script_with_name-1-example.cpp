#include "splashkit.h"

int main()
{
    // Load the script under a named identifier
    load_animation_script_named("WalkingScript", "Resources/animations/kermit.txt");

    // Free the script by name when we're finished
    free_animation_script_with_name("WalkingScript");

    write_line("Animation script freed (by name).");
    return 0;
}
