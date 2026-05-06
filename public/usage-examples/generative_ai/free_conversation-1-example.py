from splashkit import *

# Create three conversation instances
conv1 = create_conversation()
conv2 = create_conversation()
conv3 = create_conversation()

write_line("Created 3 conversations.")

# Free individual conversations
free_conversation(conv1)
write_line("Freed conversation 1.")

free_conversation(conv2)
write_line("Freed conversation 2.")

# Free all remaining conversations at once
free_all_conversations()
write_line("Freed all remaining conversations.")
write_line("All AI resources have been released.")
