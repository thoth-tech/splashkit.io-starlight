import splashkit

# Define the font name and the required size.
font_name = "Arial"
required_size = 12

# Check using the overload that takes a font name.
has_size_by_name = splashkit.font_has_size(font_name, required_size)

# Load a Font object with the required size.
my_font = splashkit.load_font("Arial", "arial.ttf", 12)
has_size_by_object = splashkit.font_has_size(my_font, required_size)

# Output the results.
print("Checking font using font name overload:")
print(f"Font {font_name} with size {required_size}: {'Yes' if has_size_by_name else 'No'}")

print("Checking font using font object overload:")
print(f"Font {my_font.name} with size {required_size}: {'Yes' if has_size_by_object else 'No'}")

# Process events to keep the application running.
while not splashkit.quit_requested():
    splashkit.process_events()
