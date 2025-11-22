#include "splashkit.h"

int main()
{
    // Look up the script by name and assign an animation to WalkFront
    animation_anim anim = create_animation();
    animation_script script = animation_script_named("WalkingScript");

    assign_animation(anim, script, "WalkFront");
    write_line("Assigned WalkFront -> script name: %s", animation_script_name(script).c_str());

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
