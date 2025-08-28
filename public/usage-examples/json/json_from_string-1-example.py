import splashkit


def main():
    # Open a window
    splashkit.open_window("JSON From String Example", 800, 600)
    
    # JSON string examples
    person_json = '{"name": "John Doe", "age": 30, "city": "New York"}'
    array_json = '[1, 2, 3, 4, 5]'
    nested_json = '{"user": {"id": 123, "active": true}, "scores": [85, 92, 78]}'
    
    splashkit.write_line("JSON From String Example")
    splashkit.write_line("Parsing JSON strings and displaying their contents")
    splashkit.write_line("Press any key to exit")
    
    while not splashkit.window_close_requested("JSON From String Example"):
        # Clear the screen
        splashkit.clear_screen(splashkit.COLOR_WHITE)
        
        # Parse JSON from strings
        person = splashkit.json_from_string(person_json)
        array = splashkit.json_from_string(array_json)
        nested = splashkit.json_from_string(nested_json)
        
        # Display parsed JSON data
        splashkit.draw_text("Person JSON:", splashkit.COLOR_BLACK, 50, 50)
        splashkit.draw_text("Name: " + splashkit.json_read_string(person, "name"), splashkit.COLOR_BLUE, 70, 80)
        splashkit.draw_text("Age: " + str(splashkit.json_read_number_as_int(person, "age")), splashkit.COLOR_BLUE, 70, 110)
        splashkit.draw_text("City: " + splashkit.json_read_string(person, "city"), splashkit.COLOR_BLUE, 70, 140)
        
        splashkit.draw_text("Array JSON:", splashkit.COLOR_BLACK, 50, 200)
        splashkit.draw_text("Values: [1, 2, 3, 4, 5]", splashkit.COLOR_GREEN, 70, 230)
        splashkit.draw_text("Count: " + str(splashkit.json_count_keys(array)), splashkit.COLOR_GREEN, 70, 260)
        
        splashkit.draw_text("Nested JSON:", splashkit.COLOR_BLACK, 50, 320)
        user = splashkit.json_read_object(nested, "user")
        splashkit.draw_text("User ID: " + str(splashkit.json_read_number_as_int(user, "id")), splashkit.COLOR_RED, 70, 350)
        splashkit.draw_text("Active: " + str(splashkit.json_read_bool(user, "active")), splashkit.COLOR_RED, 70, 380)
        
        scores = splashkit.json_read_object(nested, "scores")
        splashkit.draw_text("Scores: [85, 92, 78]", splashkit.COLOR_RED, 70, 410)
        
        # Instructions
        splashkit.draw_text("This example shows parsing JSON strings into JSON objects", splashkit.COLOR_BLACK, 50, 500)
        splashkit.draw_text("Press any key to exit", splashkit.COLOR_BLACK, 50, 530)
        
        # Refresh the screen
        splashkit.refresh_screen()
        
        # Process events
        splashkit.process_events()
        
        # Small delay
        splashkit.delay(16)
    
    # Clean up
    splashkit.free_json(person)
    splashkit.free_json(array)
    splashkit.free_json(nested)
    
    return 0

if __name__ == "__main__":
    main() 