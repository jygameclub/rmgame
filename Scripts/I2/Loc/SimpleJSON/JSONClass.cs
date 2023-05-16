using UnityEngine;

namespace I2.Loc.SimpleJSON
{
    public class JSONClass : JSONNode, IEnumerable
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, I2.Loc.SimpleJSON.JSONNode> m_Dict;
        
        // Properties
        public override I2.Loc.SimpleJSON.JSONNode Item { get; set; }
        public override I2.Loc.SimpleJSON.JSONNode Item { get; set; }
        public override int Count { get; }
        public override System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode> Childs { get; }
        
        // Methods
        public override I2.Loc.SimpleJSON.JSONNode get_Item(string aKey)
        {
            if((this.m_Dict.ContainsKey(key:  aKey)) == false)
            {
                    return (I2.Loc.SimpleJSON.JSONNode)new I2.Loc.SimpleJSON.JSONLazyCreator(aNode:  this, aKey:  aKey);
            }
            
            return this.m_Dict.Item[aKey];
        }
        public override void set_Item(string aKey, I2.Loc.SimpleJSON.JSONNode value)
        {
            if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    this.m_Dict.set_Item(key:  aKey, value:  value);
                return;
            }
            
            this.m_Dict.Add(key:  aKey, value:  value);
        }
        public override I2.Loc.SimpleJSON.JSONNode get_Item(int aIndex)
        {
            var val_3;
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_Dict.Count > aIndex)
            {
                    System.Collections.Generic.KeyValuePair<System.String, I2.Loc.SimpleJSON.JSONNode> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, I2.Loc.SimpleJSON.JSONNode>>(source:  this.m_Dict, index:  aIndex);
                val_3 = aIndex;
                return (I2.Loc.SimpleJSON.JSONNode)val_3;
            }
            
            }
            
            val_3 = 0;
            return (I2.Loc.SimpleJSON.JSONNode)val_3;
        }
        public override void set_Item(int aIndex, I2.Loc.SimpleJSON.JSONNode value)
        {
            if((aIndex & 2147483648) != 0)
            {
                    return;
            }
            
            if(this.m_Dict.Count <= aIndex)
            {
                    return;
            }
            
            System.Collections.Generic.KeyValuePair<System.String, I2.Loc.SimpleJSON.JSONNode> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, I2.Loc.SimpleJSON.JSONNode>>(source:  this.m_Dict, index:  aIndex);
            this.m_Dict.set_Item(key:  val_2.Value, value:  value);
        }
        public override int get_Count()
        {
            return this.m_Dict.Count;
        }
        public override void Add(string aKey, I2.Loc.SimpleJSON.JSONNode aItem)
        {
            string val_4;
            var val_5;
            if((System.String.IsNullOrEmpty(value:  aKey)) != false)
            {
                    System.Guid val_2 = System.Guid.NewGuid();
                val_4 = ;
                val_5 = public System.Void System.Collections.Generic.Dictionary<System.String, I2.Loc.SimpleJSON.JSONNode>::Add(System.String key, I2.Loc.SimpleJSON.JSONNode value);
            }
            else
            {
                    if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    this.m_Dict.set_Item(key:  aKey, value:  aItem);
                return;
            }
            
                val_4 = aKey;
                val_5 = public System.Void System.Collections.Generic.Dictionary<System.String, I2.Loc.SimpleJSON.JSONNode>::Add(System.String key, I2.Loc.SimpleJSON.JSONNode value);
            }
            
            this.m_Dict.Add(key:  val_4, value:  aItem);
        }
        public override I2.Loc.SimpleJSON.JSONNode Remove(string aKey)
        {
            var val_4;
            if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    val_4 = this.m_Dict.Item[aKey];
                bool val_3 = this.m_Dict.Remove(key:  aKey);
                return (I2.Loc.SimpleJSON.JSONNode)val_4;
            }
            
            val_4 = 0;
            return (I2.Loc.SimpleJSON.JSONNode)val_4;
        }
        public override I2.Loc.SimpleJSON.JSONNode Remove(int aIndex)
        {
            var val_4;
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_Dict.Count > aIndex)
            {
                    System.Collections.Generic.KeyValuePair<System.String, I2.Loc.SimpleJSON.JSONNode> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, I2.Loc.SimpleJSON.JSONNode>>(source:  this.m_Dict, index:  aIndex);
                val_4 = aIndex;
                bool val_3 = this.m_Dict.Remove(key:  val_2.Value);
                return (I2.Loc.SimpleJSON.JSONNode)val_4;
            }
            
            }
            
            val_4 = 0;
            return (I2.Loc.SimpleJSON.JSONNode)val_4;
        }
        public override I2.Loc.SimpleJSON.JSONNode Remove(I2.Loc.SimpleJSON.JSONNode aNode)
        {
            JSONClass.<>c__DisplayClass12_0 val_1 = new JSONClass.<>c__DisplayClass12_0();
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            .aNode = aNode;
            System.Collections.Generic.KeyValuePair<System.String, I2.Loc.SimpleJSON.JSONNode> val_4 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.String, I2.Loc.SimpleJSON.JSONNode>>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, I2.Loc.SimpleJSON.JSONNode>>(source:  this.m_Dict, predicate:  new System.Func<System.Collections.Generic.KeyValuePair<System.String, I2.Loc.SimpleJSON.JSONNode>, System.Boolean>(object:  val_1, method:  System.Boolean JSONClass.<>c__DisplayClass12_0::<Remove>b__0(System.Collections.Generic.KeyValuePair<string, I2.Loc.SimpleJSON.JSONNode> k))));
            bool val_5 = this.m_Dict.Remove(key:  val_4.Value);
            return (I2.Loc.SimpleJSON.JSONNode)(JSONClass.<>c__DisplayClass12_0)[1152921528830922384].aNode;
        }
        public override System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode> get_Childs()
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            .<>4__this = this;
            return (System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>)new JSONClass.<get_Childs>d__14();
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new JSONClass.<GetEnumerator>d__15();
        }
        public override string ToString()
        {
            string val_3;
            var val_4;
            string val_10;
            string val_11;
            int val_12;
            var val_13;
            int val_14;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.m_Dict.GetEnumerator();
            label_23:
            if(((-1545367776) & 1) == 0)
            {
                goto label_2;
            }
            
            val_11 = "{";
            string[] val_6 = new string[5];
            if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_12 = val_6.Length;
            if(val_12 == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_6[0] = ;
            if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            val_12 = val_6.Length;
            val_6[1] = "\"";
            val_13 = 0;
            string val_7 = I2.Loc.SimpleJSON.JSONNode.Escape(aText:  val_3);
            if(val_7 != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            val_14 = val_6.Length;
            if(val_14 <= 2)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_6[2] = val_7;
            val_10 = "\":";
            if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            val_14 = val_6.Length;
            if(val_14 <= 3)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_6[3] = "\":";
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_10 = val_3;
            if(val_10 != 0)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            if(val_6.Length <= 4)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_6[4] = val_10;
            string val_8 = +val_6;
            goto label_23;
            label_2:
            val_4.Dispose();
            return (string)"{" + "}";
        }
        public override string ToString(string aPrefix)
        {
            string val_3;
            var val_4;
            string val_12;
            string val_13;
            int val_14;
            int val_15;
            val_12 = "{ ";
            Dictionary.Enumerator<TKey, TValue> val_1 = this.m_Dict.GetEnumerator();
            label_22:
            if(((-1545194080) & 1) == 0)
            {
                goto label_2;
            }
            
            val_12 = val_12 + ", ";
            string[] val_7 = new string[5];
            if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_14 = val_7.Length;
            if(val_14 == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_7[0] = val_12 + "\n" + aPrefix + "   ";
            val_13 = "\"";
            if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            val_14 = val_7.Length;
            if(val_14 <= 1)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_7[1] = "\"";
            string val_8 = I2.Loc.SimpleJSON.JSONNode.Escape(aText:  val_3);
            if(val_8 != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            val_15 = val_7.Length;
            if(val_15 <= 2)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_7[2] = val_8;
            if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            val_15 = val_7.Length;
            val_7[3] = "\" : ";
            string val_9 = aPrefix + "   ";
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_13 = val_3;
            if(val_13 != 0)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            if(val_7.Length <= 4)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_7[4] = val_13;
            string val_10 = +val_7;
            goto label_22;
            label_2:
            val_4.Dispose();
            return (string)val_12 + "\n" + aPrefix + "}";
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            string val_5;
            System.Collections.Generic.Dictionary<System.String, I2.Loc.SimpleJSON.JSONNode> val_6;
            int val_1 = this.m_Dict.Count;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = this.m_Dict.Keys.GetEnumerator();
            label_8:
            if(((-1545016440) & 1) == 0)
            {
                goto label_5;
            }
            
            val_5 = 0;
            val_6 = this.m_Dict;
            if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_5 = 0;
            if(val_6.Item[val_5] == null)
            {
                    throw new NullReferenceException();
            }
            
            goto label_8;
            label_5:
            0.Dispose();
        }
        public JSONClass()
        {
            null = null;
            this.m_Dict = new System.Collections.Generic.Dictionary<System.String, I2.Loc.SimpleJSON.JSONNode>(comparer:  System.StringComparer._ordinal);
        }
    
    }

}
