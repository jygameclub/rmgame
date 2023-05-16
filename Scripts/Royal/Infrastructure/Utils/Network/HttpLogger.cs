using UnityEngine;

namespace Royal.Infrastructure.Utils.Network
{
    public class HttpLogger : ILogger
    {
        // Fields
        private BestHTTP.Logger.Loglevels <Level>k__BackingField;
        private string <FormatVerbose>k__BackingField;
        private string <FormatInfo>k__BackingField;
        private string <FormatWarn>k__BackingField;
        private string <FormatErr>k__BackingField;
        private string <FormatEx>k__BackingField;
        
        // Properties
        public BestHTTP.Logger.Loglevels Level { get; set; }
        public string FormatVerbose { get; set; }
        public string FormatInfo { get; set; }
        public string FormatWarn { get; set; }
        public string FormatErr { get; set; }
        public string FormatEx { get; set; }
        
        // Methods
        public BestHTTP.Logger.Loglevels get_Level()
        {
            return (BestHTTP.Logger.Loglevels)this.<Level>k__BackingField;
        }
        public void set_Level(BestHTTP.Logger.Loglevels value)
        {
            this.<Level>k__BackingField = value;
        }
        public string get_FormatVerbose()
        {
            return (string)this.<FormatVerbose>k__BackingField;
        }
        public void set_FormatVerbose(string value)
        {
            this.<FormatVerbose>k__BackingField = value;
        }
        public string get_FormatInfo()
        {
            return (string)this.<FormatInfo>k__BackingField;
        }
        public void set_FormatInfo(string value)
        {
            this.<FormatInfo>k__BackingField = value;
        }
        public string get_FormatWarn()
        {
            return (string)this.<FormatWarn>k__BackingField;
        }
        public void set_FormatWarn(string value)
        {
            this.<FormatWarn>k__BackingField = value;
        }
        public string get_FormatErr()
        {
            return (string)this.<FormatErr>k__BackingField;
        }
        public void set_FormatErr(string value)
        {
            this.<FormatErr>k__BackingField = value;
        }
        public string get_FormatEx()
        {
            return (string)this.<FormatEx>k__BackingField;
        }
        public void set_FormatEx(string value)
        {
            this.<FormatEx>k__BackingField = value;
        }
        public HttpLogger()
        {
            this.<FormatVerbose>k__BackingField = "[{0}] D [{1}]: {2}";
            this.<FormatInfo>k__BackingField = "[{0}] I [{1}]: {2}";
            this.<FormatWarn>k__BackingField = "[{0}] W [{1}]: {2}";
            this.<FormatErr>k__BackingField = "[{0}] Err [{1}]: {2}";
            this.<FormatEx>k__BackingField = "[{0}] Ex [{1}]: {2} - Message: {3}";
        }
        public void Verbose(string division, string verb)
        {
            string val_11;
            int val_13;
            if((this.<Level>k__BackingField) != 0)
            {
                    return;
            }
            
            val_11 = this.<FormatVerbose>k__BackingField;
            object[] val_1 = new object[3];
            string val_2 = val_1.GetFormattedTime();
            if(val_2 != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            val_13 = val_1.Length;
            if(val_13 == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_1[0] = val_2;
            if(division != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
                val_13 = val_1.Length;
            }
            
            if(val_13 <= 1)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_1[1] = division;
            if(verb != null)
            {
                    val_13 = val_1.Length;
            }
            
            val_1[2] = verb;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  8, log:  val_11, values:  val_1);
        }
        public void Information(string division, string info)
        {
            string val_11;
            int val_13;
            if((this.<Level>k__BackingField) > 1)
            {
                    return;
            }
            
            val_11 = this.<FormatInfo>k__BackingField;
            object[] val_1 = new object[3];
            string val_2 = val_1.GetFormattedTime();
            if(val_2 != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            val_13 = val_1.Length;
            if(val_13 == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_1[0] = val_2;
            if(division != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
                val_13 = val_1.Length;
            }
            
            if(val_13 <= 1)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_1[1] = division;
            if(info != null)
            {
                    val_13 = val_1.Length;
            }
            
            val_1[2] = info;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  8, log:  val_11, values:  val_1);
        }
        public void Warning(string division, string warn)
        {
            string val_11;
            int val_13;
            if((this.<Level>k__BackingField) > 2)
            {
                    return;
            }
            
            val_11 = this.<FormatWarn>k__BackingField;
            object[] val_1 = new object[3];
            string val_2 = val_1.GetFormattedTime();
            if(val_2 != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            val_13 = val_1.Length;
            if(val_13 == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_1[0] = val_2;
            if(division != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
                val_13 = val_1.Length;
            }
            
            if(val_13 <= 1)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_1[1] = division;
            if(warn != null)
            {
                    val_13 = val_1.Length;
            }
            
            val_1[2] = warn;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  8, log:  val_11, values:  val_1);
        }
        public void Error(string division, string err)
        {
            string val_11;
            int val_13;
            if((this.<Level>k__BackingField) > 3)
            {
                    return;
            }
            
            val_11 = this.<FormatErr>k__BackingField;
            object[] val_1 = new object[3];
            string val_2 = val_1.GetFormattedTime();
            if(val_2 != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            val_13 = val_1.Length;
            if(val_13 == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_1[0] = val_2;
            if(division != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
                val_13 = val_1.Length;
            }
            
            if(val_13 <= 1)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_1[1] = division;
            if(err != null)
            {
                    val_13 = val_1.Length;
            }
            
            val_1[2] = err;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  8, log:  val_11, values:  val_1);
        }
        public void Exception(string division, string msg, System.Exception ex)
        {
            string val_7;
            object val_8;
            object val_9;
            var val_10;
            int val_11;
            object val_12;
            if((this.<Level>k__BackingField) > 4)
            {
                    return;
            }
            
            if(ex == null)
            {
                goto label_2;
            }
            
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            var val_7 = 1;
            label_5:
            val_8 = ex;
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            System.Text.StringBuilder val_3 = val_1.AppendFormat(format:  "{0}: {1} {2}", arg0:  val_7.ToString(), arg1:  ex, arg2:  val_8);
            if(ex._innerException == null)
            {
                goto label_4;
            }
            
            val_7 = val_7 + 1;
            System.Text.StringBuilder val_4 = val_1.AppendLine();
            goto label_5;
            label_4:
            val_9 = val_1;
            goto label_6;
            label_2:
            val_9 = "null";
            label_6:
            val_7 = this.<FormatEx>k__BackingField;
            val_10 = 5;
            object[] val_5 = new object[5];
            string val_6 = val_5.GetFormattedTime();
            if(val_6 != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            val_11 = val_5.Length;
            if(val_11 == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_5[0] = val_6;
            if(division != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
                val_11 = val_5.Length;
            }
            
            if(val_11 <= 1)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_5[1] = division;
            if(msg != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
                val_11 = val_5.Length;
            }
            
            if(val_11 <= 2)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_5[2] = msg;
            if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            val_11 = val_5.Length;
            if(val_11 <= 3)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_5[3] = val_9;
            if(ex == null)
            {
                goto label_20;
            }
            
            val_12 = ex;
            if(val_12 != null)
            {
                goto label_21;
            }
            
            goto label_23;
            label_20:
            val_12 = "null";
            label_21:
            label_23:
            val_5[4] = val_12;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  8, log:  val_7, values:  val_5);
        }
        private string GetFormattedTime()
        {
            System.DateTime val_1 = System.DateTime.Now;
            return (string)val_1.dateData.Ticks.ToString();
        }
    
    }

}
