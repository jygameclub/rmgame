using UnityEngine;

namespace I2.Loc.SimpleJSON
{
    public class JSONNode
    {
        // Properties
        public virtual I2.Loc.SimpleJSON.JSONNode Item { get; set; }
        public virtual I2.Loc.SimpleJSON.JSONNode Item { get; set; }
        public virtual string Value { get; set; }
        public virtual int Count { get; }
        public virtual System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode> Childs { get; }
        public System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode> DeepChilds { get; }
        public virtual int AsInt { get; set; }
        public virtual float AsFloat { get; set; }
        public virtual double AsDouble { get; set; }
        public virtual bool AsBool { get; set; }
        public virtual I2.Loc.SimpleJSON.JSONArray AsArray { get; }
        public virtual I2.Loc.SimpleJSON.JSONClass AsObject { get; }
        
        // Methods
        public virtual void Add(string aKey, I2.Loc.SimpleJSON.JSONNode aItem)
        {
        
        }
        public virtual I2.Loc.SimpleJSON.JSONNode get_Item(int aIndex)
        {
            return 0;
        }
        public virtual void set_Item(int aIndex, I2.Loc.SimpleJSON.JSONNode value)
        {
        
        }
        public virtual I2.Loc.SimpleJSON.JSONNode get_Item(string aKey)
        {
            return 0;
        }
        public virtual void set_Item(string aKey, I2.Loc.SimpleJSON.JSONNode value)
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
        public virtual void Add(I2.Loc.SimpleJSON.JSONNode aItem)
        {
            goto typeof(I2.Loc.SimpleJSON.JSONNode).__il2cppRuntimeField_170;
        }
        public virtual I2.Loc.SimpleJSON.JSONNode Remove(string aKey)
        {
            return 0;
        }
        public virtual I2.Loc.SimpleJSON.JSONNode Remove(int aIndex)
        {
            return 0;
        }
        public virtual I2.Loc.SimpleJSON.JSONNode Remove(I2.Loc.SimpleJSON.JSONNode aNode)
        {
            return (I2.Loc.SimpleJSON.JSONNode)aNode;
        }
        public virtual System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode> get_Childs()
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            return (System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>)new JSONNode.<get_Childs>d__17();
        }
        public System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode> get_DeepChilds()
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            .<>4__this = this;
            return (System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>)new JSONNode.<get_DeepChilds>d__19();
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
            return (float)((System.Single.TryParse(s:  this, result: out  float val_1 = -9.649753E-18f)) != true) ? 0 : 0f;
        }
        public virtual void set_AsFloat(float value)
        {
            string val_1 = value.ToString();
        }
        public virtual double get_AsDouble()
        {
            return (double)((System.Double.TryParse(s:  this, result: out  double val_1 = 1.28823667992328E-231)) != true) ? 0 : 0;
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
            goto typeof(I2.Loc.SimpleJSON.JSONNode).__il2cppRuntimeField_1D0;
        }
        public virtual I2.Loc.SimpleJSON.JSONArray get_AsArray()
        {
            var val_2 = 0;
            return (I2.Loc.SimpleJSON.JSONArray);
        }
        public virtual I2.Loc.SimpleJSON.JSONClass get_AsObject()
        {
            var val_2 = 0;
            return (I2.Loc.SimpleJSON.JSONClass);
        }
        public static I2.Loc.SimpleJSON.JSONNode op_Implicit(string s)
        {
            return (I2.Loc.SimpleJSON.JSONNode)new I2.Loc.SimpleJSON.JSONData(aData:  s);
        }
        public static string op_Implicit(I2.Loc.SimpleJSON.JSONNode d)
        {
            if((I2.Loc.SimpleJSON.JSONNode.op_Equality(a:  d, b:  0)) != false)
            {
                    return 0;
            }
        
        }
        public static bool op_Equality(I2.Loc.SimpleJSON.JSONNode a, object b)
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
        public static bool op_Inequality(I2.Loc.SimpleJSON.JSONNode a, object b)
        {
            bool val_1 = I2.Loc.SimpleJSON.JSONNode.op_Equality(a:  a, b:  b);
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
            
            var val_5 = 36607612 + (((val_1 & 65535) - 8)) << 2;
            val_5 = val_5 + 36607612;
            goto (36607612 + (((val_1 & 65535) - 8)) << 2 + 36607612);
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
        public static I2.Loc.SimpleJSON.JSONNode Parse(string aJSON)
        {
            var val_37;
            string val_38;
            var val_39;
            var val_40;
            I2.Loc.SimpleJSON.JSONNode val_41;
            I2.Loc.SimpleJSON.JSONNode val_42;
            string val_43;
            var val_44;
            string val_46;
            System.Collections.Generic.Stack<I2.Loc.SimpleJSON.JSONNode> val_1 = new System.Collections.Generic.Stack<I2.Loc.SimpleJSON.JSONNode>();
            if(aJSON.m_stringLength < 1)
            {
                goto label_2;
            }
            
            val_37 = 1152921505152479232;
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
            
            I2.Loc.SimpleJSON.JSONArray val_6 = null;
            val_42 = val_6;
            val_6 = new I2.Loc.SimpleJSON.JSONArray();
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
            
            I2.Loc.SimpleJSON.JSONNode val_10 = I2.Loc.SimpleJSON.JSONNode.op_Implicit(s:  val_38);
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
            
            I2.Loc.SimpleJSON.JSONClass val_12 = null;
            val_42 = val_12;
            val_12 = new I2.Loc.SimpleJSON.JSONClass();
            label_14:
            val_1.Push(item:  val_12);
            if(((I2.Loc.SimpleJSON.JSONNode.op_Equality(a:  val_41, b:  0)) == true) || ((System.String.op_Inequality(a:  Trim(), b:  "")) == false))
            {
                goto label_37;
            }
            
            I2.Loc.SimpleJSON.JSONNode val_16 = val_1.Peek();
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
            
            I2.Loc.SimpleJSON.JSONNode val_17 = val_1.Pop();
            if(((System.String.op_Inequality(a:  val_38, b:  "")) == false) || ((System.String.op_Inequality(a:  Trim(), b:  "")) == false))
            {
                goto label_54;
            }
            
            I2.Loc.SimpleJSON.JSONNode val_21 = I2.Loc.SimpleJSON.JSONNode.op_Implicit(s:  val_38);
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
            
            var val_38 = 36607636 + (((val_27 & 65535) - 110)) << 2;
            val_38 = val_38 + 36607636;
            goto (36607636 + (((val_27 & 65535) - 110)) << 2 + 36607636);
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
            val_37 = 1152921528821422432;
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
            goto typeof(I2.Loc.SimpleJSON.JSONNode).__il2cppRuntimeField_2F0;
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
        public void SaveToFile(string aFileName)
        {
            System.IO.DirectoryInfo val_4 = System.IO.Directory.CreateDirectory(path:  new System.IO.FileInfo(fileName:  aFileName).Directory.FullName);
            System.IO.FileStream val_5 = System.IO.File.OpenWrite(path:  aFileName);
            this.SaveToStream(aData:  val_5);
            if(val_5 != null)
            {
                    var val_7 = 0;
                if(mem[1152921504641335296] != null)
            {
                    val_7 = val_7 + 1;
            }
            else
            {
                    System.IO.FileStream val_6 = 1152921504641298432 + ((mem[1152921504641335304]) << 4);
            }
            
                val_5.Dispose();
            }
            
            if(0 != 0)
            {
                    throw ???;
            }
        
        }
        public string SaveToBase64()
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            this.SaveToStream(aData:  val_1);
            var val_4 = 0;
            if(mem[1152921504639631360] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    System.IO.MemoryStream val_3 = 1152921504639594496 + ((mem[1152921504639631368]) << 4);
            }
            
            val_1.Dispose();
            if(0 != 0)
            {
                    throw 0;
            }
            
            return (string)System.Convert.ToBase64String(inArray:  val_1);
        }
        public static I2.Loc.SimpleJSON.JSONNode Deserialize(System.IO.BinaryReader aReader)
        {
            if(((aReader & 255) - 1) > 6)
            {
                    throw new System.Exception(message:  "Error deserializing JSON. Unknown tag: "("Error deserializing JSON. Unknown tag: ") + 1152921505152851968);
            }
            
            var val_13 = 36607668;
            val_13 = (36607668 + (((aReader & 255) - 1)) << 2) + val_13;
            goto (36607668 + (((aReader & 255) - 1)) << 2 + 36607668);
        }
        public static I2.Loc.SimpleJSON.JSONNode LoadFromCompressedFile(string aFileName)
        {
            throw new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static I2.Loc.SimpleJSON.JSONNode LoadFromCompressedStream(System.IO.Stream aData)
        {
            throw new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static I2.Loc.SimpleJSON.JSONNode LoadFromCompressedBase64(string aBase64)
        {
            throw new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static I2.Loc.SimpleJSON.JSONNode LoadFromStream(System.IO.Stream aData)
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
            
            return (I2.Loc.SimpleJSON.JSONNode)I2.Loc.SimpleJSON.JSONNode.Deserialize(aReader:  val_1);
        }
        public static I2.Loc.SimpleJSON.JSONNode LoadFromFile(string aFileName)
        {
            System.IO.FileStream val_1 = System.IO.File.OpenRead(path:  aFileName);
            if(val_1 != null)
            {
                    var val_4 = 0;
                if(mem[1152921504641335296] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    System.IO.FileStream val_3 = 1152921504641298432 + ((mem[1152921504641335304]) << 4);
            }
            
                val_1.Dispose();
            }
            
            if(0 != 0)
            {
                    throw 0;
            }
            
            return (I2.Loc.SimpleJSON.JSONNode)I2.Loc.SimpleJSON.JSONNode.LoadFromStream(aData:  val_1);
        }
        public static I2.Loc.SimpleJSON.JSONNode LoadFromBase64(string aBase64)
        {
            return I2.Loc.SimpleJSON.JSONNode.LoadFromStream(aData:  new System.IO.MemoryStream(buffer:  System.Convert.FromBase64String(s:  aBase64)));
        }
        public JSONNode()
        {
        
        }
    
    }

}
