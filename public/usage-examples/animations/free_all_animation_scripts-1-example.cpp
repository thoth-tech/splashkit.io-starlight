#include "splashkit.h"

int main()
{
    // Load an example script (WalkingScript -> kermit.txt) and then free all loaded animation scripts
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");

    // Free all animation scripts
    free_all_animation_scripts();
    write_line("All animation scripts freed.");

    // safe to still call free on script in this example context
    free_animation_script(script);
    return 0;
}
