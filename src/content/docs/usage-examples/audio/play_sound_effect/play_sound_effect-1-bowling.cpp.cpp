#include "splashkit.h"


int main()
{
    //Loads the sound effect, we give it a name we can use to access it easily
    //and then we add the file itself.
    load_sound_effect("bowling", "bowling.wav");
    //We call the name we gave our sound effect and allow it play
    play_sound_effect("bowling");
    //Delay to hear the sound effect in whole
    delay(2000);
    
    return 0;


}