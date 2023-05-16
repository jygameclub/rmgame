using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View
{
    public class CurtainItemToken : MonoBehaviour
    {
        // Fields
        public const int NoDamage = -1;
        public const int LeftDamage = 0;
        public const int RightDamage = 2;
        public const int TopDamage = 3;
        public const int BottomDamage = 4;
        public int curtainHeight;
        private int CurtainTokenLeft;
        private int CurtainTokenRight;
        private int CurtainTokenExplode;
        public UnityEngine.SpriteRenderer token;
        public TMPro.TextMeshPro countText;
        public UnityEngine.Animator animator;
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainHitParticles curtainHitParticles;
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainHitParticles curtainFinalHitParticles;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemAssets curtainAssets;
        private Royal.Scenes.Game.Mechanics.Matches.MatchType matchType;
        
        // Methods
        public void UpdateTokenSprite(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            this.matchType = matchType;
            this.UpdateTokenNames();
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemAssets val_2 = val_1.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemAssets>();
            this.curtainAssets = val_2;
            this.token.sprite = val_2.GetTokenSprite(matchType:  matchType);
            this.countText.fontMaterial = this.curtainAssets.GetTokenMaterial(matchType:  matchType);
            Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainHitParticles val_7 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainHitParticles>(original:  this.curtainAssets.GetCurtainHitParticles(), parent:  this.token.transform);
            this.curtainHitParticles = val_7;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            val_7.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_10 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetCurtainTokenSorting();
            this.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_10.layer, order = val_10.order, sortEverything = val_10.sortEverything & 4294967295});
            this.animator.enabled = false;
        }
        public void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            sortingData.sortEverything = sortingData.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything});
        }
        private void UpdateTokenNames()
        {
            this.CurtainTokenLeft = this.GetAnimationHash(direction:  "Left");
            this.CurtainTokenRight = this.GetAnimationHash(direction:  "Right");
            this.CurtainTokenExplode = this.GetAnimationHash(direction:  "Explode");
        }
        public int GetAnimationHash(string direction)
        {
            return (int)UnityEngine.Animator.StringToHash(name:  System.String.Format(format:  "Base Layer.Token{0}{1}", arg0:  this.curtainHeight, arg1:  direction));
        }
        public void UpdateTokenCount(int count, int damageDirection = -1)
        {
            float val_4;
            int val_8;
            this.countText.text = count.ToString();
            UnityEngine.AnimatorStateInfo val_2 = this.animator.GetCurrentAnimatorStateInfo(layerIndex:  0);
            if((val_4 >= 0.6f) || (this.animator.enabled == false))
            {
                goto label_5;
            }
            
            if(damageDirection != 1)
            {
                goto label_11;
            }
            
            goto label_9;
            label_5:
            this.animator.enabled = true;
            if(damageDirection == 1)
            {
                goto label_9;
            }
            
            if(damageDirection == 2)
            {
                goto label_10;
            }
            
            if(damageDirection != 0)
            {
                goto label_11;
            }
            
            val_8 = this.CurtainTokenLeft;
            goto label_13;
            label_10:
            val_8 = this.CurtainTokenRight;
            label_13:
            this.animator.Play(stateNameHash:  val_8, layer:  0, normalizedTime:  0f);
            label_11:
            this.curtainHitParticles.particles.Play();
            label_9:
            if(count != 0)
            {
                    return;
            }
            
            if(this.curtainFinalHitParticles != 0)
            {
                    return;
            }
            
            this.PlayCurtainFinalHit();
        }
        public float PlayTokenExplode()
        {
            var val_4;
            float val_5;
            this.animator.CrossFade(stateHashName:  this.CurtainTokenExplode, normalizedTransitionDuration:  0.1f, layer:  0, normalizedTimeOffset:  0f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_2 = DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.countText, endValue:  0f, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  30f));
            if((this.curtainHeight - 8) < 2)
            {
                goto label_4;
            }
            
            if(this.curtainHeight == 10)
            {
                goto label_5;
            }
            
            if(this.curtainHeight != 11)
            {
                goto label_6;
            }
            
            label_4:
            val_4 = null;
            val_5 = 70f;
            return Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  val_5 = 65f);
            label_5:
            val_4 = null;
            val_5 = 75f;
            return Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  val_5);
            label_6:
            val_4 = null;
            return Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  val_5);
        }
        public void PlayCurtainFinalHit()
        {
            UnityEngine.Debug.Log(message:  "Play final hit particles");
            Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainHitParticles val_3 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainHitParticles>(original:  this.curtainAssets.GetCurtainFinalHitParticles(), parent:  this.token.transform);
            this.curtainFinalHitParticles = val_3;
            val_3.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.curtainFinalHitParticles.particles.Play();
        }
        public void PlayCurtainTokenExplodeParticles()
        {
            Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainTokenExplodeParticles val_2 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainTokenExplodeParticles>(original:  this.curtainAssets.GetCurtainTokenExplodeParticles());
            UnityEngine.Vector3 val_5 = this.token.transform.position;
            val_2.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            val_2.Play(tokenColor:  this.matchType, curtainHeight:  this.curtainHeight);
        }
        public CurtainItemToken()
        {
        
        }
    
    }

}
