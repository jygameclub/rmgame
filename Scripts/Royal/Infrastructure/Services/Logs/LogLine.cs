using UnityEngine;

namespace Royal.Infrastructure.Services.Logs
{
    public struct LogLine
    {
        // Fields
        public System.DateTime dateTime;
        public int frameCount;
        public Royal.Infrastructure.Services.Logs.LogLevel logLevel;
        public Royal.Infrastructure.Services.Logs.LogTag logTag;
        public System.Type classType;
        public string message;
        public object[] Params;
        public Royal.Infrastructure.Services.Analytics.EventData eventData;
        private const string Delimiter = " | ";
        private const string PreMessageDelimiter = " > ";
        private const string TimeFormat = "yy/MM/dd HH:mm:ss.fff";
        
        // Methods
        public void LineToString(System.Text.StringBuilder builder)
        {
            builder = this.logTag;
            builder = this.logTag + 8;
            builder = this.logTag + 16;
            builder = this.logTag + 24;
            builder = this.logTag + 32;
            builder = this.logTag + 40;
        }
        public static string FormatMessage(string message, object[] values)
        {
            return (string)System.String.Format(format:  message, args:  values);
        }
    
    }

}
