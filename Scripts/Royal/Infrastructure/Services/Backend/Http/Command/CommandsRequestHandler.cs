using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command
{
    public class CommandsRequestHandler
    {
        // Fields
        private const float ConnectionTimeOut = 5;
        public const float DefaultTimeOut = 10;
        private readonly float timeOut;
        private readonly System.Uri endPoint;
        private readonly Royal.Infrastructure.Services.Backend.Http.Command.Commands commands;
        private System.DateTime requestSendTime;
        private bool isCancelled;
        private BestHTTP.HTTPRequest request;
        private byte errorCount;
        private System.Action<Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler> OnRequestCompleted;
        
        // Methods
        public void add_OnRequestCompleted(System.Action<Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnRequestCompleted, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnRequestCompleted != 1152921528639993512);
            
            return;
            label_2:
        }
        public void remove_OnRequestCompleted(System.Action<Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnRequestCompleted, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnRequestCompleted != 1152921528640130088);
            
            return;
            label_2:
        }
        public CommandsRequestHandler(System.Uri endPoint, Royal.Infrastructure.Services.Backend.Http.Command.Commands commands, float timeOut = 10)
        {
            val_1 = new System.Object();
            this.endPoint = endPoint;
            this.commands = val_1;
            this.timeOut = timeOut;
        }
        public void Send()
        {
            this.errorCount = 0;
            BestHTTP.HTTPRequest val_2 = new BestHTTP.HTTPRequest(uri:  this.endPoint, methodType:  2, callback:  new BestHTTP.OnRequestFinishedDelegate(object:  this, method:  System.Void Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler::RequestCompleted(BestHTTP.HTTPRequest originalRequest, BestHTTP.HTTPResponse response)));
            this.request = val_2;
            val_2.SetHeader(name:  "Content-Type", value:  "application/octet-stream");
            this.request = this.commands.PrepareRequests();
            System.TimeSpan val_4 = System.TimeSpan.FromSeconds(value:  5);
            this.request = val_4._ticks;
            System.TimeSpan val_5 = System.TimeSpan.FromSeconds(value:  (double)this.timeOut);
            this.request = val_5._ticks;
            BestHTTP.HTTPRequest val_6 = this.request.Send();
            System.DateTime val_7 = System.DateTime.Now;
            this.requestSendTime = val_7;
        }
        public bool IsTimeOut()
        {
            System.DateTime val_1 = System.DateTime.Now;
            System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_1.dateData}, d2:  new System.DateTime() {dateData = this.requestSendTime});
            return (bool)(this.timeOut <= (float)val_2._ticks.Seconds) ? 1 : 0;
        }
        private void RequestCompleted(BestHTTP.HTTPRequest originalRequest, BestHTTP.HTTPResponse response)
        {
            if(this.isCancelled != false)
            {
                    object[] val_1 = new object[1];
                val_1[0] = originalRequest.State;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  8, log:  "RequestCompleted ({0}) but timeout is already called", values:  val_1);
                return;
            }
            
            BestHTTP.HTTPRequestStates val_3 = originalRequest.State;
            if(val_3 > 6)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            var val_8 = 1;
            val_8 = val_8 << val_3;
            if((val_8 & 115) != 0)
            {
                goto label_9;
            }
            
            label_18:
            label_17:
            if(this.OnRequestCompleted != null)
            {
                    this.OnRequestCompleted.Invoke(obj:  this);
            }
            
            if((0 & 1) != 0)
            {
                    this.commands.Finish(data:  response.<Data>k__BackingField);
                return;
            }
            
            this.commands.Fail(httpState:  originalRequest.State);
            return;
            label_9:
            if(val_3 != 2)
            {
                goto label_15;
            }
            
            bool val_5 = response.IsSuccess;
            goto label_17;
            label_15:
            if(this.errorCount != 0)
            {
                goto label_18;
            }
            
            this.errorCount = 1;
            BestHTTP.HTTPRequest val_6 = this.request.Send();
        }
        public void Cancel()
        {
            var val_1;
            this.isCancelled = true;
            if(this.OnRequestCompleted != null)
            {
                    this.OnRequestCompleted.Invoke(obj:  this);
            }
            
            this.request.Abort();
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  8, log:  "HttpRequest cancelled because of timeout", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.commands.Fail(httpState:  6);
        }
    
    }

}
