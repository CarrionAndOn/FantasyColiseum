using MelonLoader;
using Il2CppSLZ.Bonelab;
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
                __instance.maxEnemyCount = 500;
                __instance.maxConcurrent = 500;
                __instance.maxFriendlyCount = 500;
            }
        }
    }
}