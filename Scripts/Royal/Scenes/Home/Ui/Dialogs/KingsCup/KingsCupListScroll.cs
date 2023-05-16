using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup
{
    public class KingsCupListScroll : MonoBehaviour
    {
        // Fields
        public UnityEngine.BoxCollider2D boxCollider;
        public Royal.Infrastructure.UiComponents.Scroll.Content.UiOptimizedScrollContent content;
        public Royal.Infrastructure.UiComponents.Scroll.UiVerticalScroll verticalScroll;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow myBottomRow;
        public UnityEngine.Sprite[] giftBoxSprites;
        public UnityEngine.GameObject tooltipPrefab;
        public static bool isClaimButtonActive;
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
        public int PrepareContent(bool isCupFinished)
        {
            long val_9;
            long val_10;
            long val_11;
            int val_12;
            long val_13;
            string val_14;
            Royal.Infrastructure.UiComponents.Scroll.Content.UiOptimizedScrollContent val_16;
            var val_17;
            Royal.Infrastructure.UiComponents.Scroll.Content.UiOptimizedScrollContent val_18;
            int val_19;
            var val_20;
            this.myViewTransformAtBottom = this.myBottomRow.transform.parent;
            Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListScroll.isClaimButtonActive = isCupFinished;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Leader> val_4 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetLeaderboard(type:  7);
            this.totalCount = Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListScroll.__il2cppRuntimeField_static_fields;
            if(Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListScroll.isClaimButtonActive != false)
            {
                    bool val_6 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).IsDeviceTall();
                var val_8 = (val_6 != true) ? (5 + 1) : 5;
                this.content = (val_6 != true) ? 1.9f : 1.5f;
            }
            else
            {
                    val_16 = 7;
            }
            
            if(Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListScroll.isClaimButtonActive < val_16)
            {
                    this.content = val_16;
            }
            
            val_17 = null;
            val_17 = null;
            Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.scroll = this;
            Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.myUserId = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name;
            val_19 = this.totalCount;
            if(val_19 < 1)
            {
                    return val_19;
            }
            
            var val_16 = 0;
            int val_15 = 0;
            do
            {
                if(val_15 >= )
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_15 = val_15 + 1;
                val_20 = null;
                val_20 = null;
                if(Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.myUserId == val_14)
            {
                    val_13 = val_9;
                val_11 = val_10;
                val_10 = val_13;
                this.myBottomRow.UpdateView(memberData:  new Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRowData() {leader = new Royal.Infrastructure.Services.Storage.Tables.Leader() {<UserId>k__BackingField = val_10, <UserName>k__BackingField = val_14, <TeamId>k__BackingField = val_11, <TeamName>k__BackingField = val_11, <TeamLogo>k__BackingField = val_12, <Level>k__BackingField = val_12, <LeagueLevel>k__BackingField = val_12, <LevelUpdateTime>k__BackingField = val_13, <FacebookId>k__BackingField = val_13, <IsGold>k__BackingField = val_11}}, myBottomRow:  true);
            }
            
                val_18 = this.content;
                val_14 = val_12;
                val_19 = this.totalCount;
                val_16 = val_16 + 80;
            }
            while(val_15 < val_19);
            
            return val_19;
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
            
            object val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<System.Object>(id:  1);
            val_12 = this.content.transform.childCount;
            if(val_1.IsDeviceTall() != true)
            {
                    if(val_1.IsDeviceWide() == false)
            {
                goto label_8;
            }
            
            }
            
            val_13 = 6;
            goto label_9;
            label_8:
            val_13 = 5;
            label_9:
            int val_7 = UnityEngine.Mathf.Min(a:  5, b:  val_12 - 1);
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
            (KingsCupListScroll.<>c__DisplayClass15_0)[1152921519469840624].item.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            float val_14 = (float)order + 1;
            val_14 = val_14 * delay;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  val_6, delay:  val_14);
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_6, callback:  new DG.Tweening.TweenCallback(object:  new KingsCupListScroll.<>c__DisplayClass15_0(), method:  System.Void KingsCupListScroll.<>c__DisplayClass15_0::<AnimateItem>b__0()));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveX(target:  (KingsCupListScroll.<>c__DisplayClass15_0)[1152921519469840624].item, endValue:  val_3.x, duration:  0.4f, snapping:  false), ease:  27);
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
        private void OnDestroy()
        {
            null = null;
            Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupListRow.scroll = 0;
        }
        public KingsCupListScroll()
        {
        
        }
    
    }

}
