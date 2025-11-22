#include "splashkit.h"

int main()
{
    animation_script script = load_animation_script("ExplosionScript", "explosion.txt");
    animation anim = create_animation(script, "explosion");

    // In a real update loop you'd call update_animation(anim, dt) each frame and then query frame time
    float time = animation_frame_time(anim);
    write_line("Time spent in current frame: %f", time);

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
