[assembly: AssemblyTitle(FantasyColiseum.Main.Description)]
[assembly: AssemblyDescription(FantasyColiseum.Main.Description)]
[assembly: AssemblyCompany(FantasyColiseum.Main.Company)]
[assembly: AssemblyProduct(FantasyColiseum.Main.Name)]
[assembly: AssemblyCopyright("Developed by " + FantasyColiseum.Main.Author)]
[assembly: AssemblyTrademark(FantasyColiseum.Main.Company)]
[assembly: AssemblyVersion(FantasyColiseum.Main.Version)]
[assembly: AssemblyFileVersion(FantasyColiseum.Main.Version)]
[assembly:
    MelonInfo(typeof(FantasyColiseum.Main), FantasyColiseum.Main.Name, FantasyColiseum.Main.Version,
        FantasyColiseum.Main.Author, FantasyColiseum.Main.DownloadLink)]
[assembly: MelonColor(ConsoleColor.Yellow)]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONELAB")]