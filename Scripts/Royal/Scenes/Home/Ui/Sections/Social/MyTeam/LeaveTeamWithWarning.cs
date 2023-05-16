using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.MyTeam
{
    public class LeaveTeamWithWarning : UiDialog
    {
        // Fields
        public TMPro.TextMeshPro titleLabel;
        public TMPro.TextMeshPro descriptionLabel;
        private System.Action onConfirm;
        
        // Methods
        public void Show(System.Action confirm)
        {
            this.onConfirm = confirm;
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.Show();
        }
        private void Start()
        {
            float val_12;
            float val_13;
            this.descriptionLabel.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Are you sure you want to leave your team?");
            string val_2 = this.titleLabel.text;
            if(val_2.m_stringLength < 4)
            {
                goto label_4;
            }
            
            string val_3 = this.titleLabel.text;
            if(val_3.m_stringLength < 7)
            {
                goto label_7;
            }
            
            string val_4 = this.titleLabel.text;
            if(val_4.m_stringLength < 10)
            {
                goto label_10;
            }
            
            string val_5 = this.titleLabel.text;
            var val_6 = (val_5.m_stringLength > 13) ? 1 : 0;
            val_12 = mem[36529944 + val_5.m_stringLength > 13 ? 1 : 0];
            val_12 = 36529944 + val_5.m_stringLength > 13 ? 1 : 0;
            var val_7 = (val_5.m_stringLength > 13) ? 5f : 4f;
            goto label_15;
            label_4:
            val_12 = 5.6f;
            val_13 = 1f;
            goto label_15;
            label_7:
            val_12 = 5.55f;
            val_13 = 2f;
            goto label_15;
            label_10:
            val_13 = 3f;
            val_12 = 5.5f;
            label_15:
            Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve val_8 = this.titleLabel.GetComponentInChildren<Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve>();
            val_8 = 1;
            val_8 = val_13;
            val_8.ForceUpdate();
            val_8 = 0;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  val_12);
            this.titleLabel.transform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        }
        public void Confirm()
        {
            if(this.onConfirm == null)
            {
                    return;
            }
            
            this.onConfirm.Invoke();
        }
        public override void OnClose(System.Action dialogClosed)
        {
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.OnClose(dialogClosed:  dialogClosed);
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
        public LeaveTeamWithWarning()
        {
        
        }
    
    }

}
