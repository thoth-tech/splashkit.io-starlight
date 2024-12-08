from splashkit import *

# Create a JSON object
json_obj = create_json()
json_set_string(json_obj, "name", "Breezy")
json_set_number_integer(json_obj, "age", 25)
json_set_bool(json_obj, "is_active", True)

# Convert the JSON object to a string
json_string = json_to_string(json_obj)

# Display the JSON string
write_line("JSON Object as String:")
write_line(json_string)

# Free the JSON object
free_json(json_obj)