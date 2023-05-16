using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassConfig
    {
        // Fields
        public int version;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep[] steps;
        
        // Methods
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep GetStep(int step)
        {
            .step = step;
            return System.Linq.Enumerable.FirstOrDefault<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep>(source:  this.steps, predicate:  new System.Func<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep, System.Boolean>(object:  new RoyalPassConfig.<>c__DisplayClass2_0(), method:  System.Boolean RoyalPassConfig.<>c__DisplayClass2_0::<GetStep>b__0(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep ladderOfferStep)));
        }
        public int LastStep()
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep val_2 = this.steps[((-4294967296) + ((this.steps.Length) << 32)) >> 29];
            return (int)this.steps[((ulong)(-4294967296 + (this.steps.Length) << 32)) >> 29][0].s;
        }
        public int GetTotalNumberOfSteps()
        {
            if(this.steps != null)
            {
                    return (int)this.steps.Length;
            }
            
            throw new NullReferenceException();
        }
        public RoyalPassConfig()
        {
        
        }
    
    }

}
