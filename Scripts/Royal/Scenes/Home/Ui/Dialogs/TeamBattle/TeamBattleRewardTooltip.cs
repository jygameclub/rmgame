using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.TeamBattle
{
    public class TeamBattleRewardTooltip : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject teamMessage;
        public UnityEngine.GameObject playerMessage;
        public UnityEngine.GameObject upArrow;
        public UnityEngine.GameObject downArrow;
        public TMPro.TextMeshPro infoText;
        
        // Methods
        public void ArrangePosition(bool forTeam, bool atDown)
        {
            forTeam = forTeam;
            this.teamMessage.SetActive(value:  forTeam);
            this.playerMessage.SetActive(value:  (~forTeam) & 1);
            this.upArrow.SetActive(value:  atDown);
            this.downArrow.SetActive(value:  (~atDown) & 1);
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            this = this.infoText.rectTransform;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  2.8f, y:  0.78f);
            this.sizeDelta = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        }
        public TeamBattleRewardTooltip()
        {
        
        }
    
    }

}
