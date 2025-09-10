#include "splashkit.h"

int main()
{
    //  Check if audio is ready to use
    if(!audio_ready())
    {
        open_audio();
    }   

    //  Load music file and start playback
    load_music("adventure", "time_for_adventure.mp3");
    play_music("adventure");

    //  Wait 5 second before fadeout
    delay(5000);

    //  Fade music out over 5 seconds
    fade_music_out(5000);

    //  Hold program for 10 seconds
    delay(10900);

    //  Free resources
    free_all_music();
}