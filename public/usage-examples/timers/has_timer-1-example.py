from splashkit import *

timer_name = "GameTimer"

write_line(f"Does '{timer_name}' exist? {str(has_timer(timer_name)).lower()}")

create_timer(timer_name)
write_line(f"Created timer '{timer_name}'")

write_line(f"Does '{timer_name}' exist? {str(has_timer(timer_name)).lower()}")

free_timer(timer_name)
write_line(f"Freed timer '{timer_name}'")

write_line(f"Does '{timer_name}' exist? {str(has_timer(timer_name)).lower()}")
