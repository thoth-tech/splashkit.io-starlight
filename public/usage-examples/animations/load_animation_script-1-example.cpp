#include "splashkit.h"

int main()
{
    // Load an animation script and register it under a name
    animation_script script = load_animation_script("WalkingScript", "Resources/animations/kermit.txt");

    // Confirm by printing the script name (in real code you'd access its data)
    write_line("Loaded animation script -> name: WalkingScript");

    // When done, free the script
    free_animation_script(script);

    return 0;
}
