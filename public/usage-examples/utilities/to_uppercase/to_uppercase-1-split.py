from splashkit import *

text = "Monkeys love bananas, but penguins prefer ice cream sundaes."

# Split the string into words
words = text.split(' ')
result = ""

# Alternate words between lowercase and uppercase
for i in range(len(words)):
    if i % 2 == 0:
        # Convert to uppercase
        result += to_uppercase(words[i])
    else:
        # Convert to lowercase
        result += to_lowercase(words[i])

    if i < len(words) - 1:
        result += " "  # Add space between words

write_line(f"Original text: {text}")
write_line(f"Modified text: {result}")
