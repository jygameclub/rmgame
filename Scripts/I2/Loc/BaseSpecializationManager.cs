using UnityEngine;

namespace I2.Loc
{
    public class BaseSpecializationManager
    {
        // Fields
        public string[] mSpecializations;
        public System.Collections.Generic.Dictionary<string, string> mSpecializationsFallbacks;
        
        // Methods
        public virtual void InitializeSpecializations()
        {
            int val_3;
            string[] val_1 = new string[12];
            val_3 = val_1.Length;
            val_1[0] = "Any";
            val_3 = val_1.Length;
            val_1[1] = "PC";
            val_3 = val_1.Length;
            val_1[2] = "Touch";
            val_3 = val_1.Length;
            val_1[3] = "Controller";
            val_3 = val_1.Length;
            val_1[4] = "VR";
            val_3 = val_1.Length;
            val_1[5] = "XBox";
            val_3 = val_1.Length;
            val_1[6] = "PS4";
            val_3 = val_1.Length;
            val_1[7] = "OculusVR";
            val_3 = val_1.Length;
            val_1[8] = "ViveVR";
            val_3 = val_1.Length;
            val_1[9] = "GearVR";
            val_3 = val_1.Length;
            val_1[10] = "Android";
            val_3 = val_1.Length;
            val_1[11] = "IOS";
            this.mSpecializations = val_1;
            System.Collections.Generic.Dictionary<System.String, System.String> val_2 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            val_2.Add(key:  "XBox", value:  "Controller");
            val_2.Add(key:  "PS4", value:  "Controller");
            val_2.Add(key:  "OculusVR", value:  "VR");
            val_2.Add(key:  "ViveVR", value:  "VR");
            val_2.Add(key:  "GearVR", value:  "VR");
            val_2.Add(key:  "Android", value:  "Touch");
            val_2.Add(key:  "IOS", value:  "Touch");
            this.mSpecializationsFallbacks = val_2;
        }
        public virtual string GetCurrentSpecialization()
        {
            if(this.mSpecializations != null)
            {
                    return "Android";
            }
            
            return "Android";
        }
        public virtual string GetFallbackSpecialization(string specialization)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_4 = this.mSpecializationsFallbacks;
            if(val_4 != null)
            {
                    return (string)((val_4.TryGetValue(key:  specialization, value: out  0)) != true) ? -1653638680 : "Any";
            }
            
            val_4 = this.mSpecializationsFallbacks;
            return (string)((val_4.TryGetValue(key:  specialization, value: out  0)) != true) ? -1653638680 : "Any";
        }
        public BaseSpecializationManager()
        {
        
        }
    
    }

}
