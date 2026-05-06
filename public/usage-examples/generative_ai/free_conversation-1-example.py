from splashkit import *

# Create a conversation instance
conv = create_conversation()
write_line("Conversation created.")

# Free the conversation to release its resources
free_conversation(conv)
write_line("Conversation freed successfully.")