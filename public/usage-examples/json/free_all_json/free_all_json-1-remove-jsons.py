from splashkit import *

# Create multiple JSON objects
json1 = create_json()
json2 = create_json()

# Add some data to the JSON objects
json_set_string(json1, "name", "Breezy")
json_set_number_integer(json2, "age", 25)

write_line("Json1: " + json_to_string(json1))
write_line("Json2: " + json_to_string(json2))

# Free all JSON objects
write_line("Freeing all JSON objects...")
free_all_json()

# These should now display a warning of an invalid JSON object
# Attempting to use json1 or json2 after this would be invalid
write_line("Json1: " + json_to_string(json1))
write_line("Json2: " + json_to_string(json2))

write_line("All JSON objects have been freed.")