#include "splashkit.h"

int main()
{
    write_line("Loading animation script...");

    animation_script script = load_animation_script("WalkingScript", "kermit.txt");

    write_line("Script name:");
    write_line(animation_script_name(script));

    write_line("Animations in script: " + std::to_string(animation_count(script)));

    free_animation_script(script);
    return 0;
}
