using UnityEngine;

namespace Royal.Player.Context.Units
{
    public class LifeHelper : IContextUnit
    {
        // Fields
        public const int StandardMaxPossibleLivesToHave = 5;
        public const int RoyalPassMaxPossibleLivesToHave = 8;
        public readonly long requiredTimeInMsToFillOneLife;
        private Royal.Infrastructure.Services.Backend.Http.TimeHelper timeHelper;
        
        // Properties
        public static int MaxPossibleLivesToHave { get; }
        public int Id { get; }
        
        // Methods
        public static int get_MaxPossibleLivesToHave()
        {
            return (int)(Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_typeDefinition == 0) ? 5 : 8;
        }
        public int get_Id()
        {
            return 3;
        }
        public void Bind()
        {
            this.timeHelper = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14);
        }
        public int GetLives()
        {
            var val_7 = Royal.Player.Context.Units.LifeHelper.MaxPossibleLivesToHave;
            long val_2 = this.timeHelper.CurrentServerTimeInMs();
            val_7 = val_7 - ((((((Royal.Player.Context.Data.Persistent.BasicUserData.__il2cppRuntimeField_byval_arg - val_2) / this.requiredTimeInMsToFillOneLife) + 1)) > val_7) ? (val_7) : ((((Royal.Player.Context.Data.Persistent.BasicUserData.__il2cppRuntimeField_byval_arg - val_2) / this.requiredTimeInMsToFillOneLife)) + 1));
            return (int)val_7;
        }
        public bool IsFull()
        {
            var val_5;
            if(this.HasUnlimitedLives() == false)
            {
                    return (bool)(this.GetLives() == Royal.Player.Context.Units.LifeHelper.MaxPossibleLivesToHave) ? 1 : 0;
            }
            
            val_5 = 1;
            return (bool)(this.GetLives() == Royal.Player.Context.Units.LifeHelper.MaxPossibleLivesToHave) ? 1 : 0;
        }
        public bool HasLives()
        {
            long val_1 = this.timeHelper.CurrentServerTimeInMs();
            var val_5 = (long)Royal.Player.Context.Units.LifeHelper.MaxPossibleLivesToHave - 1;
            val_5 = this.requiredTimeInMsToFillOneLife * val_5;
            return this.HasUnlimitedLives();
        }
        public void RefillLives()
        {
            UpdateFullLivesTimeInMs(newFullLivesTimeInMs:  this.timeHelper.CurrentServerTimeInMs());
        }
        public bool HasUnlimitedLives()
        {
            var val_3;
            if((this.timeHelper.<IsOfflineClientTimeTakenBack>k__BackingField) == false)
            {
                    return (bool)(this.timeHelper.CurrentServerTimeInMs() < typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_28) ? 1 : 0;
            }
            
            val_3 = 0;
            return (bool)(this.timeHelper.CurrentServerTimeInMs() < typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_28) ? 1 : 0;
        }
        public void IncrementLives()
        {
            SubstractTimeFromFullLivesTimeInMs(delta:  this.requiredTimeInMsToFillOneLife);
        }
        public void DecrementLives()
        {
            long val_7 = this;
            if(this.HasUnlimitedLives() == true)
            {
                    return;
            }
            
            if(this.HasLives() == false)
            {
                    return;
            }
            
            long val_3 = this.timeHelper.CurrentServerTimeInMs();
            typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_20 = ;
            UpdateFullLivesTimeInMs(newFullLivesTimeInMs:  null);
        }
        public int RemainingSecondsToNextLife()
        {
            long val_1 = this.timeHelper.CurrentServerTimeInMs();
            return System.Math.Max(val1:  0, val2:  (((Royal.Player.Context.Data.Persistent.BasicUserData.__il2cppRuntimeField_byval_arg - val_1) - (((Royal.Player.Context.Data.Persistent.BasicUserData.__il2cppRuntimeField_byval_arg - val_1) / this.requiredTimeInMsToFillOneLife) * this.requiredTimeInMsToFillOneLife)) >> 7) + (((Royal.Player.Context.Data.Persistent.BasicUserData.__il2cppRuntimeField_byval_arg - val_1) - (((Royal.Player.Context.Data.Persistent.BasicUserData.__il2cppRuntimeField_byval_arg - val_1) / this.requiredTimeInMsToFillOneLife) * this.requiredTimeInMsToFillOneLife)) >> 63));
        }
        public long PassedTimeMsForNextLife()
        {
            var val_3;
            int val_1 = this.RemainingSecondsToNextLife();
            if(val_1 >= 1)
            {
                    val_3 = this.requiredTimeInMsToFillOneLife - ((val_1 * 1000) << );
                return (long)val_3;
            }
            
            val_3 = 0;
            return (long)val_3;
        }
        public int RemainingSecondsToEndUnlimitedTimes()
        {
            long val_1 = this.timeHelper.CurrentServerTimeInMs();
            return System.Math.Max(val1:  0, val2:  (((typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_28 - val_1)) >> 38) + (((typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_28 - val_1)) >> 63));
        }
        public long RemainingMsToEndUnlimitedTimes()
        {
            long val_1 = this.timeHelper.CurrentServerTimeInMs();
            return System.Math.Max(val1:  0, val2:  (typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_28 - val_1));
        }
        public void AddUnlimitedLivesInMinutes(int deltaMinutes)
        {
            deltaMinutes = deltaMinutes * 60;
            this.AddUnlimitedLivesInSeconds(deltaSeconds:  deltaMinutes);
            int val_1 = GetPausedUnlimitedLivesTimeInMinutes();
            if(val_1 < 1)
            {
                    return;
            }
            
            UpdatePausedUnlimitedLivesTimeInMinutes(lifeTimeMinutes:  val_1 + deltaMinutes);
        }
        public void AddUnlimitedLivesInSeconds(int deltaSeconds)
        {
            if(deltaSeconds < 1)
            {
                    return;
            }
            
            this = System.Math.Max(val1:  typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_28, val2:  this.timeHelper.CurrentServerTimeInMs());
            System.TimeSpan val_3 = System.TimeSpan.FromSeconds(value:  (double)deltaSeconds);
            UpdateUnlimitedLivesEndTimeInMs(newUnlimitedLivesEndTimeInMs:  this + (long)(double)deltaSeconds);
        }
        public LifeHelper()
        {
            System.TimeSpan val_1 = System.TimeSpan.FromMinutes(value:  30);
            this.requiredTimeInMsToFillOneLife = 30;
        }
    
    }

}
