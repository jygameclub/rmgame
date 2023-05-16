using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect
{
    public static class MatchCollectManagerAnimation
    {
        // Fields
        private const float CollectDuration = 0.7;
        private const float XOffset = -1;
        private const float YOffset = -2.5;
        private const float StartSpeed = 1;
        private const float StartSpeedCoefficientVertical = 0.2;
        private const float StartSpeedCoefficientHorizontal = 0.2;
        private const float MinSpeed = 1;
        private const float MinCollectSpeed = 0.2;
        private const float NormalDelayOffset = 0.04;
        private const float SpecialDelayOffset = 0.07;
        private const float MinSpeedVerticalCoefficient = 0.1;
        private const float HorizontalOffsetCoefficientY = 0.4;
        private const float HorizontalOffsetCoefficientX = 0.5;
        private const float VerticalOffsetCoefficientY = 1;
        private const int CollectSortingMax = 1000;
        private const int CurtainAtLeft = 1;
        private const int CurtainAtMiddle = 0;
        private const int CurtainAtRight = -1;
        private const int CurtainAtBottom = -1;
        private const int CurtainAtTop = 1;
        
        // Methods
        public static System.Collections.IEnumerator Collect(Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView itemView, Royal.Scenes.Game.Mechanics.Items.MatchItem.View.IMatchItemViewDelegate viewDelegate, Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager collectManager, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel currentCell, Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectData collectData)
        {
            .<>1__state = 0;
            .currentCell = currentCell;
            .viewDelegate = viewDelegate;
            .itemView = itemView;
            .collectManager = collectManager;
            return (System.Collections.IEnumerator)new MatchCollectManagerAnimation.<Collect>d__20();
        }
    
    }

}
