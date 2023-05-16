using UnityEngine;

namespace Royal.Player.Context.Data
{
    public class User
    {
        // Fields
        private Royal.Player.Context.Data.UserId <UserId>k__BackingField;
        private readonly Royal.Player.Context.Data.Persistent.BasicUserData <BasicData>k__BackingField;
        private readonly Royal.Player.Context.Data.Persistent.UserInventory <Inventory>k__BackingField;
        private readonly Royal.Player.Context.Data.Persistent.UserAreaData <AreaData>k__BackingField;
        private readonly Royal.Player.Context.Data.Persistent.UserLogData <LogData>k__BackingField;
        private readonly Royal.Player.Context.Data.Session.UserSessionData <SessionData>k__BackingField;
        private readonly Royal.Player.Context.Data.Persistent.AbTestData <AbTestData>k__BackingField;
        private bool <IsTemp>k__BackingField;
        
        // Properties
        public Royal.Player.Context.Data.UserId UserId { get; set; }
        public Royal.Player.Context.Data.Persistent.BasicUserData BasicData { get; }
        public Royal.Player.Context.Data.Persistent.UserInventory Inventory { get; }
        public Royal.Player.Context.Data.Persistent.UserAreaData AreaData { get; }
        public Royal.Player.Context.Data.Persistent.UserLogData LogData { get; }
        public Royal.Player.Context.Data.Session.UserSessionData SessionData { get; }
        public Royal.Player.Context.Data.Persistent.AbTestData AbTestData { get; }
        public bool IsTemp { get; set; }
        public bool HasToken { get; }
        public Royal.Player.Context.Units.UserSkill Skill { get; }
        public bool HasRoyalPass { get; }
        
        // Methods
        public Royal.Player.Context.Data.UserId get_UserId()
        {
            return (Royal.Player.Context.Data.UserId)this.<UserId>k__BackingField;
        }
        private void set_UserId(Royal.Player.Context.Data.UserId value)
        {
            this.<UserId>k__BackingField = value;
        }
        public Royal.Player.Context.Data.Persistent.BasicUserData get_BasicData()
        {
            return (Royal.Player.Context.Data.Persistent.BasicUserData)this.<BasicData>k__BackingField;
        }
        public Royal.Player.Context.Data.Persistent.UserInventory get_Inventory()
        {
            return (Royal.Player.Context.Data.Persistent.UserInventory)this.<Inventory>k__BackingField;
        }
        public Royal.Player.Context.Data.Persistent.UserAreaData get_AreaData()
        {
            return (Royal.Player.Context.Data.Persistent.UserAreaData)this.<AreaData>k__BackingField;
        }
        public Royal.Player.Context.Data.Persistent.UserLogData get_LogData()
        {
            return (Royal.Player.Context.Data.Persistent.UserLogData)this.<LogData>k__BackingField;
        }
        public Royal.Player.Context.Data.Session.UserSessionData get_SessionData()
        {
            return (Royal.Player.Context.Data.Session.UserSessionData)this.<SessionData>k__BackingField;
        }
        public Royal.Player.Context.Data.Persistent.AbTestData get_AbTestData()
        {
            return (Royal.Player.Context.Data.Persistent.AbTestData)this.<AbTestData>k__BackingField;
        }
        public bool get_IsTemp()
        {
            return (bool)this.<IsTemp>k__BackingField;
        }
        private void set_IsTemp(bool value)
        {
            this.<IsTemp>k__BackingField = value;
        }
        public bool get_HasToken()
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  this.<UserId>k__BackingField.token);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public Royal.Player.Context.Units.UserSkill get_Skill()
        {
            if((this.<Inventory>k__BackingField) != null)
            {
                    return this.<Inventory>k__BackingField.GetSkill();
            }
            
            throw new NullReferenceException();
        }
        public bool get_HasRoyalPass()
        {
            if((this.<Inventory>k__BackingField) != null)
            {
                    return (bool)((this.<Inventory>k__BackingField) != 0) ? 1 : 0;
            }
            
            throw new NullReferenceException();
        }
        public User(Royal.Player.Context.Data.UserId userId)
        {
            if(userId.id == 0)
            {
                    this.<IsTemp>k__BackingField = true;
            }
            
            this.<UserId>k__BackingField = userId;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetLong(key:  "UserId", value:  userId.id);
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetString(key:  "Token", value:  this.<UserId>k__BackingField.token);
            this.<BasicData>k__BackingField = new Royal.Player.Context.Data.Persistent.BasicUserData();
            this.<Inventory>k__BackingField = new Royal.Player.Context.Data.Persistent.UserInventory();
            this.<AreaData>k__BackingField = new Royal.Player.Context.Data.Persistent.UserAreaData();
            this.<AbTestData>k__BackingField = new Royal.Player.Context.Data.Persistent.AbTestData();
            this.<SessionData>k__BackingField = new Royal.Player.Context.Data.Session.UserSessionData();
        }
        public void UpdateUserId(long newId, string newToken)
        {
            this.<IsTemp>k__BackingField = (newId == 0) ? 1 : 0;
            .id = newId;
            .token = newToken;
            this.<UserId>k__BackingField = new Royal.Player.Context.Data.UserId();
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetLong(key:  "UserId", value:  (Royal.Player.Context.Data.UserId)[1152921524208411424].id);
            bool val_4 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetString(key:  "Token", value:  this.<UserId>k__BackingField.token);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).UpdateUserId();
            Royal.Scenes.Home.Context.HomeContext.Get<Royal.Infrastructure.Services.Helpshift.HelpshiftManager>(id:  1).UpdateUserId();
            Royal.Infrastructure.Services.Native.NativeService val_7 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            val_7.backupManager.UpdateUserId(force:  false);
        }
        public override string ToString()
        {
            return (string)this.<UserId>k__BackingField.id.ToString();
        }
        public bool IsConnectedFacebook()
        {
            if((this.<UserId>k__BackingField) != null)
            {
                    return (bool)((this.<UserId>k__BackingField.<FacebookId>k__BackingField) > 0) ? 1 : 0;
            }
            
            throw new NullReferenceException();
        }
        public bool IsConnectedApple()
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  this.<UserId>k__BackingField.<AppleId>k__BackingField);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public bool IsConnectedToAnyPlatform()
        {
            if((this.<UserId>k__BackingField) != null)
            {
                    if((this.<UserId>k__BackingField.<FacebookId>k__BackingField) <= 0)
            {
                    return this.IsConnectedApple();
            }
            
                return true;
            }
            
            throw new NullReferenceException();
        }
        public bool HasTeam()
        {
            if((this.<UserId>k__BackingField) != null)
            {
                    return (bool)((this.<UserId>k__BackingField.<Team>k__BackingField) > 0) ? 1 : 0;
            }
            
            throw new NullReferenceException();
        }
        public bool IsInLeague()
        {
            if((this.<BasicData>k__BackingField) != null)
            {
                    return (bool)((this.<BasicData>k__BackingField.<LeagueLevel>k__BackingField) > 0) ? 1 : 0;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
