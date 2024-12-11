from splashkit import *

# Create a JSON object
json_obj = create_json()

# Add some data to the JSON object
json_set_string(json_obj, "name", "Breezy")
json_set_number_integer(json_obj, "age", 25)
json_set_string(json_obj, "hobby", "Coding")

# Count the keys in the JSON object
key_count = json_count_keys(json_obj)

# Display the count of keys
write_line("The JSON object has " + str(key_count) + " keys.")

# Free the JSON object
free_json(json_obj)