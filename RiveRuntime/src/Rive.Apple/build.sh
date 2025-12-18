dotnet clean

dotnet restore

dotnet build -c Release -f net9.0-ios -r ios-arm64
dotnet build -c Release -f net9.0-maccatalyst -r maccatalyst-arm64
dotnet build -c Release -f net9.0-maccatalyst -r maccatalyst-x64

