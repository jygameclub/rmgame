using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.PotionItem.View
{
    public class PotionItemView : ItemView
    {
        // Fields
        private static readonly int PotionsIdleAnimation;
        private static readonly int PotionsShakeAnimation1;
        public UnityEngine.Animator potionsAnimator;
        public UnityEngine.Transform potionsContainer;
        private Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemAssets itemAssets;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager levelRandomManager;
        private readonly Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView[] potions;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate viewDelegate, UnityEngine.Vector3 position, bool isPredefined, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType> matchTypes)
        {
            this.levelRandomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            this.itemAssets = Load<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemAssets>();
            if(isPredefined != false)
            {
                    this.InitPredefinedPotions(matchTypes:  matchTypes);
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.PotionItem.PotionItemHelper val_6 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.PotionItem.PotionItemHelper>(contextId:  24);
                if(val_3.missingMatchTypeCalculated != true)
            {
                    val_6 = true;
                val_6.FindMissingMatchType(potionMatchTypes:  matchTypes);
            }
            
                this.InitDefaultPotions(missingType:  val_3.missingMatchType);
            }
            
            var val_9 = 4;
            label_15:
            int val_4 = val_9 - 4;
            if(val_4 >= this.potions.Length)
            {
                goto label_8;
            }
            
            this.potions[0].transform.SetParent(p:  this.potionsContainer);
            this.potions[0].ShowAt(index:  val_4);
            val_9 = val_9 + 1;
            if(this.potions != null)
            {
                goto label_15;
            }
            
            label_8:
            this.levelRandomManager.ShuffleArray<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView>(array:  this.potions);
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.potionsAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemView.PotionsIdleAnimation, layer:  0, normalizedTime:  0f);
        }
        private void InitPredefinedPotions(System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType> matchTypes)
        {
            Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView val_3;
            bool val_3 = true;
            if(val_3 < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                val_3 = 27824.Spawn<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView>(poolId:  52, activate:  true);
                if(val_4 >= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = val_3 + 0;
                Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView val_2 = val_3.Init(type:  (true + 0) + 32, itemAssets:  this.itemAssets);
                this.potions[val_4] = val_3;
                val_4 = val_4 + 1;
            }
            while(val_4 < this.potions[val_4]);
        
        }
        private void InitDefaultPotions(Royal.Scenes.Game.Mechanics.Matches.MatchType missingType)
        {
            Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView[] val_35;
            Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemAssets val_36;
            Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView[] val_37;
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_38;
            if((missingType - 1) <= 3)
            {
                    var val_30 = 36613936 + ((missingType - 1)) << 2;
                val_30 = val_30 + 36613936;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView val_22 = 27823.Spawn<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView>(poolId:  52, activate:  true);
                Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView val_23 = val_22.Init(type:  4, itemAssets:  this.itemAssets);
                this.potions = val_22;
                Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView val_24 = X0.Spawn<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView>(poolId:  52, activate:  true);
                Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView val_25 = val_24.Init(type:  3, itemAssets:  this.itemAssets);
                this.potions = val_24;
                Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView val_26 = X0.Spawn<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView>(poolId:  52, activate:  true);
                Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView val_27 = val_26.Init(type:  1, itemAssets:  this.itemAssets);
                this.potions = val_26;
                val_35 = this.potions;
                val_36 = this.itemAssets;
                val_37 = X0.Spawn<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView>(poolId:  52, activate:  true);
                val_38 = 2;
                Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView val_29 = val_37.Init(type:  val_38, itemAssets:  val_36);
                val_35 = val_37;
            }
        
        }
        private Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView GetPotionByType(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView[] val_2;
            Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView val_3;
            val_2 = this.potions;
            var val_2 = 0;
            label_6:
            if(val_2 >= this.potions.Length)
            {
                goto label_1;
            }
            
            val_3 = val_2[val_2];
            if(val_3.IsActive() != false)
            {
                    if(this.potions[0x0][0].matchType == matchType)
            {
                    return val_3;
            }
            
            }
            
            val_2 = this.potions;
            val_2 = val_2 + 1;
            if(val_2 != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_1:
            val_3 = val_2[0];
            return val_3;
        }
        public override bool IsOneCellItem()
        {
            return false;
        }
        public override int GetPoolId()
        {
            return 51;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            var val_3 = 4;
            do
            {
                if((val_3 - 4) >= (this.potions.Length << ))
            {
                    return;
            }
            
                27826.Recycle<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView>(go:  this.potions[0]);
                this.potions = 0;
                val_3 = val_3 + 1;
            }
            while(this.potions != null);
            
            throw new NullReferenceException();
        }
        public override UnityEngine.Vector3 GetMasterViewCenterPosition()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  0.5f);
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public void Damage(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            this.PlayShakeAnimation();
            this.ExplodePotion(matchType:  matchType);
            this.PlayPotionAnimation();
        }
        public void Explode()
        {
            27821.PlaySfx(type:  214, offset:  0.04f);
            Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemExplodeParticles val_1 = 27821.Spawn<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemExplodeParticles>(poolId:  54, activate:  true);
            val_1.Play();
            UnityEngine.Transform val_2 = val_1.transform;
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_2.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            val_2.Recycle<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemView>(go:  this);
        }
        private void ExplodePotion(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            PlaySfx(type:  ((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5).Next(min:  0, max:  2)) != 0) ? (212 + 1) : 212, offset:  0.04f);
            Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView val_4 = this.GetPotionByType(matchType:  matchType);
            Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemSingleExplodeParticles val_5 = Spawn<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemSingleExplodeParticles>(poolId:  53, activate:  true);
            val_5.Play(splashSprite:  this.itemAssets.GetLiquid(matchType:  matchType, startIndex:  10), dropSprite:  this.itemAssets.GetLiquid(matchType:  matchType, startIndex:  15));
            UnityEngine.Vector3 val_10 = val_4.transform.position;
            val_5.transform.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            val_4.SetActive(active:  false);
            if(Royal.Player.Context.Units.LevelManager.IsStoryLevel == false)
            {
                    return;
            }
            
            StoryItemCollection val_13 = UnityEngine.Object.Instantiate<StoryItemCollection>(original:  UnityEngine.Resources.Load<StoryItemCollection>(path:  "StoryItemCollected"));
            UnityEngine.Vector3 val_16 = val_4.transform.position;
            val_13.transform.position = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            val_13.Init();
        }
        private void PlayShakeAnimation()
        {
            this.potionsAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemView.PotionsShakeAnimation1, layer:  0, normalizedTime:  0f);
        }
        private void PlayPotionAnimation()
        {
            this.levelRandomManager.ShuffleArray<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView>(array:  this.potions);
            var val_4 = 0;
            var val_3 = 0;
            do
            {
                if(val_4 >= this.potions.Length)
            {
                    return;
            }
            
                Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView val_2 = this.potions[val_4];
                if(val_2.IsActive() != false)
            {
                    val_2.PlayAnimation(order:  0);
                val_3 = val_3 + 2;
            }
            
                val_4 = val_4 + 1;
            }
            while(this.potions != null);
            
            throw new NullReferenceException();
        }
        public override bool IsReverseSorted()
        {
            return true;
        }
        public PotionItemView()
        {
            this.potions = new Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionBottleView[4];
        }
        private static PotionItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemView.PotionsIdleAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.PotionsIdleAnimation");
            Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemView.PotionsShakeAnimation1 = UnityEngine.Animator.StringToHash(name:  "Base Layer.PotionsShakeAnimation1");
        }
    
    }

}
