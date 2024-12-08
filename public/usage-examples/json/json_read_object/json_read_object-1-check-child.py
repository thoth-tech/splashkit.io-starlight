from splashkit import *

# Create a parent JSON object with a nested JSON object
parent_json = create_json()
child_json = create_json()
json_set_string(child_json, "name", "Breezy")
json_set_object(parent_json, "user", child_json)

# Read the nested JSON object
user_json = json_read_object(parent_json, "user")

# Display a value from the nested JSON object
write_line("User Name: " + json_read_string(user_json, "name"))

# Free the JSON objects
free_json(parent_json)
free_json(child_json)