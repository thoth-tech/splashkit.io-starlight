from splashkit import *

window_width = 800
window_height = 600
port = 5000

open_window("UDP Sprite Signal", window_width, window_height)

sender_bitmap = create_bitmap("sender dot", 28, 28)
clear_bitmap(sender_bitmap, rgba_color(0, 0, 0, 0))
fill_circle_on_bitmap(sender_bitmap, rgba_color(53, 184, 255, 255), 14, 14, 12)
sender_sprite = create_sprite(sender_bitmap)
sprite_set_x(sender_sprite, 80)
sprite_set_y(sender_sprite, 180)
velocity_x = 2.4
velocity_y = 1.8

hub_server = create_server_with_port_and_protocol("hub", port, ConnectionType.udp)
sender_connection = open_connection_with_protocol("sender", "127.0.0.1", port, ConnectionType.udp)
handshake_received = False
has_position = False
received_x = 0
received_y = 0
last_payload = "Waiting for position data"
frame_count = 0

send_message_to_connection("PING", sender_connection)

while not quit_requested():
    process_events()

    next_x = sprite_x(sender_sprite) + velocity_x
    next_y = sprite_y(sender_sprite) + velocity_y
    if next_x <= 40 or next_x >= 500:
        velocity_x = -velocity_x
        next_x = sprite_x(sender_sprite) + velocity_x
    if next_y <= 130 or next_y >= 520:
        velocity_y = -velocity_y
        next_y = sprite_y(sender_sprite) + velocity_y
    sprite_set_x(sender_sprite, next_x)
    sprite_set_y(sender_sprite, next_y)

    sender_x = sprite_x(sender_sprite)
    sender_y = sprite_y(sender_sprite)
    position_packet = "POS:" + str(int(sender_x)) + "," + str(int(sender_y))
    send_message_to_connection(position_packet, sender_connection)

    check_network_activity()
    while has_messages_on_server(hub_server):
        packet = read_message_from_server(hub_server)
        payload = message_data(packet)

        if payload == "PING":
            handshake_received = True

        if payload.startswith("POS:"):
            coordinates = payload[4:]
            comma_index = coordinates.index(",")
            received_x = convert_to_double(coordinates[:comma_index])
            received_y = convert_to_double(coordinates[comma_index + 1:])
            last_payload = payload
            has_position = True
        close_message(packet)

    clear_screen(rgba_color(10, 16, 30, 255))
    fill_rectangle(rgba_color(19, 29, 52, 255), 0, 0, window_width, 90)
    draw_text_no_font_no_size("UDP Sprite Signal", color_white(), 24, 18)
    draw_text_no_font_no_size("Sender  ->  127.0.0.1:5000  ->  Hub", rgba_color(142, 202, 255, 255), 24, 50)
    fill_rectangle(rgba_color(22, 101, 52, 255) if handshake_received else rgba_color(120, 75, 18, 255), 595, 22, 180, 42)
    draw_text_no_font_no_size("HANDSHAKE: ONLINE" if handshake_received else "HANDSHAKE: WAITING", color_white(), 610, 36)

    draw_rectangle(rgba_color(55, 78, 112, 255), 20, 110, 520, 460)
    draw_text_no_font_no_size("SENDER SPRITE", rgba_color(142, 202, 255, 255), 36, 124)
    draw_line(rgba_color(38, 120, 82, 255), sender_x + 14, sender_y + 14, 670, 330)
    if handshake_received:
        pulse = (frame_count % 90) / 90.0
        pulse_x = sender_x + 14 + (670 - sender_x - 14) * pulse
        pulse_y = sender_y + 14 + (330 - sender_y - 14) * pulse
        fill_circle(rgba_color(74, 222, 128, 255), pulse_x, pulse_y, 5)
    draw_sprite(sender_sprite)

    if has_position:
        draw_circle(rgba_color(255, 220, 85, 255), received_x + 14, received_y + 14, 18)

    fill_rectangle(rgba_color(17, 27, 46, 255), 560, 110, 220, 460)
    draw_rectangle(rgba_color(55, 78, 112, 255), 560, 110, 220, 460)
    draw_text_no_font_no_size("HUB RECEIVER", rgba_color(74, 222, 128, 255), 580, 135)
    draw_text_no_font_no_size("Protocol: UDP", color_white(), 580, 175)
    draw_text_no_font_no_size("Port: 5000", color_white(), 580, 200)
    draw_text_no_font_no_size("LATEST COORDINATES", rgba_color(142, 202, 255, 255), 580, 250)
    draw_text_no_font_no_size("X: " + str(int(received_x)), color_white(), 580, 285)
    draw_text_no_font_no_size("Y: " + str(int(received_y)), color_white(), 580, 315)
    draw_text_no_font_no_size("LAST PAYLOAD", rgba_color(142, 202, 255, 255), 580, 375)
    draw_text_no_font_no_size(last_payload, rgba_color(255, 220, 85, 255), 580, 410)
    draw_text_no_font_no_size("PACKETS: LIVE" if has_position else "PACKETS: WAITING", rgba_color(74, 222, 128, 255) if has_position else rgba_color(255, 183, 77, 255), 580, 500)

    refresh_screen_with_target_fps(60)
    frame_count += 1

free_sprite(sender_sprite)
free_bitmap(sender_bitmap)
close_connection(sender_connection)
close_server(hub_server)
close_all_windows()
