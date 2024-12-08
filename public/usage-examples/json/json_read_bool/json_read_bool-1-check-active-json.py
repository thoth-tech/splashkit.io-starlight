from splashkit import *

# Create a JSON object with a boolean value
json_obj = create_json()
json_set_bool(json_obj, "is_active", True)

# Read the boolean value from the JSON object
is_active = json_read_bool(json_obj, "is_active")

# Display the boolean value
write_line("Is Active: " + str(is_active))

# Free the JSON object
free_json(json_obj)