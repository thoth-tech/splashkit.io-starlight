from splashkit import *

# Replace all occurrences of "foo" with "bar" in a sentence.
text = "foo is fun, and foo is useful."
updated = replace_all(text, "foo", "bar")

print("Original:", text)
print("Updated:", updated)