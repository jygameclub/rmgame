using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Prelevel
{
    public abstract class AbstractLevelDialog : UiDialog
    {
        // Fields
        public TMPro.TextMeshPro title;
        public Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve titleCurve;
        
        // Methods
        protected void PrepareTitle(Royal.Player.Context.Data.Session.UserActiveLevelData levelData)
        {
            int val_12;
            TMPro.TextMeshPro val_13;
            string val_14;
            float val_15;
            if(levelData.IsStory == true)
            {
                    return;
            }
            
            val_12 = levelData.number;
            if(levelData.IsLeague != false)
            {
                    val_12 = levelData.leagueIndex;
                val_13 = this.title;
                val_14 = "Round";
            }
            else
            {
                    val_13 = this.title;
                val_14 = "Level";
            }
            
            val_13.text = Royal.Infrastructure.Services.Localization.LocalizationHelper.AddTextToEnd(value:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_14), level:  val_12);
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isKorean != false)
            {
                    this.title.GetComponent<Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve>() = 0;
                UnityEngine.Transform val_6 = this.title.transform;
                UnityEngine.Vector3 val_7 = val_6.localPosition;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  0.14f);
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                val_6.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
                this.title.enableAutoSizing = false;
                this.title.fontSize = 10f;
            }
            
            val_15 = 0f;
            if(val_12 >= 10)
            {
                    if(val_12 >= 100)
            {
                    var val_11 = (val_12 > 999) ? 1 : 0;
                val_15 = mem[36530440 + val_12 > 999 ? 1 : 0];
                val_15 = 36530440 + val_12 > 999 ? 1 : 0;
            }
            else
            {
                    val_15 = 0.2f;
            }
            
            }
            
            val_15 = val_15 + this.titleCurve.CurveScale;
            this.titleCurve = val_15;
        }
        protected AbstractLevelDialog()
        {
        
        }
    
    }

}
