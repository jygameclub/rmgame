using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.PiggyBankCollect
{
    public class PlayPiggyBankCollectionAnimationAction : AnimationAction
    {
        // Fields
        private readonly bool isThereAnyIconAnimationAfterwards;
        
        // Methods
        public PlayPiggyBankCollectionAnimationAction()
        {
            var val_2;
            bool val_3;
            if(this.ShouldConsumePiggy() == false)
            {
                    return;
            }
            
            val_2 = null;
            val_2 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 64.PrepareIconForAnimation(initialAmount:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_68 + 20);
            val_3 = 1;
            if(this == null)
            {
                    val_3 = mem[Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 24 + 16];
                val_3 = Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 24 + 16;
            }
            
            this.isThereAnyIconAnimationAfterwards = val_3;
        }
        protected override float GetDurationForNextAction()
        {
            return (float)(this.isThereAnyIconAnimationAfterwards == false) ? 1f : 0.5f;
        }
        public override void Execute()
        {
            if(this.ShouldConsumePiggy() != false)
            {
                    this.Execute();
                UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.PiggyBankCollect.PiggyBankCollectAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.PiggyBankCollect.PiggyBankCollectAnimation>(path:  "PiggyBankCollectAnimation")).Play();
                return;
            }
            
            this.Complete();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            this.Complete();
        }
        private bool ShouldConsumePiggy()
        {
            return (bool)Royal.Player.Context.Data.Session.__il2cppRuntimeField_68 + 16;
        }
    
    }

}
