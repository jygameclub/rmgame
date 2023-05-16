using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Leaderboard.Players
{
    public class PlayersScrollView : AScrollView
    {
        // Methods
        public override void PrepareContent(System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Leader> players)
        {
            var val_14;
            Royal.Infrastructure.Services.Storage.Tables.Leader val_15;
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_16;
            var val_17;
            UnityEngine.Vector3 val_2 = 27662.transform.localPosition;
            mem[1152921519070451100] = val_2.y;
            mem[1152921519070451088] = 0;
            System.Collections.Generic.Dictionary<System.Int32, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem> val_3 = new System.Collections.Generic.Dictionary<System.Int32, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem>(dictionary:  X9 + 112);
            val_3.ClearButDontDestroyItems();
            mem[1152921519070451096] = 1152921519067898848;
            if(1152921519067898848 >= 1)
            {
                    var val_14 = 0;
                if(0 >= 1152921519067898848)
            {
                    val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_15 = System.Byte[];
                int val_4 = this.FindItemKeyInPool(pool:  val_3, userId:  public List.Enumerator<T> System.Collections.Generic.List<com.adjust.sdk.JSONNode>::GetEnumerator());
                Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData val_6 = new Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData();
                .rank = 0 + 1;
                .leader = val_15;
                mem[1152921519070495360] = public List.Enumerator<T> System.Collections.Generic.List<com.adjust.sdk.JSONNode>::GetEnumerator();
                .scrollView = this;
                mem[1152921519070495416] = "Hash key cannot be changed after the first write to the stream.";
                mem[1152921519070495400] = "Cannot create a data handler without payload data";
                mem[1152921519070495384] = null;
                mem[1152921519070495368] = public System.Void System.Collections.Generic.List<UnityEngine.UI.Graphic>::Sort(System.Comparison<T> comparison);
                mem[1152921519070451088] = val_6;
                if(val_4 != 1)
            {
                    val_16 = val_3.Item[val_4];
                val_16.UpdateView(leaderboardRowData:  val_6);
                bool val_8 = val_3.Remove(key:  val_4);
            }
            else
            {
                    val_16 = 0;
            }
            
                val_6.AddDataNotItem(data:  val_6, item:  val_16);
                val_14 = val_14 + 80;
            }
            
            val_17 = val_3;
            if(val_3.Count >= 1)
            {
                    val_15 = 1152921504784535552;
                var val_15 = 0;
                do
            {
                System.Collections.Generic.KeyValuePair<System.Int32, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem> val_10 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.Int32, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem>>(source:  val_3, index:  0);
                UnityEngine.Object.Destroy(obj:  0.gameObject);
                val_17 = val_3;
                val_15 = val_15 + 1;
            }
            while(val_15 < val_3.Count);
            
            }
            
            if(val_15 <= Royal.Scenes.Home.Ui.Sections.Leaderboard.AScrollView.FullVisibleRowCount())
            {
                    return;
            }
        
        }
        private int FindItemKeyInPool(System.Collections.Generic.Dictionary<int, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem> pool, long userId)
        {
            var val_4;
            var val_5;
            if(pool.Count >= 1)
            {
                    val_4 = 0;
                do
            {
                System.Collections.Generic.KeyValuePair<System.Int32, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.Int32, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem>>(source:  pool, index:  0);
                if(4251056 == userId)
            {
                    return (int)val_5;
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < pool.Count);
            
            }
            
            val_5 = 0;
            return (int)val_5;
        }
        public PlayersScrollView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
