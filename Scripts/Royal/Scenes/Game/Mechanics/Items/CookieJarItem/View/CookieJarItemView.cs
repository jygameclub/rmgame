using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View
{
    public class CookieJarItemView : ItemView
    {
        // Fields
        private static readonly int CookieJarIdleState;
        private static readonly int CookieJarPlayState;
        private static readonly int MailBoxCloseState;
        public UnityEngine.Animator animator;
        private Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.ICookieJarItemViewDelegate itemViewDelegate;
        private float disableAnimationStartedAt;
        private const float DisableDelay = 0.24;
        private Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarCollectHelper collectHelper;
        public UnityEngine.Renderer front;
        public UnityEngine.Renderer back;
        private Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.ICookieJarItemViewDelegate ItemViewDelegate { get; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.ICookieJarItemViewDelegate get_ItemViewDelegate()
        {
            return (Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.ICookieJarItemViewDelegate)this.itemViewDelegate;
        }
        public void Init(Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.ICookieJarItemViewDelegate viewDelegate, UnityEngine.Vector3 position)
        {
            this.itemViewDelegate = viewDelegate;
            this.animator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemView.DisableDelay, layer:  0, normalizedTime:  0f);
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.collectHelper = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarCollectHelper>(contextId:  36);
            this.randomManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
        }
        public override int GetPoolId()
        {
            return 115;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            this.itemViewDelegate = 0;
            this.disableAnimationStartedAt = 0f;
            this.collectHelper = 0;
        }
        public void Explode()
        {
            9507.PlaySfx(type:  83, offset:  0.04f);
            this.animator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemView.CookieJarPlayState, layer:  0, normalizedTime:  0f);
            this.animator.Update(deltaTime:  UnityEngine.Time.deltaTime);
        }
        public void PlayExplodeParticles()
        {
            this.PlayParticle();
            this.PlayMailboxCloseSound();
        }
        public void FinalViewExplode()
        {
            var val_2 = 0;
            if(mem[1152921505105551360] != null)
            {
                    val_2 = val_2 + 1;
            }
            else
            {
                    var val_3 = mem[1152921505105551368];
                val_3 = val_3 + 1;
                Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.ICookieJarItemViewDelegate val_1 = 1152921505105514496 + val_3;
            }
            
            this.itemViewDelegate.FinalizeExplode(freezeDuration:  0.15f);
            this.itemViewDelegate.Recycle<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemView>(go:  this);
        }
        private void PlayParticle()
        {
            Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemExplodeParticles val_1 = 9510.Spawn<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemExplodeParticles>(poolId:  118, activate:  true);
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            val_1.Play(particleLayer:  1);
        }
        public override void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            bool val_3 = sortingData.sortEverything;
            val_3 = val_3 & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.back, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_3});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_3}, offset:  5);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.front, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295});
        }
        public void CollectAnimationCompleted()
        {
            var val_2 = 0;
            if(mem[1152921505105551360] != null)
            {
                    val_2 = val_2 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.ICookieJarItemViewDelegate val_1 = 1152921505105514496 + ((mem[1152921505105551368]) << 4);
            }
            
            this.itemViewDelegate.OnGoalReached();
        }
        public void ChangeToDisabledView()
        {
            this.disableAnimationStartedAt = Royal.Scenes.Game.Levels.LevelContext.Time;
            this.Invoke(methodName:  "DisableDelayed", time:  0.24f);
        }
        private void DisableDelayed()
        {
            this.Invoke(methodName:  "PlayMailboxCloseSound", time:  0.25f);
            this.animator.speed = 1f;
            this.animator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemView.MailBoxCloseState, layer:  0, normalizedTime:  0f);
        }
        private void PlayMailboxCloseSound()
        {
            if(this != null)
            {
                    this.PlaySfx(type:  84, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        public bool CanPlayCollectAnimation()
        {
            var val_4;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  this.disableAnimationStartedAt, b:  0f, precision:  0.001f)) != false)
            {
                    val_4 = 1;
                return (bool)(val_2 < 0) ? 1 : 0;
            }
            
            float val_2 = Royal.Scenes.Game.Levels.LevelContext.Time;
            val_2 = val_2 - this.disableAnimationStartedAt;
            return (bool)(val_2 < 0) ? 1 : 0;
        }
        public override bool IsReverseSorted()
        {
            if(W8 == 0)
            {
                    return (bool)(W8 == 0) ? 1 : 0;
            }
            
            return false;
        }
        public CookieJarItemView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private static CookieJarItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemView.DisableDelay = UnityEngine.Animator.StringToHash(name:  "Base Layer.idle");
            Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemView.CookieJarPlayState = UnityEngine.Animator.StringToHash(name:  "Base Layer.cookie");
            Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemView.MailBoxCloseState = UnityEngine.Animator.StringToHash(name:  "Base Layer.mailbox_kapali");
        }
    
    }

}
