from splashkit import *

prompt = "What is AI?"

write_line(f"Prompt: {prompt}")
write_line("")

# Create a conversation using the Qwen3 model, and send the prompt to it
write_line("Asking Qwen3 1.7B Instruct...")
qwen_chat = create_conversation_with_model(QWEN3_1_7B_INSTRUCT)
conversation_add_message(qwen_chat, prompt)
qwen_reply = conversation_get_reply(qwen_chat)
write_line(f"Qwen3 reply: {qwen_reply}")
write_line("")

# Create a conversation using the Gemma3 model, and send the same prompt to it
write_line("Asking Gemma3 1B Instruct...")
gemma_chat = create_conversation_with_model(GEMMA3_1B_INSTRUCT)
conversation_add_message(gemma_chat, prompt)
gemma_reply = conversation_get_reply(gemma_chat)
write_line(f"Gemma3 reply: {gemma_reply}")

# Release the resources used by both conversations
free_conversation(qwen_chat)
free_conversation(gemma_chat)