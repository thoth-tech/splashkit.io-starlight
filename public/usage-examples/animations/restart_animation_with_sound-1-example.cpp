#include "splashkit.h"

int main()
{
    // Load script and create animation
    animation_script script = load_animation_script("Resources/animations/kermit.txt");
    Animation anim = create_animation_from_script(script, "WalkFront");

    // Restart and play sound if the first frame defines one
    restart_animation_with_sound(anim, true);
    write_line("Animation restarted (with_sound=true).");

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
