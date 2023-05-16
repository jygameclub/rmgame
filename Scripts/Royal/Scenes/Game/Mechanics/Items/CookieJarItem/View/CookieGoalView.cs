using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View
{
    public class CookieGoalView : MonoBehaviour, IPoolable
    {
        // Fields
        private static readonly int MailBoxMailState;
        public static float ElasticDuration;
        public UnityEngine.Animator mailboxAnimator;
        public UnityEngine.Transform viewParent;
        public UnityEngine.Renderer spineRenderer;
        public Spine.Unity.SkeletonMecanim skeletonMecanim;
        private Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieTracerParticles tracerParticles;
        private float collectDelay;
        public UnityEngine.Renderer shadowRenderer;
        public UnityEngine.Renderer cookieRenderer;
        
        // Methods
        public void InitAndMove(Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemView parent, UnityEngine.Vector3 targetPosition, System.Action onComplete)
        {
            UnityEngine.Vector3 val_3 = parent.animator.transform.position;
            this.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.viewParent.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.shadowRenderer.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetSorting(renderer:  parent.back);
            val_6.sortEverything = val_6.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_6.layer, order = val_6.order, sortEverything = val_6.sortEverything}, offset:  2);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.shadowRenderer, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = val_7.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_9 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetSorting(renderer:  parent.back);
            val_9.sortEverything = val_9.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_10 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_9.layer, order = val_9.order, sortEverything = val_9.sortEverything}, offset:  3);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.cookieRenderer, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_10.layer, order = val_10.order, sortEverything = val_10.sortEverything & 4294967295});
            this.viewParent.gameObject.SetActive(value:  true);
            this.PlayMailSpineAnimation();
            this.EnableTracerParticles();
            UnityEngine.Coroutine val_14 = this.StartCoroutine(routine:  this.CurveToGoal(duration:  0.4f, targetPos:  new UnityEngine.Vector3() {x = targetPosition.x, y = targetPosition.y, z = targetPosition.z}, onComplete:  onComplete));
        }
        public void SetCollectDelay(float collectDelay)
        {
            this.collectDelay = collectDelay;
        }
        public void EnableCookie()
        {
            9476.SetAttachment(slotName:  "cookie01", attachmentName:  "cookie01");
        }
        private void EnableTracerParticles()
        {
            Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieTracerParticles val_2 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1).Spawn<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieTracerParticles>(poolId:  117, activate:  true);
            this.tracerParticles = val_2;
            val_2.SetBone(skeletonMecanim:  this.skeletonMecanim);
        }
        public void PlayMailSpineAnimation()
        {
            this.mailboxAnimator.PlayInFixedTime(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieGoalView.MailBoxMailState, layer:  0, fixedTime:  0f);
            this.mailboxAnimator.Update(deltaTime:  0f);
            this.skeletonMecanim.Skeleton.Update(delta:  UnityEngine.Time.deltaTime);
            this.skeletonMecanim.translator.Apply(skeleton:  this.skeletonMecanim.Skeleton);
        }
        private System.Collections.IEnumerator CurveToGoal(float duration, UnityEngine.Vector3 targetPos, System.Action onComplete)
        {
            .<>1__state = 0;
            .<>4__this = this;
            mem[1152921523769700576] = targetPos.z;
            .duration = duration;
            .targetPos = targetPos;
            mem[1152921523769700572] = targetPos.y;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new CookieGoalView.<CurveToGoal>d__15();
        }
        public int GetPoolId()
        {
            return 116;
        }
        public void OnSpawn()
        {
        
        }
        public void OnRecycle()
        {
            this.collectDelay = 0f;
        }
        public CookieGoalView()
        {
        
        }
        private static CookieGoalView()
        {
            Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieGoalView.MailBoxMailState = UnityEngine.Animator.StringToHash(name:  "Base Layer.bone");
            Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieGoalView.ElasticDuration = 0.5f;
        }
    
    }

}
