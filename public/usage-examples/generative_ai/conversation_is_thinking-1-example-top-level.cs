using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Conversation chat = CreateConversation(
    LanguageModel.Qwen306BThinking
);

string question = "What is 2 plus 2? Give only the answer.";

WriteLine("Question: " + question);
WriteLine("");

// Send the question to the language model
ConversationAddMessage(chat, question);

bool thinkingStarted = false;
bool thinkingFinished = false;
bool replyHeadingShown = false;

while (ConversationIsReplying(chat))
{
    bool isThinking = ConversationIsThinking(chat);

    // Display messages when the thinking state changes
    if (isThinking && !thinkingStarted)
    {
        WriteLine("The model is thinking...");
        thinkingStarted = true;
    }

    if (!isThinking && thinkingStarted && !thinkingFinished)
    {
        WriteLine("Thinking done.");
        thinkingFinished = true;
    }

    string replyPiece = ConversationGetReplyPiece(chat);

    if (!isThinking)
    {
        if (!replyHeadingShown)
        {
            WriteLine("");
            WriteLine("Final reply:");
            replyHeadingShown = true;
        }

        Write(replyPiece);
    }
}

WriteLine("");
WriteLine("");
WriteLine("Reply complete.");

FreeConversation(chat);