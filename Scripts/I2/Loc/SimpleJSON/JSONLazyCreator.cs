using UnityEngine;

namespace I2.Loc.SimpleJSON
{
    internal class JSONLazyCreator : JSONNode
    {
        // Fields
        private I2.Loc.SimpleJSON.JSONNode m_Node;
        private string m_Key;
        
        // Properties
        public override I2.Loc.SimpleJSON.JSONNode Item { get; set; }
        public override I2.Loc.SimpleJSON.JSONNode Item { get; set; }
        public override int AsInt { get; set; }
        public override float AsFloat { get; set; }
        public override double AsDouble { get; set; }
        public override bool AsBool { get; set; }
        public override I2.Loc.SimpleJSON.JSONArray AsArray { get; }
        public override I2.Loc.SimpleJSON.JSONClass AsObject { get; }
        
        // Methods
        public JSONLazyCreator(I2.Loc.SimpleJSON.JSONNode aNode)
        {
            val_1 = new System.Object();
            this.m_Node = aNode;
            this.m_Key = 0;
        }
        public JSONLazyCreator(I2.Loc.SimpleJSON.JSONNode aNode, string aKey)
        {
            val_1 = new System.Object();
            this.m_Node = aNode;
            this.m_Key = val_1;
        }
        private void Set(I2.Loc.SimpleJSON.JSONNode aVal)
        {
            if(this.m_Key != null)
            {
                
            }
            
            this.m_Node = 0;
        }
        public override I2.Loc.SimpleJSON.JSONNode get_Item(int aIndex)
        {
            .m_Node = this;
            .m_Key = 0;
            return (I2.Loc.SimpleJSON.JSONNode)new I2.Loc.SimpleJSON.JSONLazyCreator();
        }
        public override void set_Item(int aIndex, I2.Loc.SimpleJSON.JSONNode value)
        {
            I2.Loc.SimpleJSON.JSONArray val_1 = new I2.Loc.SimpleJSON.JSONArray();
            val_1.Add(aItem:  value);
            this.Set(aVal:  val_1);
        }
        public override I2.Loc.SimpleJSON.JSONNode get_Item(string aKey)
        {
            .m_Node = this;
            .m_Key = aKey;
            return (I2.Loc.SimpleJSON.JSONNode)new I2.Loc.SimpleJSON.JSONLazyCreator();
        }
        public override void set_Item(string aKey, I2.Loc.SimpleJSON.JSONNode value)
        {
            this.Set(aVal:  new I2.Loc.SimpleJSON.JSONClass());
        }
        public override void Add(I2.Loc.SimpleJSON.JSONNode aItem)
        {
            I2.Loc.SimpleJSON.JSONArray val_1 = new I2.Loc.SimpleJSON.JSONArray();
            val_1.Add(aItem:  aItem);
            this.Set(aVal:  val_1);
        }
        public override void Add(string aKey, I2.Loc.SimpleJSON.JSONNode aItem)
        {
            this.Set(aVal:  new I2.Loc.SimpleJSON.JSONClass());
        }
        public static bool op_Equality(I2.Loc.SimpleJSON.JSONLazyCreator a, object b)
        {
            a = ((b == 0) ? 1 : 0) | ((a == b) ? 1 : 0);
            return (bool)a;
        }
        public static bool op_Inequality(I2.Loc.SimpleJSON.JSONLazyCreator a, object b)
        {
            a = ((a != b) ? 1 : 0) & ((b != 0) ? 1 : 0);
            return (bool)a;
        }
        public override bool Equals(object obj)
        {
            this = ((obj == 0) ? 1 : 0) | ((this == obj) ? 1 : 0);
            return (bool)this;
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        public override string ToString()
        {
            return "";
        }
        public override string ToString(string aPrefix)
        {
            return "";
        }
        public override int get_AsInt()
        {
            this.Set(aVal:  new I2.Loc.SimpleJSON.JSONData(aData:  0));
            return 0;
        }
        public override void set_AsInt(int value)
        {
            this.Set(aVal:  new I2.Loc.SimpleJSON.JSONData(aData:  value));
        }
        public override float get_AsFloat()
        {
            this.Set(aVal:  new I2.Loc.SimpleJSON.JSONData(aData:  0f));
            return 0f;
        }
        public override void set_AsFloat(float value)
        {
            this.Set(aVal:  new I2.Loc.SimpleJSON.JSONData(aData:  value));
        }
        public override double get_AsDouble()
        {
            this.Set(aVal:  new I2.Loc.SimpleJSON.JSONData(aData:  0));
            return 0;
        }
        public override void set_AsDouble(double value)
        {
            this.Set(aVal:  new I2.Loc.SimpleJSON.JSONData(aData:  value));
        }
        public override bool get_AsBool()
        {
            this.Set(aVal:  new I2.Loc.SimpleJSON.JSONData(aData:  false));
            return false;
        }
        public override void set_AsBool(bool value)
        {
            I2.Loc.SimpleJSON.JSONData val_1 = null;
            value = value;
            val_1 = new I2.Loc.SimpleJSON.JSONData(aData:  value);
            this.Set(aVal:  val_1);
        }
        public override I2.Loc.SimpleJSON.JSONArray get_AsArray()
        {
            I2.Loc.SimpleJSON.JSONArray val_1 = new I2.Loc.SimpleJSON.JSONArray();
            this.Set(aVal:  val_1);
            return val_1;
        }
        public override I2.Loc.SimpleJSON.JSONClass get_AsObject()
        {
            I2.Loc.SimpleJSON.JSONClass val_1 = new I2.Loc.SimpleJSON.JSONClass();
            this.Set(aVal:  val_1);
            return val_1;
        }
    
    }

}
