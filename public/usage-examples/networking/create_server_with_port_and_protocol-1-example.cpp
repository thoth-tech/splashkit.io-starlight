#include "splashkit.h"

int main()
{
    const int window_width = 800;
    const int window_height = 600;
    const unsigned short port = 5000;

    open_window("UDP Sprite Signal", window_width, window_height);

    bitmap sender_bitmap = create_bitmap("sender dot", 28, 28);
    clear_bitmap(sender_bitmap, rgba_color(0, 0, 0, 0));
    fill_circle_on_bitmap(sender_bitmap, rgba_color(53, 184, 255, 255), 14, 14, 12);
    sprite sender_sprite = create_sprite(sender_bitmap);
    sprite_set_x(sender_sprite, 80);
    sprite_set_y(sender_sprite, 180);
    double velocity_x = 2.4;
    double velocity_y = 1.8;

    server_socket hub_server = create_server("hub", port, UDP);
    connection sender_connection = open_connection("sender", "127.0.0.1", port, UDP);
    bool handshake_received = false;
    bool has_position = false;
    double received_x = 0;
    double received_y = 0;
    string last_payload = "Waiting for position data";
    unsigned int frame_count = 0;

    send_message_to("PING", sender_connection);

    while (!quit_requested())
    {
        process_events();

        double next_x = sprite_x(sender_sprite) + velocity_x;
        double next_y = sprite_y(sender_sprite) + velocity_y;
        if (next_x <= 40 || next_x >= 500)
        {
            velocity_x = -velocity_x;
            next_x = sprite_x(sender_sprite) + velocity_x;
        }
        if (next_y <= 130 || next_y >= 520)
        {
            velocity_y = -velocity_y;
            next_y = sprite_y(sender_sprite) + velocity_y;
        }
        sprite_set_x(sender_sprite, next_x);
        sprite_set_y(sender_sprite, next_y);

        double sender_x = sprite_x(sender_sprite);
        double sender_y = sprite_y(sender_sprite);
        string position_packet = "POS:" + std::to_string(static_cast<int>(sender_x)) + "," + std::to_string(static_cast<int>(sender_y));
        send_message_to(position_packet, sender_connection);

        check_network_activity();
        while (has_messages(hub_server))
        {
            message packet = read_message(hub_server);
            string payload = message_data(packet);

            if (payload == "PING")
            {
                handshake_received = true;
            }

            if (payload.rfind("POS:", 0) == 0)
            {
                string coordinates = payload.substr(4);
                unsigned int comma_index = coordinates.find(",");
                received_x = convert_to_double(coordinates.substr(0, comma_index));
                received_y = convert_to_double(coordinates.substr(comma_index + 1));
                last_payload = payload;
                has_position = true;
            }
            close_message(packet);
        }

        clear_screen(rgba_color(10, 16, 30, 255));
        fill_rectangle(rgba_color(19, 29, 52, 255), 0, 0, window_width, 90);
        draw_text("UDP Sprite Signal", COLOR_WHITE, 24, 18);
        draw_text("Sender  ->  127.0.0.1:5000  ->  Hub", rgba_color(142, 202, 255, 255), 24, 50);
        fill_rectangle(handshake_received ? rgba_color(22, 101, 52, 255) : rgba_color(120, 75, 18, 255), 595, 22, 180, 42);
        draw_text(handshake_received ? "HANDSHAKE: ONLINE" : "HANDSHAKE: WAITING", COLOR_WHITE, 610, 36);

        draw_rectangle(rgba_color(55, 78, 112, 255), 20, 110, 520, 460);
        draw_text("SENDER SPRITE", rgba_color(142, 202, 255, 255), 36, 124);
        draw_line(rgba_color(38, 120, 82, 255), sender_x + 14, sender_y + 14, 670, 330);
        if (handshake_received)
        {
            double pulse = (frame_count % 90) / 90.0;
            double pulse_x = sender_x + 14 + (670 - sender_x - 14) * pulse;
            double pulse_y = sender_y + 14 + (330 - sender_y - 14) * pulse;
            fill_circle(rgba_color(74, 222, 128, 255), pulse_x, pulse_y, 5);
        }
        draw_sprite(sender_sprite);

        if (has_position)
        {
            draw_circle(rgba_color(255, 220, 85, 255), received_x + 14, received_y + 14, 18);
        }

        fill_rectangle(rgba_color(17, 27, 46, 255), 560, 110, 220, 460);
        draw_rectangle(rgba_color(55, 78, 112, 255), 560, 110, 220, 460);
        draw_text("HUB RECEIVER", rgba_color(74, 222, 128, 255), 580, 135);
        draw_text("Protocol: UDP", COLOR_WHITE, 580, 175);
        draw_text("Port: 5000", COLOR_WHITE, 580, 200);
        draw_text("LATEST COORDINATES", rgba_color(142, 202, 255, 255), 580, 250);
        draw_text("X: " + std::to_string(static_cast<int>(received_x)), COLOR_WHITE, 580, 285);
        draw_text("Y: " + std::to_string(static_cast<int>(received_y)), COLOR_WHITE, 580, 315);
        draw_text("LAST PAYLOAD", rgba_color(142, 202, 255, 255), 580, 375);
        draw_text(last_payload, rgba_color(255, 220, 85, 255), 580, 410);
        draw_text(has_position ? "PACKETS: LIVE" : "PACKETS: WAITING", has_position ? rgba_color(74, 222, 128, 255) : rgba_color(255, 183, 77, 255), 580, 500);

        refresh_screen(60);
        frame_count++;
    }

    free_sprite(sender_sprite);
    free_bitmap(sender_bitmap);
    close_connection(sender_connection);
    close_server(hub_server);
    close_all_windows();

    return 0;
}
