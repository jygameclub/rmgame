using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.League
{
    public class LeagueMemberListScroll : MonoBehaviour
    {
        // Fields
        public UnityEngine.BoxCollider2D boxCollider;
        public Royal.Infrastructure.UiComponents.Scroll.Content.UiOptimizedScrollContent content;
        public Royal.Infrastructure.UiComponents.Scroll.UiVerticalScroll verticalScroll;
        private UnityEngine.Transform myViewTransformInScroll;
        private UnityEngine.Transform myViewTransformAtBottom;
        public Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow myBottomRow;
        public static bool isClaimButtonActive;
        private int totalCount;
        private bool isMyViewInScroll;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        
        // Methods
        public void Update()
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
        public void PrepareContent(bool isLeagueFinished)
        {
            var val_10;
            var val_11;
            Royal.Infrastructure.UiComponents.Scroll.Content.UiOptimizedScrollContent val_12;
            var val_13;
            var val_14;
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.myViewTransformAtBottom = this.myBottomRow.transform.parent;
            val_11 = 1152921505048059904;
            Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListScroll.isClaimButtonActive = isLeagueFinished;
            System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Leader> val_5 = Royal.Infrastructure.Services.Storage.Tables.UserLeaderboard.GetLeaderboard(type:  2);
            this.totalCount = Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListScroll.__il2cppRuntimeField_static_fields;
            if(Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListScroll.isClaimButtonActive != false)
            {
                    bool val_7 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).IsDeviceTall();
                var val_9 = (val_7 != true) ? (5 + 1) : 5;
                this.content = (val_7 != true) ? 1.9f : 1.5f;
            }
            else
            {
                    val_12 = 7;
            }
            
            if(Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListScroll.isClaimButtonActive < val_12)
            {
                    this.content = val_12;
            }
            
            val_13 = 1152921505048006656;
            val_14 = null;
            val_14 = null;
            Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.scroll = this;
            do
            {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_13 = 0 + 1;
                if(val_10 != 0)
            {
                    this.myBottomRow.UpdateView(memberData:  new Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRowData() {leader = new Royal.Infrastructure.Services.Storage.Tables.Leader() {<IsGold>k__BackingField = false}, isMyUser = false}, myBottomRow:  true);
            }
            
                val_11 = 32 + 80;
            }
            while(val_13 < null);
        
        }
        public void AnimateMembers()
        {
            int val_11;
            this.PrepareMyBottomView();
            int val_2 = this.content.transform.childCount;
            if(val_2 < 1)
            {
                    return;
            }
            
            val_11 = UnityEngine.Mathf.Min(a:  (this.camManager.IsDeviceTall() != true) ? (5 + 1) : 5, b:  val_2 - 1);
            var val_11 = 0;
            do
            {
                this.AnimateItem(item:  this.content.transform.GetChild(index:  0), order:  0, delay:  0.03f);
                if(val_11 == val_11)
            {
                    this.AnimateItem(item:  this.myBottomRow.transform.parent, order:  val_11, delay:  0.03f);
            }
            
                val_11 = val_11 + 1;
            }
            while(val_11 < val_2);
        
        }
        private void PrepareMyBottomView()
        {
            if(this.isMyViewInScroll != false)
            {
                    return;
            }
            
            this.myViewTransformAtBottom.gameObject.SetActive(value:  true);
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
        private void AnimateItem(UnityEngine.Transform item, int order, float delay = 0.03)
        {
            .item = item;
            UnityEngine.Vector3 val_3 = item.localPosition;
            val_3.x = (this.camManager.cameraWidth + 0.5f) + val_3.x;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_3.x, y:  val_3.y);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            (LeagueMemberListScroll.<>c__DisplayClass16_0)[1152921519403965440].item.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            float val_14 = (float)order + 1;
            val_14 = val_14 * delay;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  val_6, delay:  val_14);
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_6, callback:  new DG.Tweening.TweenCallback(object:  new LeagueMemberListScroll.<>c__DisplayClass16_0(), method:  System.Void LeagueMemberListScroll.<>c__DisplayClass16_0::<AnimateItem>b__0()));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveX(target:  (LeagueMemberListScroll.<>c__DisplayClass16_0)[1152921519403965440].item, endValue:  val_3.x, duration:  0.4f, snapping:  false), ease:  27);
            val_12 = 1061158912;
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  val_12);
        }
        private void OnDestroy()
        {
            null = null;
            Royal.Scenes.Home.Ui.Dialogs.League.LeagueMemberListRow.scroll = 0;
        }
        public LeagueMemberListScroll()
        {
        
        }
    
    }

}
