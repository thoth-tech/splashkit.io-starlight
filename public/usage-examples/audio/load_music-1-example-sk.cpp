#include "splashkit.h"

int main()
{
    // Check if audio is ready to use
    if(!audio_ready())
    {
        open_audio();
    }   

    string music_names[] = {"adventure", "NoAdventure"};

    load_music("adventure", "time_for_adventure.mp3");

    for (int i = 0; i < sizeof(music_names)/sizeof(music_names[0]); i++)
    {
        // Check for successful load
        if (has_music(music_names[i]))
        {
            write_line(music_names[i] + " successfully loaded. Ready for playback.");
        }
        else
        {
            write_line("Failed to load " + music_names[i] + ", check file location.");
        }
    }
    // Cleanup
    free_all_music();    
    return 0;
}