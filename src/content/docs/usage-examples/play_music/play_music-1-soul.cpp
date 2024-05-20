#include "splashkit.h"


int main()
{
    //Loads the music, we give it a name we can use to access it easily and then we add the file itself.
    load_music("music", "soulful_streets.mp3");
    //We call the name we gave our music file and allow it play
    play_music("music");
    //Add a delay to ensure the music has enough time to play
    delay(150000);
   
    return 0;


}