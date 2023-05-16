using UnityEngine;

namespace com.adjust.sdk
{
    public class JSONNode
    {
        // Properties
        public virtual com.adjust.sdk.JSONNode Item { get; set; }
        public virtual com.adjust.sdk.JSONNode Item { get; set; }
        public virtual string Value { get; set; }
        public virtual int Count { get; }
        public virtual System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> Childs { get; }
        public System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> DeepChilds { get; }
        public virtual int AsInt { get; set; }
        public virtual float AsFloat { get; set; }
        public virtual double AsDouble { get; set; }
        public virtual bool AsBool { get; set; }
        public virtual com.adjust.sdk.JSONArray AsArray { get; }
        public virtual com.adjust.sdk.JSONClass AsObject { get; }
        
        // Methods
        public virtual void Add(string aKey, com.adjust.sdk.JSONNode aItem)
        {
        
        }
        public virtual com.adjust.sdk.JSONNode get_Item(int aIndex)
        {
            return 0;
        }
        public virtual void set_Item(int aIndex, com.adjust.sdk.JSONNode value)
        {
        
        }
        public virtual com.adjust.sdk.JSONNode get_Item(string aKey)
        {
            return 0;
        }
        public virtual void set_Item(string aKey, com.adjust.sdk.JSONNode value)
        {
        
        }
        public virtual string get_Value()
        {
            return "";
        }
        public virtual void set_Value(string value)
        {
        
        }
        public virtual int get_Count()
        {
            return 0;
        }
        public virtual void Add(com.adjust.sdk.JSONNode aItem)
        {
            goto typeof(com.adjust.sdk.JSONNode).__il2cppRuntimeField_170;
        }
        public virtual com.adjust.sdk.JSONNode Remove(string aKey)
        {
            return 0;
        }
        public virtual com.adjust.sdk.JSONNode Remove(int aIndex)
        {
            return 0;
        }
        public virtual com.adjust.sdk.JSONNode Remove(com.adjust.sdk.JSONNode aNode)
        {
            return (com.adjust.sdk.JSONNode)aNode;
        }
        public virtual System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> get_Childs()
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            return (System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode>)new JSONNode.<get_Childs>d__17();
        }
        public System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> get_DeepChilds()
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            .<>4__this = this;
            return (System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode>)new JSONNode.<get_DeepChilds>d__19();
        }
        public override string ToString()
        {
            return "JSONNode";
        }
        public virtual string ToString(string aPrefix)
        {
            return "JSONNode";
        }
        public virtual int get_AsInt()
        {
            int val_1 = 0;
            return (int)((System.Int32.TryParse(s:  this, result: out  val_1)) != true) ? (val_1) : 0;
        }
        public virtual void set_AsInt(int value)
        {
            string val_1 = value.ToString();
        }
        public virtual float get_AsFloat()
        {
            return (float)((System.Single.TryParse(s:  this, result: out  float val_1 = -1.656812E-13f)) != true) ? 0 : 0f;
        }
        public virtual void set_AsFloat(float value)
        {
            string val_1 = value.ToString();
        }
        public virtual double get_AsDouble()
        {
            return (double)((System.Double.TryParse(s:  this, result: out  double val_1 = 1.28823671367647E-231)) != true) ? 0 : 0;
        }
        public virtual void set_AsDouble(double value)
        {
            string val_1 = value.ToString();
        }
        public virtual bool get_AsBool()
        {
            var val_6;
            bool val_1 = false;
            if((System.Boolean.TryParse(value:  this, result: out  val_1)) != false)
            {
                    var val_3 = (val_1 != 0) ? 1 : 0;
            }
            else
            {
                    bool val_4 = System.String.IsNullOrEmpty(value:  this);
                val_6 = val_4 ^ 1;
            }
            
            val_4 = val_6;
            return (bool)val_4;
        }
        public virtual void set_AsBool(bool value)
        {
            var val_1 = (value != true) ? "true" : "false";
            goto typeof(com.adjust.sdk.JSONNode).__il2cppRuntimeField_1D0;
        }
        public virtual com.adjust.sdk.JSONArray get_AsArray()
        {
            var val_2 = 0;
            return (com.adjust.sdk.JSONArray);
        }
        public virtual com.adjust.sdk.JSONClass get_AsObject()
        {
            var val_2 = 0;
            return (com.adjust.sdk.JSONClass);
        }
        public static com.adjust.sdk.JSONNode op_Implicit(string s)
        {
            .m_Data = s;
            return (com.adjust.sdk.JSONNode)new com.adjust.sdk.JSONData();
        }
        public static string op_Implicit(com.adjust.sdk.JSONNode d)
        {
            if((com.adjust.sdk.JSONNode.op_Equality(a:  d, b:  0)) != false)
            {
                    return 0;
            }
        
        }
        public static bool op_Equality(com.adjust.sdk.JSONNode a, object b)
        {
            if(b != null)
            {
                    return (bool)(a == b) ? 1 : 0;
            }
            
            if(a == null)
            {
                    return (bool)(a == b) ? 1 : 0;
            }
            
            return (bool)(a == b) ? 1 : 0;
        }
        public static bool op_Inequality(com.adjust.sdk.JSONNode a, object b)
        {
            bool val_1 = com.adjust.sdk.JSONNode.op_Equality(a:  a, b:  b);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public override bool Equals(object obj)
        {
            return (bool)(this == obj) ? 1 : 0;
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        internal static string Escape(string aText)
        {
            string val_5;
            string val_6;
            val_5 = "";
            if(aText.m_stringLength < 1)
            {
                    return (string)val_5;
            }
            
            var val_6 = 0;
            label_13:
            char val_2 = aText.Chars[0] & 65535;
            if((val_2 - 8) > '')
            {
                goto label_3;
            }
            
            var val_5 = 36773368 + (((val_1 & 65535) - 8)) << 2;
            val_5 = val_5 + 36773368;
            goto (36773368 + (((val_1 & 65535) - 8)) << 2 + 36773368);
            label_3:
            if(val_2 == '"')
            {
                goto label_5;
            }
            
            if(val_2 != '\')
            {
                goto label_6;
            }
            
            val_6 = "\\\\";
            goto label_12;
            label_6:
            val_6;
            goto label_12;
            label_5:
            val_6 = "\\\"";
            label_12:
            val_6 = val_6 + 1;
            val_5 = val_5 + val_6;
            if(val_6 < aText.m_stringLength)
            {
                goto label_13;
            }
            
            return (string)val_5;
        }
        public static com.adjust.sdk.JSONNode Parse(string aJSON)
        {
            var val_37;
            string val_38;
            var val_39;
            var val_40;
            com.adjust.sdk.JSONNode val_41;
            com.adjust.sdk.JSONNode val_42;
            string val_43;
            var val_44;
            string val_46;
            System.Collections.Generic.Stack<com.adjust.sdk.JSONNode> val_1 = new System.Collections.Generic.Stack<com.adjust.sdk.JSONNode>();
            if(aJSON.m_stringLength < 1)
            {
                goto label_2;
            }
            
            val_37 = 1152921505158017024;
            val_38 = "";
            val_39 = 0;
            val_40 = 0;
            val_41 = 0;
            label_76:
            char val_2 = aJSON.Chars[0];
            char val_3 = val_2 & 65535;
            if(val_3 > ',')
            {
                goto label_3;
            }
            
            if(val_3 > ' ')
            {
                goto label_4;
            }
            
            char val_4 = val_2 & 65535;
            if(val_4 > '')
            {
                goto label_5;
            }
            
            if(val_4 == '	')
            {
                goto label_6;
            }
            
            if(val_4 == '
            ')
            {
                goto label_74;
            }
            
            goto label_43;
            label_3:
            if(val_3 > ']')
            {
                goto label_9;
            }
            
            char val_5 = val_2 & 65535;
            if(val_5 > '[')
            {
                goto label_10;
            }
            
            if(val_5 == (':'))
            {
                goto label_11;
            }
            
            if(val_5 != '[')
            {
                goto label_43;
            }
            
            if((val_39 & 1) != 0)
            {
                goto label_44;
            }
            
            com.adjust.sdk.JSONArray val_6 = null;
            val_42 = val_6;
            val_6 = new com.adjust.sdk.JSONArray();
            if(val_1 != null)
            {
                goto label_14;
            }
            
            label_4:
            char val_7 = val_2 & 65535;
            if(val_7 == '"')
            {
                goto label_16;
            }
            
            if(val_7 != ',')
            {
                goto label_43;
            }
            
            if((val_39 & 1) != 0)
            {
                goto label_44;
            }
            
            if(((System.String.op_Inequality(a:  val_38, b:  "")) == false) || ((System.String.op_Inequality(a:  val_38, b:  "")) == false))
            {
                goto label_25;
            }
            
            com.adjust.sdk.JSONNode val_10 = com.adjust.sdk.JSONNode.op_Implicit(s:  val_38);
            goto label_25;
            label_9:
            char val_11 = val_2 & 65535;
            if(val_11 == '}')
            {
                goto label_26;
            }
            
            if(val_11 != '{')
            {
                goto label_43;
            }
            
            if((val_39 & 1) != 0)
            {
                goto label_44;
            }
            
            com.adjust.sdk.JSONClass val_12 = null;
            val_42 = val_12;
            val_12 = new com.adjust.sdk.JSONClass();
            label_14:
            val_1.Push(item:  val_12);
            if(((com.adjust.sdk.JSONNode.op_Equality(a:  val_41, b:  0)) == true) || ((System.String.op_Inequality(a:  Trim(), b:  "")) == false))
            {
                goto label_37;
            }
            
            com.adjust.sdk.JSONNode val_16 = val_1.Peek();
            goto label_37;
            label_5:
            if(val_4 == '')
            {
                goto label_74;
            }
            
            if(val_4 != ' ')
            {
                goto label_43;
            }
            
            label_6:
            if((val_39 & 1) != 0)
            {
                goto label_44;
            }
            
            val_39 = 0;
            goto label_74;
            label_10:
            if(val_5 == '\')
            {
                goto label_42;
            }
            
            if(val_5 != ']')
            {
                goto label_43;
            }
            
            label_26:
            if((val_39 & 1) != 0)
            {
                goto label_44;
            }
            
            if(val_5 == 0)
            {
                goto label_46;
            }
            
            com.adjust.sdk.JSONNode val_17 = val_1.Pop();
            if(((System.String.op_Inequality(a:  val_38, b:  "")) == false) || ((System.String.op_Inequality(a:  Trim(), b:  "")) == false))
            {
                goto label_54;
            }
            
            com.adjust.sdk.JSONNode val_21 = com.adjust.sdk.JSONNode.op_Implicit(s:  val_38);
            goto label_54;
            label_43:
            string val_23 = val_38 + aJSON.Chars[0];
            goto label_74;
            label_16:
            val_39 = val_39 ^ 1;
            goto label_74;
            label_11:
            if((val_39 & 1) == 0)
            {
                goto label_57;
            }
            
            label_44:
            string val_25 = val_38 + aJSON.Chars[0];
            val_39 = 1;
            goto label_74;
            label_42:
            if((val_39 & 1) == 0)
            {
                goto label_59;
            }
            
            char val_28 = (aJSON.Chars[val_40 + 1]) & 65535;
            if(val_28 > 'f')
            {
                goto label_60;
            }
            
            if(val_28 == 'b')
            {
                goto label_61;
            }
            
            if(val_28 != 'f')
            {
                goto label_66;
            }
            
            val_43 = "\f";
            goto label_73;
            label_57:
            val_39 = 0;
            val_38 = val_38;
            goto label_74;
            label_59:
            val_39 = 0;
            goto label_65;
            label_60:
            val_28 = val_28 - 110;
            if(val_28 > '')
            {
                goto label_66;
            }
            
            var val_38 = 36773336 + (((val_27 & 65535) - 110)) << 2;
            val_38 = val_38 + 36773336;
            goto (36773336 + (((val_27 & 65535) - 110)) << 2 + 36773336);
            label_66:
            val_44;
            goto label_68;
            label_61:
            val_43 = "\b";
            goto label_73;
            label_37:
            val_38 = "";
            goto label_70;
            label_54:
            val_38 = "";
            if(1179403647 < 1)
            {
                goto label_72;
            }
            
            label_70:
            val_41 = val_1.Peek();
            goto label_72;
            label_73:
            label_68:
            string val_32 = val_38 + ;
            val_39 = 1;
            label_65:
            val_40 = val_37;
            val_37 = 1152921528939422224;
            goto label_74;
            label_25:
            val_38 = "";
            label_72:
            val_39 = 0;
            label_74:
            val_40 = val_40 + 1;
            if(val_40 < aJSON.m_stringLength)
            {
                goto label_76;
            }
            
            if((val_39 & 1) != 0)
            {
                goto label_77;
            }
            
            return val_41;
            label_2:
            if((0 & 1) == 0)
            {
                    return val_41;
            }
            
            label_77:
            val_46 = "JSON Parse: Quotation marks seems to be messed up.";
            goto label_79;
            label_46:
            System.Exception val_37 = null;
            val_46 = "JSON Parse: Too many closing brackets";
            label_79:
            val_37 = new System.Exception(message:  val_46);
            throw val_37;
        }
        public virtual void Serialize(System.IO.BinaryWriter aWriter)
        {
        
        }
        public void SaveToStream(System.IO.Stream aData)
        {
            System.IO.BinaryWriter val_1 = new System.IO.BinaryWriter(output:  aData);
            goto typeof(com.adjust.sdk.JSONNode).__il2cppRuntimeField_2F0;
        }
        public void SaveToCompressedStream(System.IO.Stream aData)
        {
            throw new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public void SaveToCompressedFile(string aFileName)
        {
            throw new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public string SaveToCompressedBase64()
        {
            throw new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static com.adjust.sdk.JSONNode Deserialize(System.IO.BinaryReader aReader)
        {
            if(((aReader & 255) - 1) > 6)
            {
                    throw new System.Exception(message:  "Error deserializing JSON. Unknown tag: "("Error deserializing JSON. Unknown tag: ") + null);
            }
            
            var val_12 = 36773392;
            val_12 = (36773392 + (((aReader & 255) - 1)) << 2) + val_12;
            goto (36773392 + (((aReader & 255) - 1)) << 2 + 36773392);
        }
        public static com.adjust.sdk.JSONNode LoadFromCompressedFile(string aFileName)
        {
            throw new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static com.adjust.sdk.JSONNode LoadFromCompressedStream(System.IO.Stream aData)
        {
            throw new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static com.adjust.sdk.JSONNode LoadFromCompressedBase64(string aBase64)
        {
            throw new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static com.adjust.sdk.JSONNode LoadFromStream(System.IO.Stream aData)
        {
            System.IO.BinaryReader val_1 = new System.IO.BinaryReader(input:  aData);
            if(val_1 != null)
            {
                    var val_4 = 0;
                if(mem[1152921504638353408] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    System.IO.BinaryReader val_3 = 1152921504638316544 + ((mem[1152921504638353416]) << 4);
            }
            
                val_1.Dispose();
            }
            
            if(0 != 0)
            {
                    throw 0;
            }
            
            return (com.adjust.sdk.JSONNode)com.adjust.sdk.JSONNode.Deserialize(aReader:  val_1);
        }
        public static com.adjust.sdk.JSONNode LoadFromBase64(string aBase64)
        {
            return com.adjust.sdk.JSONNode.LoadFromStream(aData:  new System.IO.MemoryStream(buffer:  System.Convert.FromBase64String(s:  aBase64)));
        }
        public JSONNode()
        {
        
        }
    
    }

}
