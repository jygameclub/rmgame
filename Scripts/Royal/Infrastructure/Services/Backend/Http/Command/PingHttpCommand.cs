using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command
{
    public class PingHttpCommand : BaseHttpCommand
    {
        // Fields
        private const byte LifeHackControlEnabledBit = 0;
        private const byte MadnessEventDisabledBit = 1;
        private const byte RoyalPassDisabledBit = 2;
        private static int LastProcessedPingPackageId;
        private Royal.Infrastructure.Services.Backend.Protocol.PingResponse <Response>k__BackingField;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        private Royal.Infrastructure.Services.Backend.Protocol.PingResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 1;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 1;
        }
        private Royal.Infrastructure.Services.Backend.Protocol.PingResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.PingResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        private void set_Response(Royal.Infrastructure.Services.Backend.Protocol.PingResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528643438816] = value.__p.bb;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            var val_11;
            Royal.Player.Context.Units.LeagueManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5);
            Royal.Player.Context.Units.KingsCupManager val_2 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7);
            Royal.Player.Context.Units.TeamBattleManager val_3 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9);
            val_11 = null;
            val_11 = null;
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.PingRequest> val_10 = Royal.Infrastructure.Services.Backend.Protocol.PingRequest.CreatePingRequest(builder:  builder, bad_words_version:  Royal.Infrastructure.Utils.BadWords.BadWordsFilter.BadWordsFilterVersion, league_group_id:  val_1.groupId, league_config_version:  val_1.version, kings_cup_group_id:  val_2.groupId, team_battle_group_id:  val_3.groupId, team_id:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg, madness_event_version:  Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10).GetConfigVersion(), ladder_offer_version:  Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11).GetConfigVersion(), royal_pass_version:  Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).GetConfigVersion());
            return (int)val_10.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            int val_4;
            int val_5;
            val_4 = package.__p.bb_pos;
            val_5 = packageId;
            Royal.Infrastructure.Services.Backend.Protocol.PingResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.PingResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = val_4, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528643733712] = val_1.__p.bb;
            mem[1152921528643733696] = (((-1732929168) & 255) != 0) ? 1 : 0;
            if(65536 != 0)
            {
                    return;
            }
            
            if(Royal.Infrastructure.Services.Backend.Http.Command.PingHttpCommand.LastProcessedPingPackageId > val_5)
            {
                    object[] val_3 = new object[2];
                val_4 = 1152921504619413504;
                val_3[0] = val_5;
                val_5 = Royal.Infrastructure.Services.Backend.Http.Command.PingHttpCommand.LastProcessedPingPackageId;
                val_3[1] = val_5;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  11, log:  "Ignoring this ping ({0}) because already a newer one ({1}) is processed.", values:  val_3);
                return;
            }
            
            Royal.Infrastructure.Services.Backend.Http.Command.PingHttpCommand.LastProcessedPingPackageId = val_5;
            this.ProcessSettings();
            this.ProcessBadWords();
            this.ProcessUserData(syncId:  -1732929152);
        }
        public override void PackageFail()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3).CheckForceUpdate();
        }
        private void ProcessSettings()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3).UpdateForceVersion(version:  -1732660048);
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2).UpdateMaxPublishedLevel(newMaxPublishedLevel:  -1732660048);
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5).UpdateRequiredLevel(newRequiredLevel:  -1732660048);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14).LifeHackControlEnabledByBackend(enabled:  Royal.Infrastructure.Utils.Math.BitwiseOperations.IsBitSet(number:  null, position:  0));
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10).MadnessDisabledByBackend(isDisabled:  Royal.Infrastructure.Utils.Math.BitwiseOperations.IsBitSet(number:  null, position:  1));
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).DisabledByBackend(isDisabled:  Royal.Infrastructure.Utils.Math.BitwiseOperations.IsBitSet(number:  null, position:  2));
        }
        private void ProcessBadWords()
        {
            var val_1;
            string val_2;
            var val_3;
            var val_3 = val_1;
            val_3 = val_3 & 255;
            if(val_3 == 0)
            {
                    return;
            }
            
            val_3;
            Royal.Infrastructure.Utils.BadWords.BadWordsFilter.UpdateBadWordsFilterVersion(newVersion:  224);
            if((-1732521504) < 1)
            {
                    return;
            }
            
            do
            {
                Royal.Infrastructure.Utils.BadWords.BadWordsFilter.UpdateBadWordsRegex(language:  val_2, regex:  val_2);
                val_3 = 0 + 1;
            }
            while(val_3 < (-1732521504));
        
        }
        private void ProcessUserData(int syncId)
        {
            long val_9;
            var val_10;
            var val_11;
            var val_12;
            val_9 = 1152921505124790272;
            if(((-1732397072) & 1) != 0)
            {
                    if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasTeam()) != true)
            {
                    UpdateTeam(teamId:  1);
            }
            
            }
            
            val_9;
            UpdateAbTestData(userId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name, newAbTestData:  val_9, newAbTestUpdateData:  null, abTestContent:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent>() {HasValue = true});
            val_11 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1);
            if(240 == 2)
            {
                    val_11.SendDataToBackend(forceToSend:  true, forceScoreData:  false);
                return;
            }
            
            if((val_11.TryUpdateDataFromBackend(serverSyncId:  syncId, serverUserProgress:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>() {HasValue = true}, oldUserId:  0, trigger:  0)) != true)
            {
                    this.UpdateLeagueData();
                this.UpdateTeamBattleData();
                this.UpdateKingsCupData();
                this.UpdateMadnessData();
                this.UpdateLadderOfferData();
                this.UpdateRoyalPassData();
            }
            
            if(240 != 1)
            {
                    return;
            }
            
            string val_6 = "ForceLog: "("ForceLog: ") + this.<Response>k__BackingField(this.<Response>k__BackingField);
            val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  8, log:  val_6, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            Royal.Infrastructure.Services.Logs.LogUploader val_7 = null;
            val_10 = val_7;
            val_7 = new Royal.Infrastructure.Services.Logs.LogUploader();
            val_7.StartCompressAndUpload(message:  val_6);
        }
        private void UpdateLeagueData()
        {
            var val_2;
            Royal.Player.Context.Units.LeagueManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5);
            if((-1732268672) >= 1)
            {
                    val_1.UpdateRankAndDate(newRank:  -1732268672, remainingTime:  null);
            }
            
            var val_4 = val_2;
            val_4 = val_4 & 255;
            if(val_4 == 0)
            {
                    return;
            }
            
            val_1.UpdateConfig(config:  new Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig() {__p = new FlatBuffers.Table() {bb_pos = -1732268704, bb = public Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LeagueConfig>::get_Value()}});
        }
        private void UpdateKingsCupData()
        {
            var val_1;
            var val_4 = val_1;
            val_4 = val_4 & 255;
            if(val_4 == 0)
            {
                    return;
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7).UpdateInfo(info:  new Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo() {__p = new FlatBuffers.Table() {bb_pos = -1732148496, bb = public Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo>::get_Value()}});
        }
        private void UpdateTeamBattleData()
        {
            var val_1;
            var val_4 = val_1;
            val_4 = val_4 & 255;
            if(val_4 == 0)
            {
                    return;
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9).UpdateInfo(info:  new Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo() {__p = new FlatBuffers.Table() {bb_pos = -1732028304, bb = public Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo>::get_Value()}});
        }
        private void UpdateMadnessData()
        {
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10).UpdateInfo(info:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.MadnessEventInfo>() {HasValue = true});
        }
        private void UpdateLadderOfferData()
        {
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11).UpdateInfo(info:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LadderOfferInfo>() {HasValue = true});
        }
        private void UpdateRoyalPassData()
        {
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).UpdateInfo(royalPassInfo:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassInfo>() {HasValue = true});
        }
        public PingHttpCommand()
        {
            val_1 = new System.Object();
        }
    
    }

}
