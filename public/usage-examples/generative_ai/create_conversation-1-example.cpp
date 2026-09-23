#include "splashkit.h"

int main()
{
    // Create a new conversation using the default language model
    conversation chat = create_conversation();

    string prompt = "What is SplashKit?";
    write_line("Prompt: " + prompt);

    // Add the prompt to the conversation
    conversation_add_message(chat, prompt);

    write_line("Reply:");

    // Retrieve and display the reply one piece at a time
    while (conversation_is_replying(chat))
    {
        write(conversation_get_reply_piece(chat));
    }

    write_line("");
    write_line("Reply complete!");

    // Release the conversation resources
    free_conversation(chat);

    return 0;
}