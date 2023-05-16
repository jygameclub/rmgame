using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Tutorial
{
    public class HomeTutorialHighlightHelper
    {
        // Fields
        private readonly Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialViewAssets assets;
        private Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialBlackView blackView;
        private Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialMaskView maskView;
        private System.Action OnBackgroundClicked;
        
        // Methods
        public void add_OnBackgroundClicked(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnBackgroundClicked, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnBackgroundClicked != 1152921519557933320);
            
            return;
            label_2:
        }
        public void remove_OnBackgroundClicked(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnBackgroundClicked, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnBackgroundClicked != 1152921519558069896);
            
            return;
            label_2:
        }
        public HomeTutorialHighlightHelper(Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialViewAssets assets)
        {
            this.assets = assets;
        }
        public void HighlightArea(UnityEngine.Vector3 centerPos, float width, float height)
        {
            this.ShowBlack();
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialMaskView val_2 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialMaskView>(original:  this.assets.homeTutorialMaskView, parent:  this.blackView.renderParent.transform);
            this.maskView = val_2;
            val_2.ArrangeArea(centerPosition:  new UnityEngine.Vector3() {x = centerPos.x, y = centerPos.y, z = centerPos.z}, width:  width, height:  height);
        }
        public void DisableHighlight()
        {
            if(this.blackView != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.blackView.gameObject);
                this.blackView = 0;
            }
            
            UnityEngine.Object.Destroy(obj:  this.maskView.gameObject);
        }
        private void ShowBlack()
        {
            if(this.blackView != 0)
            {
                    return;
            }
            
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialBlackView val_2 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialBlackView>(original:  this.assets.blackView);
            this.blackView = val_2;
            val_2.Show(delay:  0.33f, fadeDuration:  0.43f, onComplete:  0, darkness:  0.7f);
            this.blackView.add_OnBackgroundClicked(value:  this.OnBackgroundClicked);
        }
    
    }

}
