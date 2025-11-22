#include "splashkit.h"

int main()
{
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");

    // Create an animation from index 0, play starting-frame sound if present
    animation anim = create_animation(script, 0, true);
    write_line("Created animation from index 0 -> name: %s", animation_name(anim).c_str());

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
