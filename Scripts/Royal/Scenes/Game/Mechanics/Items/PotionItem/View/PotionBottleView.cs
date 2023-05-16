using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.PotionItem.View
{
    public class PotionBottleView : MonoBehaviour, IPoolable
    {
        // Fields
        private static readonly int PotionIdleAnimation;
        private static readonly int PotionAnimation1;
        private static readonly int PotionAnimation2;
        private static readonly int PotionAnimation3;
        private static readonly int PotionAnimation4;
        private const float TopX = 0.38;
        private const float TopY = 0.294;
        private const float BottomX = 0.395;
        private const float BottomY = -0.361;
        public UnityEngine.Rendering.SortingGroup sortingGroup;
        public UnityEngine.Animator potionAnimator;
        public UnityEngine.SpriteRenderer liquidA;
        public UnityEngine.SpriteRenderer liquidB;
        public UnityEngine.SpriteRenderer liquidC;
        public Royal.Scenes.Game.Mechanics.Matches.MatchType matchType;
        
        // Methods
        public int GetPoolId()
        {
            return 52;
        }
        public void OnSpawn()
        {
        
        }
        public void OnRecycle()
        {
        
        }
        public Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView Init(Royal.Scenes.Game.Mechanics.Matches.MatchType type, Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemAssets itemAssets)
        {
            this.matchType = type;
            this.liquidA.sprite = itemAssets.GetLiquid(matchType:  type, startIndex:  0);
            this.liquidB.sprite = itemAssets.GetLiquid(matchType:  this.matchType, startIndex:  5);
            this.liquidC.sprite = itemAssets.GetLiquid(matchType:  this.matchType, startIndex:  20);
            return (Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView)this;
        }
        public void ShowAt(int index)
        {
            this.PreparePositionAndSorting(index:  index);
            this.potionAnimator.speed = 0.8f;
            this.potionAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView.BottomY, layer:  0, normalizedTime:  0f);
        }
        private void PreparePositionAndSorting(int index)
        {
            var val_9;
            if(index > 3)
            {
                    return;
            }
            
            var val_9 = 36613900 + (index) << 2;
            val_9 = this.transform;
            val_9 = val_9 + 36613900;
            goto (36613900 + (index) << 2 + 36613900);
        }
        public bool IsActive()
        {
            return this.gameObject.activeSelf;
        }
        public void SetActive(bool active)
        {
            this.gameObject.SetActive(value:  active);
        }
        public void PlayAnimation(int order)
        {
            this.Invoke(methodName:  "PlayRandomAnimation", time:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  (float)order + 1));
        }
        private void PlayRandomAnimation()
        {
            UnityEngine.Animator val_3;
            int val_4;
            if(this.IsActive() == false)
            {
                    return;
            }
            
            float val_2 = UnityEngine.Random.value;
            if(val_2 < 0)
            {
                goto label_4;
            }
            
            if(val_2 < 0)
            {
                goto label_5;
            }
            
            val_3 = this.potionAnimator;
            if(val_2 < 0)
            {
                goto label_6;
            }
            
            val_4 = Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView.PotionAnimation4;
            goto label_18;
            label_4:
            val_3 = this.potionAnimator;
            val_4 = Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView.PotionAnimation1;
            goto label_18;
            label_5:
            val_3 = this.potionAnimator;
            val_4 = Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView.PotionAnimation2;
            goto label_18;
            label_6:
            val_4 = Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView.PotionAnimation3;
            label_18:
            val_3.Play(stateNameHash:  val_4, layer:  0, normalizedTime:  0f);
        }
        private static int RandomValue()
        {
            var val_3;
            float val_1 = UnityEngine.Random.value;
            if(val_1 < 0)
            {
                goto label_0;
            }
            
            if(val_1 < 0)
            {
                goto label_1;
            }
            
            var val_2 = (val_1 >= 0) ? 4 : 3;
            return (int)val_3;
            label_0:
            val_3 = 1;
            return (int)val_3;
            label_1:
            val_3 = 2;
            return (int)val_3;
        }
        public PotionBottleView()
        {
        
        }
        private static PotionBottleView()
        {
            Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView.BottomY = UnityEngine.Animator.StringToHash(name:  "Base Layer.PotionIdleAnimation");
            Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView.PotionAnimation1 = UnityEngine.Animator.StringToHash(name:  "Base Layer.PotionAnimation1");
            Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView.PotionAnimation2 = UnityEngine.Animator.StringToHash(name:  "Base Layer.PotionAnimation2");
            Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView.PotionAnimation3 = UnityEngine.Animator.StringToHash(name:  "Base Layer.PotionAnimation3");
            Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView.PotionAnimation4 = UnityEngine.Animator.StringToHash(name:  "Base Layer.PotionAnimation4");
        }
    
    }

}
