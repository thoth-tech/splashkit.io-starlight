from splashkit import *

# Create a JSON object with a string value
json_obj = create_json()
json_set_string(json_obj, "greeting", "Hello, SplashKit!")
json_set_string(json_obj, "name", "SplashKit")

# Read the string value from the JSON object
greeting = json_read_string(json_obj, "greeting")

# Display the string value
write_line("Greeting: " + greeting)

# Free the JSON object
free_json(json_obj)
