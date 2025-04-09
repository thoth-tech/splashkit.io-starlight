import splashkit as sk
import os

def main():
    # Open window
    window = sk.open_window("Bitmap Center Example", 1200, 800)

    # Load bitmap with a name and filename
    img_path = os.path.join(r"D:/Academic deakin/trimester 05/SIT 378 Group Project/code-website/Bitmap center/Bitmap_center/", "obj", "bitmap.png")
    img = sk.load_bitmap("example_bitmap", img_path)

    # Check if the bitmap is loaded
    if img is None:
        sk.draw_text("Failed to load bitmap.", sk.color_red(), 100, 100)
        sk.refresh_screen()
        sk.delay(3000)
        return

    # Get center of bitmap
    center = sk.bitmap_center(img)

    # Get bitmap width and height
    img_width = sk.bitmap_width(img)
    img_height = sk.bitmap_height(img)

    # Debug print statements
    print(f"Bitmap width: {img_width}, Bitmap height: {img_height}")

    # Clear screen
    sk.clear_screen(sk.color_white())

    # Draw bitmap at its center (center of the window)
    sk.draw_bitmap(img, (window.width() - img_width) / 2, (window.height() - img_height) / 2)

    # Refresh screen
    sk.refresh_screen()

    # Wait for 3 seconds
    sk.delay(3000)

if __name__ == "__main__":
    main()
