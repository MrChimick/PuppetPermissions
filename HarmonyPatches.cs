using System.Reflection;
using HarmonyLib;
using Verse;


namespace PuppetPermissions
{
    [StaticConstructorOnStartup]
    static class HarmonyPatches
    {
        static HarmonyPatches() => new Harmony("PuppetPermissions").PatchAll();
    }

    [HarmonyPatch]
    static class CustomizerChangePatch
    {
        static MethodBase TargetMethod() => AccessTools.Method("Puppeteer.Customizer:Change");

        static bool Prefix() => false;
    }
}