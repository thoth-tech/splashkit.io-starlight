from splashkit import *

# Open a window for the telemetry hub display
open_window("UDP Telemetry Hub", 800, 600)

# Set up a UDP server to receive telemetry data
hub_server = create_server_with_port_and_protocol("hub", 5000, ConnectionType.udp)

# Set up a UDP connection to send telemetry data to the hub
sender_conn = open_connection_with_protocol("sender", "127.0.0.1", 5000, ConnectionType.udp)

# Simulated sprite position (sender side)
sprite_pos_x = 400.0
sprite_pos_y = 300.0
velocity_x = 2.0
velocity_y = 1.5

# Received position (hub display side)
received_x = 0.0
received_y = 0.0
has_data = False

# Send an initial handshake ping
send_message_to_connection("PING", sender_conn)

while not quit_requested():
    process_events()

    # Update simulated sprite position with bouncing
    sprite_pos_x += velocity_x
    sprite_pos_y += velocity_y

    # Bounce off window edges
    if sprite_pos_x <= 0 or sprite_pos_x >= 780:
        velocity_x = -velocity_x
    if sprite_pos_y <= 80 or sprite_pos_y >= 580:
        velocity_y = -velocity_y

    # Format position data as a string and send via UDP
    pos_data = "POS:" + str(int(sprite_pos_x)) + "," + str(int(sprite_pos_y))
    send_message_to_connection(pos_data, sender_conn)

    # Check for incoming UDP packets on the hub server
    check_network_activity()

    # Process any received messages
    if has_messages():
        # Read the incoming message and extract its payload
        msg = read_message()
        payload = message_data(msg)

        # Parse the position data from the payload
        if len(payload) >= 4 and payload[:4] == "POS:":
            coords = payload[4:]
            comma_pos = coords.index(",")
            received_x = float(coords[:comma_pos])
            received_y = float(coords[comma_pos + 1:])
            has_data = True

        close_message(msg)

    # Render the hub display
    clear_screen(color_black())

    # Draw header panel
    fill_rectangle(rgba_color(30, 30, 50, 255), 0, 0, 800, 70)
    draw_text_no_font_no_size("UDP Telemetry Hub", color_white(), 20, 10)
    draw_text_no_font_no_size("Protocol: UDP | Port: 5000 | Status: LIVE", color_green(), 20, 35)

    # Draw the sender indicator (what is being sent)
    fill_circle(rgba_color(50, 120, 200, 150), sprite_pos_x, sprite_pos_y, 10)
    draw_text_no_font_no_size("SENDER", rgba_color(50, 120, 200, 200), sprite_pos_x - 20, sprite_pos_y - 20)

    # Draw the received position indicator (what the hub received)
    if has_data:
        fill_circle(color_yellow(), received_x, received_y, 6)
        draw_circle(rgba_color(255, 255, 0, 100), received_x, received_y, 15)
        draw_text_no_font_no_size("HUB", color_yellow(), received_x - 10, received_y + 18)

        # Display telemetry readout
        fill_rectangle(rgba_color(20, 20, 40, 200), 560, 80, 230, 100)
        draw_rectangle(rgba_color(0, 200, 100, 150), 560, 80, 230, 100)
        draw_text_no_font_no_size("Telemetry Readout", color_green(), 580, 90)
        draw_text_no_font_no_size("X: " + str(int(received_x)), color_white(), 580, 115)
        draw_text_no_font_no_size("Y: " + str(int(received_y)), color_white(), 580, 140)

    # Draw a dashed connection line between sender and hub
    if has_data:
        draw_line(rgba_color(0, 200, 100, 80), sprite_pos_x, sprite_pos_y, received_x, received_y)

    refresh_screen_with_target_fps(60)

# Clean up networking resources
close_all_connections()
close_all_servers()
close_all_windows()
