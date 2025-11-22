#include "splashkit.h"

int main()
{
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");

    // Create an animation by name and play the starting-frame sound if requested
    animation anim = create_animation(script, "WalkFront", true);
    write_line("Created animation by name -> animation: %s", animation_name(anim).c_str());

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
