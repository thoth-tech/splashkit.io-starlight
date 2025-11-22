#include "splashkit.h"

int main()
{
    // Load the animation script (this loads frame data)
    animation_script script = load_animation_script("Resources/animations/kermit.txt");

    // Free the script's loaded frame data when it's no longer required
    free_animation_script(script);

    write_line("Animation script freed.");
    return 0;
}
