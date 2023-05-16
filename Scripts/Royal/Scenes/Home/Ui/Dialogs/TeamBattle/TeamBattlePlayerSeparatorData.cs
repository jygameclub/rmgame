using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.TeamBattle
{
    public struct TeamBattlePlayerSeparatorData : IUiScrollContentData
    {
        // Fields
        public readonly bool isContribution;
        public readonly bool isParticipation;
        
        // Methods
        public TeamBattlePlayerSeparatorData(bool isContribution, bool isParticipation)
        {
            mem[1152921519169849520] = isContribution;
            mem[1152921519169849521] = isParticipation;
        }
    
    }

}
