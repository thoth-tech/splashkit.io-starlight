from splashkit import *
from splashkit import KeyCode

# I am clipping a day/night scene to a window "glass"; SPACE toggles day/night.
RGB = globals().get("rgb_color", globals().get("RGBColor"))
WHITE, BLACK, SKY, GREEN, BROWN, YEL = RGB(255,255,255), RGB(0,0,0), RGB(135,206,235), RGB(0,128,0), RGB(150,75,0), RGB(255,255,0)
SPACE = KeyCode.space_key

open_window("push_clip modern window (day/night)", 720, 405)
glass = rectangle_from(60, 40, 600, 300)
night = False
SUN_SPEED, CLOUD_SPEED, MOON_SPEED = 0.01, 0.10, 0.03
sx = [120,150,180,210,240,270,480,510,540,570,600,630]
sy = [80,60,90,70,110,85,75,95,65,105,85,70]
sun, moon, cloud = 120.0, 500.0, 110.0
cmin, cmax = glass.x + 42, glass.x + glass.width - 72

while not quit_requested(): 
    process_events()

    if key_down(SPACE):
        night = not night

    clear_screen(WHITE)

    # I am limiting drawing to the glass region.
    push_clip(glass)
    fill_rectangle(BLACK if night else SKY, 0, 0, 720, 405)
    fill_rectangle(GREEN, 0, 260, 720, 145)  # grass

    if night:
        fill_circle(WHITE, moon, 120, 24)
        fill_circle(BLACK, moon + 9, 118, 24)  # crescent
        for i in range(len(sx)):
            draw_pixel(WHITE, sx[i], sy[i])     # stars
    else:
        fill_circle(YEL, sun, 120, 26)          # sun
        cy = 108                                # cloud
        fill_circle(WHITE, cloud - 26, cy + 8, 16)
        fill_circle(WHITE, cloud - 6,  cy + 0, 20)
        fill_circle(WHITE, cloud + 18, cy + 4, 18)
        fill_circle(WHITE, cloud + 42, cy + 10, 14)

    fill_rectangle(BROWN, 520, 220, 22, 100)    # tree
    fill_circle(GREEN, 531, 205, 46)
    pop_clip()

    # I am drawing the window frame outside the clip.
    f, m = 10, 6
    x, y, w, h = glass.x, glass.y, glass.width, glass.height
    fill_rectangle(BLACK, x - f, y - f, w + 2 * f, f)
    fill_rectangle(BLACK, x - f, y + h, w + 2 * f, f)
    fill_rectangle(BLACK, x - f, y - f, f, h + 2 * f)
    fill_rectangle(BLACK, x + w, y - f, f, h + 2 * f)
    fill_rectangle(BLACK, x + w / 3 - m / 2, y, m, h)
    fill_rectangle(BLACK, x + 2 * w / 3 - m / 2, y, m, h)

    refresh_screen()
    delay(16)  # ~60 FPS cap

    if night:
        moon += MOON_SPEED
        if moon > 780:
            moon = -40
    else:
        sun += SUN_SPEED
        if sun > 780:
            sun = -40
        cloud += CLOUD_SPEED
        if cloud > cmax:
            cloud = cmin