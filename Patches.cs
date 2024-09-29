using Database;
using HarmonyLib;

namespace Unlock_Blueprints
{
    public class Patches
    {
        [HarmonyPatch(typeof(Blueprints_U51AndBefore))]
        [HarmonyPatch("SetupBlueprints")]
        public class Blueprints_U51AndBefore_SetupBlueprints_Patch
        {
            public static void Postfix(ref Blueprints_U51AndBefore __instance)
            {
                foreach (var buildingFacade in __instance.blueprintCollection.buildingFacades)
                {
                    buildingFacade.rarity = PermitRarity.Universal;
                }

                foreach (var artable in __instance.blueprintCollection.artables)
                {
                    artable.rarity = PermitRarity.Universal;
                }


                foreach (var clothingItem in __instance.blueprintCollection.clothingItems)
                {
                    clothingItem.rarity = PermitRarity.Universal;
                }


                foreach (var balloonArtistFacade in __instance.blueprintCollection.balloonArtistFacades)
                {
                    balloonArtistFacade.rarity = PermitRarity.Universal;
                }
            }
        }
    }
}
