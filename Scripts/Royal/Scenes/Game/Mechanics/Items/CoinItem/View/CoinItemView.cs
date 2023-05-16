using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CoinItem.View
{
    public class CoinItemView : ItemView
    {
        // Fields
        private static readonly UnityEngine.Color ShadowColor;
        private static readonly int CoinIdleAnimation;
        private static readonly int CoinFlipAnimation;
        public UnityEngine.Animator animator;
        public UnityEngine.SpriteRenderer baseView;
        public UnityEngine.SpriteRenderer shadowView;
        private Royal.Scenes.Game.Mechanics.Items.CoinItem.View.ICoinItemViewDelegate itemViewDelegate;
        
        // Properties
        public UnityEngine.Transform Transform { get; }
        public UnityEngine.Transform ShadowTransform { get; }
        
        // Methods
        public UnityEngine.Transform get_Transform()
        {
            return this.transform;
        }
        public UnityEngine.Transform get_ShadowTransform()
        {
            if(this.shadowView != null)
            {
                    return this.shadowView.transform;
            }
            
            throw new NullReferenceException();
        }
        public void Init(Royal.Scenes.Game.Mechanics.Items.CoinItem.View.ICoinItemViewDelegate viewDelegate, UnityEngine.Vector3 position)
        {
            this.itemViewDelegate = viewDelegate;
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.animator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView.CoinIdleAnimation, layer:  0, normalizedTime:  0f);
            this.ResetValues();
        }
        public override int GetPoolId()
        {
            return 61;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            this.ResetValues();
        }
        private void ResetValues()
        {
            var val_3;
            this.animator.speed = 1f;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.baseView.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            val_3 = null;
            val_3 = null;
            this.shadowView.color = new UnityEngine.Color() {r = Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView.ShadowColor, g = Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView.ShadowColor.__il2cppRuntimeField_4, b = Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView.ShadowColor.__il2cppRuntimeField_8, a = Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView.ShadowColor.__il2cppRuntimeField_C};
            this.shadowView.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public void PrepareShadowColorForCollect()
        {
            this.shadowView.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        public void SetSortingForCollect(int offset)
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetMatchItemCollectSorting(offset:  offset);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295});
        }
        public void SetSortingForCollectOnUi()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetMatchItemCollectUiSorting(order:  this.sortingOrder);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295});
        }
        public void CollectToGoal(UnityEngine.Vector3 goalPosition)
        {
            Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22);
            val_1.PlaySfx(type:  72, offset:  0.04f);
            Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemExplodeParticles val_2 = val_1.Spawn<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemExplodeParticles>(poolId:  62, activate:  true);
            UnityEngine.Vector3 val_5 = this.transform.position;
            val_2.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            val_2.Play();
            UnityEngine.Coroutine val_8 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  Royal.Scenes.Game.Mechanics.Items.CoinItem.Collect.CoinBezierCollect.CollectToGoal(itemView:  this, goalPosition:  new UnityEngine.Vector3() {x = goalPosition.x, y = goalPosition.y, z = goalPosition.z}, onComplete:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView::<CollectToGoal>b__19_0())));
        }
        public void PlayFlipAnimation(float time)
        {
            this.animator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView.CoinFlipAnimation, layer:  0, normalizedTime:  time);
        }
        public CoinItemView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private static CoinItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView.ShadowColor = 0;
            Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView.CoinIdleAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.CoinIdleAnimation");
            Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView.CoinFlipAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.CoinFlipAnimation");
        }
        private void <CollectToGoal>b__19_0()
        {
            var val_2 = 0;
            if(mem[1152921505107042304] != null)
            {
                    val_2 = val_2 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.CoinItem.View.ICoinItemViewDelegate val_1 = 1152921505107005440 + ((mem[1152921505107042312]) << 4);
            }
            
            this.itemViewDelegate.CollectAnimationCompleted();
        }
    
    }

}
