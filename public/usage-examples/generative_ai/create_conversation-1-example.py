from splashkit import *

# Create a new conversation using the default language model
chat = create_conversation()

prompt = "What is SplashKit?"
write_line(f"Prompt: {prompt}")

# Add the prompt to the conversation
conversation_add_message(chat, prompt)

write_line("Reply:")

# Retrieve and display the reply one piece at a time
while conversation_is_replying(chat):
    write(conversation_get_reply_piece(chat))

write_line("")
write_line("Reply complete!")

# Release the conversation resources
free_conversation(chat)