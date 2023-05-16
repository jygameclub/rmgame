using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public enum ResponseType
    {
        // Fields
        NONE = 0
        ,PingResponse = 1
        ,RegisterResponse = 2
        ,UpdateUserProgressResponse = 3
        ,PurchaseVerificationResponse = 4
        ,LeaderboardResponse = 5
        ,SocialConnectResponse = 6
        ,DetachUserFromDeviceResponse = 7
        ,CreateTeamResponse = 8
        ,GetTeamInfoResponse = 9
        ,GetTeamMembersResponse = 10
        ,JoinTeamResponse = 11
        ,UpdateTeamMemberResponse = 12
        ,LeaveTeamResponse = 13
        ,TeamMemberInfo = 14
        ,SearchTeamResponse = 15
        ,ChangeUserNameResponse = 16
        ,EnterLeagueResponse = 17
        ,GetLeagueInfoResponse = 18
        ,DepreciatedCheckLeagueResponse = 19
        ,CheckLeagueResponse = 20
        ,ClaimLeagueRewardResponse = 21
        ,ClaimKingsCupRewardResponse = 22
        ,GetKingsCupInfoResponse = 23
        ,GetTeamBattleInfoResponse = 24
        ,ClaimTeamBattleRewardResponse = 25
        ,PurchaseInMaintenanceModeResponse = 26
        
    
    }

}
