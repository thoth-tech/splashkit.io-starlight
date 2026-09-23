from splashkit import *

# Create a conversation using the default language model
chat = create_conversation()

write_line("Sending message: \"Explain what AI is in one sentence.\"")
write_line("")

# Add a user message — the model begins replying immediately
conversation_add_message(chat, "Explain what AI is in one sentence.")

# Show a thinking indicator while the model is processing
if conversation_is_thinking(chat):
    write("Thinking")

while conversation_is_thinking(chat):
    write(".")
    delay(200)

# Move to a new line after thinking dots
write_line("")

write("AI: ")

# Stream the reply one piece at a time as it generates
while conversation_is_replying(chat):
    # Retrieve the next small piece of the reply (generally one word)
    piece = conversation_get_reply_piece(chat)
    write(piece)

write_line("")
write_line("")
write_line("Response complete.")

# Release conversation resources
free_conversation(chat)
