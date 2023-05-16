using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CoinItem.Collect
{
    public static class CoinBezierCollect
    {
        // Methods
        public static System.Collections.IEnumerator CollectToGoal(Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView itemView, UnityEngine.Vector3 goalPosition, System.Action onComplete)
        {
            .<>1__state = 0;
            .itemView = itemView;
            .goalPosition = goalPosition;
            mem[1152921523819366492] = goalPosition.y;
            mem[1152921523819366496] = goalPosition.z;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new CoinBezierCollect.<CollectToGoal>d__0();
        }
        public static System.Collections.IEnumerator CollectToUserInfo(Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView itemView, UnityEngine.Vector3 goalPosition, System.Action onComplete)
        {
            .<>1__state = 0;
            .itemView = itemView;
            .goalPosition = goalPosition;
            mem[1152921523819503068] = goalPosition.y;
            mem[1152921523819503072] = goalPosition.z;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new CoinBezierCollect.<CollectToUserInfo>d__1();
        }
    
    }

}
