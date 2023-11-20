namespace FantasyColiseum.Melon;

internal static class Preferences
{
    private static readonly MelonPreferences_Category GlobalCategory = MelonPreferences.CreateCategory("Global");
    public static readonly MelonPreferences_Category OwnCategory = MelonPreferences.CreateCategory("Fantasy Coliseum");
        
    public static MelonPreferences_Entry<int> LoggingMode { get; private set; }
    public static MelonPreferences_Entry<bool> Enabled { get; private set; }

    public static void Setup()
    {
        LoggingMode = GlobalCategory.GetEntry<int>("LoggingMode") ?? GlobalCategory.CreateEntry("LoggingMode", 0, "Logging Mode", "The level of logging to use. 0 = Important Only, 1 = All");
        Enabled = OwnCategory.GetEntry<bool>("Enabled") ?? OwnCategory.CreateEntry("Enabled", true, "Enabled", "If the mod should unlock the max enemy count or not.");
        GlobalCategory.SetFilePath(MelonUtils.UserDataDirectory+"/WeatherElectric.cfg");
        GlobalCategory.SaveToFile(false);
        OwnCategory.SetFilePath(MelonUtils.UserDataDirectory+"/WeatherElectric.cfg");
        OwnCategory.SaveToFile(false);
        ModConsole.Msg("Finished preferences setup for Fantasy Coliseum", 1);
    }
}