using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Dialog
{
    public class UiDialog : UiPanel
    {
        // Fields
        protected Royal.Scenes.Start.Context.Units.Flow.DialogAction action;
        
        // Methods
        public static T InstantiateFromResources<T>(string assetName, Royal.Scenes.Start.Context.Units.Flow.DialogAction action)
        {
            goto __RuntimeMethodHiddenParam + 48 + 8;
        }
        public static T Instantiate<T>(T asset, Royal.Scenes.Start.Context.Units.Flow.DialogAction action)
        {
            Royal.Scenes.Game.Ui.Dialogs.LevelFail.EgoDialog val_1 = asset;
            val_1 = action;
            return (Royal.Scenes.Game.Ui.Dialogs.LevelFail.EgoDialog)val_1;
        }
        public void SetSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData getDialogSorting)
        {
            getDialogSorting.sortEverything = getDialogSorting.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = getDialogSorting.layer, order = getDialogSorting.order, sortEverything = getDialogSorting.sortEverything});
        }
        public virtual void Show()
        {
            this.action.<DialogManager>k__BackingField.ShowDialog(uiDialog:  this);
        }
        public virtual void Close()
        {
            this.action.<DialogManager>k__BackingField.CloseDialog(uiDialog:  this, fast:  false);
        }
        public virtual void OnShow(UnityEngine.Vector3 position)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Transform val_2 = this.transform;
            val_2.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.01f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_2.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.02f);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_2, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.05f), ease:  6));
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  0.01f);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_2, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  0.12f), ease:  6));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_2, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.065f), ease:  6));
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_6, action:  new DG.Tweening.TweenCallback(object:  this, method:  typeof(Royal.Infrastructure.UiComponents.Dialog.UiDialog).__il2cppRuntimeField_288));
        }
        public virtual void OnClose(System.Action dialogClosed)
        {
            dialogClosed.Invoke();
            UnityEngine.Object.Destroy(obj:  this.gameObject);
            goto typeof(Royal.Scenes.Start.Context.Units.Flow.DialogAction).__il2cppRuntimeField_1B0;
        }
        protected virtual void AfterShowAnimation()
        {
        
        }
        public virtual void SkipFast()
        {
        
        }
        public virtual Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            mem[1152921527527799065] = 0;
            val_0.shouldCloseOnEscape = false;
            val_0.shouldCloseOnTouch = false;
            val_0.shouldCloseOnSwipe = false;
            val_0.shouldSkipFastOnTouch = false;
            val_0.shouldHideBackgroundOnShow = false;
            mem[1152921527527799062] = 0;
            val_0.backgroundFadeOutDuration = 0f;
            val_0.backgroundFadeOutDelay = 0f;
            val_0.shouldHideBackground = true;
            val_0.backgroundFadeAlpha = 0.8f;
            return val_0;
        }
        public virtual void PressEscape()
        {
            var val_1;
            if(val_1 == false)
            {
                    return;
            }
        
        }
        public virtual void CloseOnEscape()
        {
            goto typeof(Royal.Infrastructure.UiComponents.Dialog.UiDialog).__il2cppRuntimeField_250;
        }
        public UiDialog()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
