#include "splashkit.h"


int main()
{
    //Loads the music, we give it a name we can use to access it easily and then we add the file itself.
    load_music("music", "soulful_streets.mp3");
    //We call the name we gave our music file and allow it play 
    play_music("music");
    //Delay to hear the music
    delay(2000);
    //Stops the music
    stop_music();
    delay(2000);
   
    return 0;


}