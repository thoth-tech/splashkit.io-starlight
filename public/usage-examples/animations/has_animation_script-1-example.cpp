#include "splashkit.h"

int main()
{
    // Load script so frames are present
    load_animation_script_named("WalkingScript", "Resources/animations/kermit.txt");

    // Check globally for the frames for the named animation
    bool present = has_animation_script("WalkFront");
    write_line(present ? "Has animation script: true" : "Has animation script: false");

    // cleanup via name
    free_animation_script_with_name("WalkingScript");
    return 0;
}
