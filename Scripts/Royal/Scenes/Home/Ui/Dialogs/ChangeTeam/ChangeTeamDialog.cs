using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.ChangeTeam
{
    public class ChangeTeamDialog : UiDialog
    {
        // Fields
        public Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoView currentTeamLogo;
        public Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoView newTeamLogo;
        public TMPro.TextMeshPro currentTeamNameText;
        public TMPro.TextMeshPro newTeamNameText;
        public UnityEngine.Transform currentDuo;
        public UnityEngine.Transform newDuo;
        private System.Action joinAction;
        
        // Methods
        public void Show(Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse newTeamInfo, System.Action join)
        {
            Royal.Player.Context.Units.SocialManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
            this.currentTeamLogo.InitById(logoId:  val_1.<MyTeamLogo>k__BackingField);
            this.currentTeamNameText.text = val_1.<MyTeamName>k__BackingField;
            this.newTeamLogo.InitById(logoId:  2026265904);
            this.newTeamNameText.text = newTeamInfo.__p.bb_pos;
            this.newTeamNameText.AdjustTeamPosition(teamNameText:  this.currentTeamNameText, duo:  this.currentDuo);
            this.newTeamNameText.AdjustTeamPosition(teamNameText:  this.newTeamNameText, duo:  this.newDuo);
            this.joinAction = join;
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.Show();
        }
        private void AdjustTeamPosition(TMPro.TextMeshPro teamNameText, UnityEngine.Transform duo)
        {
            float val_13 = teamNameText.renderedWidth;
            UnityEngine.Rect val_3 = teamNameText.rectTransform.rect;
            if(val_13 >= 0)
            {
                    return;
            }
            
            UnityEngine.Rect val_5 = teamNameText.rectTransform.rect;
            UnityEngine.Vector3 val_8 = duo.localPosition;
            val_13 = val_8.x;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  val_5.m_XMin - teamNameText.renderedWidth);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  2f);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            duo.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        }
        public void Confirm()
        {
            this.joinAction.Invoke();
        }
        public override void Close()
        {
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.Close();
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeInDuration = val_3;
            val_0.shouldCloseOnTouch = val_4;
            return val_0;
        }
        public ChangeTeamDialog()
        {
        
        }
    
    }

}
