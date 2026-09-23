using static SplashKitSDK.SplashKit;

string sentence = "foo fighters say foo is fun";
string updatedSentence = ReplaceAll(sentence, "foo", "bar");

WriteLine("Original: " + sentence);
WriteLine("Updated: " + updatedSentence);
