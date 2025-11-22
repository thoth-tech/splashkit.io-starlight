#include "splashkit.h"

int main()
{
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");
    animation anim = create_animation();

    // assign by index — 0 for first identifier in the script
    assign_animation(anim, script, 0);
    write_line("Assigned animation -> script identifier index: %d", 0);

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
