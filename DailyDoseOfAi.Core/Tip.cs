namespace DailyDoseOfAi.Core;

public class Tip
{
    public string Title { get; set; }
    public string Description { get; set; }

    public Tip(string title, string description)
    {
        Title = title;
        Description = description;
    }
}
