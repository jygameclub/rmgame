using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Tcp
{
    public class BackendTcpService : IContextBehaviour, IContextUnit
    {
        // Fields
        private static readonly string Host;
        private const int Port = 6525;
        private const int MaxByteSize = 1048576;
        private const int MessageLengthByteSize = 4;
        private System.Net.Sockets.TcpClient tcpClient;
        private System.Threading.Thread listener;
        private byte echo;
        private int lastEchoFrame;
        private int activeListenerThread;
        private bool authenticated;
        private readonly Royal.Infrastructure.Services.Backend.Tcp.Request.EchoTcpRequest echoTcpRequest;
        private bool <IsConnected>k__BackingField;
        private readonly System.Collections.Concurrent.ConcurrentQueue<FlatBuffers.IFlatbufferObject> incomingMessageQueue;
        private System.Action OnConnected;
        private System.Action<bool> OnDisconnected;
        private System.Action<Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse> OnAuthenticateResponseReceived;
        private System.Action<Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse> OnSendChatMessageResponseReceived;
        private System.Action<Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse> OnAskLifeResponseReceived;
        private System.Action<Royal.Infrastructure.Services.Backend.Protocol.HelpLifeResponse> OnHelpLifeResponseReceived;
        private System.Action<Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse> OnLifeChangeResponseReceived;
        private System.Action<Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse> OnPendingJoinTeamResponseReceived;
        private System.Action<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse> OnRoyalPassClaimResponseReceived;
        private System.Action<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse> OnRoyalPassDataResponseReceived;
        
        // Properties
        public bool IsConnected { get; set; }
        public int Id { get; }
        
        // Methods
        public bool get_IsConnected()
        {
            return (bool)this.<IsConnected>k__BackingField;
        }
        private void set_IsConnected(bool value)
        {
            this.<IsConnected>k__BackingField = value;
        }
        public void add_OnConnected(System.Action value)
        {
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  this.OnConnected, b:  value);
            }
            while(this.OnConnected != 1152921528363304216);
        
        }
        public void remove_OnConnected(System.Action value)
        {
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  this.OnConnected, value:  value);
            }
            while(this.OnConnected != 1152921528363440792);
        
        }
        public void add_OnDisconnected(System.Action<bool> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnDisconnected, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnDisconnected != 1152921528363577376);
            
            return;
            label_2:
        }
        public void remove_OnDisconnected(System.Action<bool> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnDisconnected, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnDisconnected != 1152921528363713952);
            
            return;
            label_2:
        }
        public void add_OnAuthenticateResponseReceived(System.Action<Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnAuthenticateResponseReceived, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnAuthenticateResponseReceived != 1152921528363850536);
            
            return;
            label_2:
        }
        public void remove_OnAuthenticateResponseReceived(System.Action<Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnAuthenticateResponseReceived, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnAuthenticateResponseReceived != 1152921528363987112);
            
            return;
            label_2:
        }
        public void add_OnSendChatMessageResponseReceived(System.Action<Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnSendChatMessageResponseReceived, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnSendChatMessageResponseReceived != 1152921528364123696);
            
            return;
            label_2:
        }
        public void remove_OnSendChatMessageResponseReceived(System.Action<Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnSendChatMessageResponseReceived, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnSendChatMessageResponseReceived != 1152921528364260272);
            
            return;
            label_2:
        }
        public void add_OnAskLifeResponseReceived(System.Action<Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnAskLifeResponseReceived, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnAskLifeResponseReceived != 1152921528364396856);
            
            return;
            label_2:
        }
        public void remove_OnAskLifeResponseReceived(System.Action<Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnAskLifeResponseReceived, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnAskLifeResponseReceived != 1152921528364533432);
            
            return;
            label_2:
        }
        public void add_OnHelpLifeResponseReceived(System.Action<Royal.Infrastructure.Services.Backend.Protocol.HelpLifeResponse> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnHelpLifeResponseReceived, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnHelpLifeResponseReceived != 1152921528364670016);
            
            return;
            label_2:
        }
        public void remove_OnHelpLifeResponseReceived(System.Action<Royal.Infrastructure.Services.Backend.Protocol.HelpLifeResponse> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnHelpLifeResponseReceived, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnHelpLifeResponseReceived != 1152921528364806592);
            
            return;
            label_2:
        }
        public void add_OnLifeChangeResponseReceived(System.Action<Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnLifeChangeResponseReceived, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnLifeChangeResponseReceived != 1152921528364943176);
            
            return;
            label_2:
        }
        public void remove_OnLifeChangeResponseReceived(System.Action<Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnLifeChangeResponseReceived, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnLifeChangeResponseReceived != 1152921528365079752);
            
            return;
            label_2:
        }
        public void add_OnPendingJoinTeamResponseReceived(System.Action<Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnPendingJoinTeamResponseReceived, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnPendingJoinTeamResponseReceived != 1152921528365216336);
            
            return;
            label_2:
        }
        public void remove_OnPendingJoinTeamResponseReceived(System.Action<Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnPendingJoinTeamResponseReceived, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnPendingJoinTeamResponseReceived != 1152921528365352912);
            
            return;
            label_2:
        }
        public void add_OnRoyalPassClaimResponseReceived(System.Action<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnRoyalPassClaimResponseReceived, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnRoyalPassClaimResponseReceived != 1152921528365489496);
            
            return;
            label_2:
        }
        public void remove_OnRoyalPassClaimResponseReceived(System.Action<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnRoyalPassClaimResponseReceived, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnRoyalPassClaimResponseReceived != 1152921528365626072);
            
            return;
            label_2:
        }
        public void add_OnRoyalPassDataResponseReceived(System.Action<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnRoyalPassDataResponseReceived, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnRoyalPassDataResponseReceived != 1152921528365762656);
            
            return;
            label_2:
        }
        public void remove_OnRoyalPassDataResponseReceived(System.Action<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnRoyalPassDataResponseReceived, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnRoyalPassDataResponseReceived != 1152921528365899232);
            
            return;
            label_2:
        }
        public int get_Id()
        {
            return 4;
        }
        public BackendTcpService()
        {
            this.echoTcpRequest = new Royal.Infrastructure.Services.Backend.Tcp.Request.EchoTcpRequest();
            this.incomingMessageQueue = new System.Collections.Concurrent.ConcurrentQueue<FlatBuffers.IFlatbufferObject>();
        }
        public void Bind()
        {
        
        }
        public void ManualUpdate()
        {
            FlatBuffers.IFlatbufferObject val_1 = 0;
            if((((this.incomingMessageQueue.TryDequeue(result: out  val_1)) == false) || ((this.<IsConnected>k__BackingField) == false)) || (val_1 == 0))
            {
                goto label_32;
            }
            
            if(1179403647 == null)
            {
                goto label_5;
            }
            
            if(1179403647 == null)
            {
                goto label_6;
            }
            
            if(1179403647 == null)
            {
                goto label_7;
            }
            
            if(1179403647 == null)
            {
                goto label_8;
            }
            
            if(1179403647 == null)
            {
                goto label_9;
            }
            
            if(1179403647 == null)
            {
                goto label_10;
            }
            
            if(1179403647 == null)
            {
                goto label_11;
            }
            
            if(1179403647 == null)
            {
                goto label_12;
            }
            
            if(1179403647 == null)
            {
                goto label_13;
            }
            
            if(1179403647 != null)
            {
                goto label_32;
            }
            
            val_1.System.IDisposable.Dispose();
            if(this.OnRoyalPassDataResponseReceived == null)
            {
                goto label_32;
            }
            
            this.OnRoyalPassDataResponseReceived.Invoke(obj:  new Royal.Infrastructure.Services.Backend.Protocol.RoyalPassDataResponse() {__p = new FlatBuffers.Table() {bb_pos = 1179403647}});
            goto label_32;
            label_5:
            val_1.System.IDisposable.Dispose();
            this.Authenticated(authMessage:  new Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse() {__p = new FlatBuffers.Table() {bb_pos = 1179403647}});
            goto label_32;
            label_6:
            val_1.System.IDisposable.Dispose();
            if(this.OnSendChatMessageResponseReceived == null)
            {
                goto label_32;
            }
            
            this.OnSendChatMessageResponseReceived.Invoke(obj:  new Royal.Infrastructure.Services.Backend.Protocol.SendChatMessageResponse() {__p = new FlatBuffers.Table() {bb_pos = 1179403647}});
            goto label_32;
            label_7:
            val_1.System.IDisposable.Dispose();
            if(this.OnAskLifeResponseReceived == null)
            {
                goto label_32;
            }
            
            this.OnAskLifeResponseReceived.Invoke(obj:  new Royal.Infrastructure.Services.Backend.Protocol.AskLifeResponse() {__p = new FlatBuffers.Table() {bb_pos = 1179403647}});
            goto label_32;
            label_8:
            val_1.System.IDisposable.Dispose();
            if(this.OnHelpLifeResponseReceived == null)
            {
                goto label_32;
            }
            
            this.OnHelpLifeResponseReceived.Invoke(obj:  new Royal.Infrastructure.Services.Backend.Protocol.HelpLifeResponse() {__p = new FlatBuffers.Table() {bb_pos = 1179403647}});
            goto label_32;
            label_9:
            val_1.System.IDisposable.Dispose();
            if(this.OnLifeChangeResponseReceived == null)
            {
                goto label_32;
            }
            
            this.OnLifeChangeResponseReceived.Invoke(obj:  new Royal.Infrastructure.Services.Backend.Protocol.LifeChangeResponse() {__p = new FlatBuffers.Table() {bb_pos = 1179403647}});
            goto label_32;
            label_10:
            val_1.System.IDisposable.Dispose();
            if(this.OnPendingJoinTeamResponseReceived != null)
            {
                    this.OnPendingJoinTeamResponseReceived.Invoke(obj:  new Royal.Infrastructure.Services.Backend.Protocol.PendingJoinTeamResponse() {__p = new FlatBuffers.Table() {bb_pos = 1179403647}});
            }
            
            label_32:
            this.CheckConnection();
            if(this.authenticated == false)
            {
                    return;
            }
            
            int val_5 = this.lastEchoFrame;
            val_5 = UnityEngine.Time.frameCount - val_5;
            if(val_5 < 61)
            {
                    return;
            }
            
            byte val_6 = this.echo;
            val_6 = val_6 + 1;
            this.echo = val_6;
            this.lastEchoFrame = UnityEngine.Time.frameCount;
            this.SendMessage(baseTcpRequest:  this.echoTcpRequest);
            return;
            label_11:
            val_1.System.IDisposable.Dispose();
            this.Disconnect(otherDevice:  true);
            return;
            label_12:
            val_1.System.IDisposable.Dispose();
            byte val_7 = this.echo;
            val_7 = val_7 - 1;
            this.echo = val_7;
            return;
            label_13:
            val_1.System.IDisposable.Dispose();
            if(this.OnRoyalPassClaimResponseReceived == null)
            {
                goto label_32;
            }
            
            this.OnRoyalPassClaimResponseReceived.Invoke(obj:  new Royal.Infrastructure.Services.Backend.Protocol.RoyalPassClaimResponse() {__p = new FlatBuffers.Table() {bb_pos = 1179403647}});
            goto label_32;
        }
        private void Authenticated(Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse authMessage)
        {
            this.authenticated = true;
            this.lastEchoFrame = UnityEngine.Time.frameCount;
            if(this.OnAuthenticateResponseReceived == null)
            {
                    return;
            }
            
            this.OnAuthenticateResponseReceived.Invoke(obj:  new Royal.Infrastructure.Services.Backend.Protocol.AuthenticateResponse() {__p = new FlatBuffers.Table() {bb_pos = authMessage.__p.bb_pos, bb = authMessage.__p.bb}});
        }
        public void Connect()
        {
            if(this.tcpClient != null)
            {
                    if(this.tcpClient.Connected == true)
            {
                    return;
            }
            
            }
            
            System.Threading.Thread val_3 = new System.Threading.Thread(start:  new System.Threading.ThreadStart(object:  this, method:  System.Void Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService::ListenSocket()));
            val_3.Name = "TcpListener";
            val_3.IsBackground = true;
            this.listener = val_3;
            val_3.Start();
        }
        public void Disconnect(bool otherDevice = False)
        {
            if(this.tcpClient != null)
            {
                    this.tcpClient.Close();
                this.<IsConnected>k__BackingField = false;
                this.authenticated = false;
                if(this.OnDisconnected != null)
            {
                    this.OnDisconnected.Invoke(obj:  otherDevice);
            }
            
                this.tcpClient.Dispose();
                this.tcpClient = 0;
                return;
            }
            
            if(this.OnDisconnected == null)
            {
                    return;
            }
            
            otherDevice = otherDevice;
            this.OnDisconnected.Invoke(obj:  otherDevice);
        }
        private void ListenSocket()
        {
            System.Net.Sockets.TcpClient val_27;
            var val_28;
            System.Net.Sockets.LingerOption val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            System.Threading.Thread val_1 = System.Threading.Thread.CurrentThread;
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            mem[1152921528375442488] = val_1.ManagedThreadId;
            val_28 = null;
            val_28 = null;
            System.Net.Sockets.TcpClient val_3 = new System.Net.Sockets.TcpClient(hostname:  Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService.MessageLengthByteSize, port:  125);
            System.Net.Sockets.LingerOption val_4 = null;
            val_29 = val_4;
            val_4 = new System.Net.Sockets.LingerOption(enable:  true, seconds:  0);
            if(val_3 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_3.LingerState = val_4;
            val_3.NoDelay = true;
            mem[1152921528375442464] = val_3;
            System.Threading.Thread val_5 = System.Threading.Thread.CurrentThread;
            if(val_5 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(mem[1152921528375442488] != val_5.ManagedThreadId)
            {
                goto label_6;
            }
            
            byte[] val_7 = new byte[1048576];
            if(mem[1152921528375442464] == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_30 = 1152921504781234176;
            label_49:
            if(val_3.Connected == false)
            {
                    return;
            }
            
            val_27 = mem[1152921528375442464];
            if(val_27 == 0)
            {
                    throw new NullReferenceException();
            }
            
            System.Net.Sockets.NetworkStream val_9 = val_3.GetStream();
            if(val_9 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_31 = 0;
            goto label_13;
            label_40:
            System.Array.Clear(array:  val_7, index:  0, length:  val_7.Length);
            val_31 = 0;
            goto label_13;
            label_39:
            if(val_31 < 4)
            {
                goto label_13;
            }
            
            if((0 & 1) == 0)
            {
                    byte[] val_10 = new byte[4];
                if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
                if(val_7.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
                if(val_10 == null)
            {
                    throw new NullReferenceException();
            }
            
                if(val_10.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
                val_10[0] = val_7[0];
                if(val_7.Length <= 1)
            {
                    throw new IndexOutOfRangeException();
            }
            
                if(val_10.Length <= 1)
            {
                    throw new IndexOutOfRangeException();
            }
            
                val_10[0] = val_7[0];
                if(val_7.Length <= 2)
            {
                    throw new IndexOutOfRangeException();
            }
            
                if(val_10.Length <= 2)
            {
                    throw new IndexOutOfRangeException();
            }
            
                val_10[0] = val_7[0];
                if(val_7.Length <= 3)
            {
                    throw new IndexOutOfRangeException();
            }
            
                if(val_10.Length <= 3)
            {
                    throw new IndexOutOfRangeException();
            }
            
                val_10[0] = val_7[0];
                val_32 = null;
                val_32 = null;
                if(System.BitConverter.IsLittleEndian != false)
            {
                    System.Array.Reverse(array:  val_10);
                val_32 = null;
            }
            
                int val_12 = (System.BitConverter.ToInt32(value:  val_10, startIndex:  0)) + 4;
            }
            
            int val_13 = val_31 - val_12;
            if(val_10.Length < 3)
            {
                goto label_30;
            }
            
            byte[] val_15 = new byte[0];
            System.Array.Copy(sourceArray:  val_7, sourceIndex:  4, destinationArray:  val_15, destinationIndex:  0, length:  val_12 - 4);
            FlatBuffers.IFlatbufferObject val_16 = val_7.ConvertBytesToTcpMessage(bytes:  val_15);
            if(val_16 != null)
            {
                    if(mem[1152921528375442512] == 0)
            {
                    throw new NullReferenceException();
            }
            
                mem[1152921528375442512].Enqueue(item:  val_16);
            }
            
            if(val_13 >= 1)
            {
                    byte[] val_17 = new byte[0];
                System.Array.Copy(sourceArray:  val_7, sourceIndex:  val_12, destinationArray:  val_17, destinationIndex:  0, length:  val_13);
                System.Array.Clear(array:  val_7, index:  0, length:  0);
                System.Array.Copy(sourceArray:  val_17, sourceIndex:  0, destinationArray:  val_7, destinationIndex:  0, length:  val_13);
            }
            else
            {
                    System.Array.Clear(array:  val_7, index:  0, length:  0);
            }
            
            int val_18 = UnityEngine.Mathf.Max(a:  0, b:  val_13);
            goto label_39;
            label_30:
            label_13:
            var val_19 = 1048576 - val_31;
            if(val_9 == null)
            {
                goto label_38;
            }
            
            if(null < 1048576)
            {
                goto label_39;
            }
            
            if(val_7 != null)
            {
                goto label_40;
            }
            
            throw new NullReferenceException();
            label_38:
            var val_32 = 0;
            val_33 = 0;
            val_32 = val_32 + 1;
            -2001220464 = 450;
            var val_34 = 0;
            if(mem[1152921504754167808] != null)
            {
                    val_34 = val_34 + 1;
            }
            else
            {
                    System.Net.Sockets.NetworkStream val_20 = 1152921504754130944 + ((mem[1152921504754167816]) << 4);
            }
            
            val_9.Dispose();
            if(val_33 != 0)
            {
                goto label_46;
            }
            
            if((val_32 != 1) && ((-2001220464 + ((0 + 1)) << 2) == 450))
            {
                    var val_35 = 0;
                val_35 = val_35 ^ (val_32 >> 31);
                val_32 = val_32 + val_35;
            }
            
            if(mem[1152921528375442464] != 0)
            {
                goto label_49;
            }
            
            throw new NullReferenceException();
            label_6:
            object[] val_21 = new object[2];
            System.Threading.Thread val_22 = System.Threading.Thread.CurrentThread;
            if(val_22 == null)
            {
                    throw new NullReferenceException();
            }
            
            int val_23 = val_22.ManagedThreadId;
            val_30 = 1152921504619413504;
            if(val_21 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_23 != 0)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            if(val_21.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_21[0] = val_23;
            val_29 = mem[1152921528375442488];
            val_21[1] = val_29;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Another thread is trying to connect: {0}/{1}", values:  val_21);
            return;
            label_46:
            val_27 = X22;
            throw val_27;
        }
        private void CheckConnection()
        {
            if((this.<IsConnected>k__BackingField) != false)
            {
                    if(this.tcpClient != null)
            {
                    if(this.tcpClient.Connected != false)
            {
                    if(this.echo < 4)
            {
                    return;
            }
            
                object[] val_2 = new object[1];
                val_2[0] = this.echo;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  20, log:  "No echo response for {0} times", values:  val_2);
                this.echo = 0;
                this.Disconnect(otherDevice:  false);
                return;
            }
            
            }
            
                this.<IsConnected>k__BackingField = false;
                this.authenticated = false;
                if(this.OnDisconnected == null)
            {
                    return;
            }
            
                this.OnDisconnected.Invoke(obj:  false);
                return;
            }
            
            if(this.tcpClient == null)
            {
                    return;
            }
            
            if(this.tcpClient.Connected == false)
            {
                    return;
            }
            
            if(this.OnConnected != null)
            {
                    this.OnConnected.Invoke();
            }
            
            this.<IsConnected>k__BackingField = true;
        }
        public void SendMessage(Royal.Infrastructure.Services.Backend.Tcp.Request.BaseTcpRequest baseTcpRequest)
        {
            var val_6;
            System.Byte[] val_8;
            var val_9;
            var val_10;
            if(this.tcpClient == null)
            {
                goto label_2;
            }
            
            val_6 = 0;
            if(this.tcpClient.Connected == false)
            {
                goto label_2;
            }
            
            if(this.tcpClient == null)
            {
                    throw new NullReferenceException();
            }
            
            val_8 = baseTcpRequest.Build();
            val_6 = 0;
            System.Net.Sockets.NetworkStream val_3 = this.tcpClient.GetStream();
            if(val_3 == null)
            {
                    throw new NullReferenceException();
            }
            
            if((val_3 & 1) == 0)
            {
                goto label_6;
            }
            
            val_6 = Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService.WrapMessageWithLength(message:  val_8);
            if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
            return;
            label_2:
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  20, log:  "Not connected.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            return;
            label_6:
            val_8 = public static T[] System.Array::Empty<System.Object>();
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  20, log:  "Couldn\'t write stream.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private static byte[] WrapMessageWithLength(byte[] message)
        {
            System.Byte[] val_1 = System.BitConverter.GetBytes(value:  message.Length);
            if(System.BitConverter.IsLittleEndian != false)
            {
                    System.Array.Reverse(array:  val_1);
            }
            
            int val_2 = message.Length + 4;
            byte[] val_3 = new byte[0];
            val_1.CopyTo(array:  val_3, index:  0);
            message.CopyTo(array:  val_3, index:  val_1.Length);
            return (System.Byte[])val_3;
        }
        private FlatBuffers.IFlatbufferObject ConvertBytesToTcpMessage(byte[] bytes)
        {
            var val_4;
            Royal.Infrastructure.Services.Backend.Protocol.TcpResponsePackage val_2 = Royal.Infrastructure.Services.Backend.Protocol.TcpResponsePackage.GetRootAsTcpResponsePackage(_bb:  new FlatBuffers.ByteBuffer(buffer:  bytes));
            if(191 <= 10)
            {
                    return (FlatBuffers.IFlatbufferObject)val_4;
            }
            
            throw new System.ArgumentOutOfRangeException();
        }
        private static BackendTcpService()
        {
            Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService.MessageLengthByteSize = "prod-social-server.royal.drmgms.com";
            Royal.Infrastructure.Services.Backend.Tcp.BackendTcpService.MessageLengthByteSize.__il2cppRuntimeField_3 = 268435461;
        }
    
    }

}
