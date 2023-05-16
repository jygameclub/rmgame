using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Actions
{
    public class ShowPropellerMadnessInfoDialogAction : DialogAction
    {
        // Fields
        private Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessInfoDialog dialog;
        private readonly int <Type>k__BackingField;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return (int)this.<Type>k__BackingField;
        }
        public ShowPropellerMadnessInfoDialogAction(bool isUserAction = True)
        {
            this.<Type>k__BackingField = ((isUserAction & true) != 0) ? (2 + 1) : 2;
        }
        public override void Execute()
        {
            string val_7;
            var val_8;
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25).LoadBundle(bundleType:  Royal.Player.Context.Units.MadnessManager.GetBundleType(eventType:  val_2.type))) == false)
            {
                goto label_7;
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10).SetInfoDialogAsSeen();
            if(val_2.type == 0)
            {
                goto label_8;
            }
            
            if(val_2.type != 3)
            {
                goto label_9;
            }
            
            val_7 = "BookOfTreasureInfoDialog";
            goto label_10;
            label_7:
            object[] val_5 = new object[1];
            val_5[0] = val_2.type;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  22, log:  "Bundle is not loaded so closing dialog: {0}", values:  val_5);
            this.Complete();
            return;
            label_8:
            val_7 = "PropellerMadnessInfoDialog";
            label_10:
            Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessInfoDialog val_6 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessInfoDialog>(assetName:  val_7, action:  this);
            this.dialog = val_6;
            val_6.Init(madnessEventType:  val_2.type);
            goto label_17;
            label_9:
            val_8 = public System.Void Royal.Scenes.Start.Context.Units.Flow.FlowAction::Complete();
            label_17:
            this.Complete();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
