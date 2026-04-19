#include "splashkit.h"

int main()
{
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");

    write_line("Freeing animation script: " + animation_script_name(script));
    free_animation_script(script);

    return 0;
}
