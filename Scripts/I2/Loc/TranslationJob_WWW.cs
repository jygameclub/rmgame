using UnityEngine;

namespace I2.Loc
{
    public class TranslationJob_WWW : TranslationJob
    {
        // Fields
        public UnityEngine.Networking.UnityWebRequest www;
        
        // Methods
        public override void Dispose()
        {
            if(this.www != null)
            {
                    this.www.Dispose();
            }
            
            this.www = 0;
        }
        public TranslationJob_WWW()
        {
            val_1 = new System.Object();
        }
    
    }

}
