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
    pause_music();
    delay(2000);
    //Sets the volume of the music to 20%
    set_music_volume(0.2);
    //Resumes playing the music
    resume_music();
    delay(10000);
   
    return 0;


}