#include "splashkit.h"


int main()
{
    //Loads the music, we give it a name we can use to access it easily and then we add the file itself.
    load_music("music", "soulful_streets.mp3");
    //We then call which music file we want and how many milliseconds it should take to fade in to full volume. 
    fade_music_in("music", 4000);
    //Delay to hear the music
    delay(150000);

   
    return 0;


}