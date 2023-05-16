using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MatchItem
{
    public class MatchItemCounts
    {
        // Fields
        private int[] explodeCounts;
        
        // Methods
        public void Reset()
        {
            this.explodeCounts = new int[5];
        }
        public static void ItemExploded(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, int count = 1)
        {
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_80.IncrementCount(matchType:  matchType, count:  count);
        }
        private void IncrementCount(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, int count)
        {
            if()
            {
                    return;
            }
            
            if(matchType > 5)
            {
                    return;
            }
            
            int val_2 = this.explodeCounts[matchType - 1];
            val_2 = val_2 + count;
            this.explodeCounts[matchType - 1] = val_2;
        }
        private int GetIndex(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            if()
            {
                    return 0;
            }
            
            return (int)(matchType < 6) ? (matchType - 1) : (!0);
        }
        private int GetCount(Royal.Scenes.Game.Mechanics.Matches.MatchType type)
        {
            int val_2;
            if( && (type <= 5))
            {
                    val_2 = this.explodeCounts[type - 1];
                return (int)val_2;
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        public Royal.Infrastructure.Services.Analytics.MatchItemCountsJson Serialize()
        {
            .blue = this.GetCount(type:  1);
            .green = this.GetCount(type:  2);
            .red = this.GetCount(type:  3);
            .yellow = this.GetCount(type:  4);
            .pink = this.GetCount(type:  5);
            return (Royal.Infrastructure.Services.Analytics.MatchItemCountsJson)new Royal.Infrastructure.Services.Analytics.MatchItemCountsJson();
        }
        public MatchItemCounts()
        {
            this.explodeCounts = new int[5];
        }
    
    }

}
