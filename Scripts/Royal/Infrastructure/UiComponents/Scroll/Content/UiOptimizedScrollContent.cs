using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Scroll.Content
{
    public class UiOptimizedScrollContent : UiExpandableScrollContent
    {
        // Fields
        public int poolCount;
        public System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData> dataList;
        public System.Collections.Generic.Dictionary<int, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem> pool;
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
            if((this.dataList.Contains(item:  data)) == true)
            {
                    return;
            }
            
            this.dataList.Add(item:  data);
            int val_5 = this.poolCount;
            int val_6 = this.maxIndex;
            val_5 = val_5 - 1;
            if(val_6 < val_5)
            {
                    val_6 = val_6 + 1;
                this.maxIndex = val_6;
                this.PopulateData(item:  UnityEngine.Object.Instantiate<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem>(original:  data, parent:  this.transform), position:  null, index:  this.maxIndex);
            }
            
            float val_4 = S1 + S0;
            val_4 = S2 + val_4;
            mem[1152921527518669468] = val_4;
            if(this == null)
            {
                    return;
            }
            
            this.Invoke();
        }
        public void AddDataOnly(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data)
        {
            if((this.dataList.Contains(item:  data)) == true)
            {
                    return;
            }
            
            this.dataList.Add(item:  data);
            float val_2 = S1 + S0;
            val_2 = S2 + val_2;
            mem[1152921527518814236] = val_2;
            if(this.dataList == null)
            {
                    return;
            }
            
            this.dataList.Invoke();
        }
        public void AddDataNotItem(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem item)
        {
            UnityEngine.Object val_6;
            Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData val_7;
            val_6 = item;
            val_7 = data;
            if((this.dataList.Contains(item:  val_7)) == true)
            {
                    return;
            }
            
            this.dataList.Add(item:  val_7);
            int val_6 = this.poolCount;
            int val_7 = this.maxIndex;
            val_6 = val_6 - 1;
            if(val_7 < val_6)
            {
                    val_7 = val_7 + 1;
                this.maxIndex = val_7;
                val_7 = 1152921504784535552;
                if(val_6 == 0)
            {
                    val_7 = this.transform;
                val_6 = UnityEngine.Object.Instantiate<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem>(original:  val_6, parent:  val_7);
            }
            
                this.PopulateData(item:  val_6, position:  null, index:  this.maxIndex);
            }
            
            float val_5 = S1 + S0;
            val_5 = S2 + val_5;
            mem[1152921527518963100] = val_5;
            if(this == null)
            {
                    return;
            }
            
            this.Invoke();
        }
        public int CalculateMinIndex(float newLocation)
        {
            float val_1 = S9 + S10;
            val_1 = newLocation / val_1;
            return System.Math.Max(val1:  0, val2:  (UnityEngine.Mathf.RoundToInt(f:  val_1)) - (((this.poolCount < 0) ? (this.poolCount + 1) : this.poolCount) >> 1));
        }
        public int CalculateMaxIndex(float newLocation)
        {
            return System.Math.Min(val1:  W21 - 1, val2:  ((this.CalculateMinIndex(newLocation:  newLocation)) + this.poolCount) - 1);
        }
        public void SetMinIndex(int index)
        {
            this.minIndex = index;
        }
        public void SetMaxIndex(int index)
        {
            this.maxIndex = index;
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
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_1 = 0;
            if((this.pool.TryGetValue(key:  from, value: out  val_1)) == false)
            {
                    return;
            }
            
            System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData> val_5 = this.dataList;
            val_5 = val_5 - 1;
            if(val_5 < to)
            {
                    return;
            }
            
            bool val_3 = this.pool.Remove(key:  from);
            float val_4 = S1 + S0;
            val_4 = val_4 * (float)to;
            this.PopulateData(item:  val_1, position:  val_4, index:  to);
        }
        public void RefreshIndex(int index)
        {
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_1 = 0;
            if((this.pool.TryGetValue(key:  index, value: out  val_1)) == false)
            {
                    return;
            }
            
            float val_3 = S1 + S0;
            val_3 = val_3 * (float)index;
            this.PopulateData(item:  val_1, position:  val_3, index:  index);
        }
        private void MoveNextIndex(int delta)
        {
            int val_1 = this.minIndex;
            val_1 = V1.2S + val_1;
            this.minIndex = val_1;
        }
        public float CalculateSizeForIndex(int index)
        {
            float val_1 = S1 + S0;
            val_1 = val_1 * (float)index;
            return (float)val_1;
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
            mem[1152921527520309788] = 0;
            if(this.dataList != null)
            {
                    this.dataList.Invoke();
            }
            
            this.minIndex = -4294967296;
            this.maxIndex = -1;
        }
        public void ClearButDontDestroyItems()
        {
            if((this.maxIndex & 2147483648) == 0)
            {
                    var val_3 = 0;
                do
            {
                if((this.pool.ContainsKey(key:  0)) != false)
            {
                    bool val_2 = this.pool.Remove(key:  0);
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 <= this.maxIndex);
            
            }
            
            this.dataList.Clear();
            mem[1152921527520451484] = 0;
            if(this.dataList != null)
            {
                    this.dataList.Invoke();
            }
            
            this.minIndex = -4294967296;
            this.maxIndex = -1;
        }
        public UiOptimizedScrollContent()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
