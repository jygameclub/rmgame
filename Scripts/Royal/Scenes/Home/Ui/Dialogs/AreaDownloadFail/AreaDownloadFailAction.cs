using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.AreaDownloadFail
{
    public class AreaDownloadFailAction : DialogAction
    {
        // Fields
        private readonly bool isAtAreaUnlock;
        private readonly bool isAtAreaLoad;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public AreaDownloadFailAction(bool isAtAreaUnlock = False, bool isAtAreaLoad = False)
        {
            this.isAtAreaUnlock = isAtAreaUnlock;
            this.isAtAreaLoad = isAtAreaLoad;
        }
        public override int get_Type()
        {
            return 2;
        }
        public override void Execute()
        {
            Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.AreaDownloadFail.AreaDownloadFailDialog>(assetName:  "AreaDownloadFailDialog", action:  this).Init(isAtAreaUnlock:  this.isAtAreaUnlock, isAtAreaLoad:  this.isAtAreaLoad);
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.AreaDownloadFail.AreaDownloadFailDialog).__il2cppRuntimeField_240;
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
