#include "splashkit.h"


int main()
{
    //Loads the music, we give it a name we can use to access it easily and then we add the file itself.
    load_music("music", "soulful_streets.mp3");
    //We then call which music file we want and how many milliseconds it should take to fade in to full volume. 
    fade_music_in("music", 3000);
    delay(4000);
    //We then can fade the music out and, again, determine how many milliseconds it should take to fade out. 
    fade_music_out(3000);
    delay(4000);
    return 0;


}