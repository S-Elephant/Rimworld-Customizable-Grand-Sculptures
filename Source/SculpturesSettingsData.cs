using Verse;

namespace CustomizableGrandSculptures
{
    public class SculpturesSettingsData : ModSettings
    {
        #region Fields
        
        public int Beauty = 400;
        public int MaxHp = 300;
        public int WorkToMake = 105000;
        public int Mass = 28;
        public int CostStuffCount = 400;
        
        #endregion

        public override void ExposeData()
        {
            Scribe_Values.Look(ref Beauty, "CGS_Beauty", 400);
            Scribe_Values.Look(ref MaxHp, "CGS_MaxHP", 300);
            Scribe_Values.Look(ref WorkToMake, "CGS_WorkToMake", 105000);
            Scribe_Values.Look(ref Mass, "CGS_Mass", 28);
            Scribe_Values.Look(ref CostStuffCount, "CGS_CostStuffCount", 400);

            base.ExposeData();
        }
    }
}
