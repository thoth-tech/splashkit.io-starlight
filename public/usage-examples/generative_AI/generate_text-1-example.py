from splashkit import *

# Prompt sent to the AI model
prompt = "Give me a fun fact about space."

# Let the user know the AI response is being generated
write_line("Generating AI response...")
write_line("")

# Generate a text response from the AI
response = generate_text(prompt)

# Display the prompt and AI response
write_line("Prompt: " + prompt)
write_line("")
write_line("AI Response:")
write_line(response)
