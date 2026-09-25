#include "splashkit.h"

string get_full_reply(conversation conv)
{
    string reply = "";

    while (conversation_is_replying(conv))
    {
        reply += conversation_get_reply_piece(conv);
    }

    return reply;
}

int main()
{
    write_line("=== Splashwood Village Guide ===");
    write_line("");

    // Create one conversation so the NPC keeps the conversation context
    conversation guide = create_conversation();

    // Give the NPC its role and background
    string role_prompt =
        "You are Rowan, a friendly village guide in Splashwood Village. "
        "Stay in character and keep your answers short and helpful. "
        "Splashwood Village has a market in the village square, "
        "an old forest to the north, and an inn beside the fountain.";

    conversation_add_message(guide, role_prompt);

    // Consume the setup response before continuing
    get_full_reply(guide);

    string first_question = "Where can I buy supplies?";
    write_line("Player: " + first_question);

    conversation_add_message(guide, first_question);
    string first_reply = get_full_reply(guide);

    write_line("Rowan: " + first_reply);
    write_line("");

    // This question relies on the previous answer
    string second_question = "Where is that from here?";
    write_line("Player: " + second_question);

    conversation_add_message(guide, second_question);
    string second_reply = get_full_reply(guide);

    write_line("Rowan: " + second_reply);
    write_line("");

    string third_question = "Is there anywhere dangerous I should avoid?";
    write_line("Player: " + third_question);

    conversation_add_message(guide, third_question);
    string third_reply = get_full_reply(guide);

    write_line("Rowan: " + third_reply);

    free_conversation(guide);

    return 0;
}