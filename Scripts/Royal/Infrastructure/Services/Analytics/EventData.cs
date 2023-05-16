using UnityEngine;

namespace Royal.Infrastructure.Services.Analytics
{
    public class EventData
    {
        // Fields
        public readonly string name;
        private readonly System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> parameters;
        private readonly Royal.Infrastructure.Services.Analytics.BasicInfo basicInfo;
        private readonly Royal.Infrastructure.Services.Analytics.EventParameter deviceInfo;
        
        // Methods
        public EventData(string name, System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> parameters, int timeOffset = 0)
        {
            val_1 = new System.Object();
            this.name = name;
            this.parameters = val_1;
            .event_time = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs() + (timeOffset << );
            .user_id = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name;
            .is_payer = IsPaidUser;
            this.basicInfo = new Royal.Infrastructure.Services.Analytics.BasicInfo();
            .key = "deviceInfo";
            .value = Royal.Infrastructure.Utils.Native.DeviceHelper.GetDeviceInfo();
            .type = 3;
            this.deviceInfo = new Royal.Infrastructure.Services.Analytics.EventParameter();
        }
        public Firebase.Analytics.Parameter[] ToFbParameterArray()
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Analytics.EventParameter> val_3;
            Firebase.Analytics.Parameter[] val_1 = new Firebase.Analytics.Parameter[0];
            val_3 = this.parameters;
            var val_4 = 4;
            do
            {
                var val_2 = val_4 - 4;
                if(val_2 >= 1152921507817884704)
            {
                    return val_1;
            }
            
                if(1152921507817884704 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1[0] = ToFbParameter();
                val_3 = this.parameters;
                val_4 = val_4 + 1;
            }
            while(val_3 != null);
            
            throw new NullReferenceException();
        }
        public void ToString(System.Text.StringBuilder builder)
        {
            System.Text.StringBuilder val_8 = builder.Append(value:  "{\"key\":\"").Append(value:  this.name).Append(value:  '_').Append(value:  this.basicInfo.event_time).Append(value:  '_').Append(value:  Royal.Infrastructure.Utils.Native.DeviceHelper.DeviceId()).Append(value:  "\",\"value\":{");
            .key = "basicInfo";
            .value = this.basicInfo;
            .type = 3;
            System.Text.StringBuilder val_10 = val_8.Append(value:  new Royal.Infrastructure.Services.Analytics.EventParameter());
            var val_15 = 0;
            label_15:
            System.Text.StringBuilder val_11 = builder.Append(value:  ',');
            if(val_15 >= val_8)
            {
                goto label_11;
            }
            
            if(val_15 >= this.parameters)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.Text.StringBuilder val_12 = val_11.Append(value:  System.Collections.Generic.List<T>.__il2cppRuntimeField_byval_arg);
            val_15 = val_15 + 1;
            if(this.parameters != null)
            {
                goto label_15;
            }
            
            label_11:
            System.Text.StringBuilder val_13 = val_11.Append(value:  this.deviceInfo);
            System.Text.StringBuilder val_14 = builder.Append(value:  "}}");
        }
        public override string ToString()
        {
            this.ToString(builder:  new System.Text.StringBuilder());
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
        }
    
    }

}
