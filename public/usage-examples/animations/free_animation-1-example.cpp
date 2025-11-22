#include "splashkit.h"

int main()
{
    // Load the animation resource from a script and create an Animation
    animation_script script = load_animation_script("Resources/animations/kermit.txt");
    Animation anim = create_animation_from_script(script, "WalkFront");

    // When we're done using the animation we must free it to dispose resources.
    free_animation(anim);

    write_line("Animation freed.");

    // Also free the script reference in this example.
    free_animation_script(script);
    return 0;
}
