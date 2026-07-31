from splashkit import *

# Create and start a timer
my_timer = create_timer("my_timer")
start_timer(my_timer)
write_line("Timer started!")

# Wait 1 second
delay(1000)
write_line("After 1 second: " + str(timer_ticks(my_timer)) + " ms")

# Pause the timer
pause_timer(my_timer)
write_line("Timer paused!")

# Wait 1 second while paused - timer should NOT increase
delay(1000)
write_line("After pause delay, still at: " + str(timer_ticks(my_timer)) + " ms")

# Resume the timer
resume_timer(my_timer)
write_line("Timer resumed!")

# Wait 1 more second - timer continues from where it left off
delay(1000)
write_line("After resume: " + str(timer_ticks(my_timer)) + " ms")

free_timer(my_timer)