using UnityEngine;
using Verse;

namespace CustomizableGrandSculptures
{
    public class SculpturesSettings : Mod
    {
        public static SculpturesSettingsData Settings;

        public SculpturesSettings(ModContentPack content) : base(content)
        {
            Settings = GetSettings<SculpturesSettingsData>();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard ls = new Listing_Standard();
            ls.Begin(inRect);
            ls.Label("CGS_SettingsRequiresRestart".Translate());
            ls.Gap();

            string bufferBeauty = Settings.Beauty.ToString();
            ls.TextFieldNumericLabeled<int>("CGS_Beauty".Translate(), ref Settings.Beauty, ref bufferBeauty, -1000, 1000);

            string bufferMaxHP = Settings.MaxHp.ToString();
            ls.TextFieldNumericLabeled<int>("CGS_MaxHP".Translate(), ref Settings.MaxHp, ref bufferMaxHP, 1, 9000);

            string bufferWorkToMake = Settings.WorkToMake.ToString();
            ls.TextFieldNumericLabeled<int>("CGS_WorkToMake".Translate(), ref Settings.WorkToMake, ref bufferWorkToMake, 1, 900000);

            string bufferMass = Settings.Mass.ToString();
            ls.TextFieldNumericLabeled<int>("CGS_Mass".Translate(), ref Settings.Mass, ref bufferMass, 1, 1000);

            string bufferCostStuffCount = Settings.CostStuffCount.ToString();
            ls.TextFieldNumericLabeled<int>("CGS_CostStuffCount".Translate(), ref Settings.CostStuffCount, ref bufferCostStuffCount, 0, 2500);

            ls.End();
            base.DoSettingsWindowContents(inRect);
        }

        public override string SettingsCategory() => "CGS_SettingsCategory".Translate();
    }
}
