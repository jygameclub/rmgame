using UnityEngine;

namespace I2.Loc
{
    public static class GoogleTranslation
    {
        // Fields
        private static System.Collections.Generic.List<UnityEngine.Networking.UnityWebRequest> mCurrentTranslations;
        private static System.Collections.Generic.List<I2.Loc.TranslationJob> mTranslationJobs;
        
        // Methods
        public static bool CanTranslate()
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            if((I2.Loc.LocalizationManager.Sources + 24) >= 1)
            {
                    val_5 = (System.String.IsNullOrEmpty(value:  I2.Loc.LocalizationManager.GetWebServiceURL(source:  0))) ^ 1;
                return (bool)val_5 & 1;
            }
            
            val_5 = 0;
            return (bool)val_5 & 1;
        }
        public static void Translate(string text, string LanguageCodeFrom, string LanguageCodeTo, I2.Loc.GoogleTranslation.fnOnTranslated OnTranslationReady)
        {
            string val_6;
            var val_7;
            string val_8;
            val_6 = LanguageCodeTo;
            .OnTranslationReady = OnTranslationReady;
            .text = text;
            .LanguageCodeTo = val_6;
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            val_7 = null;
            if(I2.Loc.GoogleTranslation.CanTranslate() == false)
            {
                goto label_6;
            }
            
            if((System.String.op_Equality(a:  (GoogleTranslation.<>c__DisplayClass2_0)[1152921528727491200].LanguageCodeTo, b:  LanguageCodeFrom)) == false)
            {
                goto label_7;
            }
            
            val_8 = (GoogleTranslation.<>c__DisplayClass2_0)[1152921528727491200].text;
            goto label_9;
            label_6:
            val_8 = 0;
            goto label_11;
            label_7:
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_4 = null;
            val_6 = val_4;
            val_4 = new System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>();
            .queries = val_6;
            if((System.String.IsNullOrEmpty(value:  (GoogleTranslation.<>c__DisplayClass2_0)[1152921528727491200].LanguageCodeTo)) == false)
            {
                goto label_12;
            }
            
            val_8 = System.String.alignConst;
            label_9:
            label_11:
            (GoogleTranslation.<>c__DisplayClass2_0)[1152921528727491200].OnTranslationReady.Invoke(Translation:  val_8, Error:  0);
            return;
            label_12:
            I2.Loc.GoogleTranslation.CreateQueries(text:  (GoogleTranslation.<>c__DisplayClass2_0)[1152921528727491200].text, LanguageCodeFrom:  LanguageCodeFrom, LanguageCodeTo:  (GoogleTranslation.<>c__DisplayClass2_0)[1152921528727491200].LanguageCodeTo, dict:  (GoogleTranslation.<>c__DisplayClass2_0)[1152921528727491200].queries);
            mem[1152921528727540384] = new GoogleTranslation.<>c__DisplayClass2_0();
            mem[1152921528727540392] = System.Void GoogleTranslation.<>c__DisplayClass2_0::<Translate>b__0(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> results, string error);
            mem[1152921528727540368] = System.Void GoogleTranslation.<>c__DisplayClass2_0::<Translate>b__0(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> results, string error);
            I2.Loc.GoogleTranslation.Translate(requests:  (GoogleTranslation.<>c__DisplayClass2_0)[1152921528727491200].queries, OnTranslationReady:  new GoogleTranslation.fnOnTranslationReady(), usePOST:  false);
        }
        public static string ForceTranslate(string text, string LanguageCodeFrom, string LanguageCodeTo)
        {
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_1 = new System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>();
            I2.Loc.GoogleTranslation.AddQuery(text:  text, LanguageCodeFrom:  LanguageCodeFrom, LanguageCodeTo:  LanguageCodeTo, dict:  val_1);
            I2.Loc.TranslationJob_Main val_2 = new I2.Loc.TranslationJob_Main(requests:  val_1, OnTranslationReady:  0);
            do
            {
            
            }
            while(val_2 == null);
            
            if(val_2 != 2)
            {
                    return I2.Loc.GoogleTranslation.GetQueryResult(text:  text, LanguageCodeTo:  "", dict:  val_1);
            }
            
            return 0;
        }
        public static void Translate(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, I2.Loc.GoogleTranslation.fnOnTranslationReady OnTranslationReady, bool usePOST = True)
        {
            I2.Loc.GoogleTranslation.AddTranslationJob(job:  new I2.Loc.TranslationJob_Main(requests:  requests, OnTranslationReady:  OnTranslationReady));
        }
        public static bool ForceTranslate(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, bool usePOST = True)
        {
            I2.Loc.TranslationJob_Main val_1 = new I2.Loc.TranslationJob_Main(requests:  requests, OnTranslationReady:  0);
            do
            {
            
            }
            while(val_1 == null);
            
            return (bool)(val_1 != 2) ? 1 : 0;
        }
        public static System.Collections.Generic.List<string> ConvertTranslationRequest(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, bool encodeGET)
        {
            string val_4;
            string val_5;
            var val_6;
            string val_24;
            System.Collections.Generic.List<T> val_25;
            string val_26;
            var val_27;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            System.Text.StringBuilder val_2 = new System.Text.StringBuilder();
            Dictionary.Enumerator<TKey, TValue> val_3 = requests.GetEnumerator();
            label_24:
            val_24 = public System.Boolean Dictionary.Enumerator<System.String, I2.Loc.TranslationQuery>::MoveNext();
            if(((-1648551864) & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_2 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_26 = val_4;
            if(val_2.Length >= 1)
            {
                    System.Text.StringBuilder val_8 = val_2.Append(value:  "<I2Loc>");
            }
            
            System.Text.StringBuilder val_10 = val_2.Append(value:  I2.Loc.GoogleLanguages.GetGoogleLanguageCode(InternationalCode:  val_5));
            val_24 = ":";
            System.Text.StringBuilder val_11 = val_2.Append(value:  val_24);
            if(val_6 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_6 + 24) >= 1)
            {
                    var val_24 = 0;
                val_27 = (val_6 + 24) & 4294967295;
                var val_12 = val_6 + 32;
                do
            {
                if(val_24 != 0)
            {
                    System.Text.StringBuilder val_13 = val_2.Append(value:  ",");
                val_27 = mem[val_6 + 24];
                val_27 = val_6 + 24;
            }
            
                System.Text.StringBuilder val_15 = val_2.Append(value:  I2.Loc.GoogleLanguages.GetGoogleLanguageCode(InternationalCode:  (val_6 + 32) + 0));
                val_24 = val_24 + 1;
            }
            while(val_24 < ((val_6 + 24) << ));
            
            }
            
            System.Text.StringBuilder val_16 = val_2.Append(value:  "=");
            val_24 = val_26;
            if((System.String.op_Equality(a:  I2.Loc.GoogleTranslation.TitleCase(s:  val_26), b:  val_24)) != false)
            {
                    if(val_26 == 0)
            {
                    throw new NullReferenceException();
            }
            
                val_26 = val_26.ToLowerInvariant();
            }
            
            if(encodeGET == false)
            {
                goto label_18;
            }
            
            System.Text.StringBuilder val_21 = val_2.Append(value:  System.Uri.EscapeDataString(stringToEscape:  val_26));
            if(val_2.Length < 4001)
            {
                goto label_24;
            }
            
            val_24 = val_2;
            val_25 = val_1;
            if(val_25 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_1.Add(item:  val_2);
            val_2.Length = 0;
            goto label_24;
            label_18:
            System.Text.StringBuilder val_23 = val_2.Append(value:  val_26);
            goto label_24;
            label_2:
            Dispose();
            val_1.Add(item:  val_2);
            return val_1;
        }
        private static void AddTranslationJob(I2.Loc.TranslationJob job)
        {
            null = null;
            I2.Loc.GoogleTranslation.mTranslationJobs.Add(item:  job);
            if((I2.Loc.GoogleTranslation.mTranslationJobs + 24) != 1)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_2 = I2.Loc.CoroutineManager.Start(coroutine:  I2.Loc.GoogleTranslation.WaitForTranslations());
        }
        private static System.Collections.IEnumerator WaitForTranslations()
        {
            .<>1__state = 0;
            return (System.Collections.IEnumerator)new GoogleTranslation.<WaitForTranslations>d__11();
        }
        public static string ParseTranslationResult(string html, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests)
        {
            System.String[] val_11;
            string val_12;
            string val_13;
            System.String[] val_14;
            System.String[] val_24;
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_25;
            var val_26;
            var val_27;
            System.String[] val_28;
            string val_29;
            val_25 = requests;
            if((html.StartsWith(value:  "<!DOCTYPE html>")) != true)
            {
                    if((html.StartsWith(value:  "<HTML>")) == false)
            {
                goto label_3;
            }
            
            }
            
            if((html.Contains(value:  "The script completed but did not return anything")) != false)
            {
                    val_26 = "The current Google WebService is not supported.\nPlease, delete the WebService from the Google Drive and Install the latest version.";
                return (string)"There was a problem contacting the WebService. Please try again later\n" + html;
            }
            
            if((html.Contains(value:  "Service invoked too many times in a short time")) == false)
            {
                    return (string)"There was a problem contacting the WebService. Please try again later\n" + html;
            }
            
            val_26 = "";
            return (string)"There was a problem contacting the WebService. Please try again later\n" + html;
            label_3:
            string[] val_5 = new string[1];
            val_5[0] = "<I2Loc>";
            System.String[] val_6 = html.Split(separator:  val_5, options:  0);
            string[] val_7 = new string[1];
            val_24 = "<i2>";
            val_28 = val_7;
            val_28[0] = "<i2>";
            int val_23 = val_9.Length;
            if(val_23 >= 1)
            {
                    var val_29 = 0;
                val_23 = val_23 & 4294967295;
                do
            {
                TSource val_24 = System.Linq.Enumerable.ToArray<System.String>(source:  val_25.Keys)[val_29];
                I2.Loc.TranslationQuery val_10 = I2.Loc.GoogleTranslation.FindQueryFromOrigText(origText:  val_24, dict:  val_25);
                val_24 = val_14;
                val_29 = val_6[val_29];
                if(val_24 != 0)
            {
                    var val_25 = val_14 + 24;
                val_25 = val_25 - 1;
                if(val_29 >= 0)
            {
                    int val_26 = (long)val_25;
                do
            {
                var val_16 = val_24 + (((long)(int)((val_14 + 24 - 1))) << 3);
                val_26 = val_26 - 1;
                val_29 = val_29.Replace(oldValue:  I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  val_26), newValue:  (val_14 + ((long)(int)((val_14 + 24 - 1))) << 3) + 32);
            }
            while((val_26 & 2147483648) == 0);
            
            }
            
            }
            
                val_28 = val_6;
                System.String[] val_18 = val_29.Split(separator:  val_7, options:  0);
                if((System.String.op_Equality(a:  I2.Loc.GoogleTranslation.TitleCase(s:  val_24), b:  val_24)) != false)
            {
                    int val_27 = val_18.Length;
                if(val_27 >= 1)
            {
                    var val_28 = 0;
                val_27 = val_27 & 4294967295;
                do
            {
                mem2[0] = I2.Loc.GoogleTranslation.TitleCase(s:  1152921505165333712);
                val_28 = val_28 + 1;
            }
            while(val_28 < (val_18.Length << ));
            
            }
            
            }
            
                val_13 = val_13;
                val_11 = val_11;
                val_12 = val_12;
                val_14 = val_24;
                val_25 = val_25;
                val_29 = val_29 + 1;
                val_25.set_Item(key:  val_13, value:  new I2.Loc.TranslationQuery() {OrigText = val_13, Text = val_12, LanguageCode = val_12, TargetLanguagesCode = val_11, Results = val_18, Tags = val_14});
            }
            while(val_29 < (val_9.Length << ));
            
            }
            
            val_27 = 0;
            return (string)"There was a problem contacting the WebService. Please try again later\n" + html;
        }
        public static bool IsTranslating()
        {
            var val_2;
            var val_4;
            val_2 = null;
            val_2 = null;
            if((I2.Loc.GoogleTranslation.mCurrentTranslations + 24) <= 0)
            {
                    return (bool)((I2.Loc.GoogleTranslation.mTranslationJobs + 24) > 0) ? 1 : 0;
            }
            
            val_4 = 1;
            return (bool)((I2.Loc.GoogleTranslation.mTranslationJobs + 24) > 0) ? 1 : 0;
        }
        public static void CancelCurrentGoogleTranslations()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            I2.Loc.GoogleTranslation.mCurrentTranslations.Clear();
            List.Enumerator<T> val_1 = I2.Loc.GoogleTranslation.mTranslationJobs.GetEnumerator();
            label_7:
            if(((-1647318824) & 1) == 0)
            {
                goto label_5;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            goto label_7;
            label_5:
            0.Dispose();
            val_3 = null;
            val_3 = null;
            I2.Loc.GoogleTranslation.mTranslationJobs.Clear();
        }
        public static void CreateQueries(string text, string LanguageCodeFrom, string LanguageCodeTo, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            var val_4;
            if((text.Contains(value:  "[i2s_")) == false)
            {
                goto label_2;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_3 = I2.Loc.SpecializationManager.GetSpecializations(text:  text, buffer:  0).GetEnumerator();
            val_4 = 1152921515587819216;
            label_9:
            if(((-1647186392) & 1) == 0)
            {
                goto label_6;
            }
            
            I2.Loc.GoogleTranslation.CreateQueries_Plurals(text:  0, LanguageCodeFrom:  LanguageCodeFrom, LanguageCodeTo:  LanguageCodeTo, dict:  dict);
            goto label_9;
            label_2:
            I2.Loc.GoogleTranslation.CreateQueries_Plurals(text:  text, LanguageCodeFrom:  LanguageCodeFrom, LanguageCodeTo:  LanguageCodeTo, dict:  dict);
            return;
            label_6:
            0.Dispose();
        }
        private static void CreateQueries_Plurals(string text, string LanguageCodeFrom, string LanguageCodeTo, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            string val_15;
            string val_16;
            bool val_1 = text.Contains(value:  "{[#");
            if(((val_1 | (text.Contains(value:  "[i2p_"))) != false) && ((I2.Loc.GoogleTranslation.HasParameters(text:  text)) != false))
            {
                    do
            {
                val_15 = 0;
                string val_5 = 0.ToString();
                string val_6 = 0.ToString();
                if((I2.Loc.GoogleLanguages.LanguageHasPluralType(langCode:  LanguageCodeTo, pluralType:  val_5)) != false)
            {
                    val_16 = I2.Loc.GoogleTranslation.GetPluralText(text:  text, pluralType:  val_5);
                string val_11 = I2.Loc.GoogleTranslation.GetPluralParameter(text:  val_16, forceTag:  val_1);
                val_15 = val_11;
                if((System.String.IsNullOrEmpty(value:  val_11)) != true)
            {
                    val_16 = val_16.Replace(oldValue:  val_15, newValue:  I2.Loc.GoogleLanguages.GetPluralTestNumber(langCode:  LanguageCodeTo, pluralType:  null).ToString());
            }
            
                I2.Loc.GoogleTranslation.AddQuery(text:  val_16, LanguageCodeFrom:  LanguageCodeFrom, LanguageCodeTo:  LanguageCodeTo, dict:  dict);
            }
            
                string val_15 = val_15 + 1;
            }
            while(val_15 < 6);
            
                return;
            }
            
            I2.Loc.GoogleTranslation.AddQuery(text:  text, LanguageCodeFrom:  LanguageCodeFrom, LanguageCodeTo:  LanguageCodeTo, dict:  dict);
        }
        public static void AddQuery(string text, string LanguageCodeFrom, string LanguageCodeTo, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            string val_4;
            T[] val_5;
            string val_6;
            var val_7;
            T[] val_16;
            var val_17;
            if((System.String.IsNullOrEmpty(value:  text)) == true)
            {
                    return;
            }
            
            if((dict.ContainsKey(key:  text)) != false)
            {
                    I2.Loc.TranslationQuery val_3 = dict.Item[text];
                val_16 = val_5;
                if(((System.Array.IndexOf<System.String>(array:  val_16, value:  LanguageCodeTo)) & 2147483648) != 0)
            {
                    string[] val_9 = new string[1];
                val_9[0] = LanguageCodeTo;
                val_16 = System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Distinct<System.String>(source:  System.Linq.Enumerable.Concat<System.String>(first:  val_16, second:  val_9)));
            }
            
                val_17 = public System.Void System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>::set_Item(System.String key, I2.Loc.TranslationQuery value);
                val_4 = val_4;
                val_5 = val_16;
                val_6 = val_6;
                val_7 = val_7;
            }
            else
            {
                    string[] val_13 = new string[1];
                val_13[0] = LanguageCodeTo;
                I2.Loc.GoogleTranslation.ParseNonTranslatableElements(query: ref  new I2.Loc.TranslationQuery() {OrigText = text, Text = text, LanguageCode = LanguageCodeFrom, TargetLanguagesCode = val_13});
                val_17 = public System.Void System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>::set_Item(System.String key, I2.Loc.TranslationQuery value);
                val_4 = LanguageCodeFrom;
                val_7 = 0;
                val_6 = text;
            }
            
            dict.set_Item(key:  text, value:  new I2.Loc.TranslationQuery() {OrigText = val_6, Text = val_6, LanguageCode = val_4, TargetLanguagesCode = val_4});
        }
        private static string GetTranslation(string text, string LanguageCodeTo, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            T[] val_3;
            var val_4;
            var val_7;
            var val_8;
            if((dict.ContainsKey(key:  text)) != false)
            {
                    I2.Loc.TranslationQuery val_2 = dict.Item[text];
                int val_5 = System.Array.IndexOf<System.String>(array:  val_3, value:  LanguageCodeTo);
                val_7 = "";
                if(((val_5 & 2147483648) == 0) && (val_4 != 0))
            {
                    val_7 = (val_4 + (val_5 << 3)) + 32;
            }
            
                val_8 = mem[((val_4 + (val_5) << 3) + 32)];
                val_8 = val_7;
                return (string)val_8;
            }
            
            val_8 = 0;
            return (string)val_8;
        }
        private static I2.Loc.TranslationQuery FindQueryFromOrigText(string origText, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            System.String[] val_2;
            string val_3;
            System.String[] val_4;
            string val_5;
            string val_9;
            System.String[] val_10;
            I2.Loc.TranslationQuery val_0;
            val_9 = dict;
            Dictionary.Enumerator<TKey, TValue> val_1 = val_9.GetEnumerator();
            label_3:
            if(((-1645816832) & 1) == 0)
            {
                goto label_2;
            }
            
            val_9 = val_5;
            if((System.String.op_Equality(a:  val_9, b:  origText)) == false)
            {
                goto label_3;
            }
            
            Dispose();
            val_10 = val_2;
            val_0.OrigText = val_9;
            val_0.Tags = val_10;
            val_0.TargetLanguagesCode = val_4;
            val_0.Text = val_3;
            return val_0;
            label_2:
            val_10 = 1152921528728086048;
            Dispose();
            val_0.LanguageCode = 0;
            val_0.Results = 0;
            val_0.OrigText = 0;
            return val_0;
        }
        public static bool HasParameters(string text)
        {
            var val_4;
            int val_1 = text.IndexOf(value:  "{[");
            if((val_1 & 2147483648) == 0)
            {
                    var val_3 = ((text.IndexOf(value:  "]}", startIndex:  val_1)) > 0) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public static string GetPluralParameter(string text, bool forceTag)
        {
            int val_1 = text.IndexOf(value:  "{[#");
            if((val_1 & 2147483648) != 0)
            {
                goto label_2;
            }
            
            label_5:
            int val_2 = val_1 + 2;
            int val_3 = text.IndexOf(value:  "]}", startIndex:  val_2);
            if((val_3 & 2147483648) != 0)
            {
                    return 0;
            }
            
            var val_5 = 2;
            val_5 = val_5 - val_1;
            val_2 = val_5 + val_3;
            return text.Substring(startIndex:  val_1, length:  val_2);
            label_2:
            if(forceTag == true)
            {
                    return 0;
            }
            
            if(((text.IndexOf(value:  "{[")) & 2147483648) == 0)
            {
                goto label_5;
            }
            
            return 0;
        }
        public static string GetPluralText(string text, string pluralType)
        {
            int val_8;
            string val_8 = "[i2p_" + pluralType + "]";
            int val_2 = text.IndexOf(value:  val_8);
            if((val_2 & 2147483648) != 0)
            {
                goto label_2;
            }
            
            val_8 = val_1.m_stringLength + val_2;
            label_9:
            val_8 = text;
            if(((val_8.IndexOf(value:  "[i2p_", startIndex:  val_8)) & 2147483648) == 0)
            {
                    return text.Substring(startIndex:  val_8, length:  val_8 - val_8);
            }
            
            val_8 = text.m_stringLength;
            return text.Substring(startIndex:  val_8, length:  val_8 - val_8);
            label_2:
            int val_5 = text.IndexOf(value:  "[i2p_");
            if((val_5 & 2147483648) != 0)
            {
                    return (string)text;
            }
            
            if(val_5 != 0)
            {
                    return text.Substring(startIndex:  val_8, length:  val_8 - val_8);
            }
            
            int val_6 = text.IndexOf(value:  "]");
            if((val_6 & 2147483648) != 0)
            {
                    return (string)text;
            }
            
            int val_7 = val_6 + 1;
            goto label_9;
        }
        private static int FindClosingTag(string tag, System.Text.RegularExpressions.MatchCollection matches, int startIndex)
        {
            int val_7 = startIndex;
            int val_1 = matches.Count;
            if(val_1 > val_7)
            {
                    do
            {
                string val_2 = I2.Loc.I2Utils.GetCaptureMatch(match:  matches);
                if((val_2.Chars[0] & 65535) == ('/'))
            {
                    if((tag.StartsWith(value:  val_2.Substring(startIndex:  1))) == true)
            {
                    return (int)val_7;
            }
            
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 < val_1);
            
            }
            
            val_7 = 0;
            return (int)val_7;
        }
        private static string GetGoogleNoTranslateTag(int tagNumber)
        {
            int val_3 = tagNumber;
            if(val_3 <= 69)
            {
                    return Substring(startIndex:  0, length:  val_3 + 1);
            }
            
            val_3 = val_3 + 1;
            do
            {
                val_3 = val_3 - 1;
            }
            while(val_3 != 69);
            
            return (string)"" + "+"("+");
        }
        private static void ParseNonTranslatableElements(ref I2.Loc.TranslationQuery query)
        {
            var val_26;
            var val_27;
            string val_28;
            System.Collections.Generic.List<T> val_29;
            var val_30;
            string val_31;
            string val_32;
            int val_33;
            var val_34;
            val_27 = 1152921528732009200;
            System.Text.RegularExpressions.MatchCollection val_1 = System.Text.RegularExpressions.Regex.Matches(input:  query.Text, pattern:  "\\{\\[(.*?)]}|\\[(.*?)]|\\<(.*?)>");
            if(val_1 == null)
            {
                    return;
            }
            
            if(val_1.Count == 0)
            {
                    return;
            }
            
            val_28 = query.Text;
            System.Collections.Generic.List<System.String> val_3 = null;
            val_29 = val_3;
            val_3 = new System.Collections.Generic.List<System.String>();
            int val_4 = val_1.Count;
            if(val_4 < 1)
            {
                goto label_5;
            }
            
            val_30 = "i2nt";
            val_26 = val_4;
            var val_26 = 0;
            label_35:
            string val_5 = I2.Loc.I2Utils.GetCaptureMatch(match:  val_1);
            if(((I2.Loc.GoogleTranslation.FindClosingTag(tag:  val_5, matches:  val_1, startIndex:  0)) & 2147483648) != 0)
            {
                goto label_8;
            }
            
            if((System.String.op_Equality(a:  val_5, b:  "i2nt")) == false)
            {
                goto label_9;
            }
            
            val_29 = val_29;
            val_31 = query.Text.Substring(startIndex:  val_1._matches, length:  (val_1._matches - val_1._matches) + 1152921504729690112);
            val_27 = val_27;
            val_26 = val_26;
            val_32 = query.Text.Replace(oldValue:  val_31, newValue:  I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  mem[1152921528732140264])(I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  mem[1152921528732140264])) + " ");
            val_3.Add(item:  val_31);
            val_30 = "i2nt";
            goto label_23;
            label_8:
            string val_14 = val_1.ToString();
            val_31 = val_14;
            if(((val_14.StartsWith(value:  "{[")) == false) || ((val_31.EndsWith(value:  "]}")) == false))
            {
                goto label_23;
            }
            
            val_33 = val_5;
            goto label_27;
            label_9:
            string val_17 = val_1.ToString();
            val_29 = val_29;
            val_34 = query.Text.Replace(oldValue:  val_17, newValue:  I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  -1644510512)(I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  -1644510512)) + " ");
            val_3.Add(item:  val_17);
            val_31 = val_1.ToString();
            val_33 = mem[1152921528732140264];
            label_27:
            val_32 = val_34.Replace(oldValue:  val_31, newValue:  I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  val_33)(I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  val_33)) + " ");
            val_3.Add(item:  val_31);
            label_23:
            val_26 = val_26 + 1;
            if(val_26 < val_26)
            {
                goto label_35;
            }
            
            label_5:
            query.Text = val_32;
            query.Tags = val_3.ToArray();
        }
        public static string GetQueryResult(string text, string LanguageCodeTo, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            var val_3;
            T[] val_4;
            string val_8;
            var val_9;
            val_8 = text;
            if((dict.ContainsKey(key:  val_8)) != false)
            {
                    I2.Loc.TranslationQuery val_2 = dict.Item[val_8];
                val_8 = val_3;
                if((val_8 != 0) && (((val_3 + 24) & 2147483648) == 0))
            {
                    if((System.String.IsNullOrEmpty(value:  LanguageCodeTo)) != false)
            {
                    val_9 = mem[val_3 + 32];
                val_9 = val_3 + 32;
                return (string)val_9;
            }
            
                int val_6 = System.Array.IndexOf<System.String>(array:  val_4, value:  LanguageCodeTo);
                if((val_6 & 2147483648) == 0)
            {
                    var val_7 = val_8 + (val_6 << 3);
                val_9 = mem[(val_3 + (val_6) << 3) + 32];
                val_9 = (val_3 + (val_6) << 3) + 32;
                return (string)val_9;
            }
            
            }
            
            }
            
            val_9 = 0;
            return (string)val_9;
        }
        public static string RebuildTranslation(string text, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict, string LanguageCodeTo)
        {
            string val_8 = text;
            if((val_8.Contains(value:  "[i2s_")) == false)
            {
                goto label_2;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.String> val_3 = null;
            val_8 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            Dictionary.Enumerator<TKey, TValue> val_4 = I2.Loc.SpecializationManager.GetSpecializations(text:  val_8 = text, buffer:  0).GetEnumerator();
            label_10:
            if(((-1643908824) & 1) == 0)
            {
                goto label_6;
            }
            
            if(val_8 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_3.set_Item(key:  0, value:  I2.Loc.GoogleTranslation.RebuildTranslation_Plural(text:  0, dict:  dict, LanguageCodeTo:  LanguageCodeTo));
            goto label_10;
            label_2:
            string val_6 = I2.Loc.GoogleTranslation.RebuildTranslation_Plural(text:  val_8, dict:  dict, LanguageCodeTo:  LanguageCodeTo);
            return (string)I2.Loc.SpecializationManager.SetSpecializedText(specializations:  val_3);
            label_6:
            0.Dispose();
            return (string)I2.Loc.SpecializationManager.SetSpecializedText(specializations:  val_3);
        }
        private static string RebuildTranslation_Plural(string text, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict, string LanguageCodeTo)
        {
            var val_24;
            var val_25;
            string val_26;
            string val_27;
            string val_28;
            var val_29;
            bool val_1 = text.Contains(value:  "{[#");
            val_25 = text.Contains(value:  "[i2p_");
            if(((val_1 | val_25) == false) || ((I2.Loc.GoogleTranslation.HasParameters(text:  text)) == false))
            {
                    return (string)I2.Loc.GoogleTranslation.GetTranslation(text:  text, LanguageCodeTo:  LanguageCodeTo, dict:  dict);
            }
            
            System.Text.StringBuilder val_5 = null;
            val_25 = val_5;
            val_5 = new System.Text.StringBuilder();
            val_24 = 1152921505147314176;
            label_25:
            string val_6 = 5.ToString();
            string val_7 = 5.ToString();
            val_26 = val_6;
            if((I2.Loc.GoogleLanguages.LanguageHasPluralType(langCode:  LanguageCodeTo, pluralType:  val_26)) == false)
            {
                goto label_23;
            }
            
            val_27 = I2.Loc.GoogleTranslation.GetPluralText(text:  text, pluralType:  val_6);
            int val_10 = I2.Loc.GoogleLanguages.GetPluralTestNumber(langCode:  LanguageCodeTo, pluralType:  null);
            string val_12 = I2.Loc.GoogleTranslation.GetPluralParameter(text:  val_27, forceTag:  val_1);
            if((System.String.IsNullOrEmpty(value:  val_12)) != true)
            {
                    val_27 = val_27.Replace(oldValue:  val_12, newValue:  val_10.ToString());
            }
            
            val_28 = I2.Loc.GoogleTranslation.GetTranslation(text:  val_27, LanguageCodeTo:  LanguageCodeTo, dict:  dict);
            if((System.String.IsNullOrEmpty(value:  val_12)) != true)
            {
                    val_28 = val_28.Replace(oldValue:  val_10.ToString(), newValue:  val_12);
            }
            
            if(null == 5)
            {
                    if(val_25 != null)
            {
                goto label_21;
            }
            
            }
            
            val_26 = 0;
            if((System.String.op_Equality(a:  val_28, b:  val_26)) == true)
            {
                goto label_23;
            }
            
            System.Text.StringBuilder val_21 = val_5.AppendFormat(format:  "[i2p_{0}]", arg0:  val_6);
            label_21:
            val_26 = val_28;
            System.Text.StringBuilder val_22 = val_5.Append(value:  val_26);
            label_23:
            if(null >= 0)
            {
                goto label_25;
            }
            
            val_29 = val_25;
            return (string)I2.Loc.GoogleTranslation.GetTranslation(text:  text, LanguageCodeTo:  LanguageCodeTo, dict:  dict);
        }
        public static string UppercaseFirst(string s)
        {
            if((System.String.IsNullOrEmpty(value:  s)) != false)
            {
                    return (string)System.String.alignConst;
            }
            
            System.Char[] val_6 = s.ToLower().ToCharArray();
            val_6 = System.Char.ToUpper(c:  val_6[0]);
            return 0.CreateString(val:  val_6);
        }
        public static string TitleCase(string s)
        {
            if((System.String.IsNullOrEmpty(value:  s)) == false)
            {
                    return System.Globalization.CultureInfo.CurrentCulture.ToTitleCase(str:  s);
            }
            
            return (string)System.String.alignConst;
        }
        private static GoogleTranslation()
        {
            I2.Loc.GoogleTranslation.mCurrentTranslations = new System.Collections.Generic.List<UnityEngine.Networking.UnityWebRequest>();
            I2.Loc.GoogleTranslation.mTranslationJobs = new System.Collections.Generic.List<I2.Loc.TranslationJob>();
        }
    
    }

}
