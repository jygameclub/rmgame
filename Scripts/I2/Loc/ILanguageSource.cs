using UnityEngine;

namespace I2.Loc
{
    public interface ILanguageSource
    {
        // Properties
        public abstract I2.Loc.LanguageSourceData SourceData { get; set; }
        
        // Methods
        public abstract I2.Loc.LanguageSourceData get_SourceData(); // 0
        public abstract void set_SourceData(I2.Loc.LanguageSourceData value); // 0
    
    }

}
