# Usage Example for: https://splashkit.io/api/text/#is-integer
# Goal: I am reading text and I am printing whether each line is an integer.
# Why: I am showing how to use an integer check in a simple REPL.
# Controls: I am typing q or quit to exit.

def is_integer_text(s: str) -> bool:
    # I am checking if s is an integer (leading +/- allowed)
    if not s:
        return False
    if s[0] in '+-':
        s = s[1:]
    return s.isdigit()

print("Is Integer Checker (Python)")
print("Type a value and press Enter. Type q to quit.")

while True:
    try:
        text = input("> ")
    except EOFError:
        break

    if text == "q" or text == "quit":
        break

    if is_integer_text(text):
        print("Integer")
    else:
        print("Not integer")

print("Bye")