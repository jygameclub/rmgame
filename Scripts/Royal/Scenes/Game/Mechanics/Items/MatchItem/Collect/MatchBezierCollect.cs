using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect
{
    public static class MatchBezierCollect
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
        
        // Methods
        public static System.Collections.IEnumerator CollectToGoalAnimation(Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView itemView, Royal.Scenes.Game.Mechanics.Items.MatchItem.View.IMatchItemViewDelegate itemViewDelegate, UnityEngine.Vector3 goalPosition, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel currentCell, Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectData collectData)
        {
            .<>1__state = 0;
            .currentCell = currentCell;
            .itemView = itemView;
            .itemViewDelegate = itemViewDelegate;
            .goalPosition = goalPosition;
            mem[1152921520247882980] = goalPosition.y;
            mem[1152921520247882984] = goalPosition.z;
            return (System.Collections.IEnumerator)new MatchBezierCollect.<CollectToGoalAnimation>d__15();
        }
    
    }

}
