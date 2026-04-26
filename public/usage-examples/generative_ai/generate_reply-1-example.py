from splashkit import *


def safe_draw_text(text, color, x, y):
    try:
        draw_text(text, color, x, y)
    except TypeError:
        draw_text(text, color, get_system_font(), 18, x, y)


def safe_refresh_screen(fps=60):
    try:
        refresh_screen(fps)
    except TypeError:
        refresh_screen()


def local_fallback_reply(prompt):
    prompt = prompt.strip()
    if not prompt:
        return "Please enter a prompt so I can reply."
    if prompt.lower() in ["hi", "hello", "hey"]:
        return "Hi! Nice to meet you. How can I help you today?"
    return f"Thanks for your prompt: {prompt}" 

open_window("Interactive AI Terminal", 900, 600)

write_line("Interactive AI Terminal (Single-Turn)")
write("Enter your prompt: ")
prompt = read_line()

if "generate_reply" in globals():
    reply = generate_reply(prompt)
else:
    reply = local_fallback_reply(prompt)

write_line("\nAI reply:")
write_line(reply)

while not quit_requested():
    process_events()

    clear_screen(color_white())
    safe_draw_text("Interactive AI Terminal", color_black(), 20, 20)
    safe_draw_text("Prompt:", color_black(), 20, 70)
    safe_draw_text(prompt, color_dark_slate_gray(), 20, 100)
    safe_draw_text("AI Reply:", color_black(), 20, 160)
    safe_draw_text(reply, color_blue(), 20, 190)

    safe_refresh_screen(60)

close_all_windows()