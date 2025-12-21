#include "splashkit.h"

int main()
{
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");
    animation anim = create_animation(script, "WalkFront");

    write_line("Updating animation a few times...");
    for (int i = 0; i < 10; i++)
    {
        update_animation(anim);
    }

    write_line("Restarting animation...");
    restart_animation(anim);

    free_animation(anim);
    free_animation_script(script);
    return 0;
}
