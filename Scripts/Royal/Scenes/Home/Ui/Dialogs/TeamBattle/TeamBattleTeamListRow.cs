using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.TeamBattle
{
    public class TeamBattleTeamListRow : UiScrollContentItem
    {
        // Fields
        public TMPro.TextMeshPro index;
        public TMPro.TextMeshPro teamName;
        public Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoView teamLogo;
        public TMPro.TextMeshPro level;
        public UnityEngine.SpriteRenderer medal;
        public UnityEngine.BoxCollider2D boxCollider;
        public TMPro.TextMeshPro coinsAmount;
        public UnityEngine.SpriteRenderer coins;
        public UnityEngine.SpriteRenderer coinExtra;
        public UnityEngine.GameObject coinReward;
        public UnityEngine.SpriteRenderer[] backgrounds;
        public UnityEngine.SpriteRenderer[] levelBackgrounds;
        public static long myTeamId;
        public static Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListScroll scroll;
        private static readonly UnityEngine.Vector3 CoinPositionLower;
        private static readonly UnityEngine.Vector3 CoinPositionUpper;
        private static readonly UnityEngine.Color MyTeamColor;
        private static readonly UnityEngine.Color OtherTeamColor;
        private int order;
        private long oldTeamId;
        private bool isMyBottomView;
        private Royal.Player.Context.Units.TeamBattleManager teamBattleManager;
        
        // Methods
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
            data.System.IDisposable.Dispose();
            this.UpdateView(memberData:  new Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRowData() {leader = new Royal.Infrastructure.Services.Storage.Tables.Leader() {<IsGold>k__BackingField = false}}, myBottomRow:  false);
        }
        public void UpdateView(Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRowData memberData, bool myBottomRow)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            float val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            long val_23;
            var val_25;
            TMPro.TextMeshPro val_26;
            var val_28;
            var val_30;
            this.isMyBottomView = myBottomRow;
            this.order = memberData.order;
            if(memberData.order > 5)
            {
                    this.index.enabled = true;
                this.medal.enabled = false;
                this.coinReward.SetActive(value:  false);
                this.index.text = memberData.order.ToString();
            }
            else
            {
                    if(memberData.order > 3)
            {
                    this.index.enabled = true;
                this.index.text = this.order.ToString();
                this.medal.enabled = false;
            }
            else
            {
                    this.index.enabled = false;
                this.medal.enabled = true;
                val_13 = null;
                val_13 = null;
                UnityEngine.Sprite[] val_14 = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.scroll.medalSprites;
                int val_13 = this.order;
                val_13 = val_13 - 1;
                val_14 = val_14 + (val_13 << 3);
                this.medal.sprite = mem[(Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.scroll.medalSprites + ((this.order - 1)) << 3) + 32];
            }
            
                this.coinReward.SetActive(value:  true);
                this.coinExtra.enabled = (this.order == 1) ? 1 : 0;
                val_14 = null;
                val_14 = null;
                UnityEngine.Sprite[] val_16 = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.scroll.coinSprites;
                int val_15 = this.order;
                val_15 = val_15 - 1;
                val_16 = val_16 + (val_15 << 3);
                this.coins.sprite = mem[(Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.scroll.coinSprites + ((this.order - 1)) << 3) + 32];
                val_15 = null;
                val_15 = null;
                System.Int32[] val_18 = Royal.Player.Context.Units.TeamBattleManager.Rewards;
                int val_17 = this.order;
                val_17 = val_17 - 1;
                val_18 = val_18 + (val_17 << 2);
                this.coinsAmount.text = ToString();
                UnityEngine.Transform val_6 = this.coins.transform;
                if(this.order != 3)
            {
                    if(this.order != 5)
            {
                goto label_34;
            }
            
            }
            
                val_16 = null;
                val_16 = null;
                val_17 = 1152921505034698768;
                val_18 = 1152921505034698772;
                val_19 = 1152921505034698776;
                if(val_6 == null)
            {
                    label_34:
                val_20 = null;
                val_20 = null;
                val_17 = 1152921505034698780;
                val_18 = 1152921505034698784;
                val_19 = 1152921505034698788;
            }
            
                val_6.localPosition = new UnityEngine.Vector3() {x = val_17, y = mem[1152921505034698784], z = mem[1152921505034698788]};
            }
            
            this.teamLogo.InitById(logoId:  memberData.leader.<LeagueLevel>k__BackingField);
            this.teamName.text = memberData.leader.<TeamLogo>k__BackingField;
            this.level.text = mem[1152921519176402084].ToString();
            val_21 = null;
            val_21 = null;
            val_23 = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.myTeamId;
            if((memberData.leader.<TeamName>k__BackingField) == val_23)
            {
                    if(this.isMyBottomView != true)
            {
                    Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.scroll = 1;
                Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.scroll = this.transform;
                val_25 = null;
            }
            
                val_26 = this.teamName;
                val_25 = null;
                val_26.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.MyTeamColor, g = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.myTeamId.__il2cppRuntimeField_2C, b = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.myTeamId.__il2cppRuntimeField_30, a = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.myTeamId.__il2cppRuntimeField_34};
                this.backgrounds[0].sprite = typeof(UnityEngine.Sprite[]).__il2cppRuntimeField_28;
                this.backgrounds[1].sprite = typeof(UnityEngine.Sprite[]).__il2cppRuntimeField_28;
                this.levelBackgrounds[0].sprite = typeof(UnityEngine.Sprite[]).__il2cppRuntimeField_28;
                UnityEngine.SpriteRenderer val_22 = this.levelBackgrounds[1];
            }
            else
            {
                    val_28 = null;
                val_23 = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.myTeamId;
                if(this.oldTeamId == val_23)
            {
                    Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.scroll = 0;
                Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.scroll = this.transform;
                val_28 = null;
            }
            
                val_26 = this.teamName;
                val_28 = null;
                val_26.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.OtherTeamColor, g = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.myTeamId.__il2cppRuntimeField_3C, b = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.myTeamId.__il2cppRuntimeField_40, a = Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.myTeamId.__il2cppRuntimeField_44};
                this.backgrounds[0].sprite = UnityEngine.Sprite[].__il2cppRuntimeField_byval_arg;
                this.backgrounds[1].sprite = UnityEngine.Sprite[].__il2cppRuntimeField_byval_arg;
                this.levelBackgrounds[0].sprite = UnityEngine.Sprite[].__il2cppRuntimeField_byval_arg;
            }
            
            this.levelBackgrounds[1].sprite = UnityEngine.Sprite[].__il2cppRuntimeField_byval_arg;
            this.oldTeamId = memberData.leader.<TeamName>k__BackingField;
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).IsInnerFlowExecuting()) == false)
            {
                goto label_116;
            }
            
            val_30 = 0;
            if(this.boxCollider != null)
            {
                goto label_117;
            }
            
            label_116:
            label_117:
            this.boxCollider.enabled = (Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListScroll.isClaimButtonActive == false) ? 1 : 0;
        }
        public void ShowAction()
        {
            var val_2;
            if(Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListScroll.isClaimButtonActive != false)
            {
                    return;
            }
            
            if(this.isMyBottomView != false)
            {
                    val_2 = null;
                val_2 = null;
                Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.scroll.AutoScrollToMyPosition(order:  this.order);
                return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ToggleViewTeamButton(teamId:  this.oldTeamId, parent:  this.transform, xPosition:  -3.151f, bottomOffset:  3.5f);
        }
        public void ShowRewardTooltip(Royal.Infrastructure.UiComponents.Button.UiButton button)
        {
            Royal.Infrastructure.UiComponents.Touch.ITouchable val_18;
            UnityEngine.Transform val_19;
            var val_20;
            var val_24;
            val_18 = button;
            val_19 = this;
            if(this.order > 5)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = val_18.transform.position;
            if(this.order < 4)
            {
                    val_20 = 1;
            }
            else
            {
                    UnityEngine.Vector2 val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).GetScreenSize();
                float val_18 = -0.5f;
                val_18 = val_4.y * val_18;
                float val_5 = (Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListScroll.isClaimButtonActive == false) ? 2.5f : 5f;
                val_5 = val_2.y - val_5;
                bool val_6 = (val_5 > val_18) ? 1 : 0;
            }
            
            Royal.Infrastructure.UiComponents.Dialog.DialogManager val_7 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            UnityEngine.Vector3 val_9 = this.coinReward.transform.position;
            if((val_6 & 1) != 0)
            {
                    UnityEngine.Vector3 val_10 = UnityEngine.Vector3.down;
            }
            else
            {
                    UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
            }
            
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  3f);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            val_19 = this.transform;
            val_24 = null;
            val_24 = null;
            val_18 = val_7.toolTipManager.ToggleTooltip(parent:  val_19, touchable:  val_18, pos:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, toolTip:  Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.scroll.tooltipPrefab);
            if(val_18 == 0)
            {
                    return;
            }
            
            val_18.GetComponent<Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleRewardTooltip>().ArrangePosition(forTeam:  true, atDown:  val_6);
        }
        public TeamBattleTeamListRow()
        {
        
        }
        private static TeamBattleTeamListRow()
        {
            Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.CoinPositionLower = 0;
            Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.myTeamId.__il2cppRuntimeField_18 = 0;
            Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.CoinPositionUpper = 0;
            Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.myTeamId.__il2cppRuntimeField_24 = 0;
            Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.MyTeamColor = 0;
            Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleTeamListRow.OtherTeamColor = 0;
        }
    
    }

}
