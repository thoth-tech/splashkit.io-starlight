#include "splashkit.h"

int main()
{
    // Open a window
    open_window("Open Connection Example", 800, 600);
    
    write_line("Open Connection Example");
    write_line("Attempting to open a network connection");
    write_line("Press any key to exit");
    
    // Connection details
    string host = "example.com";
    int port = 80;
    
    // Try to open a connection
    connection conn = open_connection(host, port);
    
    if (is_connection_open(conn))
    {
        write_line("Connection opened successfully!");
        write_line("Host: " + host);
        write_line("Port: " + to_string(port));
        write_line("Connection IP: " + connection_ip(conn));
        write_line("Connection Port: " + to_string(connection_port(conn)));
    }
    else
    {
        write_line("Failed to open connection to " + host + ":" + to_string(port));
        write_line("This is expected for example.com as it may not accept connections");
    }
    
    while (!window_close_requested("Open Connection Example"))
    {
        // Clear the screen
        clear_screen(COLOR_WHITE);
        
        // Display connection information
        draw_text("Open Connection Example", COLOR_BLACK, 50, 50);
        draw_text("Network Connection Test", COLOR_BLACK, 50, 100);
        
        if (is_connection_open(conn))
        {
            draw_text("Connection Status: OPEN", COLOR_GREEN, 50, 150);
            draw_text("Host: " + host, COLOR_BLUE, 70, 200);
            draw_text("Port: " + to_string(port), COLOR_BLUE, 70, 230);
            draw_text("Connection IP: " + connection_ip(conn), COLOR_BLUE, 70, 260);
            draw_text("Connection Port: " + to_string(connection_port(conn)), COLOR_BLUE, 70, 290);
        }
        else
        {
            draw_text("Connection Status: FAILED", COLOR_RED, 50, 150);
            draw_text("Host: " + host, COLOR_RED, 70, 200);
            draw_text("Port: " + to_string(port), COLOR_RED, 70, 230);
            draw_text("Note: This is expected for example.com", COLOR_ORANGE, 70, 260);
            draw_text("as it may not accept connections", COLOR_ORANGE, 70, 290);
        }
        
        // Instructions
        draw_text("This example demonstrates opening network connections", COLOR_BLACK, 50, 400);
        draw_text("Check the console for detailed connection information", COLOR_BLACK, 50, 450);
        draw_text("Press any key to exit", COLOR_BLACK, 50, 500);
        
        // Refresh the screen
        refresh_screen();
        
        // Process events
        process_events();
        
        // Small delay
        delay(16);
    }
    
    // Close the connection if it's open
    if (is_connection_open(conn))
    {
        close_connection(conn);
        write_line("Connection closed");
    }
    
    return 0;
} 