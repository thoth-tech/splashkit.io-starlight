#include "splashkit.h"

using namespace std;

int main()
{
    conversation chat = create_conversation();

    string question = "Explain what a computer network is in one short paragraph.";

    write_line("Question:");
    write_line(question);
    write_line("");
    write_line("Status: AI is replying...");
    write_line("");
    write_line("AI reply:");

    conversation_add_message(chat, question);

    while (conversation_is_replying(chat))
    {
        write(conversation_get_reply_piece(chat));
    }

    write_line("");
    write_line("");
    write_line("Status: Reply complete.");

    free_conversation(chat);

    return 0;
}