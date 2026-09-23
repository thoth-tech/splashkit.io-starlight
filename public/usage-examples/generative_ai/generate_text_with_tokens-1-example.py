from splashkit import *

prompt = "Once upon a time, there was a robot who"

write_line(f"Prompt: {prompt}")

# Generate a continuation of the story, limited to 50 tokens
story = generate_text_with_tokens(prompt, 50)

write_line(f"Generated story: {story}")