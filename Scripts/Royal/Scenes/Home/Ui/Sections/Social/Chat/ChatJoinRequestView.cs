using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Chat
{
    public class ChatJoinRequestView : ChatScrollItemView
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.GoldNickName goldNickName;
        public TMPro.TextMeshPro infoText;
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.Sprite defaultBackgroundSprite;
        public UnityEngine.Sprite royalPassBackgroundSprite;
        private Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatJoinRequestModel requestModel;
        
        // Methods
        public void Init(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatJoinRequestModel requestModel)
        {
            this.requestModel = requestModel;
            UnityEngine.Color val_2 = this.goldNickName.nick.color;
            this.goldNickName.SetNickName(nickName:  X22, isGold:  (requestModel.isGold == true) ? 1 : 0, nickColor:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a}, borderType:  1);
            this.infoText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "wants to join the team!");
            UnityEngine.Vector3 val_5 = Royal.Infrastructure.Utils.Text.TextMeshProExtensions.GetVisibleEndPosition(tmp:  this.goldNickName.nick, local:  true);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            this.infoText.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            this.ArrangeRoyalPass();
        }
        private void ArrangeRoyalPass()
        {
            var val_3;
            var val_1 = (this.requestModel.isGold == false) ? 48 : 56;
            this.background.sprite = null;
            if(this.requestModel.isGold != false)
            {
                    val_3 = 0;
            }
            else
            {
                    val_3 = 0;
            }
            
            UnityEngine.Color val_2 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            this.infoText.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        }
        public override int GetPoolId()
        {
            return 1;
        }
        public void YesButtonClicked()
        {
            this.UpdateMember(operationType:  0);
            this.requestModel.onRemoveSelf.Invoke(obj:  this.requestModel);
        }
        public void NoButtonClicked()
        {
            this.UpdateMember(operationType:  1);
            this.requestModel.onRemoveSelf.Invoke(obj:  this.requestModel);
        }
        private void UpdateMember(Royal.Infrastructure.Services.Backend.Protocol.TeamMemberOperationType operationType)
        {
            bool val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).Send(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.Social.UpdateTeamMemberCommand(teamId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg, userId:  X23, type:  operationType), onComplete:  0, syncRequired:  false);
        }
        public ChatJoinRequestView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
