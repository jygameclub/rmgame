using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View
{
    public class LightballItemBg : MonoBehaviour, IPoolable
    {
        // Fields
        public UnityEngine.SpriteRenderer colorBg;
        public UnityEngine.SpriteRenderer whiteBg;
        public UnityEngine.ParticleSystem rayTipParticle;
        public UnityEngine.Color[] spriteColors;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.Config.ItemType itemType, Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            var val_16;
            float val_18;
            val_16 = itemType;
            if(val_16 != 1)
            {
                goto label_1;
            }
            
            UnityEngine.Transform val_1 = this.colorBg.transform;
            if(matchType != 5)
            {
                goto label_3;
            }
            
            val_1.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Transform val_2 = this.whiteBg.transform;
            val_18 = 2.2f;
            goto label_6;
            label_1:
            this.colorBg.enabled = false;
            this.whiteBg.enabled = false;
            goto label_9;
            label_3:
            val_1.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_18 = 2.1f;
            label_6:
            this.whiteBg.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory val_4 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            val_16 = val_4.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemAssets>();
            this.colorBg.enabled = true;
            this.colorBg.sprite = val_16.GetSpriteFromMatchType(type:  matchType);
            UnityEngine.Color val_7 = this.GetSpriteColorFromMatchType(type:  matchType);
            this.colorBg.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            this.colorBg.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            this.whiteBg.enabled = true;
            this.whiteBg.sprite = val_16.GetSpriteFromMatchType(type:  matchType);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            this.whiteBg.transform.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            label_9:
            int val_14 = (sortingData.layer >> 32) + 1;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.whiteBg, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false});
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.colorBg, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything & 4294967295});
        }
        public void PlayRayTipParticle()
        {
            if(this.rayTipParticle != null)
            {
                    this.rayTipParticle.Play();
                return;
            }
            
            throw new NullReferenceException();
        }
        public int GetPoolId()
        {
            return 23;
        }
        public void OnSpawn()
        {
        
        }
        public void OnRecycle()
        {
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
            val_1.localRotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
            val_1.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private UnityEngine.Color GetSpriteColorFromMatchType(Royal.Scenes.Game.Mechanics.Matches.MatchType type)
        {
            if((type - 1) <= 5)
            {
                    var val_2 = 36610248 + ((type - 1)) << 2;
                val_2 = val_2 + 36610248;
            }
            else
            {
                    return new UnityEngine.Color() {r = -2.631914E+07f, g = -2.631914E+07f, b = -2.631914E+07f, a = -2.631914E+07f};
            }
        
        }
        public void RecycleSelf()
        {
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1).Recycle<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemBg>(go:  this);
        }
        public LightballItemBg()
        {
        
        }
    
    }

}
