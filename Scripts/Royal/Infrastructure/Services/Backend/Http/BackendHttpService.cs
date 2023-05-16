using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http
{
    public class BackendHttpService : IContextBehaviour, IContextUnit
    {
        // Fields
        private const float CommandSendPeriod = 1;
        private static readonly System.Uri BackendUri;
        public static System.Uri BackendPurchaseUri;
        private readonly System.Collections.Generic.LinkedList<Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler> requestList;
        private Royal.Infrastructure.Services.Backend.Http.TimeHelper timeHelper;
        private float lastTimeoutChecked;
        private float lastCommandSendTime;
        private Royal.Infrastructure.Services.Backend.Http.Command.Commands commands;
        private bool isInMaintenance;
        private BestHTTP.HTTPRequest maintenanceRequest;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 7;
        }
        public BackendHttpService()
        {
            var val_4;
            this.requestList = new System.Collections.Generic.LinkedList<Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler>();
            .<Level>k__BackingField = 4;
            val_4 = null;
            val_4 = null;
            BestHTTP.HTTPManager.logger = new Royal.Infrastructure.Utils.Network.HttpLogger();
            this.commands = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
        }
        public void Bind()
        {
            this.timeHelper = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14);
        }
        public bool Send(Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand httpCommand, Royal.Infrastructure.Services.Backend.Http.Command.Commands.ConnectionComplete onComplete, bool syncRequired = False)
        {
            ConnectionComplete val_8;
            var val_9;
            var val_10;
            val_8 = onComplete;
            if(syncRequired == false)
            {
                goto label_1;
            }
            
            if(((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<IsTemp>k__BackingField) == true) || ((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasToken) == false))
            {
                goto label_5;
            }
            
            if((this.timeHelper.<IsTimeValidatedByBackend>k__BackingField) == false)
            {
                goto label_7;
            }
            
            this.commands = 1;
            label_1:
            if(val_8 != null)
            {
                    this.commands.add_OnComplete(value:  val_8);
            }
            
            this.commands.Add(httpCommand:  httpCommand);
            val_9 = 1;
            return (bool)val_9;
            label_5:
            val_8 = 1152921505020530688;
            val_10 = null;
            val_10 = null;
            if(Royal.Scenes.Start.Context.ApplicationContext.controller.IsTryingRegister() != true)
            {
                    object[] val_3 = new object[1];
                val_8 = val_3;
                val_8[0] = httpCommand;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  8, log:  "User is not registered, {0} will not be sent.", values:  val_3);
                bool val_5 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).RegisterIfNeeded();
            }
            
            label_33:
            val_9 = 0;
            return (bool)val_9;
            label_7:
            object[] val_6 = new object[1];
            val_6[0] = httpCommand;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  8, log:  "Time is not valid, ping will be sent instead of {0}", values:  val_6);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14).SendPing();
            goto label_33;
        }
        public void SendImmediately(Royal.Infrastructure.Services.Backend.Http.Command.Commands commandsToSend, float timeOut = 10)
        {
            null = null;
            Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler val_1 = new Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler();
            .endPoint = Royal.Infrastructure.Services.Backend.Http.BackendHttpService.BackendUri;
            .commands = commandsToSend;
            .timeOut = timeOut;
            val_1.Send();
            val_1.add_OnRequestCompleted(value:  new System.Action<Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler>(object:  this, method:  System.Void Royal.Infrastructure.Services.Backend.Http.BackendHttpService::RemoveHandler(Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler handler)));
            System.Collections.Generic.LinkedListNode<T> val_3 = this.requestList.AddLast(value:  val_1);
        }
        public void SendToPurchaseServer(Royal.Infrastructure.Services.Backend.Http.Command.Commands commandsToSend)
        {
            null = null;
            Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler val_1 = new Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler();
            .endPoint = Royal.Infrastructure.Services.Backend.Http.BackendHttpService.BackendPurchaseUri;
            .commands = commandsToSend;
            .timeOut = 10f;
            val_1.Send();
            val_1.add_OnRequestCompleted(value:  new System.Action<Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler>(object:  this, method:  System.Void Royal.Infrastructure.Services.Backend.Http.BackendHttpService::RemoveHandler(Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler handler)));
            System.Collections.Generic.LinkedListNode<T> val_3 = this.requestList.AddLast(value:  val_1);
        }
        private void RemoveHandler(Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler handler)
        {
            bool val_1 = this.requestList.Remove(value:  handler);
        }
        public void ManualUpdate()
        {
            var val_10;
            float val_1 = UnityEngine.Time.time;
            val_1 = val_1 - this.lastTimeoutChecked;
            if(val_1 >= 0.5f)
            {
                    this.lastTimeoutChecked = UnityEngine.Time.time;
                this.CheckForTimeout();
            }
            
            if(this.commands.Size() == 0)
            {
                    return;
            }
            
            float val_4 = UnityEngine.Time.time;
            val_4 = val_4 - this.lastCommandSendTime;
            if(val_4 < 0)
            {
                    return;
            }
            
            this.lastCommandSendTime = UnityEngine.Time.time;
            val_10 = null;
            val_10 = null;
            Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler val_6 = new Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler();
            .endPoint = Royal.Infrastructure.Services.Backend.Http.BackendHttpService.BackendUri;
            .commands = this.commands;
            .timeOut = 10f;
            val_6.Send();
            val_6.add_OnRequestCompleted(value:  new System.Action<Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler>(object:  this, method:  System.Void Royal.Infrastructure.Services.Backend.Http.BackendHttpService::RemoveHandler(Royal.Infrastructure.Services.Backend.Http.Command.CommandsRequestHandler handler)));
            System.Collections.Generic.LinkedListNode<T> val_8 = this.requestList.AddLast(value:  val_6);
            this.commands = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
        }
        private void CheckForTimeout()
        {
            var val_4;
            var val_5;
            val_4 = this;
            if(W9 == 0)
            {
                    return;
            }
            
            val_5 = 0;
            goto label_5;
            label_6:
            val_4 = this.Next;
            if(this.commands.IsTimeOut() != false)
            {
                    this.commands.Cancel();
                val_5 = 1;
            }
            
            label_5:
            if(val_4 != null)
            {
                goto label_6;
            }
            
            if((val_5 & 1) == 0)
            {
                    return;
            }
            
            if(UnityEngine.Application.internetReachability == 0)
            {
                    return;
            }
            
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  "command_timeout");
        }
        public bool IsInMaintenance(bool checkAgain = True)
        {
            System.Uri val_10;
            BestHTTP.HTTPRequest val_11;
            if(checkAgain == false)
            {
                    return (bool)this.isInMaintenance;
            }
            
            val_11 = this.maintenanceRequest;
            if(val_11 == null)
            {
                    Firebase.AppOptions val_2 = Firebase.FirebaseApp.DefaultInstance.Options;
                System.Uri val_4 = null;
                val_10 = val_4;
                val_4 = new System.Uri(uriString:  "https://us-central1-"("https://us-central1-") + val_2.<ProjectId>k__BackingField(val_2.<ProjectId>k__BackingField) + ".cloudfunctions.net/backendMaintenanceMode"(".cloudfunctions.net/backendMaintenanceMode"));
                BestHTTP.HTTPRequest val_6 = null;
                val_11 = val_6;
                val_6 = new BestHTTP.HTTPRequest(uri:  val_4, callback:  new BestHTTP.OnRequestFinishedDelegate(object:  this, method:  System.Void Royal.Infrastructure.Services.Backend.Http.BackendHttpService::<IsInMaintenance>b__20_0(BestHTTP.HTTPRequest request, BestHTTP.HTTPResponse response)));
                val_6.DisableCache = true;
                System.TimeSpan val_7 = System.TimeSpan.FromSeconds(value:  5);
                .<Timeout>k__BackingField = val_7;
                System.TimeSpan val_8 = System.TimeSpan.FromSeconds(value:  2);
                .<ConnectTimeout>k__BackingField = val_8;
                this.maintenanceRequest = val_11;
            }
            
            BestHTTP.HTTPRequest val_9 = val_6.Send();
            return (bool)this.isInMaintenance;
        }
        private static BackendHttpService()
        {
            Royal.Infrastructure.Services.Backend.Http.BackendHttpService.BackendUri = new System.UriBuilder(uri:  "http://prod-server.royal.drmgms.com/api").Uri;
            Royal.Infrastructure.Services.Backend.Http.BackendHttpService.BackendPurchaseUri = new System.UriBuilder(uri:  "http://prod-purchase-server.royal.drmgms.com/api").Uri;
        }
        private void <IsInMaintenance>b__20_0(BestHTTP.HTTPRequest request, BestHTTP.HTTPResponse response)
        {
            System.Object[] val_8;
            object val_9;
            string val_10;
            if((request.State == 2) && (response.IsSuccess != false))
            {
                    this.isInMaintenance = System.String.op_Equality(a:  response.DataAsText, b:  "true");
                val_8 = new object[1];
                val_9 = this.isInMaintenance;
                val_8[0] = val_9;
                val_10 = "Server maintenance mode = {0}";
            }
            else
            {
                    this.isInMaintenance = false;
                object[] val_7 = new object[1];
                val_8 = val_7;
                val_9 = this.isInMaintenance;
                val_8[0] = val_9;
                val_10 = "Default maintenance mode = {0}";
            }
            
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  11, log:  val_10, values:  val_7);
        }
    
    }

}
