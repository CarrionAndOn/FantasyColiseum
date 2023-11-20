namespace FantasyColiseum;

[HarmonyPatch(typeof(ArenaMenuController), "Start")]
public static class ArenaPatch
{
    [HarmonyPostfix]
    public static void Postfix(ArenaMenuController __instance)
    {
        if (Main.LevelBarcode != CommonBarcodes.Maps.FantasyArena) return;
        if (!Preferences.Enabled.Value) return;
        ModConsole.Msg("Setting max enemy count to 500", 1);
        __instance.maxEnemyCount = 500;
        ModConsole.Msg("Setting max concurrent to 500", 1);
        __instance.maxConcurrent = 500;
        ModConsole.Msg("Setting max friendly count to 500", 1);
        __instance.maxFriendlyCount = 500;
    }
}