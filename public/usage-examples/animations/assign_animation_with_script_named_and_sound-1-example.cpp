#include "splashkit.h"

int main()
{
    animation anim = create_animation();
    animation_script script = animation_script_named("WalkingScript");

    // Assign an animation by script name and play sound if requested
    assign_animation(anim, "WalkingScript", "WalkFront", true);
    write_line("Assigned WalkFront -> script name: %s", animation_script_name(script).c_str());

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
