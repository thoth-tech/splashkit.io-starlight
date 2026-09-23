#include "splashkit.h"

int main()
{
    conversation chat = create_conversation(QWEN3_0_6B_THINKING);

    string question = "What is 2 plus 2? Give only the answer.";

    write_line("Question: " + question);
    write_line("");

    // Send the question to the language model
    conversation_add_message(chat, question);

    bool thinking_started = false;
    bool thinking_finished = false;
    bool reply_heading_shown = false;

    while (conversation_is_replying(chat))
    {
        bool is_thinking = conversation_is_thinking(chat);

        // Display messages when the thinking state changes
        if (is_thinking && !thinking_started)
        {
            write_line("The model is thinking...");
            thinking_started = true;
        }

        if (!is_thinking && thinking_started && !thinking_finished)
        {
            write_line("Thinking done.");
            thinking_finished = true;
        }

        string reply_piece = conversation_get_reply_piece(chat);

        if (!is_thinking)
        {
            if (!reply_heading_shown)
            {
                write_line("");
                write_line("Final reply:");
                reply_heading_shown = true;
            }

            write(reply_piece);
        }
    }

    write_line("");
    write_line("");
    write_line("Reply complete.");

    free_conversation(chat);

    return 0;
}