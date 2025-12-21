using static SplashKitSDK.SplashKit;

string timerName = "GameTimer";

WriteLine($"Does '{timerName}' exist? {HasTimer(timerName).ToString().ToLower()}");

CreateTimer(timerName);
WriteLine($"Created timer '{timerName}'");

WriteLine($"Does '{timerName}' exist? {HasTimer(timerName).ToString().ToLower()}");

FreeTimer(timerName);
WriteLine($"Freed timer '{timerName}'");

WriteLine($"Does '{timerName}' exist? {HasTimer(timerName).ToString().ToLower()}");
