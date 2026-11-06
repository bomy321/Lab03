# Copilot 指示

- 除非使用者另有指定，請以繁體中文溝通。
- 目前的應用程式是 `MyApp/` 下的 .NET 10 主控台專案，目標框架為 `net10.0`。
- 維持專案簡潔；除非需求需要，勿新增專案、套件或額外檔案。修改專案設定時，保留現有的 implicit usings 與 nullable 設定。
- `MyApp/Program.cs` 使用 top-level statements。建置與執行可使用 `dotnet build MyApp/MyApp.csproj`、`dotnet run --project MyApp/MyApp.csproj`。
- 目前沒有測試專案；不要假設 `dotnet test` 已有可執行的測試。
