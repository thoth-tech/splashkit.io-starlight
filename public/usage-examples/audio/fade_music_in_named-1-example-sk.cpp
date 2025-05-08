#include "splashkit.h"

int main()
{
    // Check if audio is ready to use
    if(!audio_ready())
    {
        open_audio();
    } 

    // Load music file
    load_music("adventure", "time_for_adventure.mp3");

    // Fade music in over 2 seconds
    fade_music_in("adventure", 5000);

    // Hold program for 10 seconds
    delay(10000);

    // Free resources
    free_all_music();
    return 0;
}