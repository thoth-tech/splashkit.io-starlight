from splashkit import *

def draw_traffic_lights(window):
    fill_circle_on_window(window, color_red(), 400, 100, 50)
    fill_circle_on_window(window, color_yellow(), 400, 250, 50)
    fill_circle_on_window(window, color_green(), 400, 400, 50)

def main():
    win = open_window("Traffic Lights - Python", 800, 600)
    clear_screen(color_white())

    draw_traffic_lights(win)

    refresh_screen()
    delay(5000)

    close_all_windows()

if __name__ == "__main__":
    main()
