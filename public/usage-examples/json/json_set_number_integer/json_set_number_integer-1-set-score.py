from splashkit import *

# Create a JSON object
json_obj = create_json()

# Set an integer value
json_set_number_integer(json_obj, "score", 100)

# Display the JSON object
write_line("JSON: " + json_to_string(json_obj))

# Free the JSON object
free_json(json_obj)