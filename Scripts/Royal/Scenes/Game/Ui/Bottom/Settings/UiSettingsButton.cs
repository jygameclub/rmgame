using UnityEngine;

namespace Royal.Scenes.Game.Ui.Bottom.Settings
{
    public class UiSettingsButton : MonoBehaviour
    {
        // Fields
        private const float Angle = 180;
        private const float Duration = 0.6;
        private const float OutDuration = 0.6;
        private const float Amplitude = 1;
        private const float OutAmplitude = 1;
        public Royal.Scenes.Game.Ui.Bottom.Settings.SettingsDialog settingsDialog;
        public UnityEngine.Rendering.SortingGroup sortingGroup;
        public UnityEngine.Transform gear;
        public UnityEngine.Transform gearShadow;
        
        // Methods
        public void ButtonClick()
        {
            if(this.settingsDialog != null)
            {
                    this.settingsDialog.Open();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void SetSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData data)
        {
            this.sortingGroup.enabled = true;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.sortingGroup, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = data.layer, order = data.order, sortEverything = data.sortEverything & 4294967295});
        }
        public void ResetSorting()
        {
            if(this.sortingGroup != null)
            {
                    this.sortingGroup.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public void RotateIn()
        {
            DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this.gear, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.6f, mode:  3), ease:  27) = 1065353216;
            DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this.gearShadow, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.6f, mode:  3), ease:  27) = 1065353216;
        }
        public void RotateOut()
        {
            DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this.gear, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.6f, mode:  3), ease:  27) = 1065353216;
            DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this.gearShadow, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.6f, mode:  3), ease:  27) = 1065353216;
        }
        public UiSettingsButton()
        {
        
        }
    
    }

}
