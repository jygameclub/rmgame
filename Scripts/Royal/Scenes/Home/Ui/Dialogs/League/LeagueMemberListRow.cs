using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.League
{
    public class LeagueMemberListRow : UiScrollContentItem
    {
        // Fields
        public TMPro.TextMeshPro index;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.GoldNickName goldNickName;
        public TMPro.TextMeshPro teamName;
        public Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoView teamLogo;
        public TMPro.TextMeshPro level;
        public TMPro.TextMeshPro coinsAmount;
        public TMPro.TextMeshPro hammerAmount;
        public UnityEngine.SpriteRenderer medal;
        public UnityEngine.SpriteRenderer coins;
        public UnityEngine.GameObject coinReward;
        public UnityEngine.GameObject hammerReward;
        public UnityEngine.BoxCollider2D boxCollider;
        public UnityEngine.SpriteRenderer[] backgrounds;
        public UnityEngine.SpriteRenderer[] levelBackgrounds;
        public UnityEngine.Sprite[] coinSprites;
        public UnityEngine.Sprite[] medalSprites;
        public UnityEngine.Sprite[] backgroundSprites;
        public UnityEngine.Sprite[] levelBackgroundSprites;
        private static readonly UnityEngine.Vector3 UserNameWithTeamPosition;
        private static readonly UnityEngine.Vector3 UserNameWithNoTeamPosition;
        private static readonly UnityEngine.Color MyNameColor;
        private static readonly UnityEngine.Color OtherNameColor;
        private static readonly UnityEngine.Color MyTeamColor;
        private static readonly UnityEngine.Color OtherTeamColor;
        private int order;
        private long teamId;
        private long userId;
        private bool isMyBottomView;
        private Royal.Player.Context.Units.LeagueManager leagueManager;
        public static Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListScroll scroll;
        
        // Methods
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
            data.System.IDisposable.Dispose();
            this.UpdateView(memberData:  new Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRowData() {order = 524918784, leader = new Royal.Infrastructure.Services.Storage.Tables.Leader() {<UserId>k__BackingField = 1152921505131765760, <UserName>k__BackingField = data, <TeamId>k__BackingField = ???, <TeamName>k__BackingField = ???, <TeamLogo>k__BackingField = ???, <Level>k__BackingField = ???, <LeagueLevel>k__BackingField = ???, <LevelUpdateTime>k__BackingField = ???, <FacebookId>k__BackingField = ???, <IsGold>k__BackingField = false}, isMyUser = true}, myBottomRow:  false);
            this.userId = data;
        }
        public void UpdateView(Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRowData memberData, bool myBottomRow)
        {
            Royal.Player.Context.Units.LeagueManager val_18;
            System.Int32[] val_19;
            var val_20;
            TMPro.TextMeshPro val_21;
            var val_22;
            var val_23;
            var val_25;
            var val_26;
            var val_27;
            UnityEngine.Color val_28;
            UnityEngine.Sprite val_32;
            var val_33;
            var val_34;
            val_18 = this.leagueManager;
            this.isMyBottomView = myBottomRow;
            this.teamId = memberData.leader.<TeamName>k__BackingField;
            this.leagueManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5);
            this.order = memberData.order;
            if(memberData.order <= 3)
            {
                goto label_4;
            }
            
            this.index.enabled = true;
            this.medal.enabled = false;
            this.index.text = this.order.ToString();
            this.coinReward.SetActive(value:  false);
            if(memberData.order <= 10)
            {
                goto label_10;
            }
            
            this.hammerReward.SetActive(value:  false);
            goto label_11;
            label_4:
            this.index.enabled = false;
            this.medal.enabled = true;
            int val_18 = this.order;
            val_18 = val_18 - 1;
            this.medal.sprite = this.medalSprites[val_18];
            this.coinReward.SetActive(value:  true);
            this.hammerReward.SetActive(value:  false);
            int val_20 = this.order;
            val_20 = val_20 - 1;
            this.coins.sprite = this.coinSprites[val_20];
            val_19 = this.leagueManager.rewards.amounts;
            val_20 = this.order - 1;
            val_21 = this.coinsAmount;
            goto label_26;
            label_10:
            this.hammerReward.SetActive(value:  true);
            val_19 = this.leagueManager.rewards.amounts;
            val_20 = this.order - 1;
            val_21 = this.hammerAmount;
            label_26:
            val_21.text = val_19[val_20][32].ToString();
            label_11:
            if(this.teamId >= 1)
            {
                    this.teamLogo.InitById(logoId:  memberData.leader.<LeagueLevel>k__BackingField);
                val_22 = this.goldNickName.transform;
                val_23 = null;
                val_23 = null;
            }
            else
            {
                    this.teamLogo.InitWithEmptyYellowBackground();
                val_22 = this.goldNickName.transform;
                val_25 = null;
                val_25 = null;
            }
            
            val_22.localPosition = new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.UserNameWithNoTeamPosition, y = Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.UserNameWithTeamPosition.__il2cppRuntimeField_10, z = Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.UserNameWithTeamPosition.__il2cppRuntimeField_14};
            this.teamName.text = memberData.leader.<TeamLogo>k__BackingField;
            this.level.text = memberData.leader.<LevelUpdateTime>k__BackingField.ToString();
            if(mem[1152921519401541944] != false)
            {
                    if(this.isMyBottomView != true)
            {
                    val_26 = null;
                val_26 = null;
                Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.scroll = 1;
                Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.scroll = this.transform;
            }
            
                val_27 = null;
                val_27 = null;
                val_28 = Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.MyNameColor;
                this.teamName.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.MyTeamColor, g = Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.UserNameWithTeamPosition.__il2cppRuntimeField_3C, b = Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.UserNameWithTeamPosition.__il2cppRuntimeField_40, a = Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.UserNameWithTeamPosition.__il2cppRuntimeField_44};
                this.backgrounds[0].sprite = this.backgroundSprites[1];
                this.backgrounds[1].sprite = this.backgroundSprites[1];
                this.levelBackgrounds[0].sprite = this.levelBackgroundSprites[1];
                UnityEngine.SpriteRenderer val_28 = this.levelBackgrounds[1];
                val_32 = this.levelBackgroundSprites[1];
            }
            else
            {
                    val_33 = null;
                val_33 = null;
                Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.scroll = 0;
                Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.scroll = this.transform;
                val_34 = null;
                val_34 = null;
                val_28 = Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.OtherNameColor;
                this.teamName.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.OtherTeamColor, g = Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.UserNameWithTeamPosition.__il2cppRuntimeField_4C, b = Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.UserNameWithTeamPosition.__il2cppRuntimeField_50, a = Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.UserNameWithTeamPosition.__il2cppRuntimeField_54};
                this.backgrounds[0].sprite = this.backgroundSprites[0];
                this.backgrounds[1].sprite = this.backgroundSprites[0];
                this.levelBackgrounds[0].sprite = this.levelBackgroundSprites[0];
                val_32 = this.levelBackgroundSprites[0];
            }
            
            this.levelBackgrounds[1].sprite = val_32;
            this.teamName.renderer.enabled = (~(System.String.IsNullOrEmpty(value:  this.teamName.text))) & 1;
            this.goldNickName.SetNickName(nickName:  memberData.leader.<TeamId>k__BackingField, isGold:  (mem[1152921519401541936] == true) ? 1 : 0, nickColor:  new UnityEngine.Color() {r = val_28, g = Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.UserNameWithTeamPosition.__il2cppRuntimeField_2C, b = Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.UserNameWithTeamPosition.__il2cppRuntimeField_30, a = Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.UserNameWithTeamPosition.__il2cppRuntimeField_34}, borderType:  0);
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).IsInnerFlowExecuting()) != true)
            {
                    if(Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListScroll.isClaimButtonActive == false)
            {
                goto label_113;
            }
            
            }
            
            label_115:
            this.boxCollider.enabled = (this.isMyBottomView == true) ? 1 : 0;
            return;
            label_113:
            if(this.boxCollider != null)
            {
                goto label_115;
            }
            
            throw new NullReferenceException();
        }
        public void ShowAction()
        {
            var val_2;
            if(this.isMyBottomView != false)
            {
                    val_2 = null;
                val_2 = null;
                Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.scroll.AutoScrollToMyPosition(order:  this.order);
                return;
            }
            
            if(Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListScroll.isClaimButtonActive != false)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ToggleViewTeamButton(teamId:  this.teamId, parent:  this.transform, xPosition:  -3.151f, bottomOffset:  4f);
        }
        public LeagueMemberListRow()
        {
        
        }
        private static LeagueMemberListRow()
        {
            Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.UserNameWithTeamPosition = 0;
            Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.UserNameWithTeamPosition.__il2cppRuntimeField_8 = 0;
            Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.UserNameWithNoTeamPosition = 0;
            Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.UserNameWithTeamPosition.__il2cppRuntimeField_14 = 0;
            Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.MyNameColor = 0;
            Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.OtherNameColor = 0;
            Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.MyTeamColor = 0;
            Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.OtherTeamColor = 0;
        }
    
    }

}
