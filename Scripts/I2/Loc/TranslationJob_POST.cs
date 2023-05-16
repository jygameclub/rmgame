using UnityEngine;

namespace I2.Loc
{
    public class TranslationJob_POST : TranslationJob_WWW
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> _requests;
        private I2.Loc.GoogleTranslation.fnOnTranslationReady _OnTranslationReady;
        
        // Methods
        public TranslationJob_POST(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, I2.Loc.GoogleTranslation.fnOnTranslationReady OnTranslationReady)
        {
            this = new System.Object();
            this._requests = requests;
            this._OnTranslationReady = OnTranslationReady;
            System.Collections.Generic.List<System.String> val_2 = I2.Loc.GoogleTranslation.ConvertTranslationRequest(requests:  requests, encodeGET:  false);
            UnityEngine.WWWForm val_3 = new UnityEngine.WWWForm();
            val_3.AddField(fieldName:  "action", value:  "Translate");
            if("action" == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3.AddField(fieldName:  "list", value:  public System.Net.WebResponse System.Net.FileWebRequest::GetResponse());
            UnityEngine.Networking.UnityWebRequest val_5 = UnityEngine.Networking.UnityWebRequest.Post(uri:  I2.Loc.LocalizationManager.GetWebServiceURL(source:  0), formData:  val_3);
            mem[1152921528737597368] = val_5;
            I2.Loc.I2Utils.SendWebRequest(www:  val_5);
        }
        public override I2.Loc.TranslationJob.eJobState GetState()
        {
            if(this == null)
            {
                    return (eJobState)this;
            }
            
            bool val_1 = this.isDone;
            if(val_1 == false)
            {
                    return (eJobState)this;
            }
            
            this.ProcessResult(bytes:  val_1.downloadHandler.data, errorMsg:  X8.error);
            this.Dispose();
            mem[1152921528737779000] = 0;
            return (eJobState)this;
        }
        public void ProcessResult(byte[] bytes, string errorMsg)
        {
            string val_4;
            var val_5;
            val_4 = errorMsg;
            if((System.String.IsNullOrEmpty(value:  val_4)) != false)
            {
                    val_4 = System.Text.Encoding.UTF8;
                if(this._OnTranslationReady != null)
            {
                    this._OnTranslationReady.Invoke(dict:  this._requests, error:  I2.Loc.GoogleTranslation.ParseTranslationResult(html:  val_4, requests:  this._requests));
            }
            
                val_5 = 1;
            }
            else
            {
                    val_5 = 2;
            }
            
            mem[1152921528737997488] = val_5;
        }
    
    }

}
