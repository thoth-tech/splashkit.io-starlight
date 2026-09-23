from splashkit import *


chat = create_conversation_with_model(
    LanguageModel.qwen3_0_6b_thinking
)

question = "What is 2 plus 2? Give a short answer."

write_line("Question: " + question)
write_line("")

# Send the question to the language model
conversation_add_message(chat, question)

thinking_started = False
thinking_finished = False
reply_heading_shown = False

while conversation_is_replying(chat):
    is_thinking = conversation_is_thinking(chat)

    # Display messages when the thinking state changes
    if is_thinking and not thinking_started:
        write_line("The model is thinking...")
        thinking_started = True

    if not is_thinking and thinking_started and not thinking_finished:
        write_line("Thinking done.")
        thinking_finished = True

    reply_piece = conversation_get_reply_piece(chat)

    if not is_thinking:
        if not reply_heading_shown:
            write_line("")
            write_line("Final reply:")
            reply_heading_shown = True

        write(reply_piece)

write_line("")
write_line("")
write_line("Reply complete.")

free_conversation(chat)