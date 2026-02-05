namespace DailyDoseOfAi.Core;

public class TipManager
{
    private readonly List<Tip> _tips = new()
    {
        new Tip(
            "Copilot: Your New Best Friend",
            "Copilot is like having a senior developer who never sleeps, never complains, and never judges your variable names. Well, actually it does judge, but it won't tell HR."
        ),
        new Tip(
            "The Magic of `/explain`",
            "Use Copilot's /explain command to understand code you wrote 6 months ago. Spoiler alert: you won't remember why you wrote it that way."
        ),
        new Tip(
            "Comments Are Your Love Letters",
            "Write comments for your future self. Hint: your future self is going to hate your past self regardless, so you might as well try."
        ),
        new Tip(
            "Ask Copilot Anything",
            "Copilot can help with code, tests, documentation, and debugging. Just don't ask it to write your love letters. (Actually, maybe don't ask it anything too personal)."
        ),
        new Tip(
            "Tab Complete Your Way to Victory",
            "Press Tab to accept Copilot's suggestions. Spoiler alert: you'll accidentally accept the suggestion that breaks your code. That's why they invented Ctrl+Z."
        ),
        new Tip(
            "Test-Driven Development with Copilot",
            "Let Copilot write your tests while you sip coffee. Warning: your tests might be too generous, but at least they exist!"
        ),
        new Tip(
            "Naming Things (The Hard Problem)",
            "Copilot can help with variable names so you don't end up with variables called 'temp', 'data', or 'stuff'. You're welcome, future you."
        ),
        new Tip(
            "The Power of Context",
            "Give Copilot context about your project in comments. More context = better suggestions. It's like the difference between 'fix it' and 'fix the database connection timeout'."
        ),
        new Tip(
            "Keep It DRY with Copilot",
            "Don't Repeat Yourself! Let Copilot help refactor duplicated code. Your code review comments will thank you."
        ),
        new Tip(
            "Pair Programming with an AI",
            "Copilot is your tireless pair programmer. It doesn't hog the keyboard, always stays on task, and never drinks all the office coffee."
        )
    };

    public Tip GetDailyTip()
    {
        int dayOfYear = DateTime.Now.DayOfYear;
        int tipIndex = dayOfYear % _tips.Count;
        return _tips[tipIndex];
    }
}
