# whistler
Un simple code en C# pour monter le volume de tous les périphériques audio à fond et émettre un bip puis afficher un gentil message


Pour compiler :

dotnet publish -r win-x64 /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true --self-contained true



Ne pas oublier d'inclure le package NuGet NAUDIO :

https://www.nuget.org/packages/NAudio/
