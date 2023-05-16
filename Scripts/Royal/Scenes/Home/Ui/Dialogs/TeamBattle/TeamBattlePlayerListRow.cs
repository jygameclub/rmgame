using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.TeamBattle
{
    public class TeamBattlePlayerListRow : UiScrollContentItem
    {
        // Fields
        public UnityEngine.GameObject playerGo;
        public UnityEngine.GameObject notContributingGo;
        public UnityEngine.GameObject notParticipatingGo;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.GoldNickName nickName;
        public TMPro.TextMeshPro index;
        public TMPro.TextMeshPro level;
        public UnityEngine.SpriteRenderer medal;
        public UnityEngine.GameObject firstReward;
        public UnityEngine.GameObject secondReward;
        public UnityEngine.GameObject thirdReward;
        public UnityEngine.GameObject rewardText;
        public UnityEngine.SpriteRenderer[] backgrounds;
        public UnityEngine.SpriteRenderer[] levelBackgrounds;
        public UnityEngine.Sprite[] medalSprites;
        public UnityEngine.Sprite[] backgroundSprites;
        public UnityEngine.Sprite[] levelBackgroundSprites;
        public static long myUserId;
        public static Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListScroll scroll;
        private static readonly UnityEngine.Color MyNameColor;
        private static readonly UnityEngine.Color OtherNameColor;
        private int order;
        private long userId;
        private bool isMyBottomView;
        private bool canHaveReward;
        
        // Methods
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
            if(null != null)
            {
                    data.System.IDisposable.Dispose();
                this.UpdateView(memberData:  new Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRowData() {order = 524918784, leader = new Royal.Infrastructure.Services.Storage.Tables.Leader() {<UserId>k__BackingField = 1152921505131765760, <UserName>k__BackingField = data, <TeamId>k__BackingField = ???, <TeamName>k__BackingField = ???, <TeamLogo>k__BackingField = ???, <Level>k__BackingField = ???, <LeagueLevel>k__BackingField = ???, <LevelUpdateTime>k__BackingField = ???, <FacebookId>k__BackingField = ???, <IsGold>k__BackingField = false}}, myBottomRow:  false);
                this.userId = data;
                return;
            }
            
            data.System.IDisposable.Dispose();
            this.UpdateView(seperatorData:  new Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerSeparatorData() {isContribution = false, isParticipation = true});
        }
        private void UpdateView(Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerSeparatorData seperatorData)
        {
            var val_4;
            this.playerGo.SetActive(value:  false);
            this.notContributingGo.SetActive(value:  (seperatorData.isContribution != true) ? 1 : 0);
            this.notParticipatingGo.SetActive(value:  (seperatorData.isContribution != true) ? 1 : 0);
            val_4 = null;
            val_4 = null;
            if(this.userId == Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.myUserId)
            {
                    Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.scroll = 0;
                Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.scroll = this.transform;
            }
            
            this.userId = 0;
        }
        public void UpdateView(Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRowData memberData, bool myBottomRow)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            long val_19;
            var val_21;
            UnityEngine.Color val_22;
            UnityEngine.Sprite val_26;
            var val_27;
            this.playerGo.SetActive(value:  true);
            this.notContributingGo.SetActive(value:  false);
            this.notParticipatingGo.SetActive(value:  false);
            this.isMyBottomView = myBottomRow;
            this.order = memberData.order;
            float val_2 = UnityEngine.Mathf.Max(a:  0f, b:  (float)mem[1152921519171048996]);
            this.canHaveReward = (val_2 > 0f) ? 1 : 0;
            if(val_2 <= 0f)
            {
                goto label_6;
            }
            
            var val_4 = (memberData.order == 1) ? 1 : 0;
            if(this.firstReward != null)
            {
                goto label_7;
            }
            
            label_6:
            val_13 = 0;
            label_7:
            this.firstReward.SetActive(value:  false);
            if(this.canHaveReward == false)
            {
                goto label_10;
            }
            
            var val_5 = (memberData.order == 2) ? 1 : 0;
            if(this.secondReward != null)
            {
                goto label_11;
            }
            
            label_10:
            val_14 = 0;
            label_11:
            this.secondReward.SetActive(value:  false);
            if(this.canHaveReward == false)
            {
                goto label_14;
            }
            
            var val_6 = (memberData.order == 3) ? 1 : 0;
            if(this.thirdReward != null)
            {
                goto label_15;
            }
            
            label_14:
            val_15 = 0;
            label_15:
            this.thirdReward.SetActive(value:  false);
            if(this.canHaveReward == false)
            {
                goto label_18;
            }
            
            var val_7 = (memberData.order < 4) ? 1 : 0;
            if(this.rewardText != null)
            {
                goto label_19;
            }
            
            label_18:
            val_16 = 0;
            label_19:
            this.rewardText.SetActive(value:  false);
            if(memberData.order > 3)
            {
                    this.index.enabled = true;
                this.medal.enabled = false;
                this.index.text = memberData.order.ToString();
            }
            else
            {
                    this.index.enabled = false;
                this.medal.enabled = true;
                int val_13 = memberData.order;
                val_13 = val_13 - 1;
                this.medal.sprite = this.medalSprites[val_13];
            }
            
            this.level.text = val_2.ToString();
            val_17 = null;
            val_17 = null;
            val_19 = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.myUserId;
            if((memberData.leader.<UserName>k__BackingField) == val_19)
            {
                    if(this.isMyBottomView != true)
            {
                    Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.scroll = 1;
                Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.scroll = this.transform;
                val_21 = null;
            }
            
                val_21 = null;
                val_22 = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.MyNameColor;
                this.backgrounds[0].sprite = this.backgroundSprites[1];
                this.backgrounds[1].sprite = this.backgroundSprites[1];
                this.levelBackgrounds[0].sprite = this.levelBackgroundSprites[1];
                UnityEngine.SpriteRenderer val_21 = this.levelBackgrounds[1];
                val_26 = this.levelBackgroundSprites[1];
            }
            else
            {
                    val_27 = null;
                val_19 = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.myUserId;
                if(this.userId == val_19)
            {
                    Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.scroll = 0;
                Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.scroll = this.transform;
                val_27 = null;
            }
            
                val_27 = null;
                val_22 = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.OtherNameColor;
                this.backgrounds[0].sprite = this.backgroundSprites[0];
                this.backgrounds[1].sprite = this.backgroundSprites[0];
                this.levelBackgrounds[0].sprite = this.levelBackgroundSprites[0];
                val_26 = this.levelBackgroundSprites[0];
            }
            
            this.levelBackgrounds[1].sprite = val_26;
            this.nickName.SetNickName(nickName:  memberData.leader.<TeamId>k__BackingField, isGold:  (mem[1152921519171049024] == true) ? 1 : 0, nickColor:  new UnityEngine.Color() {r = val_22, g = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.myUserId.__il2cppRuntimeField_24, b = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.myUserId.__il2cppRuntimeField_28, a = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.myUserId.__il2cppRuntimeField_2C}, borderType:  0);
        }
        public void ShowAction()
        {
            var val_1;
            if(this.isMyBottomView == false)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.scroll.AutoScrollToMyPosition(order:  this.order);
        }
        public void ShowRewardTooltip(Royal.Infrastructure.UiComponents.Button.UiButton button)
        {
            Royal.Scenes.Game.Ui.Dialogs.ToolTipManager val_9;
            Royal.Infrastructure.UiComponents.Touch.ITouchable val_10;
            var val_11;
            val_10 = button;
            if(this.order > 3)
            {
                    return;
            }
            
            if(this.canHaveReward == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = val_10.transform.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            Royal.Infrastructure.UiComponents.Dialog.DialogManager val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            val_9 = val_4.toolTipManager;
            val_11 = null;
            val_11 = null;
            val_10 = val_9.ToggleTooltip(parent:  this.transform, touchable:  val_10, pos:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, toolTip:  Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.scroll.tooltipPrefab);
            if(val_10 == 0)
            {
                    return;
            }
            
            val_10.GetComponent<Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleRewardTooltip>().ArrangePosition(forTeam:  false, atDown:  true);
        }
        public TeamBattlePlayerListRow()
        {
        
        }
        private static TeamBattlePlayerListRow()
        {
            Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.MyNameColor = 0;
            Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.OtherNameColor = 0;
        }
    
    }

}
