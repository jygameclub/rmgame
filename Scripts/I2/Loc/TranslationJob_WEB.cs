using UnityEngine;

namespace I2.Loc
{
    public class TranslationJob_WEB : TranslationJob_WWW
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> _requests;
        private I2.Loc.GoogleTranslation.fnOnTranslationReady _OnTranslationReady;
        public string mErrorMessage;
        private string mCurrentBatch_ToLanguageCode;
        private string mCurrentBatch_FromLanguageCode;
        private System.Collections.Generic.List<string> mCurrentBatch_Text;
        private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>> mQueries;
        
        // Methods
        public TranslationJob_WEB(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, I2.Loc.GoogleTranslation.fnOnTranslationReady OnTranslationReady)
        {
            val_1 = new System.Object();
            this._requests = requests;
            this._OnTranslationReady = OnTranslationReady;
            val_1.FindAllQueries();
            val_1.ExecuteNextBatch();
        }
        private void FindAllQueries()
        {
            var val_3;
            string val_4;
            Spine.Animation val_5;
            Spine.Animation val_10;
            Spine.Animation val_11;
            var val_12;
            System.Comparison<System.Collections.Generic.KeyValuePair<System.String, System.String>> val_14;
            this.mQueries = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.String>>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this._requests.GetEnumerator();
            goto label_4;
            label_8:
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            var val_10 = val_3 + 24;
            if(val_10 >= 1)
            {
                    val_10 = val_5;
                var val_11 = 0;
                val_10 = val_10 & 4294967295;
                var val_6 = val_3 + 32;
                do
            {
                val_11 = val_10;
                AnimationStateData.AnimationPair val_8 = new AnimationStateData.AnimationPair(a1:  val_11, a2:  val_4 + ":"(":") + (val_3 + 32) + 0((val_3 + 32) + 0));
                if(this.mQueries == null)
            {
                    throw new NullReferenceException();
            }
            
                this.mQueries.Add(item:  new System.Collections.Generic.KeyValuePair<System.String, System.String>() {Value = val_8.a1});
                val_11 = val_11 + 1;
            }
            while(val_11 < ((val_3 + 24) << ));
            
            }
            
            label_4:
            if(((-1638335992) & 1) != 0)
            {
                goto label_8;
            }
            
            Dispose();
            val_12 = null;
            val_12 = null;
            val_14 = TranslationJob_WEB.<>c.<>9__8_0;
            if(val_14 == null)
            {
                    System.Comparison<System.Collections.Generic.KeyValuePair<System.String, System.String>> val_9 = null;
                val_14 = val_9;
                val_9 = new System.Comparison<System.Collections.Generic.KeyValuePair<System.String, System.String>>(object:  TranslationJob_WEB.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 TranslationJob_WEB.<>c::<FindAllQueries>b__8_0(System.Collections.Generic.KeyValuePair<string, string> a, System.Collections.Generic.KeyValuePair<string, string> b));
                TranslationJob_WEB.<>c.<>9__8_0 = val_14;
            }
            
            this.mQueries.Sort(comparison:  val_9);
        }
        private void ExecuteNextBatch()
        {
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.String>> val_12;
            string val_13;
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.String>> val_14;
            if(this.mQueries == null)
            {
                goto label_2;
            }
            
            this.mCurrentBatch_Text = new System.Collections.Generic.List<System.String>();
            System.Text.StringBuilder val_2 = new System.Text.StringBuilder();
            val_12 = this.mQueries;
            var val_13 = 0;
            var val_12 = 0;
            val_13 = 0;
            label_18:
            if(val_12 >= 1152921504630222848)
            {
                goto label_4;
            }
            
            val_14 = val_12;
            if(val_12 >= 47790440)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_14 = this.mQueries;
            }
            
            if(val_12 >= X9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(val_13 != 0)
            {
                    if((System.String.op_Equality(a:  "Mongol Uls", b:  val_13)) == false)
            {
                goto label_9;
            }
            
            }
            
            if(val_13 == 0)
            {
                goto label_10;
            }
            
            System.Text.StringBuilder val_4 = val_2.Append(value:  "|||");
            goto label_12;
            label_9:
            if(val_2 != null)
            {
                goto label_13;
            }
            
            label_10:
            label_12:
            System.Text.StringBuilder val_5 = val_2.Append(value:  "AbsoluteUri");
            this.mCurrentBatch_Text.Add(item:  "AbsoluteUri");
            val_13 = "Mongol Uls";
            label_13:
            if(val_2.Length > 200)
            {
                goto label_17;
            }
            
            val_12 = val_12 + 1;
            val_13 = val_13 + 16;
            if(this.mQueries != null)
            {
                goto label_18;
            }
            
            throw new NullReferenceException();
            label_2:
            mem[1152921528738567440] = 1;
            return;
            label_17:
            val_12 = this.mQueries;
            label_4:
            val_12.RemoveRange(index:  0, count:  0);
            char[] val_7 = new char[1];
            val_7[0] = ':';
            System.String[] val_8 = Split(separator:  val_7);
            string val_14 = val_8[0];
            this.mCurrentBatch_FromLanguageCode = val_14;
            string val_15 = val_8[1];
            this.mCurrentBatch_ToLanguageCode = val_15;
            string val_10 = System.String.Format(format:  "http://www.google.com/translate_t?hl=en&vi=c&ie=UTF8&oe=UTF8&submit=Translate&langpair={0}|{1}&text={2}", arg0:  val_14, arg1:  val_15, arg2:  System.Uri.EscapeUriString(stringToEscape:  val_2));
            UnityEngine.Debug.Log(message:  val_10);
            UnityEngine.Networking.UnityWebRequest val_11 = UnityEngine.Networking.UnityWebRequest.Get(uri:  val_10);
            mem[1152921528738567448] = val_11;
            I2.Loc.I2Utils.SendWebRequest(www:  val_11);
        }
        public override I2.Loc.TranslationJob.eJobState GetState()
        {
            if(this != null)
            {
                    if(this.isDone != false)
            {
                    this.ProcessResult(bytes:  X8.downloadHandler.data, errorMsg:  X8.error);
                this.Dispose();
                mem[1152921528738826920] = 0;
            }
            else
            {
                    if(X8 != 0)
            {
                    return (eJobState)this;
            }
            
            }
            
            }
            
            this.ExecuteNextBatch();
            return (eJobState)this;
        }
        public void ProcessResult(byte[] bytes, string errorMsg)
        {
            if((System.String.IsNullOrEmpty(value:  errorMsg)) != false)
            {
                    System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
                bytes = val_2.ParseTranslationResult(html:  val_2, OriginalText:  "aab");
                UnityEngine.Debug.Log(message:  bytes);
                if((System.String.IsNullOrEmpty(value:  errorMsg)) != false)
            {
                    if(this._OnTranslationReady == null)
            {
                    return;
            }
            
                this._OnTranslationReady.Invoke(dict:  this._requests, error:  0);
                return;
            }
            
            }
            
            mem[1152921528739041392] = 2;
            this.mErrorMessage = errorMsg;
        }
        private string ParseTranslationResult(string html, string OriginalText)
        {
            var val_19;
            string val_20;
            var val_21;
            System.Text.RegularExpressions.MatchEvaluator val_23;
            var val_25;
            System.Text.RegularExpressions.MatchEvaluator val_27;
            string val_28;
            string val_29;
            val_19 = 38139;
            if(html == null)
            {
                    throw new NullReferenceException();
            }
            
            val_20 = "TRANSLATED_TEXT=\'";
            val_19 = html;
            int val_1 = val_19.IndexOf(value:  val_20);
            int val_3 = html.IndexOf(value:  "\';var", startIndex:  ("TRANSLATED_TEXT=\'".__il2cppRuntimeField_10 + val_1));
            val_21 = null;
            val_21 = null;
            val_23 = TranslationJob_WEB.<>c.<>9__12_0;
            if(val_23 == null)
            {
                    System.Text.RegularExpressions.MatchEvaluator val_5 = null;
                val_23 = val_5;
                val_5 = new System.Text.RegularExpressions.MatchEvaluator(object:  TranslationJob_WEB.<>c.__il2cppRuntimeField_static_fields, method:  System.String TranslationJob_WEB.<>c::<ParseTranslationResult>b__12_0(System.Text.RegularExpressions.Match match));
                TranslationJob_WEB.<>c.<>9__12_0 = val_23;
            }
            
            val_25 = null;
            val_25 = null;
            val_27 = TranslationJob_WEB.<>c.<>9__12_1;
            val_28 = "&#(\\d+);";
            if(val_27 == null)
            {
                    System.Text.RegularExpressions.MatchEvaluator val_7 = null;
                val_27 = val_7;
                val_7 = new System.Text.RegularExpressions.MatchEvaluator(object:  TranslationJob_WEB.<>c.__il2cppRuntimeField_static_fields, method:  System.String TranslationJob_WEB.<>c::<ParseTranslationResult>b__12_1(System.Text.RegularExpressions.Match match));
                TranslationJob_WEB.<>c.<>9__12_1 = val_27;
            }
            
            val_20 = val_28;
            string val_8 = System.Text.RegularExpressions.Regex.Replace(input:  System.Text.RegularExpressions.Regex.Replace(input:  html.Substring(startIndex:  ("TRANSLATED_TEXT=\'".__il2cppRuntimeField_10 + val_1), length:  (val_3 - ("TRANSLATED_TEXT=\'".__il2cppRuntimeField_10 + val_1))>>0&0xFFFFFFFF), pattern:  "\\\\x([a-fA-F0-9]{2})", evaluator:  val_5), pattern:  val_20, evaluator:  val_7);
            if(val_8 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_20 = "<br>";
            if(OriginalText == null)
            {
                    throw new NullReferenceException();
            }
            
            val_29 = val_8.Replace(oldValue:  val_20, newValue:  "\n");
            val_20 = OriginalText;
            if((System.String.op_Equality(a:  OriginalText.ToUpper(), b:  val_20)) != false)
            {
                    if(val_29 == null)
            {
                    throw new NullReferenceException();
            }
            
                string val_12 = val_29.ToUpper();
            }
            else
            {
                    val_28 = 1152921505147473920;
                if((System.String.op_Equality(a:  I2.Loc.GoogleTranslation.UppercaseFirst(s:  OriginalText), b:  OriginalText)) != false)
            {
                    string val_15 = I2.Loc.GoogleTranslation.UppercaseFirst(s:  val_29);
            }
            else
            {
                    if((System.String.op_Equality(a:  I2.Loc.GoogleTranslation.TitleCase(s:  OriginalText), b:  OriginalText)) == false)
            {
                    return (string)val_29;
            }
            
            }
            
            }
            
            val_29 = I2.Loc.GoogleTranslation.TitleCase(s:  val_29);
            return (string)val_29;
        }
    
    }

}
