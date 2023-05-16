using UnityEngine;

namespace Royal.Infrastructure.Services.Analytics
{
    public class EventParameter
    {
        // Fields
        private const byte StringType = 0;
        private const byte LongType = 1;
        private const byte DoubleType = 2;
        private const byte JsonType = 3;
        private const byte JsonStringType = 4;
        private readonly string key;
        private object value;
        private byte type;
        
        // Methods
        public EventParameter(string key, string value)
        {
            val_1 = new System.Object();
            this.key = key;
            this.value = val_1;
            this.type = 0;
        }
        public EventParameter(string key, long value)
        {
            this.key = key;
            this.value = value;
            this.type = 1;
        }
        public EventParameter(string key, double value)
        {
            this.key = key;
            this.value = value;
            this.type = 2;
        }
        public EventParameter(string key, object value)
        {
            val_1 = new System.Object();
            this.key = key;
            this.value = val_1;
            this.type = 3;
        }
        public Firebase.Analytics.Parameter ToFbParameter()
        {
            string val_5;
            object val_6;
            Firebase.Analytics.Parameter val_7;
            if(this.type == 1)
            {
                goto label_1;
            }
            
            if(this.type == 2)
            {
                goto label_2;
            }
            
            if(this.type != 3)
            {
                goto label_3;
            }
            
            string val_1 = UnityEngine.JsonUtility.ToJson(obj:  this.value);
            val_5 = val_1;
            this.value = val_1;
            this.type = 4;
            goto label_4;
            label_2:
            val_5 = this.key;
            val_6 = this.value;
            val_7 = new Firebase.Analytics.Parameter();
            val_6.System.IDisposable.Dispose();
            val_7 = new Firebase.Analytics.Parameter(parameterName:  val_5, parameterValue:  1.28822975940269E-231);
            return val_7;
            label_1:
            val_5 = this.key;
            val_6 = this.value;
            val_7 = new Firebase.Analytics.Parameter();
            val_6.System.IDisposable.Dispose();
            val_7 = new Firebase.Analytics.Parameter(parameterName:  val_5, parameterValue:  null);
            return val_7;
            label_3:
            val_5 = this.value;
            label_4:
            val_7 = new Firebase.Analytics.Parameter();
            if(val_5 != null)
            {
                    if(null != null)
            {
                goto label_12;
            }
            
            }
            
            val_7 = new Firebase.Analytics.Parameter(parameterName:  this.key, parameterValue:  val_5);
            return val_7;
            label_12:
        }
        public override string ToString()
        {
            string val_2;
            object val_3;
            string val_4;
            if(this.type != 3)
            {
                goto label_1;
            }
            
            string val_1 = UnityEngine.JsonUtility.ToJson(obj:  this.value);
            val_2 = this.key;
            val_3 = val_1;
            this.value = val_1;
            this.type = 4;
            goto label_2;
            label_1:
            val_2 = this.key;
            val_3 = this.value;
            if(this.type == 0)
            {
                goto label_3;
            }
            
            label_2:
            val_4 = "\"{0}\":{1}";
            return System.String.Format(format:  val_4 = "\"{0}\":\"{1}\"", arg0:  val_2, arg1:  val_3);
            label_3:
            return System.String.Format(format:  val_4, arg0:  val_2, arg1:  val_3);
        }
    
    }

}
