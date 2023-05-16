using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.TeamBattle
{
    public class ShowTeamBattleInfoDialogAction : DialogAction
    {
        // Fields
        private readonly bool userAction;
        private readonly int <Type>k__BackingField;
        private readonly Royal.Scenes.Start.Context.Units.Flow.DialogOriginType <OriginType>k__BackingField;
        
        // Properties
        public override int Type { get; }
        public override Royal.Scenes.Start.Context.Units.Flow.DialogOriginType OriginType { get; }
        
        // Methods
        public override int get_Type()
        {
            return (int)this.<Type>k__BackingField;
        }
        public override Royal.Scenes.Start.Context.Units.Flow.DialogOriginType get_OriginType()
        {
            return (Royal.Scenes.Start.Context.Units.Flow.DialogOriginType)this.<OriginType>k__BackingField;
        }
        public ShowTeamBattleInfoDialogAction(bool userAction, Royal.Scenes.Start.Context.Units.Flow.DialogOriginType originType = 0, int type = 3)
        {
            this.userAction = userAction;
            this.<OriginType>k__BackingField = originType;
            this.<Type>k__BackingField = (userAction != true) ? 2 : type;
        }
        public override void Execute()
        {
            Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleInfoDialog>(assetName:  "TeamBattleInfoDialog", action:  this).Show(userAction:  (this.userAction == true) ? 1 : 0, infoButton:  (this == 5) ? 1 : 0);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
