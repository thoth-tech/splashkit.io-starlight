#include "splashkit.h"

int main()
{
    // Load an animation script by name (this expects a resource text file such as "kermit.txt")
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");

    // Count how many animations are in the script
    int count = animation_count(script);

    write_line("This script contains %d animations.", count);

    return 0;
}
