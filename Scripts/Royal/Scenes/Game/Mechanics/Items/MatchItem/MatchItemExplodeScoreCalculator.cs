using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MatchItem
{
    public static class MatchItemExplodeScoreCalculator
    {
        // Fields
        private static Royal.Scenes.Game.Mechanics.Matches.MatchType PrioritizedType;
        
        // Methods
        public static void PrioritizeMatchType(Royal.Scenes.Game.Mechanics.Matches.MatchType type)
        {
            Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemExplodeScoreCalculator.PrioritizedType = type;
        }
        public static void Reset()
        {
            Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemExplodeScoreCalculator.PrioritizedType = 0;
        }
        public static int CalculateScoreForMatchItem(Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel itemModel)
        {
            var val_4;
            if(itemModel.ShouldCalculateScore() != false)
            {
                    int val_2 = Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ExplodeScore(itemType:  itemModel);
                var val_3 = (typeof(Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel).__il2cppRuntimeField_1F0 == Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemExplodeScoreCalculator.PrioritizedType) ? (val_2 + 1) : (val_2);
                return (int)val_4;
            }
            
            val_4 = 0;
            return (int)val_4;
        }
    
    }

}
