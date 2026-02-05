using DailyDoseOfAi.Core;

Console.WriteLine("Incipio Dosis Quotidiana Intelligentiae Artificialis...");

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

WriteWithDelay($"\n📌 Consilium Cotidianum GitHub Copilot:\n");
WriteWithDelay($"Titulus: {dailyTip.Title}\n");
WriteWithDelay($"Descriptio: {dailyTip.Description}\n\n");

Console.WriteLine("Perfectum!");