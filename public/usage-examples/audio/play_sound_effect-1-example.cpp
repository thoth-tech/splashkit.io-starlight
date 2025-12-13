#include "splashkit.h"

int main() 
{
    open_audio();

    // Load a short 'beep' or 'click' from the resources
    load_sound_effect("beep", "beep.ogg");

    // Get a named sound effect and play it
    sound_effect s = sound_effect_named("beep");
    play_sound_effect(s);

    // Small delay so it plays before the program exits
    delay(1200);

    close_audio();
    return 0;
}
