#include "splashkit.h"
#include <iostream>

int main()
{
    animation_script script = load_animation_script("Resources/animations/kermit.txt");

    bool found = has_animation_named(script, "WalkFront");
    if(found) {
        write_line("Has animation named: true");
    } else {
        write_line("Has animation named: false");
    }

    free_animation_script(script);
    return 0;
}
