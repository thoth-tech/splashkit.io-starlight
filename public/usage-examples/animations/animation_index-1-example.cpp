#include "splashkit.h"

int main()
{
    // Load the script and look up an animation index by name
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");
    int idx = animation_index(script, "WalkFront");
    write_line("Index of WalkFront: %d", idx);

    free_animation_script(script);
    return 0;
}
