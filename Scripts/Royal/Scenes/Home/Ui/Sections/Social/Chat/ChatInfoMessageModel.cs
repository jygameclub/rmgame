using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Chat
{
    public class ChatInfoMessageModel : ChatScrollItemModel
    {
        // Fields
        public Royal.Infrastructure.Services.Backend.Protocol.ChatMessageType chatMessageType;
        public string actionOwner;
        public Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageView messageView;
        
        // Properties
        public override Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemView View { get; }
        
        // Methods
        public override Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemView get_View()
        {
            return (Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemView)this.messageView;
        }
        public ChatInfoMessageModel(UnityEngine.Transform parent, long userId, string userName, long createDate, Royal.Infrastructure.Services.Backend.Protocol.ChatMessageType chatMessageType, string actionOwner)
        {
            this.chatMessageType = chatMessageType;
            this.actionOwner = actionOwner;
            mem[1152921519000376952] = 0;
        }
        public override void Show()
        {
            if(true != 0)
            {
                    return;
            }
            
            this.messageView = 7821.Spawn<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageView>(poolId:  0, parent:  null);
            this.Show();
            this.messageView.Init(infoMessage:  this);
        }
        public override void Hide()
        {
            if(true == 0)
            {
                    return;
            }
            
            7820.Recycle<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageView>(item:  this.messageView);
            this.messageView = 0;
            mem[1152921519000639904] = 0;
            this.SetSequence(animationSeq:  0);
        }
    
    }

}
