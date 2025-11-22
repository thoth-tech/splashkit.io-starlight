#include "splashkit.h"

int main()
{
    // Load resources
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");
    animation anim = create_animation(script, "WalkFront");

    // Usually animation_current_cell is used while animating; we just query it here
    int cell = animation_current_cell(anim);
    write_line("Current cell index: %d", cell);

    // Clean up
    free_animation(anim);
    free_animation_script(script);

    return 0;
}
