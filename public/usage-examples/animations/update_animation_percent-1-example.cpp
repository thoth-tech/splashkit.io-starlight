#include "splashkit.h"

int main()
{
    animation_script script = load_animation_script("Resources/animations/kermit.txt");
    Animation anim = create_animation_from_script(script, "WalkFront");

    // Advance the animation time by 0.25
    update_animation(anim, 0.25f);
    write_line("Animation updated (pct=0.25).");

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
