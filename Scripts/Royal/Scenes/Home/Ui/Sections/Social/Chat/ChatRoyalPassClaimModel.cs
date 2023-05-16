using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Chat
{
    public class ChatRoyalPassClaimModel : ChatScrollItemModel
    {
        // Fields
        public bool canClaim;
        public bool didAddCoin;
        public long purchaseDate;
        public Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatRoyalPassClaimView claimView;
        
        // Properties
        public override Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemView View { get; }
        
        // Methods
        public override Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemView get_View()
        {
            return (Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScrollItemView)this.claimView;
        }
        public ChatRoyalPassClaimModel(UnityEngine.Transform parent, long userId, string userName, long purchaseDate, bool canClaim)
        {
            bool val_1 = canClaim;
            this.canClaim = val_1;
            this.purchaseDate = purchaseDate;
            mem[1152921519007804804] = val_1;
            mem[1152921519007804808] = 0;
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
            
            this.claimView = 7853.Spawn<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatRoyalPassClaimView>(poolId:  4, parent:  null);
            this.Show();
            this.claimView.Init(reqModel:  this);
        }
        public override void Hide()
        {
            if(true == 0)
            {
                    return;
            }
            
            mem[1152921519008204336] = 0;
            if(this.claimView.rootSequence != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.claimView.rootSequence, complete:  true);
                this.claimView = 0;
            }
            
            this.claimView.CancelInvoke();
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            this.claimView.root.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.claimView.root.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.claimView.root.Recycle<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatRoyalPassClaimView>(item:  this.claimView);
            this.claimView = 0;
            mem[1152921519008204336] = 0;
            this.SetSequence(animationSeq:  0);
        }
    
    }

}
