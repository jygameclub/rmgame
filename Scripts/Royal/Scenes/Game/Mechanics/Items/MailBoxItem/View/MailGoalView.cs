using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View
{
    public class MailGoalView : MonoBehaviour, IPoolable
    {
        // Fields
        private static readonly int MailBoxMailState;
        public static float ElasticDuration;
        public UnityEngine.Animator mailboxAnimator;
        public UnityEngine.SpriteRenderer shadowView;
        public UnityEngine.Transform viewParent;
        public UnityEngine.Renderer spineRenderer;
        public UnityEngine.Renderer shadowRenderer;
        public Spine.Unity.SkeletonMecanim skeletonMecanim;
        private Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailTracerParticles tracerParticles;
        private float collectDelay;
        
        // Methods
        public void InitAndMove(UnityEngine.Transform parent, UnityEngine.Vector3 targetPosition, System.Action onComplete)
        {
            var val_15;
            MailGoalView.<>c__DisplayClass10_0 val_1 = new MailGoalView.<>c__DisplayClass10_0();
            .<>4__this = this;
            .targetPosition = targetPosition;
            mem[1152921520257064044] = targetPosition.y;
            mem[1152921520257064048] = targetPosition.z;
            .onComplete = onComplete;
            this.viewParent.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Transform val_2 = this.transform;
            val_2.SetParent(p:  parent);
            val_2.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetMailCollectSorting();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.spineRenderer, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetMailCollectShadowSorting();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.shadowRenderer, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_5.layer, order = val_5.order, sortEverything = val_5.sortEverything & 4294967295});
            this.viewParent.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.shadowView.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            DG.Tweening.Sequence val_9 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_9, interval:  0.14f);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_9, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MailGoalView.<>c__DisplayClass10_0::<InitAndMove>b__0()));
            val_15 = null;
            val_15 = null;
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_9, atPosition:  Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailGoalView.ElasticDuration, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MailGoalView.<>c__DisplayClass10_0::<InitAndMove>b__1()));
        }
        public void SetCollectDelay(float collectDelay)
        {
            this.collectDelay = collectDelay;
        }
        private void EnableTracerParticles()
        {
            Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailTracerParticles val_2 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1).Spawn<Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailTracerParticles>(poolId:  50, activate:  true);
            this.tracerParticles = val_2;
            val_2.SetBone(skeletonMecanim:  this.skeletonMecanim);
        }
        public void PlayMailSpineAnimation()
        {
            this.mailboxAnimator.PlayInFixedTime(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailGoalView.MailBoxMailState, layer:  0, fixedTime:  0f);
            this.mailboxAnimator.Update(deltaTime:  0f);
            this.skeletonMecanim.Skeleton.Update(delta:  UnityEngine.Time.deltaTime);
            this.skeletonMecanim.translator.Apply(skeleton:  this.skeletonMecanim.Skeleton);
        }
        private System.Collections.IEnumerator CurveToGoal(float duration, UnityEngine.Vector3 targetPos, System.Action onComplete)
        {
            .<>1__state = 0;
            .<>4__this = this;
            mem[1152921520257668736] = targetPos.z;
            .duration = duration;
            .targetPos = targetPos;
            mem[1152921520257668732] = targetPos.y;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new MailGoalView.<CurveToGoal>d__14();
        }
        public int GetPoolId()
        {
            return 49;
        }
        public void OnSpawn()
        {
        
        }
        public void OnRecycle()
        {
            this.collectDelay = 0f;
        }
        public MailGoalView()
        {
        
        }
        private static MailGoalView()
        {
            Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailGoalView.MailBoxMailState = UnityEngine.Animator.StringToHash(name:  "Base Layer.mailbox_mail");
            Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailGoalView.ElasticDuration = 0.5f;
        }
    
    }

}
