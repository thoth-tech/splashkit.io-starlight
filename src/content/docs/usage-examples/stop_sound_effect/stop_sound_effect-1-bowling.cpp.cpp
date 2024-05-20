#include "splashkit.h"


int main()
{
    //Loads the sound effect, we give it a name we can use to access it easily
    //and then we add the file itself.
    load_sound_effect("bowling", "bowling.wav");
    //We call the name we gave our sound effect and allow it play
    play_sound_effect("bowling");
    //Add a small delay to ensure a portion of the sound effect plays
    delay(100);
    //We can stop the sound effect from playing by calling the following:
    stop_sound_effect("bowling");
    //Delay to keep the window open
    delay(2000);
    
    return 0;


}