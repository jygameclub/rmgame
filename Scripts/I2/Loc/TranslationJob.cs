using UnityEngine;

namespace I2.Loc
{
    public class TranslationJob : IDisposable
    {
        // Fields
        public I2.Loc.TranslationJob.eJobState mJobState;
        
        // Methods
        public virtual I2.Loc.TranslationJob.eJobState GetState()
        {
            return (eJobState)this.mJobState;
        }
        public virtual void Dispose()
        {
        
        }
        public TranslationJob()
        {
        
        }
    
    }

}
