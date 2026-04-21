using OpenAI;
using OpenAI.Chat;
using DotNetEnv;
using System.ComponentModel.Design;

Env.Load(".env");
//==== OPEN AI ====//
string? apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");

var client = new OpenAIClient(apiKey);

var chat = client.GetChatClient("gpt-4o-mini");


while (true)
{
    Console.WriteLine("Enter any kind of Data so i can give you the matching datatype(s)");
    string userInput = Console.ReadLine() ?? "";

    var result = await chat.CompleteChatAsync(
        new SystemChatMessage("You take the input data of the user and see which datatype it could match, if it matches multiple then output all of those that match in a markdown list. No questions asked. Start in a new line. Only expect a string data type if letters are being used. Give a small and short one sentence explenation as to why you answered how you did."),
        new UserChatMessage(userInput)
    );

    Console.WriteLine($"AI:\n{result.Value.Content[0].Text}");

}