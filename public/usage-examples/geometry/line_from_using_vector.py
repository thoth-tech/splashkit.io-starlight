import splashkit

def main():
    splashkit.open_window("Vector Field Visualization", 800, 600)

    while not splashkit.window_close_requested("Vector Field Visualization"):
        splashkit.process_events()

        splashkit.clear_screen(splashkit.COLOR_WHITE)

        # Drawing lines originating from grid points
        for x in range(50, 800, 50):
            for y in range(50, 600, 50):
                # Define a vector (line) with small offsets as an example
                line = splashkit.line_from(x, y, x + 20, y + 10)
                splashkit.draw_line(splashkit.COLOR_BLUE, line)  # Draw the line in blue

        splashkit.refresh_screen()

if __name__ == "__main__":
    main()
