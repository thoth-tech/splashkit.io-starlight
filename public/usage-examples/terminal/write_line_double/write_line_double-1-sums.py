from splashkit import *

write_line("Demonstrating write_line(double):")

# Perform some calculations
value1 = 3.14159  # Example value: pi
value2 = 2.71828  # Example value: e
sum_value = value1 + value2
product = value1 * value2
difference = value1 - value2
quotient = value1 / value2

# Output the results using write_line_double
write_line("The values used are:")
write_line_double(value1)  # Writing the first double value
write_line_double(value2)  # Writing the second double value

write_line("Their sum is:")
write_line_double(sum_value)  # Writing the sum

write_line("Their product is:")
write_line_double(product)  # Writing the product

write_line("Their difference is:")
write_line_double(difference)  # Writing the difference

write_line("Their quotient is:")
write_line_double(quotient)  # Writing the quotient

write_line("End of demonstration.")