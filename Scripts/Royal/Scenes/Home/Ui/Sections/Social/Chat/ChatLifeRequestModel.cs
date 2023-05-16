using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Chat
{
    public class ChatLifeRequestModel : ChatScrollItemModel
    {
        // Fields
        public bool canHelp;
        public long timeToHelpLifeAfterBan;
        public bool didAddCoin;
        public int currentHelpCount;
        public readonly bool isRoyalPassGold;
        public Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestView lifeView;
        
        // Properties
        public override Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemView View { get; }
        
        // Methods
        public override Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemView get_View()
        {
            return (Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemView)this.lifeView;
        }
        public ChatLifeRequestModel(UnityEngine.Transform parent, long userId, string userName, long createDate, int helpCount, bool canHelp, bool isRoyalPassGold)
        {
            this.canHelp = canHelp;
            this.isRoyalPassGold = isRoyalPassGold;
            this.currentHelpCount = helpCount;
            this.timeToHelpLifeAfterBan = X8 + 56;
            mem[1152921519003193516] = 1077756373;
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
            
            this.lifeView = 7832.Spawn<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestView>(poolId:  3, parent:  null);
            this.Show();
            this.lifeView.Init(reqModel:  this);
        }
        public override void Hide()
        {
            if(true == 0)
            {
                    return;
            }
            
            mem[1152921519003593040] = 0;
            if(this.lifeView.rootSequence != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.lifeView.rootSequence, complete:  true);
                this.lifeView = 0;
            }
            
            this.lifeView.CancelInvoke();
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            this.lifeView.root.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.lifeView.root.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.lifeView.root.Recycle<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatLifeRequestView>(item:  this.lifeView);
            this.lifeView = 0;
            mem[1152921519003593040] = 0;
            this.SetSequence(animationSeq:  0);
        }
    
    }

}
