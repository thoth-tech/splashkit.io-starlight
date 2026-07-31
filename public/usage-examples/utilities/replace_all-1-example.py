from splashkit import *

text = "I like cats. cats are great. I have two cats."
write_line("Original: " + text)

# Replace all occurrences of "cats" with "dogs"
result = replace_all(text, "cats", "dogs")
write_line("Replaced: " + result)

greeting = "Hello World! Hello Everyone!"
write_line("\nOriginal: " + greeting)

# Replace all occurrences of "Hello" with "Hi"
new_greeting = replace_all(greeting, "Hello", "Hi")
write_line("Replaced: " + new_greeting)
