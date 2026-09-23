#include "splashkit.h"

int main()
{
    // Check the audio system status
    if (audio_ready())
        write_line("Audio ready before open_audio: True");
    else
        write_line("Audio ready before open_audio: False");

    open_audio();

    // Confirm that the audio system is ready
    if (audio_ready())
        write_line("Audio ready after open_audio: True");
    else
        write_line("Audio ready after open_audio: False");

    close_audio();

    return 0;
}