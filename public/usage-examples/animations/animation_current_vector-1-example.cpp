#include "splashkit.h"

int main()
{
    // Load the animation script containing vector annotations (explosion.txt)
    animation_script script = load_animation_script("ExplosionScript", "explosion.txt");
    animation anim = create_animation(script, "Explode");

    // In a running animation you can query the current frame's vector
    vector_2d v = animation_current_vector(anim);
    write_line("Current vector: x=%f y=%f", v.x, v.y);

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
