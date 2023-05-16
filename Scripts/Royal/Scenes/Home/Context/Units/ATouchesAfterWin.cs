using UnityEngine;

namespace Royal.Scenes.Home.Context.Units
{
    public abstract class ATouchesAfterWin : FlowAction
    {
        // Fields
        private readonly bool isAfterMadnessAnimations;
        
        // Methods
        protected ATouchesAfterWin(bool isAfterMadnessAnimations)
        {
            this.isAfterMadnessAnimations = isAfterMadnessAnimations;
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        public override bool SupportsMultiple()
        {
            return true;
        }
        protected bool ShouldDisable()
        {
            var val_3;
            Royal.Scenes.Home.Context.Units.HomeSceneFlow val_1 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.HomeSceneFlow>(id:  2);
            if(this.isAfterMadnessAnimations == false)
            {
                goto label_4;
            }
            
            label_6:
            var val_2 = ((val_1.<ShouldDisableTouchesAfterWin>k__BackingField) == true) ? 1 : 0;
            return (bool)val_3;
            label_4:
            if((val_1.<ShouldDisableTouchesForMadness>k__BackingField) == false)
            {
                goto label_6;
            }
            
            val_3 = 1;
            return (bool)val_3;
        }
    
    }

}
