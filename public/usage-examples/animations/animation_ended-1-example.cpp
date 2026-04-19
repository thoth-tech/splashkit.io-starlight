#include "splashkit.h"

int main()
{
    animation_script script = load_animation_script("ExplosionScript", "explosion.txt");
    animation anim = create_animation(script, "explosion");

    write_line("Has animation ended?");
    write_line(animation_ended(anim) ? "true" : "false");

    for (int i = 0; i < 10; i++)
    {
        update_animation(anim);
        delay(100);

        write_line("Current cell: " + std::to_string(animation_current_cell(anim)));

        if (animation_ended(anim))
        {
            write_line("Animation ended!");
            break;
        }
    }

    free_animation(anim);
    free_animation_script(script);

    return 0;
}
