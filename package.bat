dotnet build --nologo
dotnet publish --nologo -r win-x64 /p:PublishSingleFile=true -o ./output
