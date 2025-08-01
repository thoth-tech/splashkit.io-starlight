from splashkit import *

def main():
    open_window("Draw Circle", 800, 600)           # I am opening a window with size 800x600
    clear_screen(color_white())                    # I am clearing the screen with white
    draw_circle(color_red(), 400, 300, 100)        # I am drawing an outlined red circle at the center
    refresh_screen()                               # I am displaying everything I drew
    delay(3000)                                     # I am waiting 3 seconds so I can see the result

main()