import splashkit

def main():
    # Open a window
    splashkit.open_window("Open Connection Example", 800, 600)
    
    splashkit.write_line("Open Connection Example")
    splashkit.write_line("Attempting to open a network connection")
    splashkit.write_line("Press any key to exit")
    
    # Connection details
    host = "example.com"
    port = 80
    
    # Try to open a connection
    conn = splashkit.open_connection(host, port)
    
    if splashkit.is_connection_open(conn):
        splashkit.write_line("Connection opened successfully!")
        splashkit.write_line("Host: " + host)
        splashkit.write_line("Port: " + str(port))
        splashkit.write_line("Connection IP: " + splashkit.connection_ip(conn))
        splashkit.write_line("Connection Port: " + str(splashkit.connection_port(conn)))
    else:
        splashkit.write_line("Failed to open connection to " + host + ":" + str(port))
        splashkit.write_line("This is expected for example.com as it may not accept connections")
    
    while not splashkit.window_close_requested("Open Connection Example"):
        # Clear the screen
        splashkit.clear_screen(splashkit.COLOR_WHITE)
        
        # Display connection information
        splashkit.draw_text("Open Connection Example", splashkit.COLOR_BLACK, 50, 50)
        splashkit.draw_text("Network Connection Test", splashkit.COLOR_BLACK, 50, 100)
        
        if splashkit.is_connection_open(conn):
            splashkit.draw_text("Connection Status: OPEN", splashkit.COLOR_GREEN, 50, 150)
            splashkit.draw_text("Host: " + host, splashkit.COLOR_BLUE, 70, 200)
            splashkit.draw_text("Port: " + str(port), splashkit.COLOR_BLUE, 70, 230)
            splashkit.draw_text("Connection IP: " + splashkit.connection_ip(conn), splashkit.COLOR_BLUE, 70, 260)
            splashkit.draw_text("Connection Port: " + str(splashkit.connection_port(conn)), splashkit.COLOR_BLUE, 70, 290)
        else:
            splashkit.draw_text("Connection Status: FAILED", splashkit.COLOR_RED, 50, 150)
            splashkit.draw_text("Host: " + host, splashkit.COLOR_RED, 70, 200)
            splashkit.draw_text("Port: " + str(port), splashkit.COLOR_RED, 70, 230)
            splashkit.draw_text("Note: This is expected for example.com", splashkit.COLOR_ORANGE, 70, 260)
            splashkit.draw_text("as it may not accept connections", splashkit.COLOR_ORANGE, 70, 290)
        
        # Instructions
        splashkit.draw_text("This example demonstrates opening network connections", splashkit.COLOR_BLACK, 50, 400)
        splashkit.draw_text("Check the console for detailed connection information", splashkit.COLOR_BLACK, 50, 450)
        splashkit.draw_text("Press any key to exit", splashkit.COLOR_BLACK, 50, 500)
        
        # Refresh the screen
        splashkit.refresh_screen()
        
        # Process events
        splashkit.process_events()
        
        # Small delay
        splashkit.delay(16)
    
    # Close the connection if it's open
    if splashkit.is_connection_open(conn):
        splashkit.close_connection(conn)
        splashkit.write_line("Connection closed")
    
    return 0

if __name__ == "__main__":
    main() 