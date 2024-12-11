from splashkit import *

# Create a JSON object
json_obj = create_json()
json_set_string(json_obj, "name", "Breezy")

# Check if the JSON object contains specific keys
key1 = "name"
key2 = "age"

if json_has_key(json_obj, key1):
    write_line(f"Key '{key1}' exists in the JSON object.")
else:
    write_line(f"Key '{key1}' does not exist in the JSON object.")

if json_has_key(json_obj, key2):
    write_line(f"Key '{key2}' exists in the JSON object.")
else:
    write_line(f"Key '{key2}' does not exist in the JSON object.")

# Free the JSON object
free_json(json_obj)
