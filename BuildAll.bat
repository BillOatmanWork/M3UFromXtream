dotnet publish -r win-x64 -c Release -p:PublishReadyToRun=true -p:PublishSingleFile=true --self-contained true -p:IncludeNativeLibrariesForSelfExtract=true
dotnet publish -r osx-x64 -c Release /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true --self-contained
dotnet publish -r linux-arm -c Release /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true --self-contained
dotnet publish -r linux-arm64 -c Release /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true --self-contained
dotnet publish -r linux-x64 -c Release /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true --self-contained

cd C:\repos\M3UFromXtream\Build

copy /Y "C:\repos\M3UFromXtream\bin\Release\net8.0\win-x64\publish\M3UFromXtream.exe" .
"C:\Program Files\7-Zip\7z" a -tzip M3UFromXtream-WIN.zip M3UFromXtream.exe

copy /Y "C:\repos\M3UFromXtream\bin\Release\net8.0\osx-x64\publish\M3UFromXtream" .
"C:\Program Files\7-Zip\7z" a -t7z M3UFromXtream-OSX.7z M3UFromXtream

copy /Y "C:\repos\M3UFromXtream\bin\Release\net8.0\linux-x64\publish\M3UFromXtream" .
"C:\Program Files\7-Zip\7z" a -t7z M3UFromXtream-LIN64.7z M3UFromXtream

copy /Y "C:\repos\M3UFromXtream\bin\Release\net8.0\linux-arm\publish\M3UFromXtream" .
"C:\Program Files\7-Zip\7z" a -t7z M3UFromXtream-RasPi.7z M3UFromXtream

copy /Y "C:\repos\M3UFromXtream\bin\Release\net8.0\linux-arm64\publish\M3UFromXtream" .
"C:\Program Files\7-Zip\7z" a -t7z M3UFromXtream-RasPi64.7z M3UFromXtream

