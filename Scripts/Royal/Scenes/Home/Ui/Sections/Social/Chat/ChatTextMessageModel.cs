using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Chat
{
    public class ChatTextMessageModel : ChatScrollItemModel
    {
        // Fields
        public readonly string text;
        public readonly bool displayTime;
        public Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatTextMessageView messageView;
        public bool isGold;
        
        // Properties
        public override Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemView View { get; }
        
        // Methods
        public override Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemView get_View()
        {
            return (Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemView)this.messageView;
        }
        public ChatTextMessageModel(UnityEngine.Transform parent, long userId, string userName, long createDate, string text, bool isGold, bool displayTime)
        {
            this.text = text;
            this.displayTime = displayTime;
            this.isGold = isGold;
        }
        public void CalculateSize(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatTextMessageView dummyView)
        {
            mem[1152921519018318316] = dummyView.CalculateAndGetSize(text:  this.text);
        }
        public override void Show()
        {
            if(true != 0)
            {
                    return;
            }
            
            if(true != 0)
            {
                    return;
            }
            
            this.messageView = 7890.Spawn<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatTextMessageView>(poolId:  2, parent:  null);
            this.Show();
            this.messageView.Init(textModel:  this);
        }
        public override void Hide()
        {
            if(true == 0)
            {
                    return;
            }
            
            7889.Recycle<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatTextMessageView>(item:  this.messageView);
            this.messageView = 0;
            mem[1152921519018572048] = 0;
            this.SetSequence(animationSeq:  0);
        }
    
    }

}
