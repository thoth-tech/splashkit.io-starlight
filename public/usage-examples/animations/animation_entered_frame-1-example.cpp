#include "splashkit.h"

int main()
{
    // Load the explosion script and create the animation
    animation_script script = load_animation_script("ExplosionScript", "explosion.txt");
    animation anim = create_animation(script, "explosion");

    // In a game loop you'd update the animation and then check whether you entered a new frame.
    // For this example we just query the function once to demonstrate usage.
    bool entered = animation_entered_frame(anim);
    write_line("Animation entered frame? %s", entered ? "true" : "false");

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
