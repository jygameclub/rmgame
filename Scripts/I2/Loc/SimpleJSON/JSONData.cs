using UnityEngine;

namespace I2.Loc.SimpleJSON
{
    public class JSONData : JSONNode
    {
        // Fields
        private string m_Data;
        
        // Properties
        public override string Value { get; set; }
        
        // Methods
        public override string get_Value()
        {
            return (string)this.m_Data;
        }
        public override void set_Value(string value)
        {
            this.m_Data = value;
        }
        public JSONData(string aData)
        {
            this.m_Data = aData;
        }
        public JSONData(float aData)
        {
            this.AsFloat = aData;
        }
        public JSONData(double aData)
        {
            this.AsDouble = aData;
        }
        public JSONData(bool aData)
        {
            this.AsBool = aData;
        }
        public JSONData(int aData)
        {
            this.AsInt = aData;
        }
        public override string ToString()
        {
            return "\"" + I2.Loc.SimpleJSON.JSONNode.Escape(aText:  this.m_Data)(I2.Loc.SimpleJSON.JSONNode.Escape(aText:  this.m_Data)) + "\"";
        }
        public override string ToString(string aPrefix)
        {
            return "\"" + I2.Loc.SimpleJSON.JSONNode.Escape(aText:  this.m_Data)(I2.Loc.SimpleJSON.JSONNode.Escape(aText:  this.m_Data)) + "\"";
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_11;
            var val_14;
            var val_15;
            System.Xml.Schema.ParticleContentValidator val_16;
            var val_18;
            System.Xml.Schema.ParticleContentValidator val_29;
            var val_30;
            var val_31;
            var val_32;
            val_29 = aWriter;
            val_30 = this;
            I2.Loc.SimpleJSON.JSONData val_1 = null;
            val_31 = val_1;
            val_1 = new I2.Loc.SimpleJSON.JSONData();
            .m_Data = "";
            val_1.AsInt = this.AsInt;
            if((System.String.op_Equality(a:  (I2.Loc.SimpleJSON.JSONData)[1152921528835162944].m_Data, b:  this.m_Data)) == false)
            {
                goto label_2;
            }
            
            int val_4 = this.AsInt;
            label_10:
            val_32 = ???;
            val_30 = ???;
            val_29 = ???;
            val_31 = ???;
            goto typeof(System.IO.BinaryWriter).__il2cppRuntimeField_230;
            label_2:
            if((System.String.op_Equality(a:  val_31 + 16, b:  val_30 + 16)) == false)
            {
                goto label_4;
            }
            
            val_32 = val_7;
            val_30 = val_8;
            val_29 = val_9;
            val_31 = val_11;
            goto val_29 + 624;
            label_4:
            if((System.String.op_Equality(a:  val_11 + 16, b:  val_8 + 16)) == false)
            {
                goto label_6;
            }
            
            val_32 = val_14;
            val_30 = val_15;
            val_29 = val_16;
            val_31 = val_18;
            goto val_9 + 512;
            label_6:
            var val_19 = val_30 & 1;
            if((System.String.op_Equality(a:  val_18 + 16, b:  val_15 + 16)) == false)
            {
                goto label_9;
            }
            
            var val_21 = val_30 & 1;
            goto label_10;
            label_9:
            System.Xml.Schema.ParticleContentValidator val_28 = val_29;
            goto val_16 + 640;
        }
    
    }

}
