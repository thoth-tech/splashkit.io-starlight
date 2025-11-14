from splashkit import *

# Open a window (some platforms require a window for dialogs)
open_window("Dialog Demo", 400, 300)
# Load a font from Resources/fonts (ensure arial.ttf exists)
f = load_font("Custom", "arial.ttf")
# Show dialog with custom font and size
display_dialog("Hello!", "Custom font size demo", f, 28)
# Close the window after a short delay
delay(1200); close_all_windows()
