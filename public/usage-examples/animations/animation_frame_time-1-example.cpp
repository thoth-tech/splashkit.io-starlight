#include "splashkit.h"

int main()
{
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");
    animation anim = create_animation(script, "WalkFront");

    write_line("Frame time in current frame:");

    for (int i = 0; i < 5; i++)
    {
        update_animation(anim);
        delay(200);

        write_line("Frame time: " + std::to_string(animation_frame_time(anim)));
    }

    free_animation(anim);
    free_animation_script(script);

    return 0;
}
