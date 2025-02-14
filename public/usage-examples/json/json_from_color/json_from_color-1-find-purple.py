from splashkit import *

# Create a color
clr = color_purple()

# Convert the color to a JSON object
json_obj = json_from_color(clr)

# Display the JSON object as a string
write_line("JSON from Color: " + json_to_string(json_obj))

# Free the JSON object
free_json(json_obj)