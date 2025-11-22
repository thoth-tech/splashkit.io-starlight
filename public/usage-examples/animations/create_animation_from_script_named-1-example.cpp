#include "splashkit.h"

int main()
{
    // Create an animation from a named script (WalkingScript -> kermit.txt)
    animation anim = create_animation("WalkingScript", "WalkFront");
    write_line("Created animation from script name -> name: %s", animation_name(anim).c_str());

    free_animation(anim);
    return 0;
}
