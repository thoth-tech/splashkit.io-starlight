#include "splashkit.h"

int main()
{
    // Load script and create an animation already using it
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");
    animation anim = create_animation(script, "WalkFront");

    // Later in the program we switch to another named animation within the same script
    assign_animation(anim, "Dance");
    write_line("Animation assigned to: %s", animation_name(anim).c_str());

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
