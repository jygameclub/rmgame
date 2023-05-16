using UnityEngine;

namespace I2.Loc
{
    public class TranslationJob_GET : TranslationJob_WWW
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> _requests;
        private I2.Loc.GoogleTranslation.fnOnTranslationReady _OnTranslationReady;
        private System.Collections.Generic.List<string> mQueries;
        public string mErrorMessage;
        
        // Methods
        public TranslationJob_GET(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, I2.Loc.GoogleTranslation.fnOnTranslationReady OnTranslationReady)
        {
            this = new System.Object();
            this._requests = requests;
            this._OnTranslationReady = OnTranslationReady;
            this.mQueries = I2.Loc.GoogleTranslation.ConvertTranslationRequest(requests:  requests, encodeGET:  true);
            goto typeof(I2.Loc.TranslationJob_GET).__il2cppRuntimeField_180;
        }
        private void ExecuteNextQuery()
        {
            if(true != 0)
            {
                    var val_1 = X9 + 0;
                this.mQueries.RemoveAt(index:  0);
                UnityEngine.Networking.UnityWebRequest val_4 = UnityEngine.Networking.UnityWebRequest.Get(uri:  System.String.Format(format:  "{0}?action=Translate&list={1}", arg0:  I2.Loc.LocalizationManager.GetWebServiceURL(source:  0), arg1:  (X9 + 0) + 32));
                mem[1152921528736498184] = val_4;
                I2.Loc.I2Utils.SendWebRequest(www:  val_4);
                return;
            }
            
            mem[1152921528736498176] = 1;
        }
        public override I2.Loc.TranslationJob.eJobState GetState()
        {
            if(this != null)
            {
                    if(this.isDone != false)
            {
                    this.ProcessResult(bytes:  X8.downloadHandler.data, errorMsg:  X8.error);
                this.Dispose();
                mem[1152921528736671624] = 0;
            }
            else
            {
                    if(X8 != 0)
            {
                    return (eJobState)this;
            }
            
            }
            
            }
            
            this.ExecuteNextQuery();
            return (eJobState)this;
        }
        public void ProcessResult(byte[] bytes, string errorMsg)
        {
            string val_5 = errorMsg;
            if((System.String.IsNullOrEmpty(value:  val_5 = errorMsg)) != false)
            {
                    string val_3 = I2.Loc.GoogleTranslation.ParseTranslationResult(html:  System.Text.Encoding.UTF8, requests:  this._requests);
                val_5 = val_3;
                if((System.String.IsNullOrEmpty(value:  val_3)) != false)
            {
                    if(this._OnTranslationReady == null)
            {
                    return;
            }
            
                this._OnTranslationReady.Invoke(dict:  this._requests, error:  0);
                return;
            }
            
            }
            
            mem[1152921528736890112] = 2;
            this.mErrorMessage = val_5;
        }
    
    }

}
