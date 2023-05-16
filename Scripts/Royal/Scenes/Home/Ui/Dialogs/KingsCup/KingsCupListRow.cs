using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup
{
    public class KingsCupListRow : UiScrollContentItem
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.GoldNickName goldNickName;
        public TMPro.TextMeshPro index;
        public TMPro.TextMeshPro teamName;
        public Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoView teamLogo;
        public TMPro.TextMeshPro level;
        public UnityEngine.SpriteRenderer medal;
        public UnityEngine.SpriteRenderer giftBox;
        public UnityEngine.BoxCollider2D boxCollider;
        public UnityEngine.SpriteRenderer[] backgrounds;
        public UnityEngine.SpriteRenderer[] levelBackgrounds;
        public UnityEngine.Sprite[] medalSprites;
        public UnityEngine.Sprite[] backgroundSprites;
        public UnityEngine.Sprite[] levelBackgroundSprites;
        private const string EmptyName = "Player";
        public static long myUserId;
        public static Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListScroll scroll;
        private static readonly UnityEngine.Vector3 UserNameWithTeamPosition;
        private static readonly UnityEngine.Vector3 UserNameWithNoTeamPosition;
        private static readonly UnityEngine.Color MyNameColor;
        private static readonly UnityEngine.Color OtherNameColor;
        private static readonly UnityEngine.Color MyTeamColor;
        private static readonly UnityEngine.Color OtherTeamColor;
        private int order;
        private long userId;
        private long teamId;
        private bool isMyBottomView;
        
        // Methods
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
            data.System.IDisposable.Dispose();
            this.UpdateView(memberData:  new Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRowData() {order = 524918784, leader = new Royal.Infrastructure.Services.Storage.Tables.Leader() {<UserId>k__BackingField = 1152921505131765760, <UserName>k__BackingField = data, <TeamId>k__BackingField = ???, <TeamName>k__BackingField = ???, <TeamLogo>k__BackingField = ???, <Level>k__BackingField = ???, <LeagueLevel>k__BackingField = ???, <LevelUpdateTime>k__BackingField = ???, <FacebookId>k__BackingField = ???, <IsGold>k__BackingField = false}}, myBottomRow:  false);
            this.userId = data;
        }
        public void UpdateView(Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRowData memberData, bool myBottomRow)
        {
            UnityEngine.SpriteRenderer val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_26;
            var val_27;
            long val_29;
            var val_31;
            UnityEngine.Color val_32;
            UnityEngine.Sprite val_36;
            var val_37;
            this.isMyBottomView = myBottomRow;
            this.teamId = memberData.leader.<TeamName>k__BackingField;
            this.order = memberData.order;
            if(memberData.order <= 3)
            {
                goto label_1;
            }
            
            this.index.enabled = true;
            this.medal.enabled = false;
            if(memberData.order <= 10)
            {
                goto label_5;
            }
            
            this.giftBox.enabled = false;
            this.index.text = memberData.order.ToString();
            goto label_7;
            label_1:
            this.index.enabled = false;
            this.medal.enabled = true;
            this.giftBox.enabled = true;
            int val_19 = memberData.order;
            val_19 = val_19 - 1;
            this.medal.sprite = this.medalSprites[val_19];
            val_19 = this.giftBox;
            val_20 = null;
            val_20 = null;
            UnityEngine.Sprite[] val_22 = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.scroll.giftBoxSprites;
            int val_21 = memberData.order;
            val_21 = val_21 - 1;
            val_22 = val_22 + (val_21 << 3);
            val_21 = mem[(Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.scroll.giftBoxSprites + ((memberData.order - 1)) << 3) + 32];
            goto label_20;
            label_5:
            this.giftBox.enabled = true;
            this.index.text = memberData.order.ToString();
            val_19 = this.giftBox;
            val_22 = null;
            val_22 = null;
            label_20:
            val_19.sprite = typeof(UnityEngine.Sprite[]).__il2cppRuntimeField_38;
            label_7:
            if(this.teamId >= 1)
            {
                    this.teamLogo.InitById(logoId:  memberData.leader.<LeagueLevel>k__BackingField);
                val_23 = this.goldNickName.transform;
                val_24 = null;
                val_24 = null;
            }
            else
            {
                    this.teamLogo.InitWithEmptyYellowBackground();
                val_23 = this.goldNickName.transform;
                val_26 = null;
                val_26 = null;
            }
            
            val_23.localPosition = new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.UserNameWithNoTeamPosition, y = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.myUserId.__il2cppRuntimeField_20, z = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.myUserId.__il2cppRuntimeField_24};
            this.teamName.text = memberData.leader.<TeamLogo>k__BackingField;
            this.level.text = mem[1152921519467639700].ToString();
            val_27 = null;
            val_27 = null;
            val_29 = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.myUserId;
            if((memberData.leader.<UserName>k__BackingField) == val_29)
            {
                    if(this.isMyBottomView != true)
            {
                    Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.scroll = 1;
                Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.scroll = this.transform;
                val_31 = null;
            }
            
                val_31 = null;
                val_32 = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.MyNameColor;
                this.teamName.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.MyTeamColor, g = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.myUserId.__il2cppRuntimeField_4C, b = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.myUserId.__il2cppRuntimeField_50, a = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.myUserId.__il2cppRuntimeField_54};
                this.backgrounds[0].sprite = this.backgroundSprites[1];
                this.backgrounds[1].sprite = this.backgroundSprites[1];
                this.levelBackgrounds[0].sprite = this.levelBackgroundSprites[1];
                UnityEngine.SpriteRenderer val_29 = this.levelBackgrounds[1];
                val_36 = this.levelBackgroundSprites[1];
            }
            else
            {
                    val_37 = null;
                val_29 = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.myUserId;
                if(this.userId == val_29)
            {
                    Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.scroll = 0;
                Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.scroll = this.transform;
                val_37 = null;
            }
            
                val_37 = null;
                val_32 = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.OtherNameColor;
                this.teamName.color = new UnityEngine.Color() {r = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.OtherTeamColor, g = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.myUserId.__il2cppRuntimeField_5C, b = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.myUserId.__il2cppRuntimeField_60, a = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.myUserId.__il2cppRuntimeField_64};
                this.backgrounds[0].sprite = this.backgroundSprites[0];
                this.backgrounds[1].sprite = this.backgroundSprites[0];
                this.levelBackgrounds[0].sprite = this.levelBackgroundSprites[0];
                val_36 = this.levelBackgroundSprites[0];
            }
            
            this.levelBackgrounds[1].sprite = val_36;
            this.goldNickName.SetNickName(nickName:  ((System.String.IsNullOrEmpty(value:  memberData.leader.<TeamId>k__BackingField)) != true) ? "Player" : memberData.leader.<TeamId>k__BackingField, isGold:  (mem[1152921519467639728] == true) ? 1 : 0, nickColor:  new UnityEngine.Color() {r = val_32, g = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.myUserId.__il2cppRuntimeField_3C, b = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.myUserId.__il2cppRuntimeField_40, a = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.myUserId.__il2cppRuntimeField_44}, borderType:  0);
            this.teamName.renderer.enabled = (~(System.String.IsNullOrEmpty(value:  this.teamName.text))) & 1;
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).IsInnerFlowExecuting()) != true)
            {
                    if(Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListScroll.isClaimButtonActive == false)
            {
                goto label_110;
            }
            
            }
            
            label_112:
            this.boxCollider.enabled = (this.isMyBottomView == true) ? 1 : 0;
            return;
            label_110:
            if(this.boxCollider != null)
            {
                goto label_112;
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
                Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.scroll.AutoScrollToMyPosition(order:  this.order);
                return;
            }
            
            if(Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListScroll.isClaimButtonActive != false)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.ViewTeam.ViewTeamButton.ToggleViewTeamButton(teamId:  this.teamId, parent:  this.transform, xPosition:  -3.151f, bottomOffset:  4f);
        }
        public void ShowToolTip(Royal.Infrastructure.UiComponents.Button.UiButton button)
        {
            UnityEngine.Transform val_18;
            var val_19;
            var val_23;
            if(this.order > 10)
            {
                    return;
            }
            
            UnityEngine.Transform val_1 = button.transform;
            val_18 = val_1;
            UnityEngine.Vector3 val_2 = val_1.position;
            if(this.order < 4)
            {
                    val_19 = 1;
            }
            else
            {
                    UnityEngine.Vector2 val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).GetScreenSize();
                float val_18 = -0.5f;
                val_18 = val_4.y * val_18;
                float val_5 = (Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListScroll.isClaimButtonActive == false) ? 3f : 5f;
                val_5 = val_2.y - val_5;
                bool val_6 = (val_5 > val_18) ? 1 : 0;
            }
            
            Royal.Infrastructure.UiComponents.Dialog.DialogManager val_7 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  0.3f);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            if((val_6 & 1) != 0)
            {
                    UnityEngine.Vector3 val_11 = UnityEngine.Vector3.down;
            }
            else
            {
                    UnityEngine.Vector3 val_12 = UnityEngine.Vector3.up;
            }
            
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  2.5f);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            val_23 = null;
            val_23 = null;
            UnityEngine.GameObject val_15 = val_7.toolTipManager.ToggleTooltip(parent:  val_18, touchable:  button, pos:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, toolTip:  Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.scroll.tooltipPrefab);
            if(val_15 == 0)
            {
                    return;
            }
            
            val_15.GetComponent<Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftBoxToolTip>().ArrangeRewards(rank:  this.order, atDown:  val_6);
        }
        public KingsCupListRow()
        {
        
        }
        private static KingsCupListRow()
        {
            Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.UserNameWithTeamPosition = 0;
            Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.myUserId.__il2cppRuntimeField_18 = 0;
            Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.UserNameWithNoTeamPosition = 0;
            Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.myUserId.__il2cppRuntimeField_24 = 0;
            Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.MyNameColor = 0;
            Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.OtherNameColor = 0;
            Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.MyTeamColor = 0;
            Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.OtherTeamColor = 0;
        }
    
    }

}
