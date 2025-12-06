#include "splashkit.h"

int main()
{
    // Load the explosion script and create the animation for the explosion id
    animation_script script = load_animation_script("ExplosionScript", "explosion.txt");
    animation anim = create_animation(script, "explosion");

    // Check if the animation has ended (e.g. non-looping explosion)
    bool ended = animation_ended(anim);
    write_line("Animation ended? %s", ended ? "true" : "false");

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
