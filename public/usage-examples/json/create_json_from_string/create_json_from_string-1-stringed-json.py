from splashkit import *

# JSON string to convert to a JSON object
json_string = "{\"name\": \"Breezy\", \"age\": 25}"

# Create a JSON object from the string
json_obj = create_json_from_string(json_string)

# Read and display values from the JSON object
write_line("Name: " + json_read_string(json_obj, "name"))
write_line("Age: " + str(json_read_number(json_obj, "age")))