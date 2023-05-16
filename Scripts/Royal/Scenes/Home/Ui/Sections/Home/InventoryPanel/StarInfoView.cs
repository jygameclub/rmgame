using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel
{
    public class StarInfoView : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform star;
        public TMPro.TextMeshPro starsText;
        
        // Methods
        private void Awake()
        {
            add_OnStarUpdated(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.StarInfoView::UpdateStarText()));
            if(IsWin != false)
            {
                    this.starsText.text = (Royal.Player.Context.Data.Session.__il2cppRuntimeField_58 + 20).ToString();
                return;
            }
            
            this.UpdateStarText();
        }
        public void UpdateStarText()
        {
            this.starsText.text = typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_14.ToString();
        }
        public void OnButtonClick()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Star.ShowStarDialogAction(dialogType:  1));
        }
        public void PlayStarHitAnimation()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.8f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f)), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.StarInfoView::<PlayStarHitAnimation>b__5_0()));
            this.starsText.text = (Royal.Player.Context.Data.Session.__il2cppRuntimeField_58 + 24).ToString();
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_58.Consume();
        }
        public void ChangeSortingLayer(int sortingLayer)
        {
            T[] val_5 = this.gameObject.GetComponentsInChildren<UnityEngine.SpriteRenderer>();
            if(val_2.Length >= 1)
            {
                    var val_6 = 0;
                do
            {
                val_5[val_6].sortingLayerID = sortingLayer;
                val_6 = val_6 + 1;
            }
            while(val_6 < val_2.Length);
            
            }
            
            if(val_4.Length < 1)
            {
                    return;
            }
            
            do
            {
                this.gameObject.GetComponentsInChildren<TMPro.TextMeshPro>()[0].sortingLayerID = sortingLayer;
                val_5 = 0 + 1;
            }
            while(val_5 < val_4.Length);
        
        }
        public void FakeAddText(int count)
        {
            this.starsText.text = (System.Int32.Parse(s:  this.starsText.text)) + count.ToString();
        }
        private void OnDestroy()
        {
            remove_OnStarUpdated(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.StarInfoView::UpdateStarText()));
        }
        public void ShowAnimated(UnityEngine.Vector3 finalPosition, float delaySeconds)
        {
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = finalPosition.x, y = finalPosition.y, z = finalPosition.z}, duration:  0.3f, snapping:  false), ease:  27, overshoot:  1.2f), delay:  delaySeconds);
        }
        public StarInfoView()
        {
        
        }
        private void <PlayStarHitAnimation>b__5_0()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f));
        }
    
    }

}
