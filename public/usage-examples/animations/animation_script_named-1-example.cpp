#include "splashkit.h"

int main()
{
    // Retrieve a named script previously registered/known by name
    animation_script script = animation_script_named("WalkingScript");
    string name = animation_script_name(script);
    write_line("Named script loaded: %s", name.c_str());

    free_animation_script(script);
    return 0;
}
