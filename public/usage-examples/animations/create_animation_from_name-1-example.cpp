#include "splashkit.h"

int main()
{
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");

    // Create an animation from the script using the named identifier "WalkFront"
    animation anim = create_animation(script, "WalkFront");
    write_line("Created animation -> name: %s", animation_name(anim).c_str());

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
