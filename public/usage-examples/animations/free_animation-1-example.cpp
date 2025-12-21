#include "splashkit.h"

int main()
{
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");
    animation anim = create_animation(script, "WalkFront");

    write_line("Freeing animation: " + animation_name(anim));
    free_animation(anim);

    free_animation_script(script);
    return 0;
}
