using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.TeamBattle
{
    public class TeamBattlePlayerListScroll : MonoBehaviour
    {
        // Fields
        public UnityEngine.BoxCollider2D boxCollider;
        public Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayersScrollContent content;
        public Royal.Infrastructure.UiComponents.Scroll.UiVerticalScroll verticalScroll;
        public Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow myBottomRow;
        public UnityEngine.GameObject tooltipPrefab;
        private int totalCount;
        private bool isMyViewInScroll;
        private UnityEngine.Transform myViewTransformInScroll;
        private UnityEngine.Transform myViewTransformAtBottom;
        
        // Methods
        private void Update()
        {
            if(this.isMyViewInScroll == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = this.myViewTransformAtBottom.position;
            UnityEngine.Vector3 val_4 = this.myViewTransformInScroll.position;
            var val_5 = (val_3.y > val_4.y) ? 1 : 0;
            val_5 = this.myViewTransformAtBottom.gameObject.activeSelf ^ val_5;
            if(val_5 == false)
            {
                    return;
            }
            
            this.myViewTransformAtBottom.gameObject.SetActive(value:  (val_3.y > val_4.y) ? 1 : 0);
        }
        public int PrepareContent(bool isBattleFinished)
        {
            string val_10;
            int val_11;
            long val_12;
            long val_13;
            bool val_14;
            Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListScroll val_17;
            var val_18;
            var val_19;
            string val_20;
            var val_21;
            var val_22;
            Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListScroll val_23;
            var val_24;
            var val_25;
            mem[1152921519172607568] = mem[1152921519172607536].transform.parent;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Leader> val_3 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetLeaderboard(type:  9);
            mem[1152921519172607552] = mem[1152921519172607520];
            if(isBattleFinished != false)
            {
                    val_17 = this;
                bool val_5 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).IsDeviceTall();
                var val_7 = (val_5 != true) ? (4 + 1) : 4;
                mem[1152921519172607520] = (val_5 != true) ? 1.9f : 1.5f;
            }
            else
            {
                    val_17 = this;
                val_18 = 6;
            }
            
            if(mem[1152921519172607520] < val_18)
            {
                    mem[1152921519172607520] = mem[1152921519172607520] + 32;
            }
            
            val_19 = null;
            val_19 = null;
            Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.scroll = val_17;
            Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.myUserId = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name;
            if(mem[1152921519172607552] < 1)
            {
                goto label_18;
            }
            
            var val_17 = 0;
            label_36:
            if(0 >= 1680846296)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            int val_8 = 0 + 1;
            val_20 = val_12;
            val_21 = null;
            val_21 = null;
            if(Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.myUserId == val_20)
            {
                    val_11 = val_8;
                val_12 = val_11;
                val_10 = val_20;
                val_22 = 1;
                mem[1152921519172607536].UpdateView(memberData:  new Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRowData() {order = val_11, leader = new Royal.Infrastructure.Services.Storage.Tables.Leader() {<Type>k__BackingField = val_11, <UserId>k__BackingField = val_12, <UserName>k__BackingField = val_10, <TeamId>k__BackingField = val_10, <TeamName>k__BackingField = val_10, <TeamLogo>k__BackingField = val_10, <Level>k__BackingField = val_10, <LeagueLevel>k__BackingField = val_10, <LevelUpdateTime>k__BackingField = val_13, <FacebookId>k__BackingField = val_13, <IsGold>k__BackingField = val_14}}, myBottomRow:  true);
            }
            
            if((0 & 1) != 0)
            {
                goto label_24;
            }
            
            if(0 >= 1680846384)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(val_13 == 0)
            {
                goto label_26;
            }
            
            goto label_27;
            label_26:
            val_22 = mem[mem[1152921519172607520] + 384 + 8];
            val_22 = mem[1152921519172607520] + 384 + 8;
            val_23 = this;
            label_24:
            label_27:
            var val_16 = 0;
            if((val_16 & 1) == 0)
            {
                goto label_29;
            }
            
            val_24 = 1;
            goto label_30;
            label_29:
            if(0 >= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_16 = val_16 + val_17;
            if(((0 + 0) + 76) == 1)
            {
                goto label_32;
            }
            
            goto label_33;
            label_32:
            val_22 = mem[mem[1152921519172607520] + 384 + 8];
            val_22 = mem[1152921519172607520] + 384 + 8;
            val_23 = this;
            val_24 = 1;
            label_30:
            label_33:
            val_17 = val_17 + 80;
            val_25 = val_23;
            if(val_8 < mem[1152921519172607552])
            {
                goto label_36;
            }
            
            label_18:
            this.PrepareMyBottomView();
            return (int)mem[1152921519172607552];
        }
        public void AnimateMembers(bool animate)
        {
            var val_12;
            var val_13;
            this.PrepareMyBottomView();
            if(animate == false)
            {
                    return;
            }
            
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            val_12 = this.content.transform.childCount;
            if(val_1.IsDeviceTall() != true)
            {
                    if(val_1.IsDeviceWide() == false)
            {
                goto label_8;
            }
            
            }
            
            val_13 = 4;
            goto label_9;
            label_8:
            val_13 = 3;
            label_9:
            int val_7 = UnityEngine.Mathf.Min(a:  3, b:  val_12 - 1);
            if(val_12 < 1)
            {
                    return;
            }
            
            var val_12 = 0;
            do
            {
                UnityEngine.Transform val_9 = this.content.transform.GetChild(index:  0);
                val_9.AnimateItem(cameraManager:  val_1, item:  val_9, order:  0, delay:  0.03f);
                if(val_7 == val_12)
            {
                    UnityEngine.Transform val_11 = this.myBottomRow.transform.parent;
                val_11.AnimateItem(cameraManager:  val_1, item:  val_11, order:  val_7, delay:  0.03f);
            }
            
                val_12 = val_12 + 1;
            }
            while(val_12 < val_12);
        
        }
        private void PrepareMyBottomView()
        {
            if(this.isMyViewInScroll != false)
            {
                    return;
            }
            
            this.myViewTransformAtBottom.gameObject.SetActive(value:  true);
        }
        private void AnimateItem(Royal.Infrastructure.Contexts.Units.CameraManager cameraManager, UnityEngine.Transform item, int order, float delay = 0.03)
        {
            .item = item;
            UnityEngine.Vector3 val_3 = item.localPosition;
            val_3.x = (cameraManager.cameraWidth + 0.5f) + val_3.x;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_3.x, y:  val_3.y);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            (TeamBattlePlayerListScroll.<>c__DisplayClass13_0)[1152921519173152640].item.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            float val_14 = (float)order + 1;
            val_14 = val_14 * delay;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  val_6, delay:  val_14);
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_6, callback:  new DG.Tweening.TweenCallback(object:  new TeamBattlePlayerListScroll.<>c__DisplayClass13_0(), method:  System.Void TeamBattlePlayerListScroll.<>c__DisplayClass13_0::<AnimateItem>b__0()));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveX(target:  (TeamBattlePlayerListScroll.<>c__DisplayClass13_0)[1152921519173152640].item, endValue:  val_3.x, duration:  0.4f, snapping:  false), ease:  27);
            val_12 = 1061158912;
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  val_12);
        }
        public void KeepMyViewTransform(bool keep, UnityEngine.Transform row)
        {
            this.isMyViewInScroll = keep;
            this.myViewTransformInScroll = row;
        }
        public void AutoScrollToMyPosition(int order)
        {
            float val_1 = (float)this.totalCount;
            val_1 = S1 / val_1;
            val_1 = val_1 * (float)order;
            val_1 = val_1 + (-2f);
            this.verticalScroll.AnimateContent(distance:  val_1);
        }
        public void Enable(bool enable)
        {
            this.gameObject.SetActive(value:  enable);
        }
        private void OnDestroy()
        {
            null = null;
            Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattlePlayerListRow.scroll = 0;
        }
        public TeamBattlePlayerListScroll()
        {
        
        }
    
    }

}
