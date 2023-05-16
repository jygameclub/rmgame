using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SafeItem.View
{
    public class SafeItemView : ItemView
    {
        // Fields
        private static readonly int SafeIdleAnimation;
        private static readonly int SafeShakeAnimation1;
        private static readonly int CoinsAnimation1;
        public UnityEngine.Animator safeAnimator;
        public UnityEngine.Animator coinsAnimator;
        public UnityEngine.SpriteRenderer[] spriteRenderers;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate viewDelegate, UnityEngine.Vector3 position, int layer)
        {
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.coinsAnimator.gameObject.SetActive(value:  false);
            this.spriteRenderers[2].gameObject.SetActive(value:  true);
            var val_5 = 0;
            label_11:
            if(val_5 >= this.spriteRenderers.Length)
            {
                goto label_8;
            }
            
            this.spriteRenderers[val_5].enabled = true;
            val_5 = val_5 + 1;
            if(this.spriteRenderers != null)
            {
                goto label_11;
            }
            
            throw new NullReferenceException();
            label_8:
            this.safeAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemView.SafeIdleAnimation, layer:  0, normalizedTime:  0f);
        }
        public override bool IsOneCellItem()
        {
            return false;
        }
        public override int GetPoolId()
        {
            return 58;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
        
        }
        public override UnityEngine.Vector3 GetMasterViewCenterPosition()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  0.5f);
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public void Damage(int damagedLayer)
        {
            this.PlaySafeAnimation();
            this.PlaySound(damagedLayer:  damagedLayer);
            this.PlayParticles(damagedLayer:  damagedLayer);
            this.spriteRenderers[damagedLayer + 1].enabled = false;
            if(damagedLayer != 1)
            {
                    return;
            }
            
            this.PlayCoinsAnimation();
        }
        private void PlaySound(int damagedLayer)
        {
            if(this != null)
            {
                    if(damagedLayer == 4)
            {
                    this.PlaySfx(type:  251, offset:  0.04f);
                return;
            }
            
                this.PlaySfx(type:  250, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void Explode()
        {
            31114.PlaySfx(type:  249, offset:  0.04f);
            Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemExplodeParticles val_1 = 31114.Spawn<Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemExplodeParticles>(poolId:  60, activate:  true);
            val_1.Play();
            UnityEngine.Transform val_2 = val_1.transform;
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_2.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            val_2.Recycle<Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemView>(go:  this);
        }
        private void PlayParticles(int damagedLayer)
        {
            Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemSingleExplodeParticles val_1 = 31118.Spawn<Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemSingleExplodeParticles>(poolId:  59, activate:  true);
            val_1.Play(damagedLayer:  damagedLayer);
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        private void PlaySafeAnimation()
        {
            this.safeAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemView.SafeShakeAnimation1, layer:  0, normalizedTime:  0f);
        }
        private void PlayCoinsAnimation()
        {
            this.coinsAnimator.gameObject.SetActive(value:  true);
            this.coinsAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemView.CoinsAnimation1, layer:  0, normalizedTime:  0f);
        }
        public override bool IsReverseSorted()
        {
            return true;
        }
        public SafeItemView()
        {
        
        }
        private static SafeItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemView.SafeIdleAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.SafeIdleAnimation");
            Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemView.SafeShakeAnimation1 = UnityEngine.Animator.StringToHash(name:  "Base Layer.SafeShakeAnimation1");
            Royal.Scenes.Game.Mechanics.Items.SafeItem.View.SafeItemView.CoinsAnimation1 = UnityEngine.Animator.StringToHash(name:  "Base Layer.CoinsAnimation1");
        }
    
    }

}
