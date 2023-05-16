using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer
{
    public class LadderOfferConfig
    {
        // Fields
        public int version;
        public Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep[] steps;
        
        // Methods
        public int LastStep()
        {
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep val_2 = this.steps[((-4294967296) + ((this.steps.Length) << 32)) >> 29];
            return (int)this.steps[((ulong)(-4294967296 + (this.steps.Length) << 32)) >> 29][0].s;
        }
        public Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep GetLadderOfferStep(int step)
        {
            .step = step;
            return System.Linq.Enumerable.FirstOrDefault<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep>(source:  this.steps, predicate:  new System.Func<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep, System.Boolean>(object:  new LadderOfferConfig.<>c__DisplayClass3_0(), method:  System.Boolean LadderOfferConfig.<>c__DisplayClass3_0::<GetLadderOfferStep>b__0(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep ladderOfferStep)));
        }
        public LadderOfferConfig()
        {
        
        }
    
    }

}
