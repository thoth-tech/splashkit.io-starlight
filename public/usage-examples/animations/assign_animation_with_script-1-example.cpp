#include "splashkit.h"

int main()
{
    // Create an animation (conceptual) and assign it to a named script
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");
    animation anim = create_animation();

    assign_animation(anim, script, "WalkFront");
    write_line("Animation assigned to script starting at index: %d", animation_index(script, "WalkFront"));

    free_animation_script(script);
    free_animation(anim);
    return 0;
}
