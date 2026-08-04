from splashkit import *

# Check if "42" is a number
result1 = is_number("42")
write_line("Is '42' a number? " + str(result1))

# Check if "3.14" is a number
result2 = is_number("3.14")
write_line("Is '3.14' a number? " + str(result2))

# Check if "hello" is a number
result3 = is_number("hello")
write_line("Is 'hello' a number? " + str(result3))

# Check if "12abc" is a number
result4 = is_number("12abc")
write_line("Is '12abc' a number? " + str(result4))
