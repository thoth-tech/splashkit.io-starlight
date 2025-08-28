using SplashKitSDK;

class Program
{
    static void Main(string[] args)
    {
        // Open a window
        SplashKit.OpenWindow("JSON From String Example", 800, 600);
        
        // JSON string examples
        string personJson = "{\"name\": \"John Doe\", \"age\": 30, \"city\": \"New York\"}";
        string arrayJson = "[1, 2, 3, 4, 5]";
        string nestedJson = "{\"user\": {\"id\": 123, \"active\": true}, \"scores\": [85, 92, 78]}";
        
        SplashKit.WriteLine("JSON From String Example");
        SplashKit.WriteLine("Parsing JSON strings and displaying their contents");
        SplashKit.WriteLine("Press any key to exit");
        
        while (!SplashKit.WindowCloseRequested("JSON From String Example"))
        {
            // Clear the screen
            SplashKit.ClearScreen(Color.White);
            
            // Parse JSON from strings
            JSON person = SplashKit.JSONFromString(personJson);
            JSON array = SplashKit.JSONFromString(arrayJson);
            JSON nested = SplashKit.JSONFromString(nestedJson);
            
            // Display parsed JSON data
            SplashKit.DrawText("Person JSON:", Color.Black, 50, 50);
            SplashKit.DrawText("Name: " + SplashKit.JSONReadString(person, "name"), Color.Blue, 70, 80);
            SplashKit.DrawText("Age: " + SplashKit.JSONReadNumberAsInt(person, "age"), Color.Blue, 70, 110);
            SplashKit.DrawText("City: " + SplashKit.JSONReadString(person, "city"), Color.Blue, 70, 140);
            
            SplashKit.DrawText("Array JSON:", Color.Black, 50, 200);
            SplashKit.DrawText("Values: [1, 2, 3, 4, 5]", Color.Green, 70, 230);
            SplashKit.DrawText("Count: " + SplashKit.JSONCountKeys(array), Color.Green, 70, 260);
            
            SplashKit.DrawText("Nested JSON:", Color.Black, 50, 320);
            JSON user = SplashKit.JSONReadObject(nested, "user");
            SplashKit.DrawText("User ID: " + SplashKit.JSONReadNumberAsInt(user, "id"), Color.Red, 70, 350);
            SplashKit.DrawText("Active: " + (SplashKit.JSONReadBool(user, "active") ? "true" : "false"), Color.Red, 70, 380);
            
            JSON scores = SplashKit.JSONReadObject(nested, "scores");
            SplashKit.DrawText("Scores: [85, 92, 78]", Color.Red, 70, 410);
            
            // Instructions
            SplashKit.DrawText("This example shows parsing JSON strings into JSON objects", Color.Black, 50, 500);
            SplashKit.DrawText("Press any key to exit", Color.Black, 50, 530);
            
            // Refresh the screen
            SplashKit.RefreshScreen();
            
            // Process events
            SplashKit.ProcessEvents();
            
            // Small delay
            SplashKit.Delay(16);
        }
        
        // Clean up
        SplashKit.FreeJSON(person);
        SplashKit.FreeJSON(array);
        SplashKit.FreeJSON(nested);
    }
} 