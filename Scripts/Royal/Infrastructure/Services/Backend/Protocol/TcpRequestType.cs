using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Protocol
{
    public enum TcpRequestType
    {
        // Fields
        NONE = 0
        ,AuthenticateRequest = 1
        ,AskLifeRequest = 2
        ,ConsumeLifeRequest = 3
        ,HelpLifeRequest = 4
        ,SendChatMessageRequest = 5
        ,EchoRequest = 6
        ,RoyalPassClaimRequest = 7
        
    
    }

}
