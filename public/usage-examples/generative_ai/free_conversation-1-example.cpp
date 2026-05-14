#include "splashkit.h"

int main()
{
    // Create a conversation instance
    conversation conv = create_conversation();
    write_line("Conversation created.");

    // Free the conversation to release its resources
    free_conversation(conv);
    write_line("Conversation freed successfully.");

    return 0;
}