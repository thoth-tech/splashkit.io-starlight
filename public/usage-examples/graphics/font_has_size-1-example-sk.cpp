#include "splashkit.h"

int main()
{
    // Define the font name and the required size.
    std::string fontName = "Arial";
    int requiredSize = 12;
    
    // Check font size using the overload that takes a font name.
    bool hasSizeByName = font_has_size(fontName, requiredSize);
    
    // Load a Font object with the required size.
    Font myFont = load_font("Arial", "arial.ttf", 12);
    bool hasSizeByObject = font_has_size(myFont, requiredSize);
    
    // Output the results.
    write_line("Checking font using font name overload:");
    write_line("Font " + fontName + " with size " + std::to_string(requiredSize) + ": " + (hasSizeByName ? "Yes" : "No"));
    
    write_line("Checking font using font object overload:");
    write_line("Font " + font_name(myFont) + " with size " + std::to_string(requiredSize) + ": " + (hasSizeByObject ? "Yes" : "No"));
    
    // Keep processing events until the user quits.
    while (!quit_requested())
    {
        process_events();
    }
    
    return 0;
}
