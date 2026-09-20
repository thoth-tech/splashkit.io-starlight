using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Build the Json from text, so the example needs no resource files
Json basket = JsonFromString("{\"fruits\": [\"apple\", \"banana\", \"cherry\", \"mango\"]}");

// The function fills a list that we create empty first
List<string> fruits = new List<string>();
JsonReadArray(basket, "fruits", ref fruits);

int fruitCount = fruits.Count;

OpenWindow("Fruit Basket", 520, 360);

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    DrawText("Fruits in the basket", ColorBlack(), "arial", 30, 30, 25);

    for (int index = 0; index < fruitCount; index++)
    {
        DrawText($"{index + 1}. {fruits[index]}", ColorBlack(), "arial", 24, 30, 85 + index * 40);
    }

    RefreshScreen(60);
}

FreeJson(basket);
CloseAllWindows();
