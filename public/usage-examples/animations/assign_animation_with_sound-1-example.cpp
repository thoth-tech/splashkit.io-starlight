#include "splashkit.h"

int main()
{
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");
    animation anim = create_animation(script, "WalkFront");

    // Later, switch to WalkFront and optionally play its starting-frame sound
    assign_animation(anim, "WalkFront", true);
    write_line("Assigned WalkFront with sound -> animation name: %s", animation_name(anim).c_str());

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
