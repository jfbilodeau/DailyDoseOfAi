# Daily Dose of AI

A multi-platform .NET application featuring a daily GitHub Copilot tips system that displays humorous, date-based tips to users across console and web interfaces.

## Project Overview

This solution includes:
- **DailyDoseOfAi.Core**: Core library containing the `Tip` model and `TipManager` service for managing daily tips
- **DailyDoseOfAi**: Console application that displays the daily tip
- **DailyDoseOfAi.Web**: ASP.NET Core Razor Pages web application for viewing daily tips
- **DailyDoseOfAi.Tests**: Unit tests for core functionality

## Features

- **Daily Tips**: A collection of 10 humorous GitHub Copilot tips that cycle based on the day of year
- **Date-Based Selection**: All users see the same tip on the same day using `DateTime.Now.DayOfYear`
- **Multi-Platform**: Tips are accessible via console app and web interface
- **Unit Tested**: Comprehensive test coverage for tip retrieval and cycling logic

## Project Structure

```
DailyDoseOfAi/
├── DailyDoseOfAi.Core/          # Core business logic
│   ├── Tip.cs                   # Tip model
│   ├── TipManager.cs            # Tip management and selection
│   └── DailyDoseOfAi.Core.csproj
├── DailyDoseOfAi/               # Console application
│   ├── Program.cs
│   └── DailyDoseOfAi.csproj
├── DailyDoseOfAi.Web/           # ASP.NET Core web application
│   ├── Pages/
│   ├── Program.cs
│   └── DailyDoseOfAi.Web.csproj
├── DailyDoseOfAi.Tests/         # Unit tests
│   ├── TipManagerTests.cs
│   └── DailyDoseOfAi.Tests.csproj
└── DailyDoseOfAi.sln
```

## Getting Started

### Prerequisites
- .NET 9.0 SDK or later
- Visual Studio 2022 or Visual Studio Code

### Building the Project

```bash
dotnet build
```

### Running the Console Application

```bash
dotnet run --project DailyDoseOfAi/DailyDoseOfAi.csproj
```

### Running the Web Application

```bash
dotnet run --project DailyDoseOfAi.Web/DailyDoseOfAi.Web.csproj
```

The web application will be available at `https://localhost:5001` or `http://localhost:5000`

### Running Tests

```bash
dotnet test
```

## How It Works

The `TipManager` class maintains a collection of 10 hardcoded tips and provides a `GetDailyTip()` method that uses date-based selection:

```csharp
DateTime.Now.DayOfYear % tips.Count
```

This ensures:
- Same tip is displayed to all users on the same day
- Tips cycle through the year automatically
- Deterministic behavior for testing

## Future Enhancements

- Externalize tips to a JSON file or database
- Add tip rating/voting system
- Implement different cycling strategies (weekly, random)
- Add tip categories or filtering
- Support multiple languages

## License

This project is open source and available under the MIT License.
