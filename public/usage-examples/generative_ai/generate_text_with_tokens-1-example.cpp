#include "splashkit.h"

int main()
{
    string prompt = "Once upon a time, there was a robot who";

    write_line("Prompt: " + prompt);

    // Generate a continuation of the story, limited to 50 tokens
    string story = generate_text(prompt, 50);

    write_line("Generated story: " + story);

    return 0;
}