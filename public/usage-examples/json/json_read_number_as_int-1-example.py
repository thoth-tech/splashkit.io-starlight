from splashkit import *

# Create a JSON object with an integer value
json_obj = create_json()
json_set_number_integer(json_obj, "grade", 10)

# Read the integer value from the JSON object
grade = json_read_number_as_int(json_obj, "grade")

# Display the integer value
write_line("Grade: " + str(grade))