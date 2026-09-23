from splashkit import *


chat = create_conversation()

question = "Explain what a computer network is in one short paragraph."

write_line("Question:")
write_line(question)
write_line("")
write_line("Status: AI is replying...")
write_line("")
write_line("AI reply:")

conversation_add_message(chat, question)

while conversation_is_replying(chat):
    write(conversation_get_reply_piece(chat))

write_line("")
write_line("")
write_line("Status: Reply complete.")

free_conversation(chat)