using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public enum TcpResponseType
    {
        // Fields
        NONE = 0
        ,AuthenticateResponse = 1
        ,AskLifeResponse = 2
        ,ConsumeLifeResponse = 3
        ,HelpLifeResponse = 4
        ,SendChatMessageResponse = 5
        ,LifeChangeResponse = 6
        ,PendingJoinTeamResponse = 7
        ,UserConnectedFromOtherDeviceResponse = 8
        ,EchoResponse = 9
        ,RoyalPassClaimResponse = 10
        ,RoyalPassDataResponse = 11
        
    
    }

}
