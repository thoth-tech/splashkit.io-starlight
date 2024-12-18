from splashkit import *

# Create a JSON object with a float number
json_obj = create_json()
json_set_number_integer(json_obj, "temperature", 36)

# Read the number value from the JSON object
temperature = json_read_number(json_obj, "temperature")

# Display the number value
write_line("Temperature: " + str(temperature))

# Free the JSON object
free_json(json_obj)