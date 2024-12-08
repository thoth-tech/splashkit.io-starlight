from splashkit import *

# Create a JSON object
json_obj = create_json()

# Set a float value
json_set_number_float(json_obj, "temperature", 36.6)

# Display the JSON object
write_line("JSON: " + json_to_string(json_obj))

# Free the JSON object
free_json(json_obj)