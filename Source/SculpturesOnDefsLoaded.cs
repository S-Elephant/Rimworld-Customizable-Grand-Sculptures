using Verse;

namespace CustomizableGrandSculptures
{
    [StaticConstructorOnStartup]
    public class SculpturesOnDefsLoaded
    {
        static SculpturesOnDefsLoaded()
        {
            ApplySettingsToDefs();
        }

        private static void ChangeStat(BuildableDef buildableDef, string statDefName, int value)
        {
            buildableDef.statBases.Find(s => s.stat.defName == statDefName).value = value;
        }

        private static void ApplySettingsToDefs()
        {
            ThingDef thingDef = DefDatabase<ThingDef>.GetNamed("SculptureGrand");
            if (thingDef != null)
            {
                ChangeStat(thingDef, "Beauty", SculpturesSettings.Settings.Beauty);
                ChangeStat(thingDef, "MaxHitPoints", SculpturesSettings.Settings.MaxHp);
                ChangeStat(thingDef, "WorkToMake", SculpturesSettings.Settings.WorkToMake);
                ChangeStat(thingDef, "Mass", SculpturesSettings.Settings.Mass);

                thingDef.costStuffCount = SculpturesSettings.Settings.CostStuffCount;
            }
            else
                Log.Warning("Unable to find ThingDef \"SculptureGrand\". Settings not applied.");
        }
    }
}
