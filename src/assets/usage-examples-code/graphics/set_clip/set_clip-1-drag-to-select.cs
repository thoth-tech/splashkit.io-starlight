// Usage Example for: https://splashkit.io/api/graphics/#set-clip-3
// Goal: I am letting the user drag a rectangle and I am calling SetClip(...) to limit later drawing to that region.
// Why: I am showing that clipping is restricting drawing; I am pressing R to reset to the full window.
// Controls: I am dragging with Left Mouse | I am pressing R to reset | I am pressing ESC to quit.

using static SplashKitSDK.SplashKit;
using SplashKitSDK;

var win = OpenWindow("set_clip, drag to select, R to reset", 800, 500);

bool isDragging = false;   // I am tracking whether I am dragging right now
double dragStartX = 0;     // I am remembering where the drag is starting (x)
double dragStartY = 0;     // I am remembering where the drag is starting (y)
int frameCount = 0;        // I am ticking a small animation so clipping is obvious

while (!WindowCloseRequested(win))
{
    ProcessEvents();

    // I am quitting on ESC
    if (KeyTyped(KeyCode.EscapeKey))
    {
        break;
    }

    // I am resetting the clip when I am pressing R
    if (KeyTyped(KeyCode.RKey))
    {
        ResetClip();
    }

    // I am beginning a drag when the left mouse button is going down
    if (!isDragging && MouseDown(MouseButton.LeftButton))
    {
        isDragging = true;
        dragStartX = MouseX();
        dragStartY = MouseY();
    }

    // I am finishing the drag on release and I am setting the clip to that rectangle
    if (isDragging && !MouseDown(MouseButton.LeftButton))
    {
        double dragEndX = MouseX();
        double dragEndY = MouseY();

        double clipX;
        if (dragStartX < dragEndX)
        {
            clipX = dragStartX;
        }
        else
        {
            clipX = dragEndX;
        }

        double clipY;
        if (dragStartY < dragEndY)
        {
            clipY = dragStartY;
        }
        else
        {
            clipY = dragEndY;
        }

        double clipW = System.Math.Abs(dragEndX - dragStartX);
        double clipH = System.Math.Abs(dragEndY - dragStartY);

        if (clipW > 0 && clipH > 0)
        {
            SetClip(RectangleFrom(clipX, clipY, clipW, clipH));
        }

        isDragging = false;
    }

    ClearScreen(Color.White);

    // I am drawing a moving background so the clipping area is easy to see
    int stripeOffset = frameCount % 60;
    for (int x = -60 + stripeOffset; x < 800; x += 60)
    {
        FillRectangle(RGBColor(220, 240, 255), x, 0, 30, 500);
    }
    for (int y = 0; y < 500; y += 40)
    {
        DrawLine(Color.LightSteelBlue, 0, y, 800, y);
    }

    // I am showing the instructions in ASCII-only text
    DrawText("Drag to set clip | Press R to reset | ESC to quit", Color.Navy, 16, 16);

    // I am drawing a red rubber-band during the drag and I am making sure it is never clipped
    if (isDragging)
    {
        double dragEndX = MouseX();
        double dragEndY = MouseY();

        double rectX;
        if (dragStartX < dragEndX)
        {
            rectX = dragStartX;
        }
        else
        {
            rectX = dragEndX;
        }

        double rectY;
        if (dragStartY < dragEndY)
        {
            rectY = dragStartY;
        }
        else
        {
            rectY = dragEndY;
        }

        double rectW = System.Math.Abs(dragEndX - dragStartX);
        double rectH = System.Math.Abs(dragEndY - dragStartY);

        ResetClip(); // I am ensuring the preview outline is not affected by any current clip
        DrawRectangle(Color.Red, rectX, rectY, rectW, rectH);
    }

    RefreshScreen(60);
    frameCount++;
}

CloseAllWindows();