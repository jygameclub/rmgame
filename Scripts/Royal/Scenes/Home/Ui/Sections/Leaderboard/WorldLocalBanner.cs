using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Leaderboard
{
    public class WorldLocalBanner : MonoBehaviour
    {
        // Fields
        public const int World = 1;
        public const int Local = 2;
        public UnityEngine.SpriteRenderer[] worldBgs;
        public UnityEngine.SpriteRenderer[] localBgs;
        public TMPro.TextMeshPro worldText;
        public TMPro.TextMeshPro localText;
        public UnityEngine.Sprite selectedBg;
        public UnityEngine.Sprite defaultBg;
        public UnityEngine.Material selectedTextMat;
        public UnityEngine.Material defaultTextMat;
        public int currentSelection;
        private System.Action onSelectWorld;
        private System.Action onSelectLocal;
        
        // Methods
        public void add_onSelectWorld(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.onSelectWorld, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.onSelectWorld != 1152921519064544320);
            
            return;
            label_2:
        }
        public void remove_onSelectWorld(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.onSelectWorld, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.onSelectWorld != 1152921519064680896);
            
            return;
            label_2:
        }
        public void add_onSelectLocal(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.onSelectLocal, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.onSelectLocal != 1152921519064817480);
            
            return;
            label_2:
        }
        public void remove_onSelectLocal(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.onSelectLocal, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.onSelectLocal != 1152921519064954056);
            
            return;
            label_2:
        }
        public void Init(int type)
        {
            this.currentSelection = type;
            this.ArrangeViewBySelection();
        }
        public void OnSelectWorld()
        {
            this.currentSelection = 1;
            this.ArrangeViewBySelection();
            if(this.onSelectWorld == null)
            {
                    return;
            }
            
            this.onSelectWorld.Invoke();
        }
        public void OnSelectLocal()
        {
            this.currentSelection = 2;
            this.ArrangeViewBySelection();
            if(this.onSelectLocal == null)
            {
                    return;
            }
            
            this.onSelectLocal.Invoke();
        }
        public bool IsWorld()
        {
            return (bool)(this.currentSelection == 1) ? 1 : 0;
        }
        public bool IsLocal()
        {
            return (bool)(this.currentSelection == 2) ? 1 : 0;
        }
        private void ArrangeViewBySelection()
        {
            UnityEngine.Material val_1;
            if(this.currentSelection == 1)
            {
                    this.ReplaceSprites(bgs:  this.worldBgs, newSprite:  this.selectedBg);
                this.ReplaceSprites(bgs:  this.localBgs, newSprite:  this.defaultBg);
                this.worldText.fontMaterial = this.selectedTextMat;
                val_1 = this.defaultTextMat;
            }
            else
            {
                    this.ReplaceSprites(bgs:  this.worldBgs, newSprite:  this.defaultBg);
                this.ReplaceSprites(bgs:  this.localBgs, newSprite:  this.selectedBg);
                this.worldText.fontMaterial = this.defaultTextMat;
                val_1 = this.selectedTextMat;
            }
            
            this.localText.fontMaterial = val_1;
        }
        private void ReplaceSprites(UnityEngine.SpriteRenderer[] bgs, UnityEngine.Sprite newSprite)
        {
            if(bgs.Length < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                bgs[val_2].sprite = newSprite;
                val_2 = val_2 + 1;
            }
            while(val_2 < bgs.Length);
        
        }
        public WorldLocalBanner()
        {
        
        }
    
    }

}
