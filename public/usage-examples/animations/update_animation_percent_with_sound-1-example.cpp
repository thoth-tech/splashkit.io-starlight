#include "splashkit.h"

int main()
{
    animation_script script = load_animation_script("Resources/animations/kermit.txt");
    Animation anim = create_animation_from_script(script, "WalkFront");

    // Update with percent and allow sounds to trigger when frames change
    update_animation(anim, 0.25f, true);
    write_line("Animation updated (pct=0.25, with_sound=true).");

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
