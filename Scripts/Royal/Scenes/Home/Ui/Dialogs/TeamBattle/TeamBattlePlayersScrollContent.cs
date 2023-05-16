using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.TeamBattle
{
    public class TeamBattlePlayersScrollContent : UiExpandableScrollContent
    {
        // Fields
        public int poolCount;
        public System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData> dataList;
        public System.Collections.Generic.Dictionary<int, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem> pool;
        private int notContributingIndex;
        private int notParticipatingIndex;
        private int minIndex;
        private int maxIndex;
        
        // Methods
        private void Awake()
        {
            this.dataList = new System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData>();
            this.pool = new System.Collections.Generic.Dictionary<System.Int32, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem>(capacity:  this.poolCount);
            this.minIndex = -4294967296;
            this.maxIndex = -1;
        }
        public override void AddData(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data)
        {
            float val_5;
            if((this.dataList.Contains(item:  data)) != false)
            {
                    return;
            }
            
            this.dataList.Add(item:  data);
            if((data != null) && (null == null))
            {
                    data.System.IDisposable.Dispose();
                if((null & 255) == 0)
            {
                    this.notContributingIndex = 1;
            }
            else
            {
                    if(null >= 256)
            {
                    this.notParticipatingIndex = 1;
            }
            
            }
            
            }
            
            int val_5 = this.poolCount;
            int val_6 = this.maxIndex;
            val_5 = val_5 - 1;
            if(val_6 < val_5)
            {
                    val_6 = val_6 + 1;
                this.maxIndex = val_6;
                float val_4 = this.GetPositionByIndex(index:  47587328);
                this.PopulateData(item:  UnityEngine.Object.Instantiate<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem>(original:  X22, parent:  this.transform), position:  val_4, index:  this.maxIndex);
            }
            
            if(data != null)
            {
                    if(null != null)
            {
                
            }
            else
            {
                    val_5 = 0.85f;
            }
            
            }
            
            val_5 = val_5 + S2;
            val_4 = val_4 + val_5;
            this.Size = val_4;
        }
        private float GetSizeForType(bool isBanner)
        {
            float val_2;
            if(isBanner != false)
            {
                    val_2 = 0.85f;
                return (float)S0 + S1;
            }
            
            return (float)S0 + S1;
        }
        public override void OnContentMoved(float newLocation)
        {
            float val_1 = S9 + S10;
            val_1 = newLocation / val_1;
            int val_4 = (UnityEngine.Mathf.RoundToInt(f:  val_1)) - (((this.poolCount < 0) ? (this.poolCount + 1) : this.poolCount) >> 1);
            int val_5 = System.Math.Max(val1:  0, val2:  val_4);
            val_4 = (val_5 + this.poolCount) - 1;
            int val_8 = System.Math.Min(val1:  this.dataList - 1, val2:  val_4);
            if((val_5 > this.minIndex) && (val_8 > this.maxIndex))
            {
                    do
            {
                this.SwapIndex(from:  this.minIndex, to:  this.maxIndex + 1);
                int val_10 = this.minIndex + 1;
                this.minIndex = val_10;
                this.maxIndex = this.maxIndex + 1;
            }
            while(val_5 > val_10);
            
                return;
            }
            
            if(val_5 >= this.minIndex)
            {
                    return;
            }
            
            if(val_8 >= this.maxIndex)
            {
                    return;
            }
            
            do
            {
                this.SwapIndex(from:  this.maxIndex, to:  this.minIndex - 1);
                int val_13 = this.minIndex - 1;
                this.minIndex = val_13;
                this.maxIndex = this.maxIndex - 1;
            }
            while(val_5 < val_13);
        
        }
        public void SwapIndex(int from, int to)
        {
            int val_5 = from;
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_1 = 0;
            if((this.pool.TryGetValue(key:  val_5 = from, value: out  val_1)) == false)
            {
                    return;
            }
            
            System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData> val_5 = this.dataList;
            val_5 = val_5 - 1;
            if(val_5 < to)
            {
                    return;
            }
            
            bool val_3 = this.pool.Remove(key:  val_5);
            val_5 = val_1;
            this.PopulateData(item:  val_5, position:  this.GetPositionByIndex(index:  to), index:  to);
        }
        private float GetPositionByIndex(int index)
        {
            float val_7 = 1f;
            float val_1 = S3 + S2;
            float val_2 = S3 + 0.85f;
            float val_3 = (this.notContributingIndex > index) ? (val_7) : 0f;
            float val_4 = (this.notParticipatingIndex == index) ? (val_7) : 0f;
            val_7 = val_3 + val_7;
            float val_5 = (this.notParticipatingIndex > index) ? (val_7) : (val_3);
            float val_6 = val_2 + val_1;
            float val_8 = 0.5f;
            val_6 = val_4 * val_6;
            val_8 = val_6 * val_8;
            val_2 = val_2 * val_5;
            val_5 = (float)index - val_5;
            val_4 = val_5 - val_4;
            val_4 = val_1 * val_4;
            val_4 = val_2 + val_4;
            val_4 = val_8 + val_4;
            return (float)val_4;
        }
        private void MoveNextIndex(int delta)
        {
            int val_1 = this.minIndex;
            val_1 = V1.2S + val_1;
            this.minIndex = val_1;
        }
        public void PopulateData(Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem item, float position, int index)
        {
            bool val_1 = true;
            if(val_1 <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (index << 3);
            this.PopulateData(item:  item, position:  position, data:  (true + (index) << 3) + 32);
            this.pool.set_Item(key:  index, value:  item);
        }
        public override void Clear()
        {
            if((this.maxIndex & 2147483648) == 0)
            {
                    var val_5 = 0;
                do
            {
                if((this.pool.TryGetValue(key:  0, value: out  0)) != false)
            {
                    UnityEngine.Object.Destroy(obj:  val_1.gameObject);
                bool val_4 = this.pool.Remove(key:  0);
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 <= this.maxIndex);
            
            }
            
            this.dataList.Clear();
            this.Size = 0f;
            this.notContributingIndex = ;
            this.notParticipatingIndex = ;
            this.minIndex = 18446744069414584320;
            this.maxIndex = 4294967295;
        }
        public TeamBattlePlayersScrollContent()
        {
            this.notContributingIndex = -1;
            this.notParticipatingIndex = -1;
        }
    
    }

}
