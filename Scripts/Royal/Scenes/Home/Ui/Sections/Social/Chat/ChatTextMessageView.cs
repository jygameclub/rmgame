using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Chat
{
    public class ChatTextMessageView : ChatScrollItemView
    {
        // Fields
        public const float BackgroundHeight = 1.82;
        public const float ExtraLineHeight = 0.42;
        public UnityEngine.Sprite whiteBg;
        public UnityEngine.Sprite greenBg;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.GoldNickName goldNickName;
        public TMPro.TextMeshPro messageText;
        public TMPro.TextMeshPro timeText;
        public UnityEngine.SpriteRenderer background;
        private Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatTextMessageModel textModel;
        
        // Methods
        public void Init(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatTextMessageModel textModel)
        {
            string val_6;
            TMPro.TextMeshPro val_7;
            this.textModel = textModel;
            this.goldNickName.SetNickName(nickName:  textModel, isGold:  textModel.isGold, borderType:  0);
            val_6 = textModel.text;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic != false)
            {
                    string val_1 = I2.Loc.RTLFixer.Fix(str:  val_6, rtl:  true);
                val_7 = this;
                this.messageText.text = val_1;
                val_6 = this.messageText.ConvertLinesVertical(str:  val_1, lines:  0);
            }
            else
            {
                    val_7 = this.messageText;
            }
            
            string val_3 = Royal.Infrastructure.Utils.Text.EmojiHelper.ReplaceWithCustomEmojis(str:  val_6);
            if((textModel.displayTime != false) && (mem[this.messageText] >= 1))
            {
                    if((Royal.Infrastructure.Utils.Time.TimeUtil.HasNegativeValue(time:  mem[this.messageText])) == false)
            {
                goto label_16;
            }
            
            }
            
            label_20:
            this.timeText.text = System.String.alignConst;
            this.ArrangeSize();
            return;
            label_16:
            string val_5 = Royal.Infrastructure.Utils.Time.TimeUtil.GetPassedTimeInFormat(time:  textModel);
            if(this.timeText != null)
            {
                goto label_20;
            }
            
            throw new NullReferenceException();
        }
        public override int GetPoolId()
        {
            return 2;
        }
        public float CalculateAndGetSize(string text)
        {
            string val_5;
            TMPro.TextMeshPro val_6;
            val_5 = text;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic != false)
            {
                    string val_1 = I2.Loc.RTLFixer.Fix(str:  val_5, rtl:  true);
                val_6 = this;
                this.messageText.text = val_1;
                val_5 = this.messageText.ConvertLinesVertical(str:  val_1, lines:  0);
            }
            else
            {
                    val_6 = this.messageText;
            }
            
            string val_3 = Royal.Infrastructure.Utils.Text.EmojiHelper.ReplaceWithCustomEmojis(str:  val_5);
            float val_4 = this.CalculateHeightOffset();
            val_4 = val_4 + 1.82f;
            return (float)val_4;
        }
        private string ConvertLinesVertical(string str, TMPro.TMP_LineInfo[] lines)
        {
            string val_9;
            var val_10;
            System.Text.StringBuilder val_1 = null;
            val_9 = 0;
            val_1 = new System.Text.StringBuilder();
            int val_8 = lines.Length;
            if(<0)
            {
                goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
            }
            
            int val_3 = val_8 & 4294967295;
            var val_9 = (long)val_8 - 1;
            val_10 = val_8 - 2;
            val_8 = lines + (val_9 * 92);
            var val_4 = val_8 + 60;
            label_10:
            if(((((((long)(int)((lines.Length - 1)) * 92) + lines + 60) + -8) < str.m_stringLength) && (val_4 < str.m_stringLength)) && (val_4 != 0))
            {
                    lines = (1 - ((((long)(int)((lines.Length - 1)) * 92) + lines + 60) + -8)) + val_4;
                val_9 = str.Substring(startIndex:  (((long)(int)((lines.Length - 1)) * 92) + lines + 60) + -8, length:  lines);
                System.Text.StringBuilder val_7 = val_1.AppendLine(value:  val_9);
            }
            
            if((val_10 & 2147483648) != 0)
            {
                goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
            }
            
            val_9 = val_9 - 1;
            val_10 = val_10 - 1;
            val_4 = val_4 - 92;
            if(val_9 < lines.Length)
            {
                goto label_10;
            }
            
            val_9 = 0;
            throw new IndexOutOfRangeException();
        }
        private float CalculateHeightOffset()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic != false)
            {
                    UnityEngine.Rect val_2 = this.messageText.rectTransform.rect;
                this = this.messageText;
                UnityEngine.Vector2 val_4 = this.GetPreferredValues(text:  this.text, width:  val_2.m_XMin, height:  val_2.m_XMin);
                float val_6 = -0.5f;
                val_6 = val_4.y + val_6;
                return (float)val_7;
            }
            
            string val_5 = this.messageText.text;
            float val_7 = 0.42f;
            val_7 = (1.152922E+18f) * val_7;
            return (float)val_7;
        }
        private void ArrangeSize()
        {
            float val_1 = this.CalculateHeightOffset();
            this.ArrangeBackground(heightOffset:  val_1);
            var val_3 = (this.textModel == 0) ? 1 : 0;
            float val_14 = 1.42f;
            val_14 = val_1 + val_14;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  36529912 + this.textModel == null ? 1 : 0, y:  val_14);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            this.goldNickName.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            var val_7 = (this.textModel == 0) ? 1 : 0;
            float val_15 = 1.018f;
            val_15 = val_1 + val_15;
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  36529920 + this.textModel == null ? 1 : 0, y:  val_15);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            this.messageText.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            var val_11 = (this.textModel == 0) ? 1 : 0;
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  36529928 + this.textModel == null ? 1 : 0, y:  0.571f);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
            this.timeText.transform.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        }
        private void ArrangeBackground(float heightOffset)
        {
            var val_2;
            UnityEngine.Vector2 val_1 = this.background.size;
            float val_2 = 1.82f;
            val_2 = heightOffset + val_2;
            this.background.size = new UnityEngine.Vector2() {x = val_1.x, y = val_2};
            if(this.textModel != null)
            {
                    this.background.sprite = this.greenBg;
                val_2 = 1;
            }
            else
            {
                    this.background.sprite = this.whiteBg;
                val_2 = 0;
            }
            
            this.background.flipX = false;
        }
        public ChatTextMessageView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
