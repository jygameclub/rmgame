using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Leaderboard.Players
{
    public class PlayersRowView : ARowView
    {
        // Fields
        public UnityEngine.SpriteRenderer[] leagueContainers;
        public UnityEngine.Sprite[] leagueContainerSprites;
        public TMPro.TextMeshPro levelNo;
        public TMPro.TextMeshPro levelLabel;
        public TMPro.TextMeshPro leagueLevelNo;
        public UnityEngine.GameObject leagueContainer;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.GoldNickName goldNickName;
        private static readonly UnityEngine.Vector3 UserNameWithTeamPosition;
        private static readonly UnityEngine.Vector3 UserNameWithNoTeamPosition;
        public long userId;
        private long teamId;
        
        // Methods
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
            this.UpdateView(leaderboardRowData:  data);
        }
        public void UpdateView(Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData leaderboardRowData)
        {
            var val_14;
            int val_15;
            var val_16;
            UnityEngine.Color val_17;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            byte val_25;
            val_14 = 1152921505124790272;
            this.teamId = ;
            this.SetRank(newRank:  leaderboardRowData.rank);
            string val_1 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<UserId>k__BackingField.ToString();
            this.levelNo.text = val_1;
            this.levelNo.text = val_1;
            if(null >= 1)
            {
                    this.leagueContainer.SetActive(value:  true);
                this.leagueLevelNo.text = null.ToString();
            }
            else
            {
                    this.leagueContainer.SetActive(value:  false);
            }
            
            this.KeepMyViewTransform(keep:  true, data:  leaderboardRowData);
            var val_14 = 0;
            do
            {
                System.Void Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView::KeepMyViewTransform(bool keep, Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData data).__il2cppRuntimeField_20.sprite = System.Void Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView::KeepMyViewTransform(bool keep, Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData data).__il2cppRuntimeField_18 + 40;
                val_14 = val_14 + 1;
            }
            while((System.Void Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView::KeepMyViewTransform(bool keep, Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData data)) != 0);
            
            this.KeepMyViewTransform(keep:  false, data:  leaderboardRowData);
            var val_15 = 0;
            do
            {
                Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.PlayersRowView.__il2cppRuntimeField_byval_arg.sprite = Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.__il2cppRuntimeField_20;
                val_15 = val_15 + 1;
            }
            while(null != null);
            
            var val_18 = 0;
            label_37:
            if(val_18 >= this.leagueContainers.Length)
            {
                goto label_32;
            }
            
            this.leagueContainers[val_18].sprite = this.leagueContainerSprites[1];
            val_18 = val_18 + 1;
            if(this.leagueContainers != null)
            {
                goto label_37;
            }
            
            var val_21 = 0;
            label_45:
            if(val_21 >= this.leagueContainers.Length)
            {
                goto label_40;
            }
            
            this.leagueContainers[val_21].sprite = this.leagueContainerSprites[0];
            val_21 = val_21 + 1;
            if(this.leagueContainers != null)
            {
                goto label_45;
            }
            
            label_32:
            val_14 = 1152921505028890624;
            val_16 = null;
            val_16 = null;
            val_17 = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor;
            this.levelLabel.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyLabelColor, g = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_24, b = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_28, a = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_2C};
            this.levelLabel.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyLabelColor, g = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_24, b = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_28, a = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_2C};
            this.teamId = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg;
            Royal.Player.Context.Units.SocialManager val_3 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
            val_15 = val_3.<MyTeamLogo>k__BackingField;
            goto label_57;
            label_40:
            val_21 = null;
            val_21 = null;
            val_17 = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.OtherColor;
            this.levelLabel.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.OtherLabelColor, g = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_34, b = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_38, a = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_3C};
            this.levelLabel.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.OtherLabelColor, g = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_34, b = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_38, a = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_3C};
            label_57:
            this.goldNickName.SetNickName(nickName:  public System.Void TMPro.TMP_Text::set_color(UnityEngine.Color value), isGold:  (Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.__il2cppRuntimeField_static_fields != 0) ? 1 : 0, nickColor:  new UnityEngine.Color() {r = val_17, g = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_14, b = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_18, a = Royal.Scenes.Home.Ui.Sections.Leaderboard.ARowView.MyColor.__il2cppRuntimeField_1C}, borderType:  0);
            if(this.teamId >= 1)
            {
                    this.goldNickName.InitById(logoId:  this.levelNo);
                val_22 = this.goldNickName.transform;
                val_23 = null;
                val_23 = null;
            }
            else
            {
                    this.goldNickName.InitWithEmptyYellowBackground();
                val_22 = this.goldNickName.transform;
                val_24 = null;
                val_24 = null;
            }
            
            val_22.localPosition = new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.PlayersRowView.UserNameWithNoTeamPosition, y = Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.PlayersRowView.UserNameWithTeamPosition.__il2cppRuntimeField_10, z = Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.PlayersRowView.UserNameWithTeamPosition.__il2cppRuntimeField_14};
            this.SetScrollButtonScaleDown(enable:  (this.teamId > 0) ? 1 : 0);
            UnityEngine.Renderer val_8 = this.renderer;
            val_8.enabled = (~(System.String.IsNullOrEmpty(value:  this.teamId))) & 1;
            val_25 = leaderboardRowData.shouldDecreaseNameSize;
            if(val_25 == 0)
            {
                    byte val_11 = Royal.Scenes.Home.Ui.Sections.Leaderboard.Friends.LeaderboardRowData.ShouldDecreaseFontSize(text:  val_8);
                val_25 = val_11;
                leaderboardRowData = val_11;
            }
            
            byte val_12 = val_25 & 255;
            this.goldNickName.nick.fontSizeMax = (val_12 == 2) ? 5f : 5.75f;
            this.userId = val_12;
        }
        private void SetRank(int newRank)
        {
            UnityEngine.Renderer val_1 = this.renderer;
            if(newRank <= 3)
            {
                    val_1.enabled = false;
                val_1.enabled = true;
                var val_3 = X8 + ((newRank - 1) << 3);
                val_1.sprite = (X8 + ((newRank - 1)) << 3) + 32;
                return;
            }
            
            val_1.enabled = true;
            val_1.enabled = false;
            string val_4 = newRank.ToString();
        }
        public void ShowAction()
        {
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ToggleViewTeamButton(teamId:  this.teamId, parent:  this.transform, xPosition:  -3.04f, bottomOffset:  5.5f);
        }
        public PlayersRowView()
        {
            this = new Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem();
        }
        private static PlayersRowView()
        {
            Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.PlayersRowView.UserNameWithTeamPosition = 0;
            Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.PlayersRowView.UserNameWithTeamPosition.__il2cppRuntimeField_8 = 0;
            Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.PlayersRowView.UserNameWithNoTeamPosition = 0;
            Royal.Scenes.Home.Ui.Sections.Leaderboard.Players.PlayersRowView.UserNameWithTeamPosition.__il2cppRuntimeField_14 = 0;
        }
    
    }

}
