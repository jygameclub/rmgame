using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public enum RequestType
    {
        // Fields
        NONE = 0
        ,PingRequest = 1
        ,RegisterRequest = 2
        ,UpdateUserProgressRequest = 3
        ,PurchaseVerificationRequest = 4
        ,LeaderboardRequest = 5
        ,SocialConnectRequest = 6
        ,DetachUserFromDeviceRequest = 7
        ,CreateTeamRequest = 8
        ,GetTeamInfoRequest = 9
        ,GetTeamMembersRequest = 10
        ,JoinTeamRequest = 11
        ,UpdateTeamMemberRequest = 12
        ,LeaveTeamRequest = 13
        ,SearchTeamRequest = 14
        ,ChangeUserNameRequest = 15
        ,EnterLeagueRequest = 16
        ,GetLeagueInfoRequest = 17
        ,DepreciatedCheckLeagueRequest = 18
        ,CheckLeagueRequest = 19
        ,ClaimLeagueRewardRequest = 20
        ,ClaimKingsCupRewardRequest = 21
        ,GetKingsCupInfoRequest = 22
        ,GetTeamBattleInfoRequest = 23
        ,ClaimTeamBattleRewardRequest = 24
        ,PurchaseInMaintenanceModeRequest = 25
        
    
    }

}
