from splashkit import *

# Create a JSON object with a double number
json_obj = create_json()
json_set_number_double(json_obj, "pi", 3.14159)

# Read the double value from the JSON object
pi = json_read_number_as_double(json_obj, "pi")

# Display the double value
write_line("Pi: " + str(pi))

# Free the JSON object
free_json(json_obj)