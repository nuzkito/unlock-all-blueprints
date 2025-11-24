using Database;
using HarmonyLib;

namespace Unlock_Blueprints
{
    public class Patches
    {
        [HarmonyPatch(typeof(BuildingFacadeInfo), "get_rarity")]
        public static class BuildingFacadeInfo_Rarity_Patch
        {
            public static bool Prefix(ref PermitRarity __result)
            {
                __result = PermitRarity.Universal;

                return false;
            }
        }

        [HarmonyPatch(typeof(ArtableInfo), "get_rarity")]
        public static class ArtableInfo_Rarity_Patch
        {
            public static bool Prefix(ref PermitRarity __result)
            {
                __result = PermitRarity.Universal;

                return false;
            }
        }

        [HarmonyPatch(typeof(ClothingItemInfo), "get_rarity")]
        public static class ClothingItemInfo_Rarity_Patch
        {
            public static bool Prefix(ref PermitRarity __result)
            {
                __result = PermitRarity.Universal;

                return false;
            }
        }

        [HarmonyPatch(typeof(BalloonArtistFacadeInfo), "get_rarity")]
        public static class BalloonArtistFacadeInfo_Rarity_Patch
        {
            public static bool Prefix(ref PermitRarity __result)
            {
                __result = PermitRarity.Universal;

                return false;
            }
        }
    }
}
