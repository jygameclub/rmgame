using UnityEngine;

namespace Royal.Player.Context.Units
{
    public class LeaderboardManager : IContextUnit
    {
        // Fields
        private System.Action OnLeaderboardUpdated;
        public string localName;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 6;
        }
        public void add_OnLeaderboardUpdated(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnLeaderboardUpdated, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnLeaderboardUpdated != 1152921524150965216);
            
            return;
            label_2:
        }
        public void remove_OnLeaderboardUpdated(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnLeaderboardUpdated, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnLeaderboardUpdated != 1152921524151101792);
            
            return;
            label_2:
        }
        public void Bind()
        {
            this.FillFromLocal();
        }
        public void FillFromLocal()
        {
            string val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetString(key:  "LocalName", defaultValue:  0);
            this.localName = val_1;
            if((System.String.IsNullOrEmpty(value:  val_1)) == false)
            {
                    return;
            }
            
            this.ParseLocalName(name:  this.localName);
        }
        private void ParseLocalName(string name)
        {
            if(((System.String.IsNullOrEmpty(value:  name)) == true) || ((System.String.op_Equality(a:  name.ToLower(), b:  "local")) == true))
            {
                goto label_5;
            }
            
            if(name.m_stringLength == 5)
            {
                goto label_4;
            }
            
            if(name.m_stringLength != 2)
            {
                goto label_5;
            }
            
            string val_4 = Royal.Player.Context.Units.LeaderboardManager.ExtractCountry(name:  name);
            goto label_7;
            label_5:
            string val_5 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            label_7:
            this.localName = val_5;
            bool val_6 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetString(key:  "LocalName", value:  val_5);
            return;
            label_4:
            string val_7 = Royal.Player.Context.Units.LeaderboardManager.ExtractState(name:  name);
            goto label_7;
        }
        public void UpdateFacebookFriends(long[] friendsFacebookIds)
        {
            System.Collections.Generic.IEnumerable<TSource> val_5;
            System.Func<TSource, System.Boolean> val_6;
            var val_7;
            if(friendsFacebookIds.Length < 1)
            {
                goto label_2;
            }
            
            val_5 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetLeaderboard(type:  1);
            var val_5 = 0;
            label_14:
            .fbId = null;
            if(null == null)
            {
                goto label_5;
            }
            
            System.Func<Royal.Infrastructure.Services.Storage.Tables.Leader, System.Boolean> val_3 = null;
            val_6 = val_3;
            val_3 = new System.Func<Royal.Infrastructure.Services.Storage.Tables.Leader, System.Boolean>(object:  new LeaderboardManager.<>c__DisplayClass9_0(), method:  System.Boolean LeaderboardManager.<>c__DisplayClass9_0::<UpdateFacebookFriends>b__0(Royal.Infrastructure.Services.Storage.Tables.Leader friend));
            if((System.Linq.Enumerable.All<Royal.Infrastructure.Services.Storage.Tables.Leader>(source:  val_5, predicate:  val_3)) == false)
            {
                goto label_7;
            }
            
            Royal.Player.Context.Units.LeaderboardManager.CreateFacebookFriend(fbId:  (LeaderboardManager.<>c__DisplayClass9_0)[1152921524151747968].fbId);
            goto label_7;
            label_5:
            val_6 = public static T[] System.Array::Empty<System.Object>();
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  14, log:  "User with 0 Facebook Id.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            label_7:
            val_5 = val_5 + 1;
            if(val_5 < friendsFacebookIds.Length)
            {
                goto label_14;
            }
            
            label_2:
            if(this.OnLeaderboardUpdated == null)
            {
                    return;
            }
            
            this.OnLeaderboardUpdated.Invoke();
        }
        public void UpdateData(Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse response)
        {
            this.ParseLocalName(name:  response.__p.bb_pos);
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ClearLeaderboard(type:  1);
            if((-1929848096) >= 1)
            {
                    var val_6 = 0;
                do
            {
                Royal.Player.Context.Units.LeaderboardManager.UpdateFriend(member:  new Royal.Infrastructure.Services.Backend.Protocol.FriendScore() {__p = new FlatBuffers.Table() {bb_pos = -1929848128, bb = public Royal.Infrastructure.Services.Backend.Protocol.FriendScore System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.FriendScore>::get_Value()}});
                val_6 = val_6 + 1;
            }
            while(val_6 < (-1929848096));
            
            }
            
            bool val_4 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ClearLeaderboard(type:  3);
            if((-1929848096) >= 1)
            {
                    var val_7 = 0;
                do
            {
                Royal.Player.Context.Units.LeaderboardManager.UpdateLocalPlayer(tableType:  3, member:  new Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo() {__p = new FlatBuffers.Table() {bb_pos = -1929848160, bb = public Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo>::get_Value()}});
                val_7 = val_7 + 1;
            }
            while(val_7 < (-1929848096));
            
            }
            
            bool val_5 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ClearLeaderboard(type:  5);
            if((-1929848096) >= 1)
            {
                    var val_8 = 0;
                do
            {
                Royal.Player.Context.Units.LeaderboardManager.UpdateLocalTeam(tableType:  5, member:  new Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo() {__p = new FlatBuffers.Table() {bb_pos = -1929848192, bb = public Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo>::get_Value()}});
                val_8 = val_8 + 1;
            }
            while(val_8 < (-1929848096));
            
            }
            
            if(this.OnLeaderboardUpdated == null)
            {
                    return;
            }
            
            this.OnLeaderboardUpdated.Invoke();
        }
        public void UpdateData(Royal.Infrastructure.Services.Backend.Protocol.LeaderboardResponse response)
        {
            var val_9 = this;
            this.ParseLocalName(name:  response.__p.bb_pos);
            if((-1929731984) >= 1)
            {
                    bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ClearLeaderboard(type:  1);
                if((-1929731984) >= 1)
            {
                    do
            {
                Royal.Player.Context.Units.LeaderboardManager.UpdateFriend(member:  new Royal.Infrastructure.Services.Backend.Protocol.FriendScore() {__p = new FlatBuffers.Table() {bb_pos = -1929732016, bb = public Royal.Infrastructure.Services.Backend.Protocol.FriendScore System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.FriendScore>::get_Value()}});
                val_9 = 0 + 1;
            }
            while(val_9 < (-1929731984));
            
            }
            
            }
            
            if((-1929731984) >= 1)
            {
                    bool val_4 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ClearLeaderboard(type:  3);
                if((-1929731984) >= 1)
            {
                    do
            {
                Royal.Player.Context.Units.LeaderboardManager.UpdateLocalPlayer(tableType:  3, member:  new Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo() {__p = new FlatBuffers.Table() {bb_pos = -1929732048, bb = public Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo>::get_Value()}});
                val_9 = 0 + 1;
            }
            while(val_9 < (-1929731984));
            
            }
            
            }
            
            if((-1929731984) >= 1)
            {
                    bool val_5 = Royal.Infrastructure.Services.Storage.Tables.AppLeaderboard.ClearLeaderboard(type:  4);
                if((-1929731984) >= 1)
            {
                    do
            {
                Royal.Player.Context.Units.LeaderboardManager.UpdateWorldPlayer(tableType:  4, member:  new Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo() {__p = new FlatBuffers.Table() {bb_pos = -1929732048, bb = public Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo>::get_Value()}});
                val_9 = 0 + 1;
            }
            while(val_9 < (-1929731984));
            
            }
            
            }
            
            if((-1929731984) >= 1)
            {
                    bool val_6 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ClearLeaderboard(type:  5);
                if((-1929731984) >= 1)
            {
                    do
            {
                Royal.Player.Context.Units.LeaderboardManager.UpdateLocalTeam(tableType:  5, member:  new Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo() {__p = new FlatBuffers.Table() {bb_pos = -1929732080, bb = public Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo>::get_Value()}});
                val_9 = 0 + 1;
            }
            while(val_9 < (-1929731984));
            
            }
            
            }
            
            if((-1929731984) < 1)
            {
                    return;
            }
            
            bool val_7 = Royal.Infrastructure.Services.Storage.Tables.AppLeaderboard.ClearLeaderboard(type:  6);
            if((-1929731984) < 1)
            {
                    return;
            }
            
            do
            {
                Royal.Player.Context.Units.LeaderboardManager.UpdateWorldTeam(tableType:  6, member:  new Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo() {__p = new FlatBuffers.Table() {bb_pos = -1929732080, bb = public Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo>::get_Value()}});
                val_9 = 0 + 1;
            }
            while(val_9 < (-1929731984));
        
        }
        private static void UpdateLocalPlayer(byte tableType, Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo member)
        {
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.AddOrUpdateLeader(leader:  new Royal.Infrastructure.Services.Storage.Tables.Leader() {<Type>k__BackingField = tableType, <UserName>k__BackingField = member.__p.bb_pos, <TeamName>k__BackingField = member.__p.bb_pos, <IsGold>k__BackingField = false});
        }
        private static void UpdateWorldPlayer(byte tableType, Royal.Infrastructure.Services.Backend.Protocol.LeaderboardUserInfo member)
        {
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.AppLeaderboard.AddOrUpdateLeader(leader:  new Royal.Infrastructure.Services.Storage.Tables.Leader() {<Type>k__BackingField = tableType, <UserName>k__BackingField = member.__p.bb_pos, <TeamName>k__BackingField = member.__p.bb_pos, <IsGold>k__BackingField = false});
        }
        private static void UpdateLocalTeam(byte tableType, Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo member)
        {
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.AddOrUpdateLeader(leader:  new Royal.Infrastructure.Services.Storage.Tables.Leader() {<Type>k__BackingField = tableType, <TeamName>k__BackingField = member.__p.bb_pos, <FacebookId>k__BackingField = -1929396016, <IsGold>k__BackingField = false});
        }
        private static void UpdateWorldTeam(byte tableType, Royal.Infrastructure.Services.Backend.Protocol.LeaderboardTeamInfo member)
        {
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.AppLeaderboard.AddOrUpdateLeader(leader:  new Royal.Infrastructure.Services.Storage.Tables.Leader() {<Type>k__BackingField = tableType, <TeamName>k__BackingField = member.__p.bb_pos, <FacebookId>k__BackingField = -1929284016, <IsGold>k__BackingField = false});
        }
        private static void UpdateFriend(Royal.Infrastructure.Services.Backend.Protocol.FriendScore member)
        {
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.AddOrUpdateLeader(leader:  new Royal.Infrastructure.Services.Storage.Tables.Leader() {<Type>k__BackingField = 1, <UserName>k__BackingField = member.__p.bb_pos, <TeamName>k__BackingField = member.__p.bb_pos, <IsGold>k__BackingField = false});
        }
        private static void CreateFacebookFriend(long fbId)
        {
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.AddOrUpdateLeader(leader:  new Royal.Infrastructure.Services.Storage.Tables.Leader() {<Type>k__BackingField = 1, <UserName>k__BackingField = "", <TeamName>k__BackingField = "", <TeamLogo>k__BackingField = -1, <Level>k__BackingField = -1, <LeagueLevel>k__BackingField = -1, <FacebookId>k__BackingField = fbId, <IsGold>k__BackingField = false});
        }
        public static long[] GetFriendsFacebookIds()
        {
            System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Leader> val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetLeaderboard(type:  1);
            long[] val_2 = new long[0];
            if(1152921505197188192 < 1)
            {
                    return (System.Int64[])val_2;
            }
            
            var val_4 = 0;
            var val_3 = 96;
            do
            {
                if(val_4 >= 1152921505197188192)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = val_3 + 80;
                mem2[0] = val_2.Length + 96;
                val_4 = val_4 + 1;
            }
            while(val_4 < (val_2.Length + 96));
            
            return (System.Int64[])val_2;
        }
        public static void ClearFacebookLeaderboard()
        {
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.ClearLeaderboard(type:  1);
        }
        private static string ExtractState(string name)
        {
            int val_54;
            var val_55;
            val_54 = System.String.alignConst;
            char[] val_1 = new char[1];
            val_1[0] = '-';
            if(val_2.Length == 2)
            {
                    val_54 = name.Split(separator:  val_1)[1];
            }
            
            uint val_3 = _PrivateImplementationDetails_.ComputeStringHash(s:  val_54);
            if(val_3 > 1088409186)
            {
                goto label_6;
            }
            
            if(val_3 > 904296662)
            {
                goto label_7;
            }
            
            if(val_3 > 736520472)
            {
                goto label_8;
            }
            
            if(val_3 > 634721925)
            {
                goto label_9;
            }
            
            if(val_3 == 517278592)
            {
                goto label_10;
            }
            
            if(val_3 == 586507639)
            {
                goto label_11;
            }
            
            if((val_3 != 634721925) || ((System.String.op_Equality(a:  val_54, b:  "AK")) == false))
            {
                goto label_171;
            }
            
            val_55 = "Alaska";
            return (string)val_55;
            label_6:
            if(val_3 > 1625881374)
            {
                goto label_15;
            }
            
            if(val_3 > 1443004851)
            {
                goto label_16;
            }
            
            if(val_3 > 1189074900)
            {
                goto label_17;
            }
            
            if(val_3 == 1105186805)
            {
                goto label_18;
            }
            
            if(val_3 == 1138742043)
            {
                goto label_19;
            }
            
            if((val_3 != 1189074900) || ((System.String.op_Equality(a:  val_54, b:  "MD")) == false))
            {
                goto label_171;
            }
            
            val_55 = "Maryland";
            return (string)val_55;
            label_7:
            if(val_3 > 1003388258)
            {
                goto label_23;
            }
            
            if(val_3 > 937851900)
            {
                goto label_24;
            }
            
            if(val_3 == 904841115)
            {
                goto label_25;
            }
            
            if(val_3 == 920632996)
            {
                goto label_26;
            }
            
            if((val_3 != 937851900) || ((System.String.op_Equality(a:  val_54, b:  "NE")) == false))
            {
                goto label_171;
            }
            
            val_55 = "Nebraska";
            return (string)val_55;
            label_15:
            if(val_3 > 2029677063)
            {
                goto label_30;
            }
            
            if(val_3 > 1742883422)
            {
                goto label_31;
            }
            
            if(val_3 == 1677347064)
            {
                goto label_32;
            }
            
            if(val_3 == 1727238636)
            {
                goto label_33;
            }
            
            if((val_3 != 1742883422) || ((System.String.op_Equality(a:  val_54, b:  "LA")) == false))
            {
                goto label_171;
            }
            
            val_55 = "Louisiana";
            return (string)val_55;
            label_8:
            if(val_3 > 821394305)
            {
                goto label_37;
            }
            
            if(val_3 == 804175401)
            {
                goto label_38;
            }
            
            if(val_3 == 805308234)
            {
                goto label_39;
            }
            
            if((val_3 != 821394305) || ((System.String.op_Equality(a:  val_54, b:  "TX")) == false))
            {
                goto label_171;
            }
            
            val_55 = "Texas";
            return (string)val_55;
            label_16:
            if(val_3 > 1541993279)
            {
                goto label_43;
            }
            
            if(val_3 == 1458105184)
            {
                goto label_44;
            }
            
            if(val_3 == 1526892946)
            {
                goto label_45;
            }
            
            if((val_3 != 1541993279) || ((System.String.op_Equality(a:  val_54, b:  "IA")) == false))
            {
                goto label_171;
            }
            
            val_55 = "Iowa";
            return (string)val_55;
            label_23:
            if(val_3 > 1021739995)
            {
                goto label_49;
            }
            
            if(val_3 == 1004521091)
            {
                goto label_50;
            }
            
            if(val_3 == 1020607162)
            {
                goto label_51;
            }
            
            if((val_3 != 1021739995) || ((System.String.op_Equality(a:  val_54, b:  "NH")) == false))
            {
                goto label_171;
            }
            
            val_55 = "New Hampshire";
            return (string)val_55;
            label_30:
            if(val_3 > (-2116410233))
            {
                goto label_55;
            }
            
            if(val_3 == (-2133629137))
            {
                goto label_56;
            }
            
            if(val_3 == (-2116410233))
            {
                goto label_57;
            }
            
            if((val_3 != 2095360516) || ((System.String.op_Equality(a:  val_54, b:  "OR")) == false))
            {
                goto label_171;
            }
            
            val_55 = "Oregon";
            return (string)val_55;
            label_9:
            if(val_3 == 687320448)
            {
                goto label_61;
            }
            
            if(val_3 == 719742853)
            {
                goto label_62;
            }
            
            if((val_3 != 736520472) || ((System.String.op_Equality(a:  val_54, b:  "NY")) == false))
            {
                goto label_171;
            }
            
            val_55 = "New York";
            return (string)val_55;
            label_17:
            if(val_3 == 1205852519)
            {
                goto label_66;
            }
            
            if(val_3 == 1207426637)
            {
                goto label_67;
            }
            
            if((val_3 != 1443004851) || ((System.String.op_Equality(a:  val_54, b:  "SC")) == false))
            {
                goto label_171;
            }
            
            val_55 = "South Carolina";
            return (string)val_55;
            label_24:
            if(val_3 == 938984733)
            {
                goto label_71;
            }
            
            if(val_3 == 954629519)
            {
                goto label_72;
            }
            
            if((val_3 != 1003388258) || ((System.String.op_Equality(a:  val_54, b:  "DE")) == false))
            {
                goto label_171;
            }
            
            val_55 = "Delaware";
            return (string)val_55;
            label_31:
            if(val_3 == 1792671826)
            {
                goto label_76;
            }
            
            if(val_3 == 2010780873)
            {
                goto label_77;
            }
            
            if((val_3 != 2029677063) || ((System.String.op_Equality(a:  val_54, b:  "VT")) == false))
            {
                goto label_171;
            }
            
            val_55 = "Vermont";
            return (string)val_55;
            label_37:
            if(val_3 == 886386210)
            {
                goto label_81;
            }
            
            if(val_3 == 903855377)
            {
                goto label_82;
            }
            
            if((val_3 != 904296662) || ((System.String.op_Equality(a:  val_54, b:  "NC")) == false))
            {
                goto label_171;
            }
            
            val_55 = "North Carolina";
            return (string)val_55;
            label_43:
            if(val_3 == 1592326136)
            {
                goto label_86;
            }
            
            if(val_3 == 1607529637)
            {
                goto label_87;
            }
            
            if((val_3 != 1625881374) || ((System.String.op_Equality(a:  val_54, b:  "IN")) == false))
            {
                goto label_171;
            }
            
            val_55 = "Indiana";
            return (string)val_55;
            label_49:
            if(val_3 > 1072072852)
            {
                goto label_91;
            }
            
            if(val_3 == 1055295233)
            {
                goto label_92;
            }
            
            if((val_3 != 1072072852) || ((System.String.op_Equality(a:  val_54, b:  "NM")) == false))
            {
                goto label_171;
            }
            
            val_55 = "New Mexico";
            return (string)val_55;
            label_55:
            if(val_3 > (-2048608209))
            {
                goto label_96;
            }
            
            if(val_3 == (-2080044876))
            {
                goto label_97;
            }
            
            if((val_3 != (-2048608209)) || ((System.String.op_Equality(a:  val_54, b:  "OK")) == false))
            {
                goto label_171;
            }
            
            val_55 = "Oklahoma";
            return (string)val_55;
            label_91:
            if(val_3 == 1073205685)
            {
                goto label_101;
            }
            
            if((val_3 != 1088409186) || ((System.String.op_Equality(a:  val_54, b:  "MN")) == false))
            {
                goto label_171;
            }
            
            val_55 = "Minnesota";
            return (string)val_55;
            label_96:
            if(val_3 == (-2031830590))
            {
                goto label_105;
            }
            
            if((val_3 != (-2014611686)) || ((System.String.op_Equality(a:  val_54, b:  "HI")) == false))
            {
                goto label_171;
            }
            
            val_55 = "Hawaii";
            return (string)val_55;
            label_10:
            if((System.String.op_Equality(a:  val_54, b:  "AL")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Alabama";
            return (string)val_55;
            label_11:
            if((System.String.op_Equality(a:  val_54, b:  "TN")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Tennessee";
            return (string)val_55;
            label_18:
            if((System.String.op_Equality(a:  val_54, b:  "MO")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Missouri";
            return (string)val_55;
            label_19:
            if((System.String.op_Equality(a:  val_54, b:  "MA")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Massachusetts";
            return (string)val_55;
            label_25:
            if((System.String.op_Equality(a:  val_54, b:  "KS")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Kansas";
            return (string)val_55;
            label_26:
            if((System.String.op_Equality(a:  val_54, b:  "MT")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Montana";
            return (string)val_55;
            label_32:
            if((System.String.op_Equality(a:  val_54, b:  "VA")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Virginia";
            return (string)val_55;
            label_33:
            if((System.String.op_Equality(a:  val_54, b:  "UT")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Utah";
            return (string)val_55;
            label_38:
            if((System.String.op_Equality(a:  val_54, b:  "KY")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Kentucky";
            return (string)val_55;
            label_39:
            if((System.String.op_Equality(a:  val_54, b:  "PA")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Pennsylvania";
            return (string)val_55;
            label_44:
            if((System.String.op_Equality(a:  val_54, b:  "ID")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Idaho";
            return (string)val_55;
            label_45:
            if((System.String.op_Equality(a:  val_54, b:  "SD")) == false)
            {
                goto label_171;
            }
            
            val_55 = "South Dakota";
            return (string)val_55;
            label_50:
            if((System.String.op_Equality(a:  val_54, b:  "MI")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Michigan";
            return (string)val_55;
            label_51:
            if((System.String.op_Equality(a:  val_54, b:  "AR")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Arkansas";
            return (string)val_55;
            label_56:
            if((System.String.op_Equality(a:  val_54, b:  "FL")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Florida";
            return (string)val_55;
            label_57:
            if((System.String.op_Equality(a:  val_54, b:  "CO")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Colorado";
            return (string)val_55;
            label_61:
            if((System.String.op_Equality(a:  val_54, b:  "WV")) == false)
            {
                goto label_171;
            }
            
            val_55 = "West Virginia";
            return (string)val_55;
            label_62:
            if((System.String.op_Equality(a:  val_54, b:  "NV")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Nevada";
            return (string)val_55;
            label_66:
            if((System.String.op_Equality(a:  val_54, b:  "ME")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Maine";
            return (string)val_55;
            label_67:
            if((System.String.op_Equality(a:  val_54, b:  "WI")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Wisconsin";
            return (string)val_55;
            label_71:
            if((System.String.op_Equality(a:  val_54, b:  "WY")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Wyoming";
            return (string)val_55;
            label_72:
            if((System.String.op_Equality(a:  val_54, b:  "ND")) == false)
            {
                goto label_171;
            }
            
            val_55 = "North Dakota";
            return (string)val_55;
            label_76:
            if((System.String.op_Equality(a:  val_54, b:  "CT")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Connecticut";
            return (string)val_55;
            label_77:
            if((System.String.op_Equality(a:  val_54, b:  "CA")) == false)
            {
                goto label_171;
            }
            
            val_55 = "California";
            return (string)val_55;
            label_81:
            if((System.String.op_Equality(a:  val_54, b:  "AZ")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Arizona";
            return (string)val_55;
            label_82:
            if((System.String.op_Equality(a:  val_54, b:  "MS")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Mississippi";
            return (string)val_55;
            label_86:
            if((System.String.op_Equality(a:  val_54, b:  "IL")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Illinois";
            return (string)val_55;
            label_87:
            if((System.String.op_Equality(a:  val_54, b:  "GA")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Georgia";
            return (string)val_55;
            label_92:
            if((System.String.op_Equality(a:  val_54, b:  "NJ")) == false)
            {
                goto label_171;
            }
            
            val_55 = "New Jersey";
            return (string)val_55;
            label_97:
            if((System.String.op_Equality(a:  val_54, b:  "RI")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Rhode Island";
            return (string)val_55;
            label_101:
            if((System.String.op_Equality(a:  val_54, b:  "WA")) == false)
            {
                goto label_171;
            }
            
            val_55 = "Washington";
            return (string)val_55;
            label_105:
            if((System.String.op_Equality(a:  val_54, b:  "OH")) != false)
            {
                    val_55 = "Ohio";
                return (string)val_55;
            }
            
            label_171:
            val_55 = "USA";
            return (string)val_55;
        }
        private static string ExtractCountry(string name)
        {
            var val_118;
            uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  name);
            if(val_1 > 1088850471)
            {
                goto label_1;
            }
            
            if(val_1 > 738197758)
            {
                goto label_2;
            }
            
            if(val_1 > 619077139)
            {
                goto label_3;
            }
            
            if(val_1 > 485841925)
            {
                goto label_4;
            }
            
            if(val_1 > 400379712)
            {
                goto label_5;
            }
            
            if(val_1 == 365691641)
            {
                goto label_6;
            }
            
            if(val_1 == 399246879)
            {
                goto label_7;
            }
            
            if(val_1 != 400379712)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "BE")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "België";
            return (string)val_118;
            label_1:
            if(val_1 > 1792083446)
            {
                goto label_11;
            }
            
            if(val_1 > 1557196780)
            {
                goto label_12;
            }
            
            if(val_1 > 1189074900)
            {
                goto label_13;
            }
            
            if(val_1 > 1105628090)
            {
                goto label_14;
            }
            
            if(val_1 == 1104053972)
            {
                goto label_15;
            }
            
            if(val_1 == 1105186805)
            {
                goto label_16;
            }
            
            if(val_1 != 1105628090)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "NO")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Norge";
            return (string)val_118;
            label_2:
            if(val_1 > 937851900)
            {
                goto label_20;
            }
            
            if(val_1 > 787839067)
            {
                goto label_21;
            }
            
            if(val_1 > 753842544)
            {
                goto label_22;
            }
            
            if(val_1 == 739771876)
            {
                goto label_23;
            }
            
            if(val_1 == 752856806)
            {
                goto label_24;
            }
            
            if(val_1 != 753842544)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "KZ")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Qazaqstan";
            return (string)val_118;
            label_11:
            if(val_1 > 2010780873)
            {
                goto label_28;
            }
            
            if(val_1 > 1827212802)
            {
                goto label_29;
            }
            
            if(val_1 > 1810582278)
            {
                goto label_30;
            }
            
            if(val_1 == 1809449445)
            {
                goto label_31;
            }
            
            if(val_1 == 1810435183)
            {
                goto label_32;
            }
            
            if(val_1 != 1810582278)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "HU")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Magyarország";
            return (string)val_118;
            label_3:
            if(val_1 > 685054782)
            {
                goto label_36;
            }
            
            if(val_1 > 637532044)
            {
                goto label_37;
            }
            
            if(val_1 == 620754425)
            {
                goto label_38;
            }
            
            if(val_1 == 634133545)
            {
                goto label_39;
            }
            
            if(val_1 != 637532044)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "PK")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Pākistān";
            return (string)val_118;
            label_12:
            if(val_1 > 1660569445)
            {
                goto label_43;
            }
            
            if(val_1 > 1592326136)
            {
                goto label_44;
            }
            
            if(val_1 == 1575107232)
            {
                goto label_45;
            }
            
            if(val_1 == 1577225803)
            {
                goto label_46;
            }
            
            if(val_1 != 1592326136)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "IL")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Yisra\'el";
            return (string)val_118;
            label_20:
            if(val_1 > 1020607162)
            {
                goto label_50;
            }
            
            if(val_1 > 971407138)
            {
                goto label_51;
            }
            
            if(val_1 == 939529186)
            {
                goto label_52;
            }
            
            if(val_1 == 940662019)
            {
                goto label_53;
            }
            
            if(val_1 != 971407138)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "NG")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Nigeria";
            return (string)val_118;
            label_28:
            if(val_1 > 2145001825)
            {
                goto label_57;
            }
            
            if(val_1 > 2077450064)
            {
                goto label_58;
            }
            
            if(val_1 == 2046013397)
            {
                goto label_59;
            }
            
            if(val_1 == 2061658183)
            {
                goto label_60;
            }
            
            if(val_1 != 2077450064)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "FI")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Suomi";
            return (string)val_118;
            label_4:
            if(val_1 > 552952401)
            {
                goto label_64;
            }
            
            if(val_1 == 518955878)
            {
                goto label_65;
            }
            
            if(val_1 == 538440448)
            {
                goto label_66;
            }
            
            if(val_1 != 552952401)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "TH")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Thai";
            return (string)val_118;
            label_13:
            if(val_1 > 1474882803)
            {
                goto label_70;
            }
            
            if(val_1 == 1205852519)
            {
                goto label_71;
            }
            
            if(val_1 == 1458105184)
            {
                goto label_72;
            }
            
            if(val_1 != 1474882803)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "IE")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Éire";
            return (string)val_118;
            label_21:
            if(val_1 > 888063496)
            {
                goto label_76;
            }
            
            if(val_1 == 870153044)
            {
                goto label_77;
            }
            
            if(val_1 == 886386210)
            {
                goto label_78;
            }
            
            if(val_1 != 888063496)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "KR")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "대한민국";
            return (string)val_118;
            label_29:
            if(val_1 > 1860915135)
            {
                goto label_82;
            }
            
            if(val_1 == 1827904350)
            {
                goto label_83;
            }
            
            if(val_1 == 1845814802)
            {
                goto label_84;
            }
            
            if(val_1 != 1860915135)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "HR")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Hrvatska";
            return (string)val_118;
            label_36:
            if(val_1 > 704642520)
            {
                goto label_88;
            }
            
            if(val_1 > 703509687)
            {
                goto label_89;
            }
            
            if(val_1 == 687864901)
            {
                goto label_90;
            }
            
            if(val_1 != 703509687)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "KG")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Kyrgyzstan";
            return (string)val_118;
            label_43:
            if(val_1 > 1726105803)
            {
                goto label_94;
            }
            
            if(val_1 > 1710461017)
            {
                goto label_95;
            }
            
            if(val_1 == 1692006112)
            {
                goto label_96;
            }
            
            if(val_1 != 1710461017)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "US")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "USA";
            return (string)val_118;
            label_50:
            if(val_1 > 1054853948)
            {
                goto label_100;
            }
            
            if(val_1 > 1023417281)
            {
                goto label_101;
            }
            
            if(val_1 == 1022431543)
            {
                goto label_102;
            }
            
            if(val_1 != 1023417281)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "PT")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Portugal";
            return (string)val_118;
            label_57:
            if(val_1 > (-2099632614))
            {
                goto label_106;
            }
            
            if(val_1 > (-2116410233))
            {
                goto label_107;
            }
            
            if(val_1 == (-2133187852))
            {
                goto label_108;
            }
            
            if(val_1 != (-2116410233))
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "CO")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Colombia";
            return (string)val_118;
            label_5:
            if(val_1 > 432802117)
            {
                goto label_112;
            }
            
            if(val_1 == 417157331)
            {
                goto label_113;
            }
            
            if(val_1 != 432802117)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "EG")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Misr";
            return (string)val_118;
            label_14:
            if(val_1 > 1138742043)
            {
                goto label_117;
            }
            
            if(val_1 == 1106319638)
            {
                goto label_118;
            }
            
            if(val_1 != 1138742043)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "MA")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Amerruk";
            return (string)val_118;
            label_22:
            if(val_1 > 786264949)
            {
                goto label_122;
            }
            
            if(val_1 == 785279211)
            {
                goto label_123;
            }
            
            if(val_1 != 786264949)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "BR")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Brasil";
            return (string)val_118;
            label_30:
            if(val_1 > 1825638684)
            {
                goto label_127;
            }
            
            if(val_1 == 1811126731)
            {
                goto label_128;
            }
            
            if(val_1 != 1825638684)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "GR")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Hellas";
            return (string)val_118;
            label_37:
            if(val_1 > 653618115)
            {
                goto label_132;
            }
            
            if(val_1 == 650911164)
            {
                goto label_133;
            }
            
            if(val_1 != 653618115)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "TR")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Türkiye";
            return (string)val_118;
            label_44:
            if(val_1 > 1625881374)
            {
                goto label_137;
            }
            
            if(val_1 == 1610781041)
            {
                goto label_138;
            }
            
            if(val_1 != 1625881374)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "IN")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Bharôt";
            return (string)val_118;
            label_51:
            if(val_1 > 974658542)
            {
                goto label_142;
            }
            
            if(val_1 == 971951591)
            {
                goto label_143;
            }
            
            if(val_1 != 974658542)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "ZW")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Zimbabwe";
            return (string)val_118;
            label_58:
            if(val_1 > 2095213421)
            {
                goto label_147;
            }
            
            if(val_1 == 2078435802)
            {
                goto label_148;
            }
            
            if(val_1 != 2095213421)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "LT")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Lietuva";
            return (string)val_118;
            label_64:
            if(val_1 > 586507639)
            {
                goto label_152;
            }
            
            if(val_1 == 568155902)
            {
                goto label_153;
            }
            
            if(val_1 != 586507639)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "TN")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Tunes";
            return (string)val_118;
            label_70:
            if(val_1 > 1510115327)
            {
                goto label_157;
            }
            
            if(val_1 == 1476560089)
            {
                goto label_158;
            }
            
            if(val_1 != 1510115327)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "SG")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Singapore";
            return (string)val_118;
            label_76:
            if(val_1 > 920632996)
            {
                goto label_162;
            }
            
            if(val_1 == 919941448)
            {
                goto label_163;
            }
            
            if(val_1 != 920632996)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "MT")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Malta";
            return (string)val_118;
            label_82:
            if(val_1 > 1945347683)
            {
                goto label_167;
            }
            
            if(val_1 == 1877104374)
            {
                goto label_168;
            }
            
            if(val_1 != 1945347683)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "UA")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Ukraina";
            return (string)val_118;
            label_88:
            if(val_1 > 736079187)
            {
                goto label_172;
            }
            
            if(val_1 == 719301568)
            {
                goto label_173;
            }
            
            if(val_1 != 736079187)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "MY")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Malaysia";
            return (string)val_118;
            label_94:
            if(val_1 > 1744457540)
            {
                goto label_177;
            }
            
            if(val_1 == 1726547088)
            {
                goto label_178;
            }
            
            if(val_1 != 1744457540)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "VE")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Venezuela";
            return (string)val_118;
            label_100:
            if(val_1 > 1072764400)
            {
                goto label_182;
            }
            
            if(val_1 == 1071631567)
            {
                goto label_183;
            }
            
            if(val_1 != 1072764400)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "JM")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Jamaica";
            return (string)val_118;
            label_106:
            if(val_1 > (-2082854995))
            {
                goto label_187;
            }
            
            if(val_1 == (-2098499781))
            {
                goto label_188;
            }
            
            if(val_1 != (-2082854995))
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "CM")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Cameroun";
            return (string)val_118;
            label_89:
            if(val_1 == 703950972)
            {
                goto label_192;
            }
            
            if(val_1 != 704642520)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "PG")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Papua New Guinea";
            return (string)val_118;
            label_95:
            if(val_1 == 1724972970)
            {
                goto label_196;
            }
            
            if(val_1 != 1726105803)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "LB")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Lubnān";
            return (string)val_118;
            label_101:
            if(val_1 == 1036943496)
            {
                goto label_200;
            }
            
            if(val_1 != 1054853948)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "ML")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Mali";
            return (string)val_118;
            label_107:
            if(val_1 == (-2113600114))
            {
                goto label_204;
            }
            
            if(val_1 != (-2099632614))
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "CL")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Chile";
            return (string)val_118;
            label_112:
            if(val_1 == 433934950)
            {
                goto label_208;
            }
            
            if(val_1 != 485841925)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "TD")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Tchad";
            return (string)val_118;
            label_117:
            if(val_1 == 1172297281)
            {
                goto label_212;
            }
            
            if(val_1 != 1189074900)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "MD")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Moldova";
            return (string)val_118;
            label_122:
            if(val_1 == 786853329)
            {
                goto label_216;
            }
            
            if(val_1 != 787839067)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "TZ")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Tanzania";
            return (string)val_118;
            label_127:
            if(val_1 == 1826227064)
            {
                goto label_220;
            }
            
            if(val_1 != 1827212802)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "IR")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Īrān";
            return (string)val_118;
            label_132:
            if(val_1 == 668277163)
            {
                goto label_224;
            }
            
            if(val_1 != 685054782)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "AF")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Afghanestan";
            return (string)val_118;
            label_137:
            if(val_1 == 1627558660)
            {
                goto label_228;
            }
            
            if(val_1 != 1660569445)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "VN")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Viêt Nam";
            return (string)val_118;
            label_142:
            if(val_1 == 1003388258)
            {
                goto label_232;
            }
            
            if(val_1 != 1020607162)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "AR")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Argentina";
            return (string)val_118;
            label_147:
            if(val_1 == 2128224206)
            {
                goto label_236;
            }
            
            if(val_1 != 2145001825)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "CI")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Côte d’Ivoire";
            return (string)val_118;
            label_152:
            if(val_1 == 603285258)
            {
                goto label_240;
            }
            
            if(val_1 != 619077139)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "NP")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Nepāl";
            return (string)val_118;
            label_157:
            if(val_1 == 1543670565)
            {
                goto label_244;
            }
            
            if(val_1 != 1557196780)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "GB")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "United Kingdom";
            return (string)val_118;
            label_162:
            if(val_1 == 936719067)
            {
                goto label_248;
            }
            
            if(val_1 != 937851900)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "NE")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Niger";
            return (string)val_118;
            label_167:
            if(val_1 == 1993561969)
            {
                goto label_252;
            }
            
            if(val_1 != 2010780873)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "CA")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Canada";
            return (string)val_118;
            label_172:
            if(val_1 == 737064925)
            {
                goto label_256;
            }
            
            if(val_1 != 738197758)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "PE")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Perú";
            return (string)val_118;
            label_177:
            if(val_1 == 1745149088)
            {
                goto label_260;
            }
            
            if(val_1 != 1792083446)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "GT")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Guatemala";
            return (string)val_118;
            label_182:
            if(val_1 == 1088409186)
            {
                goto label_264;
            }
            
            if(val_1 != 1088850471)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "NL")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Nederland";
            return (string)val_118;
            label_187:
            if(val_1 == (-2048166924))
            {
                goto label_268;
            }
            
            if(val_1 != (-1946368377))
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            if((System.String.op_Equality(a:  name, b:  "QA")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Qatar";
            return (string)val_118;
            label_6:
            if((System.String.op_Equality(a:  name, b:  "EC")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Ecuador";
            return (string)val_118;
            label_7:
            if((System.String.op_Equality(a:  name, b:  "EE")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Eesti";
            return (string)val_118;
            label_15:
            if((System.String.op_Equality(a:  name, b:  "DO")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "República Dominicana";
            return (string)val_118;
            label_16:
            if((System.String.op_Equality(a:  name, b:  "MO")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Macao";
            return (string)val_118;
            label_23:
            if((System.String.op_Equality(a:  name, b:  "ZA")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "South Africa";
            return (string)val_118;
            label_24:
            if((System.String.op_Equality(a:  name, b:  "MZ")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Moçambique";
            return (string)val_118;
            label_31:
            if((System.String.op_Equality(a:  name, b:  "CU")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Cuba";
            return (string)val_118;
            label_32:
            if((System.String.op_Equality(a:  name, b:  "IQ")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Îraq";
            return (string)val_118;
            label_38:
            if((System.String.op_Equality(a:  name, b:  "PL")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Polska";
            return (string)val_118;
            label_39:
            if((System.String.op_Equality(a:  name, b:  "ES")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "España";
            return (string)val_118;
            label_45:
            if((System.String.op_Equality(a:  name, b:  "LK")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Sri Lankā";
            return (string)val_118;
            label_46:
            if((System.String.op_Equality(a:  name, b:  "SK")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Slovensko";
            return (string)val_118;
            label_52:
            if((System.String.op_Equality(a:  name, b:  "PY")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Paraguay";
            return (string)val_118;
            label_53:
            if((System.String.op_Equality(a:  name, b:  "YE")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Al-Yaman";
            return (string)val_118;
            label_59:
            if((System.String.op_Equality(a:  name, b:  "UG")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Uganda";
            return (string)val_118;
            label_60:
            if((System.String.op_Equality(a:  name, b:  "LV")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Latvija";
            return (string)val_118;
            label_65:
            if((System.String.op_Equality(a:  name, b:  "KH")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Kampuchea";
            return (string)val_118;
            label_66:
            if((System.String.op_Equality(a:  name, b:  "ZM")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Zambia";
            return (string)val_118;
            label_71:
            if((System.String.op_Equality(a:  name, b:  "ME")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Crna Gora";
            return (string)val_118;
            label_72:
            if((System.String.op_Equality(a:  name, b:  "ID")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Indonesia";
            return (string)val_118;
            label_77:
            if((System.String.op_Equality(a:  name, b:  "BY")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Bielaruś";
            return (string)val_118;
            label_78:
            if((System.String.op_Equality(a:  name, b:  "AZ")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Azerbaycan";
            return (string)val_118;
            label_83:
            if((System.String.op_Equality(a:  name, b:  "UZ")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "O‘zbekiston";
            return (string)val_118;
            label_84:
            if((System.String.op_Equality(a:  name, b:  "RS")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Srbija";
            return (string)val_118;
            label_90:
            if((System.String.op_Equality(a:  name, b:  "PH")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Philippines";
            return (string)val_118;
            label_96:
            if((System.String.op_Equality(a:  name, b:  "CR")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Costa Rica";
            return (string)val_118;
            label_102:
            if((System.String.op_Equality(a:  name, b:  "JP")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "日本";
            return (string)val_118;
            label_108:
            if((System.String.op_Equality(a:  name, b:  "CN")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "China";
            return (string)val_118;
            label_113:
            if((System.String.op_Equality(a:  name, b:  "BD")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Bangladesh";
            return (string)val_118;
            label_118:
            if((System.String.op_Equality(a:  name, b:  "JO")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Al-’Urdun";
            return (string)val_118;
            label_123:
            if((System.String.op_Equality(a:  name, b:  "DZ")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Dzayer";
            return (string)val_118;
            label_128:
            if((System.String.op_Equality(a:  name, b:  "UY")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Uruguay";
            return (string)val_118;
            label_133:
            if((System.String.op_Equality(a:  name, b:  "ET")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Ityop\'ia";
            return (string)val_118;
            label_138:
            if((System.String.op_Equality(a:  name, b:  "SI")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Slovenija";
            return (string)val_118;
            label_143:
            if((System.String.op_Equality(a:  name, b:  "KW")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Dawlat ul-Kuwayt";
            return (string)val_118;
            label_148:
            if((System.String.op_Equality(a:  name, b:  "LU")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Lëtzebuerg";
            return (string)val_118;
            label_153:
            if((System.String.op_Equality(a:  name, b:  "BO")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Bolivia";
            return (string)val_118;
            label_158:
            if((System.String.op_Equality(a:  name, b:  "SA")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Saudi Arabia";
            return (string)val_118;
            label_163:
            if((System.String.op_Equality(a:  name, b:  "AT")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Österreich";
            return (string)val_118;
            label_168:
            if((System.String.op_Equality(a:  name, b:  "LY")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Libya";
            return (string)val_118;
            label_173:
            if((System.String.op_Equality(a:  name, b:  "MX")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "México";
            return (string)val_118;
            label_178:
            if((System.String.op_Equality(a:  name, b:  "IT")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Italia";
            return (string)val_118;
            label_183:
            if((System.String.op_Equality(a:  name, b:  "MM")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Myanmar";
            return (string)val_118;
            label_188:
            if((System.String.op_Equality(a:  name, b:  "HN")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Honduras";
            return (string)val_118;
            label_192:
            if((System.String.op_Equality(a:  name, b:  "TW")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Taiwan";
            return (string)val_118;
            label_196:
            if((System.String.op_Equality(a:  name, b:  "GH")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Ghana";
            return (string)val_118;
            label_200:
            if((System.String.op_Equality(a:  name, b:  "DK")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Danmark";
            return (string)val_118;
            label_204:
            if((System.String.op_Equality(a:  name, b:  "RO")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "România";
            return (string)val_118;
            label_208:
            if((System.String.op_Equality(a:  name, b:  "BG")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Bulgariya";
            return (string)val_118;
            label_212:
            if((System.String.op_Equality(a:  name, b:  "MC")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Monaco";
            return (string)val_118;
            label_216:
            if((System.String.op_Equality(a:  name, b:  "NZ")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "New Zealand";
            return (string)val_118;
            label_220:
            if((System.String.op_Equality(a:  name, b:  "CZ")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Czechia";
            return (string)val_118;
            label_224:
            if((System.String.op_Equality(a:  name, b:  "AE")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "UAE";
            return (string)val_118;
            label_228:
            if((System.String.op_Equality(a:  name, b:  "SN")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Sénégal";
            return (string)val_118;
            label_232:
            if((System.String.op_Equality(a:  name, b:  "DE")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Deutschland";
            return (string)val_118;
            label_236:
            if((System.String.op_Equality(a:  name, b:  "CH")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Suisse";
            return (string)val_118;
            label_240:
            if((System.String.op_Equality(a:  name, b:  "TM")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Türkmenistan";
            return (string)val_118;
            label_244:
            if((System.String.op_Equality(a:  name, b:  "SE")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Sverige";
            return (string)val_118;
            label_248:
            if((System.String.op_Equality(a:  name, b:  "AU")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Australia";
            return (string)val_118;
            label_252:
            if((System.String.op_Equality(a:  name, b:  "FR")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "France";
            return (string)val_118;
            label_256:
            if((System.String.op_Equality(a:  name, b:  "KE")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Kenya";
            return (string)val_118;
            label_260:
            if((System.String.op_Equality(a:  name, b:  "RU")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Россия";
            return (string)val_118;
            label_264:
            if((System.String.op_Equality(a:  name, b:  "MN")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Mongol Uls";
            return (string)val_118;
            label_268:
            if((System.String.op_Equality(a:  name, b:  "HK")) == false)
            {
                    return Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Local");
            }
            
            val_118 = "Hong Kong";
            return (string)val_118;
        }
        public LeaderboardManager()
        {
        
        }
    
    }

}
