using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer
{
    [Serializable]
    public struct RewardTypeInfo
    {
        // Fields
        public Royal.Player.Context.Units.RewardType rewardType;
        public UnityEngine.GameObject info;
        public TMPro.TextMeshPro tntAmountText;
        public TMPro.TextMeshPro rocketAmountText;
        public TMPro.TextMeshPro lightballAmountText;
        public TMPro.TextMeshPro hammerAmountText;
        public TMPro.TextMeshPro cannonAmountText;
        public TMPro.TextMeshPro arrowAmountText;
        public TMPro.TextMeshPro jesterAmountText;
        public TMPro.TextMeshPro coinAmountText;
        
    
    }

}
