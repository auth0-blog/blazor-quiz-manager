This repository contains two Blazor applications implementing a simple Quiz manager. One application uses the *Blazor Server* hosting mode while the other one uses the *Blazor WebAssembly* hosting model.

The Blazor Server application is also secured with [Auth0](https://auth0.com/).

The following article describes the implementation details: [What is Blazor? A Tutorial on Building Web Apps with Authentication](https://auth0.com/blog/what-is-blazor-tutorial-on-building-webapp-with-authentication/)

## To run the applications:

Clone the repo: `git clone https://github.com/auth0-blog/blazor-quiz-manager.git`

To run the *Blazor Server* application:

1. Move to the `QuizManager` folder 
2. Add Auth0 credentials to the `appsettings.json` configuration file.
3. Type `dotnet run` in a terminal window to launch the Web API.
4. Point your browser to `https://localhost:5001`.

To run the *Blazor WebAssembly* application:

1. Move to the `QuizManagerClientHosted/Server` folder 
2. Type `dotnet run` in a terminal window to launch the Web API.
3. Point your browser to `https://localhost:5001`.

## Requirements:

- [.NET Core 3.0](https://dotnet.microsoft.com/download/dotnet-core/3.0) installed on your machine ([.NET Core 3.1 preview](https://dotnet.microsoft.com/download/dotnet-core/3.1) for the *Blazor WebAssembly* hosting model, at time of writing)
- An [Auth0](https://auth0.com/) account.
