namespace FantasyColiseum;

public class Main : MelonMod
{
    internal const string Name = "Fantasy Coliseum"; // Required
    internal const string Description = "Unlocks the max enemy count in Fantasy Arena."; // Required
    internal const string Author = "SoulWithMae"; // Required
    internal const string Company = "Weather Electric"; // Set as null if blank
    internal const string Version = "2.0.0"; // Required
    internal const string DownloadLink = "https://bonelab.thunderstore.io/package/SoulWithMae/FantasyColiseum/"; // Set as null if blank

    public override void OnInitializeMelon()
    {
        ModConsole.Setup(LoggerInstance);
        Preferences.Setup();
        BoneMenu.Setup();
        Hooking.OnLevelInitialized += OnLevelLoad;
    }

    public static string LevelBarcode;

    private static void OnLevelLoad(LevelInfo levelInfo)
    {
        LevelBarcode = levelInfo.barcode;
    }
}