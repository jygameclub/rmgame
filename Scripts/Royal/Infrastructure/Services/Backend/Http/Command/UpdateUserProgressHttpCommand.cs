using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http.Command
{
    public class UpdateUserProgressHttpCommand : BaseHttpCommand
    {
        // Fields
        private readonly bool updateArea;
        private readonly bool updateInventory;
        private readonly bool updateBasicData;
        private readonly bool updateLogData;
        private readonly bool forceScoreData;
        private Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse <Response>k__BackingField;
        
        // Properties
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType RequestType { get; }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType ResponseType { get; }
        private Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse Response { get; set; }
        
        // Methods
        public override Royal.Infrastructure.Services.Backend.Protocol.RequestType get_RequestType()
        {
            return 3;
        }
        public override Royal.Infrastructure.Services.Backend.Protocol.ResponseType get_ResponseType()
        {
            return 3;
        }
        private Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse get_Response()
        {
            return new Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse() {__p = new FlatBuffers.Table() {bb_pos = this.<Response>k__BackingField}};
        }
        private void set_Response(Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse value)
        {
            this.<Response>k__BackingField = value;
            mem[1152921528650077568] = value.__p.bb;
        }
        public UpdateUserProgressHttpCommand(bool updateBasicData, bool updateInventory = False, bool updateArea = False, bool updateLogData = False, bool forceScoreData = False)
        {
            val_1 = new System.Object();
            this.updateBasicData = updateBasicData;
            this.updateInventory = updateInventory;
            this.updateArea = updateArea;
            this.updateLogData = updateLogData;
            this.forceScoreData = forceScoreData;
        }
        public override int Build(FlatBuffers.FlatBufferBuilder builder)
        {
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            System.Collections.Generic.List<Royal.Infrastructure.Services.Backend.Protocol.UserProgressType> val_2 = new System.Collections.Generic.List<Royal.Infrastructure.Services.Backend.Protocol.UserProgressType>();
            if(this.updateBasicData != false)
            {
                    val_2.Add(item:  3);
                FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData> val_3 = Royal.Infrastructure.Services.Backend.Protocol.UpdateBasicData.CreateUpdateBasicData(builder:  builder, level:  typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14>>0&0xFFFFFFFF, full_lives_time_in_ms:  Royal.Player.Context.Data.Persistent.BasicUserData.__il2cppRuntimeField_byval_arg, unlimited_lives_end_time_in_ms:  typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_28, userData:  Royal.Player.Context.Data.Persistent.BasicUserData.__il2cppRuntimeField_this_arg);
                val_1.Add(item:  val_3.Value);
            }
            
            if(this.updateInventory != false)
            {
                    FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress> val_4 = Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress.CreateRoyalPassUserProgress(builder:  builder, pass_data:  Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_declaringType, free_data:  Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_parent, gold_data:  Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_generic_class);
                val_2.Add(item:  2);
                FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData> val_6 = Royal.Infrastructure.Services.Backend.Protocol.UpdateInventoryData.CreateUpdateInventoryData(builder:  builder, coins:  130671888, stars:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_14>>0&0xFFFFFFFF, inbox:  130675984, in_game_inventory:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_28, pre_level_inventory:  Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_this_arg, chest:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_1C>>0&0xFFFFFFFF, event_progress:  Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_byval_arg, unlimited_rocket_end_time:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_38, unlimited_tnt_end_time:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_3C, unlimited_lightball_end_time:  Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_element_class, remaining_booster_times:  Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_castClass, royal_pass_user_progressOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.RoyalPassUserProgress>() {Value = val_4.Value & 4294967295});
                val_1.Add(item:  val_6.Value);
            }
            
            if(this.updateArea == false)
            {
                goto label_12;
            }
            
            if(IsUsingRealArea() == false)
            {
                goto label_18;
            }
            
            val_2.Add(item:  1);
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData> val_9 = Royal.Infrastructure.Services.Backend.Protocol.UpdateAreaData.CreateUpdateAreaData(builder:  builder, area_id:  129259600, area_tasks:  GetTaskValue(), area_status:  129263696);
            val_1.Add(item:  val_9.Value);
            goto label_18;
            label_12:
            label_18:
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsInLeague()) != false)
            {
                    Royal.Player.Context.Units.LeagueManager val_11 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5);
                val_2.Add(item:  4);
                FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData> val_12 = Royal.Infrastructure.Services.Backend.Protocol.UpdateLeagueData.CreateUpdateLeagueData(builder:  builder, group_id:  val_11.groupId, league_level:  125198928, depreciated_claim:  false);
                val_1.Add(item:  val_12.Value);
            }
            
            0.Basic = 0;
            if(this.forceScoreData != false)
            {
                    FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ForceData> val_16 = Royal.Infrastructure.Services.Backend.Protocol.ForceData.CreateForceData(builder:  builder, forceLeagueScore:  Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetMyScore(type:  2), forceKingsCupScore:  Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetMyScore(type:  7), forceTeamBattleScore:  Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetMyScore(type:  9));
            }
            
            object[] val_17 = new object[5];
            val_17[0] = this.updateBasicData;
            val_17[1] = this.updateInventory;
            val_17[2] = this.updateArea;
            val_17[3] = this.updateLogData;
            val_17[4] = this.forceScoreData;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  11, log:  "Build basic:{0} inventory:{1} area:{2} log:{3} force:{4}", values:  val_17);
            FlatBuffers.VectorOffset val_19 = Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest.CreateUserProgressTypeVector(builder:  builder, data:  val_2.ToArray());
            FlatBuffers.VectorOffset val_21 = Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest.CreateUserProgressVector(builder:  builder, data:  val_1.ToArray());
            FlatBuffers.StringOffset val_23 = builder.CreateString(s:  Royal.Infrastructure.Utils.Native.DeviceHelper.DeviceId());
            Royal.Player.Context.Units.KingsCupManager val_24 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7);
            Royal.Player.Context.Units.TeamBattleManager val_25 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9);
            int val_29 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11).GetConfigVersion();
            int val_31 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).GetConfigVersion();
            FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest> val_34 = Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressRequest.CreateUpdateUserProgressRequest(builder:  builder, device_id:  val_23.Value, user_progress_typeOffset:  new FlatBuffers.VectorOffset() {Value = val_19.Value & 4294967295}, user_progressOffset:  new FlatBuffers.VectorOffset() {Value = val_21.Value & 4294967295}, kings_cup_group_id:  val_24.groupId, team_id:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg, team_battle_group_id:  val_25.groupId, madness_event_version:  Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10).GetConfigVersion(), forceDataOffset:  new FlatBuffers.Offset<Royal.Infrastructure.Services.Backend.Protocol.ForceData>() {Value = val_16.Value}, ladder_offer_version:  0, royal_pass_version:  0);
            return (int)val_34.Value;
        }
        public override void Finish(int packageId, Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage package, int index)
        {
            var val_4;
            Royal.Player.Context.Data.Persistent.BasicUserData val_11;
            var val_12;
            Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse val_1 = this.ParseResponse<Royal.Infrastructure.Services.Backend.Protocol.UpdateUserProgressResponse>(package:  new Royal.Infrastructure.Services.Backend.Protocol.ResponsePackage() {__p = new FlatBuffers.Table() {bb_pos = package.__p.bb_pos, bb = package.__p.bb}}, index:  index);
            this.<Response>k__BackingField = val_1;
            mem[1152921528650700704] = val_1.__p.bb;
            mem[1152921528650700688] = (((-1725962176) & 255) != 0) ? 1 : 0;
            Royal.Player.Context.Units.UserManager val_3 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1);
            if(64 == 1)
            {
                    val_11;
                bool val_6 = val_3.TryUpdateDataFromBackend(serverSyncId:  -1725962160, serverUserProgress:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>() {HasValue = true}, oldUserId:  0, trigger:  0);
                return;
            }
            
            if(((-1725962176) & 1) != 0)
            {
                    if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasTeam()) != true)
            {
                    UpdateTeam(teamId:  1);
            }
            
            }
            
            if(val_4 != false)
            {
                    val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  11, log:  "Admin update is applied", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                val_11;
                bool val_8 = val_3.TryUpdateDataFromBackend(serverSyncId:  -1725962160, serverUserProgress:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>() {HasValue = true}, oldUserId:  0, trigger:  0);
            }
            else
            {
                    val_11 = mem[Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField + 24];
                val_11 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<BasicData>k__BackingField;
                UpdateSyncId(newSyncId:  -1725962160);
                this.UpdateLeagueInfo();
                this.UpdateTeamBattleInfo();
                this.UpdateKingsCupInfo();
                this.UpdateMadnessData();
                this.UpdateLadderOfferData();
                this.UpdateRoyalPassData();
            }
            
            val_3.DataSyncedWithBackend(isBasicDataSynced:  this.updateBasicData, isInventorySynced:  this.updateInventory, isAreaDataSynced:  this.updateArea, isLogDataSynced:  this.updateLogData);
        }
        public override void PackageFail()
        {
        
        }
        private void UpdateLeagueInfo()
        {
            if( < 1)
            {
                    return;
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5).UpdateRankAndDate(newRank:  -1725729952, remainingTime:  null);
        }
        private void UpdateKingsCupInfo()
        {
            var val_1;
            var val_4 = val_1;
            val_4 = val_4 & 255;
            if(val_4 == 0)
            {
                    return;
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7).UpdateInfo(info:  new Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo() {__p = new FlatBuffers.Table() {bb_pos = -1725609776, bb = public Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.KingsCupInfo>::get_Value()}});
        }
        private void UpdateTeamBattleInfo()
        {
            var val_1;
            var val_4 = val_1;
            val_4 = val_4 & 255;
            if(val_4 == 0)
            {
                    return;
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9).UpdateInfo(info:  new Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo() {__p = new FlatBuffers.Table() {bb_pos = -1725489584, bb = public Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.TeamBattleInfo>::get_Value()}});
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
    
    }

}
