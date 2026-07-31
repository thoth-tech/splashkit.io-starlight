using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create and start a timer
SplashKitSDK.Timer myTimer = CreateTimer("my_timer");
StartTimer(myTimer);
WriteLine("Timer started!");

// Wait 1 second
Delay(1000);
WriteLine("After 1 second: " + TimerTicks(myTimer) + " ms");

// Pause the timer
PauseTimer(myTimer);
WriteLine("Timer paused!");

// Wait 1 second while paused - timer should NOT increase
Delay(1000);
WriteLine("After pause delay, still at: " + TimerTicks(myTimer) + " ms");

// Resume the timer
ResumeTimer(myTimer);
WriteLine("Timer resumed!");

// Wait 1 more second - timer continues from where it left off
Delay(1000);
WriteLine("After resume: " + TimerTicks(myTimer) + " ms");

FreeTimer(myTimer);