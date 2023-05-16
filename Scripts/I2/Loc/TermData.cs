using UnityEngine;

namespace I2.Loc
{
    [Serializable]
    public class TermData
    {
        // Fields
        public string Term;
        public I2.Loc.eTermType TermType;
        public string Description;
        public string[] Languages;
        public byte[] Flags;
        private string[] Languages_Touch;
        
        // Methods
        public string GetTranslation(int idx, string specialization, bool editMode = False)
        {
            var val_3;
            string val_3 = this.Languages[idx];
            if(val_3 != null)
            {
                    if(editMode == true)
            {
                    return (string)val_3;
            }
            
                return I2.Loc.SpecializationManager.GetSpecializedText(text:  val_3, specialization:  specialization).Replace(oldValue:  "[i2nt]", newValue:  "").Replace(oldValue:  "[/i2nt]", newValue:  "");
            }
            
            val_3 = 0;
            return (string)val_3;
        }
        public void SetTranslation(int idx, string translation, string specialization)
        {
            mem2[0] = I2.Loc.SpecializationManager.SetSpecializedText(text:  this.Languages[idx], newText:  translation, specialization:  specialization);
        }
        public void RemoveSpecialization(string specialization)
        {
            var val_1 = 0;
            do
            {
                if(val_1 >= this.Languages.Length)
            {
                    return;
            }
            
                this.RemoveSpecialization(idx:  0, specialization:  specialization);
                val_1 = val_1 + 1;
            }
            while(this.Languages != null);
            
            throw new NullReferenceException();
        }
        public void RemoveSpecialization(int idx, string specialization)
        {
            string val_7 = this.Languages[(long)idx];
            if((System.String.op_Equality(a:  specialization, b:  "Any")) == true)
            {
                    return;
            }
            
            if((val_7.Contains(value:  "[i2s_" + specialization + "]")) == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.String> val_4 = I2.Loc.SpecializationManager.GetSpecializations(text:  val_7, buffer:  0);
            bool val_5 = val_4.Remove(key:  specialization);
            this = this.Languages;
            this[(long)idx] = I2.Loc.SpecializationManager.SetSpecializedText(specializations:  val_4);
        }
        public bool IsAutoTranslated(int idx, bool IsTouch)
        {
            return (bool)(uint)(this.Flags[idx] >> 1) & 1;
        }
        public void Validate()
        {
            System.String[] val_2 = this.Languages;
            int val_1 = UnityEngine.Mathf.Max(a:  this.Languages.Length, b:  this.Flags.Length);
            if(val_1 != this.Languages.Length)
            {
                    System.Array.Resize<System.String>(array: ref  val_2, newSize:  val_1);
            }
            
            if(val_1 != this.Flags.Length)
            {
                    System.Array.Resize<System.Byte>(array: ref  this.Flags, newSize:  val_1);
            }
            
            if(this.Languages_Touch == null)
            {
                    return;
            }
            
            var val_11 = 4;
            label_27:
            if((val_11 - 4) >= ((UnityEngine.Mathf.Min(a:  this.Languages_Touch.Length, b:  val_1)) << ))
            {
                goto label_12;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_2[0])) != false)
            {
                    if((System.String.IsNullOrEmpty(value:  this.Languages_Touch[0])) != true)
            {
                    this.Languages = this.Languages_Touch[0];
                this.Languages_Touch = 0;
            }
            
            }
            
            val_11 = val_11 + 1;
            if(this.Languages_Touch != null)
            {
                goto label_27;
            }
            
            throw new NullReferenceException();
            label_12:
            this.Languages_Touch = 0;
        }
        public bool IsTerm(string name, bool allowCategoryMistmatch)
        {
            string val_2 = this.Term;
            if(allowCategoryMistmatch == false)
            {
                    return System.String.op_Equality(a:  name, b:  val_2 = I2.Loc.LanguageSourceData.GetKeyFromFullTerm(FullTerm:  val_2 = this.Term, OnlyMainCategory:  false));
            }
            
            return System.String.op_Equality(a:  name, b:  val_2);
        }
        public bool HasSpecializations()
        {
            var val_3;
            var val_6 = 4;
            label_9:
            if((val_6 - 4) >= (this.Languages.Length << ))
            {
                goto label_2;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.Languages[0])) != true)
            {
                    if((this.Languages[0].Contains(value:  "[i2s_")) == true)
            {
                goto label_8;
            }
            
            }
            
            val_6 = val_6 + 1;
            if(this.Languages != null)
            {
                goto label_9;
            }
            
            throw new NullReferenceException();
            label_2:
            val_3 = 0;
            return (bool)val_3;
            label_8:
            val_3 = 1;
            return (bool)val_3;
        }
        public System.Collections.Generic.List<string> GetAllSpecializations()
        {
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            var val_3 = 0;
            do
            {
                if(val_3 >= (this.Languages.Length << ))
            {
                    return val_1;
            }
            
                I2.Loc.SpecializationManager.AppendSpecializations(text:  this.Languages[val_3], list:  val_1);
                val_3 = val_3 + 1;
            }
            while(this.Languages != null);
            
            throw new NullReferenceException();
        }
        public TermData()
        {
            this.Term = System.String.alignConst;
            this.Languages = new string[0];
            this.Flags = new byte[0];
        }
    
    }

}
