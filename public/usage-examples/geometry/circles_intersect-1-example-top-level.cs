using System;
using SplashKitSDK;
using System.Collections.Generic;
using static SplashKitSDK.SplashKit;

const int SPEED = 3;
const int PLAYER_RADIUS = 50;

List<SplashKitSDK.Circle> circles = new List<SplashKitSDK.Circle>();
circles.Add(CircleAt(150, 150, 130));
circles.Add(CircleAt(450, 150, 130));
circles.Add(CircleAt(150, 450, 130));
circles.Add(CircleAt(450, 450, 130));

Circle player_circle = CircleAt(300, 300, PLAYER_RADIUS);
OpenWindow("Intersecting Circles?", 600, 600);
while(!QuitRequested())
{
    ProcessEvents();

    if (KeyDown(KeyCode.LeftKey) && CircleX(player_circle) > PLAYER_RADIUS)
    {
        float val = CircleX(player_circle) - SPEED;
        player_circle = CircleAt(val, CircleY(player_circle), PLAYER_RADIUS);
    }
    if (KeyDown(KeyCode.RightKey)&& CircleX(player_circle) > PLAYER_RADIUS)
    {
        float val = CircleX(player_circle) + SPEED;
        player_circle = CircleAt(val, CircleY(player_circle), PLAYER_RADIUS);
    }
    if (KeyDown(KeyCode.DownKey)&& CircleY(player_circle) > PLAYER_RADIUS)
    {
        float val = CircleY(player_circle) + SPEED;
        player_circle = CircleAt(CircleX(player_circle), val, PLAYER_RADIUS);
    }
    if (KeyDown(KeyCode.UpKey)&& CircleY(player_circle) > PLAYER_RADIUS)
    {
        float val = CircleY(player_circle) - SPEED;
        player_circle = CircleAt(CircleX(player_circle), val, PLAYER_RADIUS);
    }
    
    ClearScreen(ColorWhite());
    for (int i = 0; i < 4; i++)
    {
        // Check if the player circle has intersected any other circles
        if (CirclesIntersect(player_circle, circles[i]))
        {
            FillCircle(ColorRed(), circles[i]);
        }
        else
        {
            DrawCircle(ColorRed(), circles[i]);
        }
    }
    FillCircle(ColorBlue(), player_circle);
    Delay(60);
    RefreshScreen();
}