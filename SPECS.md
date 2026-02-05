## Plan: Add Daily GitHub Copilot Tips Feature

Create a `Tip` class and `TipManager` in the Core library with 10 humorous tips. Use date-based selection to show the same tip to all users each day. Display the tip in both the console and web applications with preliminary unit tests.

### Steps

1. Create `Tip` class in [DailyDoseOfAi.Core/Tip.cs](DailyDoseOfAi.Core/Tip.cs) with `Title` and `Description` properties.

2. Create `TipManager` class in [DailyDoseOfAi.Core/TipManager.cs](DailyDoseOfAi.Core/TipManager.cs) with hardcoded collection of 10 humorous tips and `GetDailyTip()` method that uses date-based selection (e.g., `DateTime.Now.DayOfYear % tips.Count`).

3. Update [DailyDoseOfAi/Program.cs](DailyDoseOfAi/Program.cs) to retrieve and display the daily tip using `TipManager`.

4. Update [DailyDoseOfAi.Web/Pages/Index.cshtml.cs](DailyDoseOfAi.Web/Pages/Index.cshtml.cs) to inject/instantiate `TipManager` and expose the daily tip as a property.

5. Update [DailyDoseOfAi.Web/Pages/Index.cshtml](DailyDoseOfAi.Web/Pages/Index.cshtml) to display the tip title and description in a user-friendly format.

6. Add unit tests in [DailyDoseOfAi.Tests/TipManagerTests.cs](DailyDoseOfAi.Tests/TipManagerTests.cs) covering: tip retrieval, same tip for same date, different tip for different dates, and correct tip count.

### Further Considerations

1. **Tip Storage**: The tips are hardcoded in `TipManager`. If you later want to externalize them (JSON file, database), this class would be the single place to modify.

2. **Tip Cycling**: The algorithm uses `DayOfYear % tips.Count`, so tips cycle annually. Would you prefer a different cycling approach (e.g., sequential by week, random seed by date)?

3. **Console vs Web Consistency**: Both applications will call the same `TipManager` method, ensuring consistent daily tips across platforms.