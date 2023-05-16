using UnityEngine;

namespace Royal.Player.Context.Data.Persistent
{
    public class AbTestData
    {
        // Fields
        private const byte DynamicDifficultyNewUserStartIndex = 32;
        private const byte DynamicDifficultyNewUserEndIndex = 33;
        private const byte LadderOfferNewUserStartIndex = 34;
        private const byte LadderOfferNewUserEndIndex = 35;
        private const byte LadderOfferOldUserStartIndex = 36;
        private const byte LadderOfferOldUserEndIndex = 37;
        private const byte RoyalPassNewUserStartIndex = 38;
        private const byte RoyalPassNewUserEndIndex = 39;
        private const byte RoyalPassOldUserStartIndex = 40;
        private const byte RoyalPassOldUserEndIndex = 41;
        private const byte LadderOfferNewUser2StartIndex = 42;
        private const byte LadderOfferNewUser2EndIndex = 44;
        private const byte LadderOfferOldUser2StartIndex = 45;
        private const byte LadderOfferOldUser2EndIndex = 47;
        private const byte DynamicDifficultyNewUserUpdateIndex = 14;
        private const byte LadderOfferNewUserUpdateIndex = 15;
        private const byte LadderOfferOldUserUpdateIndex = 16;
        private const byte RoyalPassNewUserUpdateIndex = 17;
        private const byte RoyalPassOldUserUpdateIndex = 18;
        private const byte LadderOfferNewUser2UpdateIndex = 19;
        private const byte LadderOfferOldUser2UpdateIndex = 20;
        public long currentAbTestData;
        private int dynamicDifficultyNewUserGroupId;
        private int ladderOfferNewUserGroupId;
        private int ladderOfferOldUserGroupId;
        private int royalPassNewUserGroupId;
        private int royalPassOldUserGroupId;
        private int ladderOfferNewUser2GroupId;
        private int ladderOfferOldUser2GroupId;
        
        // Methods
        public AbTestData()
        {
            this.ladderOfferOldUser2GroupId = 0;
            this.ladderOfferOldUserGroupId = 0;
            this.royalPassNewUserGroupId = 0;
            this.royalPassOldUserGroupId = 0;
            this.ladderOfferNewUser2GroupId = 0;
            this.dynamicDifficultyNewUserGroupId = 0;
            this.ladderOfferNewUserGroupId = 0;
            this.Reset();
        }
        public void Reset()
        {
            long val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetLong(key:  "AbTestData", defaultValue:  0);
            this.currentAbTestData = val_1;
            this.CalculateAbTestGroups(userId:  0, abTestData:  val_1, abTestUpdateData:  0);
        }
        public void UpdateAbTestData(long userId, long newAbTestData, long newAbTestUpdateData, System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent> abTestContent)
        {
            if(this.currentAbTestData == newAbTestData)
            {
                    return;
            }
            
            this.currentAbTestData = newAbTestData;
            object[] val_1 = new object[1];
            val_1[0] = this.currentAbTestData;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  18, log:  "AbTestData updated to: {0}", values:  val_1);
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "AbTestData", value:  this.currentAbTestData);
            this.CalculateAbTestGroups(userId:  userId, abTestData:  this.currentAbTestData, abTestUpdateData:  newAbTestUpdateData);
        }
        private void CalculateAbTestGroups(long userId, long abTestData, long abTestUpdateData)
        {
            this.dynamicDifficultyNewUserGroupId = this.SetAndGetAbTestGroupId(userId:  userId, abTestData:  abTestData, abTestUpdateData:  abTestUpdateData, startIndex:  32, endIndex:  33, updateIndex:  14, eventName:  "Dynamic_difficulty1_new_user", timeOffset:  1);
            this.ladderOfferNewUserGroupId = this.SetAndGetAbTestGroupId(userId:  userId, abTestData:  abTestData, abTestUpdateData:  abTestUpdateData, startIndex:  34, endIndex:  35, updateIndex:  15, eventName:  "Ladder_offer_new_user", timeOffset:  2);
            this.ladderOfferOldUserGroupId = this.SetAndGetAbTestGroupId(userId:  userId, abTestData:  abTestData, abTestUpdateData:  abTestUpdateData, startIndex:  36, endIndex:  37, updateIndex:  16, eventName:  "Ladder_offer_old_user", timeOffset:  3);
            this.royalPassNewUserGroupId = this.SetAndGetAbTestGroupId(userId:  userId, abTestData:  abTestData, abTestUpdateData:  abTestUpdateData, startIndex:  38, endIndex:  39, updateIndex:  17, eventName:  "Royal_pass_new_user", timeOffset:  4);
            this.royalPassOldUserGroupId = this.SetAndGetAbTestGroupId(userId:  userId, abTestData:  abTestData, abTestUpdateData:  abTestUpdateData, startIndex:  40, endIndex:  41, updateIndex:  18, eventName:  "Royal_pass_old_user", timeOffset:  5);
            this.ladderOfferNewUser2GroupId = this.SetAndGetAbTestGroupId(userId:  userId, abTestData:  abTestData, abTestUpdateData:  abTestUpdateData, startIndex:  42, endIndex:  44, updateIndex:  19, eventName:  "Ladder_offer_new_user_2", timeOffset:  6);
            this.ladderOfferOldUser2GroupId = this.SetAndGetAbTestGroupId(userId:  userId, abTestData:  abTestData, abTestUpdateData:  abTestUpdateData, startIndex:  45, endIndex:  47, updateIndex:  20, eventName:  "Ladder_offer_old_user_2", timeOffset:  7);
        }
        private int SetAndGetAbTestGroupId(long userId, long abTestData, long abTestUpdateData, int startIndex, int endIndex, int updateIndex, string eventName, int timeOffset)
        {
            string val_7;
            System.Object[] val_8;
            int val_9;
            string val_10;
            int val_11;
            val_7 = eventName;
            val_8 = updateIndex;
            var val_7 = 1;
            int val_1 = val_7 - startIndex;
            var val_8 = 0;
            val_7 = val_7 << val_8;
            val_1 = val_1 + endIndex;
            val_8 = val_8 << val_1;
            long val_3 = (abTestData >> startIndex) & (~val_8);
            if((((long)val_7 & abTestUpdateData) == 0) && (val_3 >= 1))
            {
                    Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).AbTestEnter(name:  val_7, groupId:  val_3, timeOffset:  timeOffset);
                val_8 = new object[3];
                val_9 = val_5.Length;
                val_8[0] = userId;
                if(val_7 != null)
            {
                    val_9 = val_5.Length;
            }
            
                val_8[1] = val_7;
                val_7 = val_3;
                val_8[2] = val_7;
                val_10 = "User {0} enters {1} AbTest GroupId = {2}";
            }
            else
            {
                    if(userId < 1)
            {
                    return (int)val_3;
            }
            
                if(val_3 < 1)
            {
                    return (int)val_3;
            }
            
                object[] val_6 = new object[3];
                val_8 = val_6;
                val_11 = val_6.Length;
                val_8[0] = userId;
                if(val_7 != null)
            {
                    val_11 = val_6.Length;
            }
            
                val_8[1] = val_7;
                val_7 = val_3;
                val_8[2] = val_7;
                val_10 = "User {0} {1} AbTest  GroupId = {2}";
            }
            
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  18, log:  val_10, values:  val_6);
            return (int)val_3;
        }
        public static bool IsPiggyBankEnabled()
        {
            return false;
        }
        public bool IsDynamicDifficultyEnabled()
        {
            return (bool)(this.dynamicDifficultyNewUserGroupId == 2) ? 1 : 0;
        }
        public bool IsRoyalPassCheap()
        {
            if(this.royalPassNewUserGroupId != 1)
            {
                    return (bool)(this.royalPassOldUserGroupId == 1) ? 1 : 0;
            }
            
            return true;
        }
    
    }

}
