using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command
{
    public class Commands
    {
        // Fields
        private static int PackageCounter;
        private Royal.Infrastructure.Services.Backend.Http.Command.Commands.ConnectionComplete OnComplete;
        private bool <SyncRequired>k__BackingField;
        private readonly FlatBuffers.FlatBufferBuilder requestBuilder;
        private readonly System.Collections.Generic.List<Royal.Infrastructure.Services.Backend.Protocol.RequestType> requestTypes;
        private readonly System.Collections.Generic.List<Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand> commands;
        private int packageId;
        private int requestFocus;
        private long requestUserId;
        private Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage <Response>k__BackingField;
        private bool <IsSuccess>k__BackingField;
        
        // Properties
        public bool SyncRequired { get; set; }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage Response { get; set; }
        public bool IsSuccess { get; set; }
        
        // Methods
        public void add_OnComplete(Royal.Infrastructure.Services.Backend.Http.Command.Commands.ConnectionComplete value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnComplete, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnComplete != 1152921528636555088);
            
            return;
            label_2:
        }
        public void remove_OnComplete(Royal.Infrastructure.Services.Backend.Http.Command.Commands.ConnectionComplete value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnComplete, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnComplete != 1152921528636691664);
            
            return;
            label_2:
        }
        public bool get_SyncRequired()
        {
            return (bool)this.<SyncRequired>k__BackingField;
        }
        public void set_SyncRequired(bool value)
        {
            this.<SyncRequired>k__BackingField = value;
        }
        public Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        private void set_Response(Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528637152016] = value.__p.bb;
        }
        public bool get_IsSuccess()
        {
            return (bool)this.<IsSuccess>k__BackingField;
        }
        private void set_IsSuccess(bool value)
        {
            this.<IsSuccess>k__BackingField = value;
        }
        public void Add(Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand httpCommand)
        {
            var val_3;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Backend.Protocol.RequestType> val_3 = this.requestTypes;
            int val_1 = W9 - 1;
            if()
            {
                    val_3 = val_3 + (val_1 << );
                if(W22 == httpCommand)
            {
                    this.commands.set_Item(index:  val_1, value:  httpCommand);
                val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  11, log:  "Replace last command: "("Replace last command: ") + httpCommand, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                return;
            }
            
            }
            
            this.commands.Add(item:  httpCommand);
            this.requestTypes.Add(item:  httpCommand);
        }
        public byte[] PrepareRequests()
        {
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            var val_18 = 0;
            label_6:
            if(val_18 >= 1152921518469134512)
            {
                goto label_2;
            }
            
            if(1152921518469134512 <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1.Add(item:  1541158080);
            val_18 = val_18 + 1;
            if(this.commands != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_2:
            int val_19 = Royal.Infrastructure.Services.Backend.Http.Command.Commands.PackageCounter;
            val_19 = val_19 + 1;
            Royal.Infrastructure.Services.Backend.Http.Command.Commands.PackageCounter = val_19;
            this.packageId = val_19;
            this.requestFocus = Royal.Infrastructure.Contexts.Units.App.AppManager.<FocusCount>k__BackingField;
            this.requestUserId = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name;
            object[] val_2 = new object[2];
            val_2[0] = this.packageId;
            val_2[1] = System.String.Join<Royal.Infrastructure.Services.Backend.Protocol.RequestType>(separator:  ", ", values:  this.requestTypes);
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  11, log:  "Send ({0}): {1}", values:  val_2);
            FlatBuffers.VectorOffset val_5 = Royal.Infrastructure.Services.Backend.Protocol.RequestPackage.CreateRequestsTypeVector(builder:  this.requestBuilder, data:  this.requestTypes.ToArray());
            FlatBuffers.VectorOffset val_7 = Royal.Infrastructure.Services.Backend.Protocol.RequestPackage.CreateRequestsVector(builder:  this.requestBuilder, data:  val_1.ToArray());
            FlatBuffers.StringOffset val_8 = this.requestBuilder.CreateString(s:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_namespaze);
            FlatBuffers.StringOffset val_10 = this.requestBuilder.CreateString(s:  Royal.Infrastructure.Utils.Native.DeviceHelper.DeviceId());
            Royal.Infrastructure.Contexts.Units.App.AppManager val_11 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RequestPackage> val_16 = Royal.Infrastructure.Services.Backend.Protocol.RequestPackage.CreateRequestPackage(builder:  this.requestBuilder, user_id:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name, user_tokenOffset:  new FlatBuffers.StringOffset() {Value = val_8.Value & 4294967295}, device_idOffset:  new FlatBuffers.StringOffset() {Value = val_10.Value & 4294967295}, sync_id:  125194832, sync_required:  this.<SyncRequired>k__BackingField, requests_typeOffset:  new FlatBuffers.VectorOffset() {Value = val_5.Value & 4294967295}, requestsOffset:  new FlatBuffers.VectorOffset() {Value = val_7.Value & 4294967295}, version:  val_11.versionHelper.currentVersion);
            this.requestBuilder.Finish(rootTable:  val_16.Value);
            return (System.Byte[])this.requestBuilder.SizedByteArray();
        }
        public void Finish(byte[] data)
        {
            object val_9;
            FlatBuffers.ByteBuffer val_10;
            System.Object[] val_11;
            string val_12;
            val_9 = this;
            FlatBuffers.ByteBuffer val_1 = null;
            val_10 = val_1;
            val_1 = new FlatBuffers.ByteBuffer(buffer:  data);
            Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage val_2 = Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage.GetRootAsResponsePackage(_bb:  val_1);
            if()
            {
                goto label_4;
            }
            
            if(32 == 1)
            {
                goto label_5;
            }
            
            System.ArgumentOutOfRangeException val_3 = null;
            val_9 = val_3;
            val_3 = new System.ArgumentOutOfRangeException();
            throw val_9;
            label_4:
            mem[1152921528638313352] = val_2.__p.bb_pos;
            mem[1152921528638313360] = val_2.__p.bb;
            if(val_2.__p.bb_pos == 0)
            {
                goto label_6;
            }
            
            if((UserId == null) || (val_2.__p.bb_pos == 0))
            {
                goto label_9;
            }
            
            val_11 = new object[2];
            val_11[0] = 1152921505160379072;
            val_10 = val_4.Length;
            val_11[1] = val_10;
            val_12 = "Received({0}): Ignoring response of previous user ({1}).";
            goto label_33;
            label_6:
            object[] val_5 = new object[1];
            val_11 = val_5;
            val_10 = 1152921505160379072;
            val_11[0] = val_10;
            val_12 = "Received({0}): Empty server response.";
            label_33:
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  val_3, logTag:  11, log:  val_12, values:  val_5);
            label_5:
            val_3.Fail(httpState:  2);
            return;
            label_9:
            if((val_10 == (Royal.Infrastructure.Contexts.Units.App.AppManager.<FocusCount>k__BackingField)) || ((Royal.Infrastructure.Contexts.Units.App.AppManager.<CurrentPausedTime>k__BackingField) <= 600f))
            {
                goto label_25;
            }
            
            object[] val_6 = new object[2];
            val_6[0] = 1152921505160379072;
            val_6[1] = val_6.Length;
            goto label_33;
            label_25:
            val_3.Success(serverTime:  null);
        }
        private void Success(long serverTime)
        {
            if((this.requestFocus == (Royal.Infrastructure.Contexts.Units.App.AppManager.<FocusCount>k__BackingField)) && ((Royal.Infrastructure.Contexts.Units.App.AppManager.<IsPaused>k__BackingField) != true))
            {
                    if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14).UpdateTime(serverTime:  serverTime)) == false)
            {
                goto label_8;
            }
            
            }
            
            this.<IsSuccess>k__BackingField = true;
            if( >= 1)
            {
                    var val_5 = 0;
                do
            {
                Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand val_3 = this.FindCommandByType(responseType:  this.<Response>k__BackingField);
                if(val_3 != null)
            {
                    1152921505146195968 = val_3;
                object[] val_4 = new object[2];
                val_4[0] = this.packageId;
                val_4[1] = 1152921505146195968;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  11, log:  "Received({0}): {1}", values:  val_4);
            }
            else
            {
                    this.SyncFail();
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 < );
            
            }
            
            if(this.OnComplete == null)
            {
                    return;
            }
            
            this.OnComplete.Invoke(isSuccess:  true, container:  this);
            return;
            label_8:
            this.Fail(httpState:  4);
        }
        private void SyncFail()
        {
            var val_6;
            bool val_6 = true;
            this.<IsSuccess>k__BackingField = false;
            val_6 = 0;
            label_12:
            if(val_6 >= val_6)
            {
                goto label_2;
            }
            
            if(val_6 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            object[] val_1 = new object[2];
            val_1[0] = this.packageId;
            val_1[1] = (true + 0) + 32;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  11, log:  "SyncFail({0}): {1}", values:  val_1);
            val_6 = val_6 + 1;
            if(this.commands != null)
            {
                goto label_12;
            }
            
            throw new NullReferenceException();
            label_2:
            if(this.OnComplete != null)
            {
                    this.OnComplete.Invoke(isSuccess:  false, container:  this);
            }
            
            bool val_5 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).TryUpdateDataFromBackend(serverSyncId:  -1738032320, serverUserProgress:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>() {HasValue = true}, oldUserId:  0, trigger:  0);
        }
        public void Fail(BestHTTP.HTTPRequestStates httpState = 2)
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand> val_2;
            bool val_2 = true;
            val_2 = this.commands;
            this.<IsSuccess>k__BackingField = false;
            var val_3 = 0;
            label_15:
            if(val_3 >= val_2)
            {
                goto label_2;
            }
            
            if(val_2 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            object[] val_1 = new object[3];
            val_1[0] = this.packageId;
            val_1[1] = (true + 0) + 32;
            val_1[2] = httpState;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  11, log:  "PackageFail({0}): {1} - {2}", values:  val_1);
            val_2 = this.commands;
            val_3 = val_3 + 1;
            if(val_2 != null)
            {
                goto label_15;
            }
            
            throw new NullReferenceException();
            label_2:
            if(this.OnComplete == null)
            {
                    return;
            }
            
            this.OnComplete.Invoke(isSuccess:  false, container:  this);
        }
        public Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand FindCommandByType(Royal.Infrastructure.Services.Backend.Protocol.ResponseType responseType)
        {
            var val_2;
            var val_3;
            val_2 = responseType;
            List.Enumerator<T> val_1 = this.commands.GetEnumerator();
            label_4:
            if(((-1737702600) & 1) == 0)
            {
                goto label_2;
            }
            
            val_3 = 0;
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(0 != val_2)
            {
                goto label_4;
            }
            
            goto label_5;
            label_2:
            val_3 = 0;
            label_5:
            0.Dispose();
            return (Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand)val_3;
        }
        public int Size()
        {
            return 8475;
        }
        public void Complete()
        {
            if(this.OnComplete == null)
            {
                    return;
            }
            
            this.OnComplete.Invoke(isSuccess:  true, container:  this);
        }
        public Commands()
        {
            this.requestBuilder = new FlatBuffers.FlatBufferBuilder(initialSize:  1024);
            this.requestTypes = new System.Collections.Generic.List<Royal.Infrastructure.Services.Backend.Protocol.RequestType>();
            this.commands = new System.Collections.Generic.List<Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand>();
        }
    
    }

}
