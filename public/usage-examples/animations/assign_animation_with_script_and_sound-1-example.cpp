#include "splashkit.h"

int main()
{
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");
    animation anim = create_animation();

    // Assign animation and play sound if set to do so
    assign_animation(anim, script, "WalkFront", true);
    write_line("Assigned WalkFront -> script identifier index: %d", animation_index(script, "WalkFront"));

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
