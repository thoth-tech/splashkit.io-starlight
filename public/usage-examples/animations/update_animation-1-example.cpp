#include "splashkit.h"

int main()
{
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");
    animation anim = create_animation(script, "WalkFront");

    write_line("Updating animation...");

    for (int i = 0; i < 5; i++)
    {
        update_animation(anim);
        delay(100);

        write_line("Current cell: " + std::to_string(animation_current_cell(anim)));
    }

    free_animation(anim);
    free_animation_script(script);

    return 0;
}
