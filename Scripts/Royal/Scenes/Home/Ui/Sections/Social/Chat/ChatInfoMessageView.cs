using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Chat
{
    public class ChatInfoMessageView : ChatScrollItemView
    {
        // Fields
        public static readonly UnityEngine.Color greenTextColor;
        public static readonly UnityEngine.Color blueTextColor;
        public UnityEngine.Sprite greenBg;
        public UnityEngine.Sprite blueBg;
        public TMPro.TextMeshPro text;
        public UnityEngine.SpriteRenderer bgLeft;
        public UnityEngine.SpriteRenderer bgRight;
        private Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageModel infoMessage;
        
        // Methods
        public void Init(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageModel infoMessage)
        {
            var val_2;
            var val_3;
            UnityEngine.Sprite val_4;
            var val_5;
            this.infoMessage = infoMessage;
            val_2 = null;
            if(infoMessage.chatMessageType == 1)
            {
                    val_3 = null;
                this.text.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageView.greenTextColor, g = Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageView.greenTextColor.__il2cppRuntimeField_4, b = Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageView.greenTextColor.__il2cppRuntimeField_8, a = Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageView.greenTextColor.__il2cppRuntimeField_C};
                this.bgLeft.sprite = this.greenBg;
                val_4 = this.greenBg;
            }
            else
            {
                    val_5 = null;
                this.text.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageView.blueTextColor, g = Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageView.greenTextColor.__il2cppRuntimeField_14, b = Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageView.greenTextColor.__il2cppRuntimeField_18, a = Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageView.greenTextColor.__il2cppRuntimeField_1C};
                this.bgLeft.sprite = this.blueBg;
                val_4 = this.blueBg;
            }
            
            this.bgRight.sprite = val_4;
            this.text.text = this.bgRight.GetText(chatMessageType:  infoMessage.chatMessageType, userName:  0, actionOwner:  infoMessage.actionOwner);
        }
        public override int GetPoolId()
        {
            return 0;
        }
        private string GetText(Royal.Infrastructure.Services.Backend.Protocol.ChatMessageType chatMessageType, string userName, string actionOwner)
        {
            string val_7;
            string val_8;
            Royal.Infrastructure.Services.Backend.Protocol.ChatMessageType val_1 = chatMessageType & 255;
            if(val_1 == 2)
            {
                goto label_1;
            }
            
            if(val_1 != 1)
            {
                    return "";
            }
            
            if((System.String.IsNullOrEmpty(value:  actionOwner)) == false)
            {
                goto label_3;
            }
            
            val_7 = "joined the team!";
            return userName + " " + Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_7 = "has left the team!")(Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_7 = "has left the team!"));
            label_1:
            if((System.String.IsNullOrEmpty(value:  actionOwner)) == false)
            {
                goto label_5;
            }
            
            return userName + " " + Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_7)(Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_7));
            label_3:
            val_8 = "was accepted to the team by";
            return System.String.Format(format:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_8 = "has been kicked out by"), arg0:  userName, arg1:  actionOwner);
            label_5:
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic != false)
            {
                    return I2.Loc.LocalizationManager.ApplyRTLfix(line:  System.String.Format(format:  "{1} طرد !{0}", arg0:  userName, arg1:  actionOwner));
            }
            
            return System.String.Format(format:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_8), arg0:  userName, arg1:  actionOwner);
        }
        public ChatInfoMessageView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private static ChatInfoMessageView()
        {
            Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageView.greenTextColor = 0;
            Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatInfoMessageView.blueTextColor = 0;
        }
    
    }

}
