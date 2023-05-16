using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends
{
    public class FriendsScrollView : MonoBehaviour
    {
        // Fields
        public Royal.Infrastructure.UiComponents.Scroll.Content.UiOptimizedScrollContent content;
        public UnityEngine.BoxCollider2D boxCollider;
        
        // Methods
        public void PrepareContent()
        {
            var val_15;
            int val_16;
            var val_17;
            System.Func<Royal.Infrastructure.Services.Storage.Tables.Leader, System.Boolean> val_19;
            UnityEngine.Object val_20;
            Royal.Infrastructure.UiComponents.Scroll.Content.UiOptimizedScrollContent val_21;
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_22;
            val_15 = this;
            val_16 = 1152921505029689344;
            val_17 = null;
            val_17 = null;
            val_19 = FriendsScrollView.<>c.<>9__2_0;
            if(val_19 == null)
            {
                    System.Func<Royal.Infrastructure.Services.Storage.Tables.Leader, System.Boolean> val_2 = null;
                val_19 = val_2;
                val_2 = new System.Func<Royal.Infrastructure.Services.Storage.Tables.Leader, System.Boolean>(object:  FriendsScrollView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FriendsScrollView.<>c::<PrepareContent>b__2_0(Royal.Infrastructure.Services.Storage.Tables.Leader friendData));
                FriendsScrollView.<>c.<>9__2_0 = val_19;
            }
            
            val_20 = System.Linq.Enumerable.ToList<Royal.Infrastructure.Services.Storage.Tables.Leader>(source:  System.Linq.Enumerable.Where<Royal.Infrastructure.Services.Storage.Tables.Leader>(source:  Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetLeaderboard(type:  1), predicate:  val_2));
            System.Collections.Generic.Dictionary<System.Int32, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem> val_5 = new System.Collections.Generic.Dictionary<System.Int32, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem>(dictionary:  this.content.pool);
            val_21 = this.content;
            val_21.ClearButDontDestroyItems();
            if(1152921519067898848 >= 1)
            {
                    var val_15 = 0;
                do
            {
                if(0 >= 1152921519067898848)
            {
                    val_21 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_16 = this.FindItemKeyInPool(pool:  val_5, facebookId:  "Hash key cannot be changed after the first write to the stream.");
                Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData val_8 = null;
                int val_7 = 0 + 1;
                val_8 = new Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData();
                .rank = val_7;
                mem[1152921519074546696] = "Hash key cannot be changed after the first write to the stream.";
                mem[1152921519074546704] = null;
                mem[1152921519074546648] = public System.Void System.Collections.Generic.List<UnityEngine.UI.Graphic>::Sort(System.Comparison<T> comparison);
                mem[1152921519074546680] = "Cannot create a data handler without payload data";
                mem[1152921519074546664] = null;
                .leader = System.Byte[];
                .scrollView = 0;
                if((val_16 != 1) && (0 < this.content.poolCount))
            {
                    val_22 = val_5.Item[val_16];
                val_22.UpdateData(leaderboardRowData:  val_8);
                bool val_10 = val_5.Remove(key:  val_16);
            }
            else
            {
                    val_22 = 0;
            }
            
                this.content.AddDataNotItem(data:  val_8, item:  val_22);
                val_15 = val_15 + 80;
            }
            while(val_7 < null);
            
            }
            
            if(val_5.Count < 1)
            {
                    return;
            }
            
            val_16 = 1152921519067913568;
            do
            {
                System.Collections.Generic.KeyValuePair<System.Int32, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem> val_12 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.Int32, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem>>(source:  val_5, index:  0);
                val_20 = 0.gameObject;
                UnityEngine.Object.Destroy(obj:  val_20);
                val_15 = 0 + 1;
            }
            while(val_15 < val_5.Count);
        
        }
        public void SetSize(float width, float height)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  width, y:  height);
            this.boxCollider.size = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        private int FindItemKeyInPool(System.Collections.Generic.Dictionary<int, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem> pool, long facebookId)
        {
            var val_4;
            var val_5;
            if(pool.Count >= 1)
            {
                    val_4 = 0;
                do
            {
                System.Collections.Generic.KeyValuePair<System.Int32, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.Int32, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem>>(source:  pool, index:  0);
                if(45209896 == facebookId)
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
        public FriendsScrollView()
        {
        
        }
    
    }

}
