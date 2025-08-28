#include "splashkit.h"

int main()
{
    // Open a window
    open_window("JSON From String Example", 800, 600);
    
    // JSON string examples
    string person_json = "{\"name\": \"John Doe\", \"age\": 30, \"city\": \"New York\"}";
    string array_json = "[1, 2, 3, 4, 5]";
    string nested_json = "{\"user\": {\"id\": 123, \"active\": true}, \"scores\": [85, 92, 78]}";
    
    write_line("JSON From String Example");
    write_line("Parsing JSON strings and displaying their contents");
    write_line("Press any key to exit");
    
    while (!window_close_requested("JSON From String Example"))
    {
        // Clear the screen
        clear_screen(COLOR_WHITE);
        
        // Parse JSON from strings
        json person = json_from_string(person_json);
        json array = json_from_string(array_json);
        json nested = json_from_string(nested_json);
        
        // Display parsed JSON data
        draw_text("Person JSON:", COLOR_BLACK, 50, 50);
        draw_text("Name: " + json_read_string(person, "name"), COLOR_BLUE, 70, 80);
        draw_text("Age: " + to_string(json_read_number_as_int(person, "age")), COLOR_BLUE, 70, 110);
        draw_text("City: " + json_read_string(person, "city"), COLOR_BLUE, 70, 140);
        
        draw_text("Array JSON:", COLOR_BLACK, 50, 200);
        draw_text("Values: [1, 2, 3, 4, 5]", COLOR_GREEN, 70, 230);
        draw_text("Count: " + to_string(json_count_keys(array)), COLOR_GREEN, 70, 260);
        
        draw_text("Nested JSON:", COLOR_BLACK, 50, 320);
        json user = json_read_object(nested, "user");
        draw_text("User ID: " + to_string(json_read_number_as_int(user, "id")), COLOR_RED, 70, 350);
        draw_text("Active: " + (json_read_bool(user, "active") ? "true" : "false"), COLOR_RED, 70, 380);
        
        json scores = json_read_object(nested, "scores");
        draw_text("Scores: [85, 92, 78]", COLOR_RED, 70, 410);
        
        // Instructions
        draw_text("This example shows parsing JSON strings into JSON objects", COLOR_BLACK, 50, 500);
        draw_text("Press any key to exit", COLOR_BLACK, 50, 530);
        
        // Refresh the screen
        refresh_screen();
        
        // Process events
        process_events();
        
        // Small delay
        delay(16);
    }
    
    // Clean up
    free_json(person);
    free_json(array);
    free_json(nested);
    
    return 0;
} 