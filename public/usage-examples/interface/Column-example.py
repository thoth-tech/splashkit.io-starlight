# Display columns with increasing percentage width
def add_column_relative(width):
    container_width = 50
    pixels = int(container_width * width)
    bar = '=' * pixels
    print(f"[{bar}] {int(width * 100)}%")

for i in range(1, 6):
    add_column_relative(i * 0.2)
