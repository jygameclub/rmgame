using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.MyTeam
{
    public class TeamMemberListRow : UiScrollContentItem
    {
        // Fields
        public TMPro.TextMeshPro index;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.GoldNickName goldNickName;
        public TMPro.TextMeshPro helps;
        public TMPro.TextMeshPro level;
        public TMPro.TextMeshPro leagueLevel;
        public TMPro.TextMeshPro leader;
        public UnityEngine.SpriteRenderer medal;
        public UnityEngine.SpriteRenderer leaderSign;
        public UnityEngine.GameObject helpContainer;
        public UnityEngine.Transform crownContainer;
        public Royal.Infrastructure.UiComponents.Button.UiScrollButton rowButton;
        public TMPro.TextMeshPro[] labels;
        public UnityEngine.SpriteRenderer[] backgrounds;
        public UnityEngine.SpriteRenderer[] helpBackgrounds;
        public UnityEngine.SpriteRenderer[] crownBackgrounds;
        public UnityEngine.Sprite[] medalSprites;
        public UnityEngine.Sprite[] backgroundSprites;
        public UnityEngine.Sprite[] helpBackgroundSprites;
        private static readonly UnityEngine.Color MyNameColor;
        private static readonly UnityEngine.Color OtherNameColor;
        private static readonly UnityEngine.Color MyLabelColor;
        private static readonly UnityEngine.Color OtherLabelColor;
        private static readonly UnityEngine.Color MyHelpsColor;
        private static readonly UnityEngine.Color OtherHelpsColor;
        private readonly UnityEngine.Vector3 crownPositionInMyTeam;
        private long userId;
        private bool isLeader;
        private bool isCoLeader;
        private string userName;
        
        // Methods
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
            var val_22;
            UnityEngine.Color val_24;
            float val_26;
            UnityEngine.Sprite val_30;
            bool val_32;
            this.rowButton = maskBounds.m_Extents.y;
            this.rowButton = maskBounds.m_Center.x;
            data.System.IDisposable.Dispose();
            val_22 = null;
            val_22 = null;
            val_24 = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.OtherNameColor;
            if((???) != 0)
            {
                    if((???) != 0)
            {
                    this.helps.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyHelpsColor, g = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_44, b = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_48, a = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_4C};
                this.labels[0].color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyLabelColor, g = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_24, b = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_28, a = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_2C};
                this.labels[1].color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyLabelColor, g = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_24, b = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_28, a = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_2C};
                this.backgrounds[0].sprite = this.backgroundSprites[1];
                this.backgrounds[1].sprite = this.backgroundSprites[1];
                this.helpBackgrounds[0].sprite = this.helpBackgroundSprites[1];
                this.helpBackgrounds[1].sprite = this.helpBackgroundSprites[1];
                this.crownBackgrounds[0].sprite = this.helpBackgroundSprites[1];
                UnityEngine.SpriteRenderer val_33 = this.crownBackgrounds[1];
                val_30 = this.helpBackgroundSprites[1];
            }
            else
            {
                    val_24 = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.OtherNameColor;
                this.helps.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.OtherHelpsColor, g = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_54, b = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_58, a = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_5C};
                this.labels[0].color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.OtherLabelColor, g = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_34, b = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_38, a = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_3C};
                this.labels[1].color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.OtherLabelColor, g = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_34, b = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_38, a = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_3C};
                this.backgrounds[0].sprite = this.backgroundSprites[0];
                this.backgrounds[1].sprite = this.backgroundSprites[0];
                this.helpBackgrounds[0].sprite = this.helpBackgroundSprites[0];
                this.helpBackgrounds[1].sprite = this.helpBackgroundSprites[0];
                this.crownBackgrounds[0].sprite = this.helpBackgroundSprites[0];
                val_30 = this.helpBackgroundSprites[0];
            }
            
                this.crownBackgrounds[1].sprite = val_30;
                this.helpContainer.SetActive(value:  true);
                this.helps.text = ???.ToString();
                this.userId = 1152921505131765760;
                this.userName = null;
                this.isLeader = ((???) != 0) ? 1 : 0;
                this.isCoLeader = ((???) != 0) ? 1 : 0;
                this.crownContainer.localPosition = new UnityEngine.Vector3() {x = this.crownPositionInMyTeam, y = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_34, z = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_38};
            }
            
            this.goldNickName.SetNickName(nickName:  null, isGold:  ((???) != 0) ? 1 : 0, nickColor:  new UnityEngine.Color() {r = val_24, g = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_14, b = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_18, a = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor.__il2cppRuntimeField_1C}, borderType:  0);
            if((???) == 0)
            {
                    if((???) == 0)
            {
                goto label_92;
            }
            
            }
            
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  -1.819f, y:  0.37f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            this.goldNickName.transform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            this.leader.enabled = true;
            if((???) == 0)
            {
                goto label_99;
            }
            
            this.leaderSign.enabled = true;
            this.leader.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Leader");
            UnityEngine.Vector3 val_10 = Royal.Infrastructure.Utils.Text.TextMeshProExtensions.GetVisibleEndPosition(tmp:  this.leader, local:  false);
            val_24 = val_10.x;
            val_26 = val_10.z;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24, y = val_10.y, z = val_26}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.leaderSign.transform.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            goto label_107;
            label_99:
            this.leaderSign.enabled = false;
            this.leader.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Co-leader");
            goto label_107;
            label_92:
            UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  -1.819f, y:  0.12f);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
            this.goldNickName.transform.localPosition = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            this.leader.enabled = false;
            this.leaderSign.enabled = false;
            label_107:
            this.level.text = ???.ToString();
            this.index.enabled = true;
            this.medal.enabled = false;
            this.index.text = Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData.__il2cppRuntimeField_element_class.ToString();
            UnityEngine.GameObject val_18 = this.crownContainer.gameObject;
            if((???) >= 1)
            {
                    val_18.SetActive(value:  true);
                this.leagueLevel.text = ???.ToString();
            }
            else
            {
                    val_18.SetActive(value:  false);
            }
            
            if(this.rowButton == 0)
            {
                    return;
            }
            
            val_32 = Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.<ShouldShowMemberActionView>k__BackingField;
            if(val_32 != false)
            {
                    val_32 = this.isLeader ^ 1;
            }
            
            this.rowButton = val_32;
        }
        public void ShowAction()
        {
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListScroll.ToggleMemberAction(userId:  this.userId, userName:  this.userName, isLeader:  this.isLeader, isCoLeader:  this.isCoLeader, row:  this);
        }
        public TeamMemberListRow()
        {
            this.crownPositionInMyTeam = 0;
            mem[1152921518988048248] = 0;
        }
        private static TeamMemberListRow()
        {
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyNameColor = 0;
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.OtherNameColor = 0;
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyLabelColor = 0;
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.OtherLabelColor = 0;
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.MyHelpsColor = 0;
            Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamMemberListRow.OtherHelpsColor = 0;
        }
    
    }

}
