using UnityEngine;

namespace I2.Loc.SimpleJSON
{
    public class JSONArray : JSONNode, IEnumerable
    {
        // Fields
        private System.Collections.Generic.List<I2.Loc.SimpleJSON.JSONNode> m_List;
        
        // Properties
        public override I2.Loc.SimpleJSON.JSONNode Item { get; set; }
        public override I2.Loc.SimpleJSON.JSONNode Item { get; set; }
        public override int Count { get; }
        public override System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode> Childs { get; }
        
        // Methods
        public override I2.Loc.SimpleJSON.JSONNode get_Item(int aIndex)
        {
            var val_2;
            bool val_2 = true;
            if(((aIndex & 2147483648) == 0) && (val_2 > aIndex))
            {
                    if(val_2 <= aIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + (aIndex << 3);
                val_2 = mem[(true + (aIndex) << 3) + 32];
                val_2 = (true + (aIndex) << 3) + 32;
                return (I2.Loc.SimpleJSON.JSONNode)val_2;
            }
            
            I2.Loc.SimpleJSON.JSONLazyCreator val_1 = null;
            val_2 = val_1;
            val_1 = new I2.Loc.SimpleJSON.JSONLazyCreator(aNode:  this);
            return (I2.Loc.SimpleJSON.JSONNode)val_2;
        }
        public override void set_Item(int aIndex, I2.Loc.SimpleJSON.JSONNode value)
        {
            if((aIndex & 2147483648) != 0)
            {
                goto label_1;
            }
            
            if(true <= aIndex)
            {
                goto label_3;
            }
            
            this.m_List.set_Item(index:  aIndex, value:  value);
            return;
            label_1:
            label_3:
            this.m_List.Add(item:  value);
        }
        public override I2.Loc.SimpleJSON.JSONNode get_Item(string aKey)
        {
            return (I2.Loc.SimpleJSON.JSONNode)new I2.Loc.SimpleJSON.JSONLazyCreator(aNode:  this);
        }
        public override void set_Item(string aKey, I2.Loc.SimpleJSON.JSONNode value)
        {
            this.m_List.Add(item:  value);
        }
        public override int get_Count()
        {
            return 20537;
        }
        public override void Add(string aKey, I2.Loc.SimpleJSON.JSONNode aItem)
        {
            this.m_List.Add(item:  aItem);
        }
        public override I2.Loc.SimpleJSON.JSONNode Remove(int aIndex)
        {
            var val_1;
            bool val_1 = true;
            if(((aIndex & 2147483648) == 0) && (val_1 > aIndex))
            {
                    if(val_1 <= aIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + (aIndex << 3);
                val_1 = mem[(true + (aIndex) << 3) + 32];
                val_1 = (true + (aIndex) << 3) + 32;
                this.m_List.RemoveAt(index:  aIndex);
                return (I2.Loc.SimpleJSON.JSONNode)val_1;
            }
            
            val_1 = 0;
            return (I2.Loc.SimpleJSON.JSONNode)val_1;
        }
        public override I2.Loc.SimpleJSON.JSONNode Remove(I2.Loc.SimpleJSON.JSONNode aNode)
        {
            bool val_1 = this.m_List.Remove(item:  aNode);
            return (I2.Loc.SimpleJSON.JSONNode)aNode;
        }
        public override System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode> get_Childs()
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            .<>4__this = this;
            return (System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>)new JSONArray.<get_Childs>d__13();
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new JSONArray.<GetEnumerator>d__14();
        }
        public override string ToString()
        {
            string val_5;
            string val_6;
            List.Enumerator<T> val_1 = this.m_List.GetEnumerator();
            label_8:
            val_6 = public System.Boolean List.Enumerator<I2.Loc.SimpleJSON.JSONNode>::MoveNext();
            if(((-1549389816) & 1) == 0)
            {
                goto label_2;
            }
            
            val_5 = "[ ";
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            string val_3 =  + 0;
            goto label_8;
            label_2:
            0.Dispose();
            return (string)"[ " + " ]";
        }
        public override string ToString(string aPrefix)
        {
            string val_7;
            string val_8 = "[ ";
            List.Enumerator<T> val_1 = this.m_List.GetEnumerator();
            label_6:
            if(((-1549232696) & 1) == 0)
            {
                goto label_2;
            }
            
            val_8 = val_8 + ", ";
            val_7 = val_8 + "\n" + aPrefix + "   ";
            string val_4 = aPrefix + "   ";
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            string val_5 = val_7 + 0;
            goto label_6;
            label_2:
            0.Dispose();
            return (string)val_8 + "\n" + aPrefix + "]";
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            var val_2 = 0;
            do
            {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_2 = val_2 + 1;
            }
            while(this.m_List != null);
            
            throw new NullReferenceException();
        }
        public JSONArray()
        {
            this.m_List = new System.Collections.Generic.List<I2.Loc.SimpleJSON.JSONNode>();
        }
    
    }

}
