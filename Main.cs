using MelonLoader;
using SLZ.Bonelab;
using HarmonyLib;

namespace FantasyColiseum
{
    public class Main : MelonMod
    {
        internal const string Name = "Fantasy Coliseum"; // Required
        internal const string Description = "Unlocks the max enemy count in Fantasy Arena."; // Required
        internal const string Author = "CarrionAndOn"; // Required
        internal const string Company = "Weather Electric"; // Set as null if blank
        internal const string Version = "1.0.0"; // Required
        internal const string DownloadLink = "https://bonelab.thunderstore.io/package/CarrionAndOn/FantasyColiseum/"; // Set as null if blank

        public override void OnInitializeMelon()
        {
            
        }
        [HarmonyPatch(typeof(ArenaMenuController), "Start")]
        public static class ArenaPatch
        {
            [HarmonyPostfix]
            public static void Postfix(ArenaMenuController __instance)
            {
                MelonLogger.Msg($"{__instance} Active");
                __instance.maxEnemyCount = 500;
                MelonLogger.Msg($"{__instance} max enemy count is {__instance.maxEnemyCount}");
                __instance.maxConcurrent = 500;
                MelonLogger.Msg($"{__instance} max concurrent is {__instance.maxConcurrent}");
                __instance.maxFriendlyCount = 500;
                MelonLogger.Msg($"{__instance} max friendly count is {__instance.maxFriendlyCount}");
            }
        }
    }
}