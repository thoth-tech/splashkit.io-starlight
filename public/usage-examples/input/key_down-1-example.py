from splashkit import *

open_window("Key Down Example", 400, 200)

write_line("Press and hold Space...")

while not quit_requested():
    process_events()

    if key_down(KeyCode.space_key):
        write_line("Space key is held down!")
        delay(500)

close_all_windows()