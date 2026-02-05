using DailyDoseOfAi.Core;

Console.WriteLine("Starting Daily Dose of AI Application...");

var tipManager = new TipManager();
var dailyTip = tipManager.GetDailyTip();

void WriteWithDelay(string text, int delayMs = 100)
{
    foreach (var ch in text)
    {
        Console.Write(ch);
        Thread.Sleep(delayMs); // Introduce a delay
    }
}

WriteWithDelay($"\n📌 Daily GitHub Copilot Tip:\n");
WriteWithDelay($"Title: {dailyTip.Title}\n");
WriteWithDelay($"Description: {dailyTip.Description}\n\n");

Console.WriteLine("Done!");