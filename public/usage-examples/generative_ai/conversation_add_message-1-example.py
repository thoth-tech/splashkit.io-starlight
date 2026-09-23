from splashkit import *


def ask_npc(conv, message):
    conversation_add_message(conv, message)

    # Wait until the model begins generating its response
    while not conversation_is_replying(conv):
        delay(10)

    return conversation_get_reply(conv)


write_line("=== Splashwood Village Guide ===")
write_line("")

guide = create_conversation()

# Establish Rowan's role
role_prompt = (
    "You are Rowan, a friendly village guide in Splashwood Village. "
    "Stay in character and keep your answers short and helpful. "
    "Splashwood Village has a market in the village square, "
    "an old forest to the north, and an inn beside the fountain."
)

ask_npc(guide, role_prompt)

first_question = "Where can I buy supplies?"
write_line("Player: " + first_question)
first_reply = ask_npc(guide, first_question)
write_line("Rowan: " + first_reply)
write_line("")

second_question = "Where is that from here?"
write_line("Player: " + second_question)
second_reply = ask_npc(guide, second_question)
write_line("Rowan: " + second_reply)
write_line("")

third_question = "Is there anywhere dangerous I should avoid?"
write_line("Player: " + third_question)
third_reply = ask_npc(guide, third_question)
write_line("Rowan: " + third_reply)

free_conversation(guide)