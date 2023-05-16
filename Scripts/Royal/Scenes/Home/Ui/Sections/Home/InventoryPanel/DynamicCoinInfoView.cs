using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel
{
    public class DynamicCoinInfoView : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform coin;
        public TMPro.TextMeshPro coinsText;
        
        // Methods
        public void PlayHitAnimation(int amount)
        {
            this.coinsText.text = amount.ToString();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.95f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.05f), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.DynamicCoinInfoView::<PlayHitAnimation>b__2_0()));
        }
        public DynamicCoinInfoView()
        {
        
        }
        private void <PlayHitAnimation>b__2_0()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_3 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.05f);
        }
    
    }

}
