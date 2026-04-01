from splashkit import *

sentence = "foo fighters say foo is fun"
updated_sentence = replace_all(sentence, "foo", "bar")

write_line("Original: " + sentence)
write_line("Updated: " + updated_sentence)
