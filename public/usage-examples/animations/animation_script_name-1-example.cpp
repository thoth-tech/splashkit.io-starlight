#include "splashkit.h"

int main()
{
    animation_script script = load_animation_script("WalkingScript", "kermit.txt");
    string name = animation_script_name(script);
    write_line("Script name: %s", name.c_str());

    free_animation_script(script);
    return 0;
}
