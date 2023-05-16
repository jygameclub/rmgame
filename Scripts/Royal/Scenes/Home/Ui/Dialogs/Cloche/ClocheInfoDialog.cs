using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Cloche
{
    public class ClocheInfoDialog : UiDialog
    {
        // Fields
        public UnityEngine.GameObject[] clocheFlags;
        public UnityEngine.GameObject[] clocheParticles;
        
        // Methods
        private void Awake()
        {
            var val_4;
            int val_1 = GetCloche();
            val_4 = 4;
            do
            {
                var val_2 = val_4 - 4;
                if(val_2 >= this.clocheFlags.Length)
            {
                    return;
            }
            
                var val_3 = val_2 + 1;
                this.clocheFlags[0].SetActive(value:  (val_3 == val_1) ? 1 : 0);
                this.clocheParticles[0].SetActive(value:  (val_3 == val_1) ? 1 : 0);
                val_4 = val_4 + 1;
            }
            while(this.clocheFlags != null);
            
            throw new NullReferenceException();
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldCloseOnTouch = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeInDuration = val_3;
            val_0.shouldCloseOnSwipe = val_4;
            return val_0;
        }
        public override void OnClose(System.Action dialogClosed)
        {
            this.OnClose(dialogClosed:  dialogClosed);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Prelevel.ShowPrelevelDialogAction(clearBoosterSelectionData:  false));
        }
        public ClocheInfoDialog()
        {
        
        }
    
    }

}
