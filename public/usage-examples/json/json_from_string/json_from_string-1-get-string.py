from splashkit import *

# JSON string to be converted
json_string = "{\"name\": \"Breezy\", \"age\": 25}"

# Create a JSON object from the string
json_obj = json_from_string(json_string)

# Display the JSON object as a string
write_line("JSON from String: " + json_to_string(json_obj))

# Free the JSON object
free_json(json_obj)