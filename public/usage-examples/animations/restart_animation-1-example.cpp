#include "splashkit.h"

int main()
{
    // Create animation from script and then restart it
    animation_script script = load_animation_script("Resources/animations/kermit.txt");
    Animation anim = create_animation_from_script(script, "WalkFront");

    // Simulate some progress (in real app you'd update frames)
    // Restart the animation back to its first frame
    restart_animation(anim);
    write_line("Animation restarted.");

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
