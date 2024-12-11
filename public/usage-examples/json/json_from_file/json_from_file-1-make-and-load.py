from splashkit import *

# Create a JSON object
json_obj = create_json()
json_set_string(json_obj, "name", "Breezy")
json_set_number_integer(json_obj, "age", 25)
json_set_bool(json_obj, "is_active", True)

# Save the JSON object to the file
write_line("Saving JSON to file...")
json_to_file(json_obj, "example.json")

# Free the original JSON object
free_json(json_obj)
write_line("Original JSON object freed.")

# Load the JSON object back from the file
write_line("Reading JSON from file...")
json_from_file_obj = json_from_file("example.json")

# Display the JSON object read from the file
write_line("JSON read from file:")
write_line(json_to_string(json_from_file_obj))

# Free the loaded JSON object
free_json(json_from_file_obj)