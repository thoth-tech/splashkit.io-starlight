from splashkit import *

open_window("Interactive AI Terminal", 900, 600)

write_line("Interactive AI Terminal (Single-Turn)")
write("Enter your prompt: ")
prompt = read_line()

reply = generate_reply(prompt)

write_line("\nAI reply:")
write_line(reply)

while not quit_requested():
    process_events()

    clear_screen(color_white())
    draw_text("Interactive AI Terminal", color_black(), 20, 20)
    draw_text("Prompt:", color_black(), 20, 70)
    draw_text(prompt, color_dark_slate_gray(), 20, 100)
    draw_text("AI Reply:", color_black(), 20, 160)
    draw_text(reply, color_blue(), 20, 190)

    refresh_screen(60)

close_all_windows()