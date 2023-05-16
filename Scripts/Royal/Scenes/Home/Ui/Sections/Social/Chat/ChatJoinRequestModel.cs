using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Chat
{
    public class ChatJoinRequestModel : ChatScrollItemModel
    {
        // Fields
        public System.Action<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel> onRemoveSelf;
        public Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatJoinRequestView messageView;
        public bool isGold;
        
        // Properties
        public override Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemView View { get; }
        
        // Methods
        public ChatJoinRequestModel(UnityEngine.Transform parent, long userId, string userName, long createDate, bool isGold, System.Action<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemModel> onRemoveSelf)
        {
            this.onRemoveSelf = onRemoveSelf;
            this.isGold = isGold;
            mem[1152921519001500836] = 1;
            mem[1152921519001500844] = 1077756373;
        }
        public override Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemView get_View()
        {
            return (Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemView)this.messageView;
        }
        public override bool RemoveOnChatDisabled()
        {
            return false;
        }
        public override void Show()
        {
            if(true != 0)
            {
                    return;
            }
            
            this.messageView = 7826.Spawn<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatJoinRequestView>(poolId:  1, parent:  null);
            this.Show();
            this.messageView.Init(requestModel:  this);
        }
        public override void Hide()
        {
            if(true == 0)
            {
                    return;
            }
            
            7825.Recycle<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatJoinRequestView>(item:  this.messageView);
            this.messageView = 0;
            mem[1152921519001991888] = 0;
            this.SetSequence(animationSeq:  0);
        }
    
    }

}
