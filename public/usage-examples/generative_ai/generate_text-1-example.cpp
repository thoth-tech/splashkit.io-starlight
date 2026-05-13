#include "splashkit.h"

int main()
{
    // Define a prompt to send to the AI
    // Note: Requires a local AI model to be set up via SplashKit
    string prompt = "What is the capital of France?";
    write_line("Prompt: " + prompt);

    // Generate a text response from the AI
    string response = generate_text(prompt);
    write_line("Response: " + response);

    return 0;
}