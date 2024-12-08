from splashkit import *

# Create a JSON object with an integer value
json_obj = create_json()
json_set_number_integer(json_obj, "score", 100)

# Read the integer value from the JSON object
score = json_read_number_as_int(json_obj, "score")

# Display the integer value
write_line("Score: " + str(score))

# Free the JSON object
free_json(json_obj)