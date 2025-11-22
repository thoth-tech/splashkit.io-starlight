#include "splashkit.h"

int main()
{
    animation_script script = load_animation_script("Resources/animations/kermit.txt");
    Animation anim = create_animation_from_script(script, "WalkFront");

    // Update the animation using default update (no explicit percent)
    update_animation(anim);
    write_line("Animation updated (default update).");

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
