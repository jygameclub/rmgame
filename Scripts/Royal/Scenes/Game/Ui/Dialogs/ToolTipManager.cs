using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs
{
    public class ToolTipManager
    {
        // Fields
        private readonly Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private readonly Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private UnityEngine.GameObject currentToolTip;
        private long lastActionFrame;
        private Royal.Infrastructure.UiComponents.Touch.ITouchable lastTouchedButton;
        private Royal.Infrastructure.UiComponents.Touch.ITouchable lastClosedButton;
        private Royal.Infrastructure.UiComponents.Touch.ITouchable currentButton;
        private bool isOpen;
        
        // Methods
        public ToolTipManager()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.uiTouchListener = val_2;
            val_2.add_OnDelayMouseUp(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Dialogs.ToolTipManager::MouseUp()));
            this.uiTouchListener.add_OnMouseDown(value:  new System.Action<Royal.Infrastructure.UiComponents.Touch.ITouchable>(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Dialogs.ToolTipManager::CloseTooltip(Royal.Infrastructure.UiComponents.Touch.ITouchable touchable)));
            this.isOpen = false;
        }
        protected override void Finalize()
        {
            if(this.uiTouchListener != null)
            {
                    this.uiTouchListener.remove_OnDelayMouseUp(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Dialogs.ToolTipManager::MouseUp()));
                this.uiTouchListener.remove_OnMouseDown(value:  new System.Action<Royal.Infrastructure.UiComponents.Touch.ITouchable>(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Dialogs.ToolTipManager::CloseTooltip(Royal.Infrastructure.UiComponents.Touch.ITouchable touchable)));
            }
            
            this.Finalize();
        }
        public void ToggleTooltip(UnityEngine.Transform parent, Royal.Infrastructure.UiComponents.Touch.ITouchable touchable, Royal.Scenes.Game.Ui.Dialogs.ToolTipManager.Direction direction, UnityEngine.Vector3 pos, float bodyPosition, string text)
        {
            if((this.ToggleTooltip(touchable:  touchable, direction:  direction, pos:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, bodyPosition:  bodyPosition, text:  text)) == false)
            {
                    return;
            }
            
            this.currentToolTip.transform.SetParent(p:  parent);
        }
        public UnityEngine.GameObject ToggleTooltip(UnityEngine.Transform parent, Royal.Infrastructure.UiComponents.Touch.ITouchable touchable, UnityEngine.Vector3 pos, UnityEngine.GameObject toolTip)
        {
            if((this.ToggleTooltip(touchable:  touchable, pos:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, toolTip:  toolTip)) == false)
            {
                    return (UnityEngine.GameObject)this.currentToolTip;
            }
            
            this.currentToolTip.transform.SetParent(p:  parent);
            return (UnityEngine.GameObject)this.currentToolTip;
        }
        private bool ToggleTooltip(Royal.Infrastructure.UiComponents.Touch.ITouchable touchable, Royal.Scenes.Game.Ui.Dialogs.ToolTipManager.Direction direction, UnityEngine.Vector3 pos, float bodyPosition, string text)
        {
            var val_2;
            if((this.CanOpenTooltip(touchable:  touchable)) != false)
            {
                    this.OpenTooltip(touchable:  touchable, direction:  direction, pos:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, bodyPosition:  bodyPosition, text:  text);
                val_2 = 1;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        private bool ToggleTooltip(Royal.Infrastructure.UiComponents.Touch.ITouchable touchable, UnityEngine.Vector3 pos, UnityEngine.GameObject toolTip)
        {
            var val_2;
            if((this.CanOpenTooltip(touchable:  touchable)) != false)
            {
                    this.OpenTooltip(touchable:  touchable, pos:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, toolTip:  toolTip);
                val_2 = 1;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        private bool CanOpenTooltip(Royal.Infrastructure.UiComponents.Touch.ITouchable touchable)
        {
            if(this.isOpen != false)
            {
                    this.CloseTooltip(touchable:  this.currentButton);
                return false;
            }
            
            if(this.lastClosedButton != touchable)
            {
                    return true;
            }
            
            if(this.lastTouchedButton == touchable)
            {
                    return false;
            }
            
            return true;
        }
        private void OpenTooltip(Royal.Infrastructure.UiComponents.Touch.ITouchable touchable, Royal.Scenes.Game.Ui.Dialogs.ToolTipManager.Direction direction, UnityEngine.Vector3 pos, float bodyPosition, string text)
        {
            this.audioManager.PlaySound(type:  2, offset:  0.04f);
            Royal.Infrastructure.UiComponents.Dialog.DialogManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            Royal.Scenes.Home.Ui.Dialogs.Tooltip.TextTooltip val_2 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.Tooltip.TextTooltip>(original:  val_1.commonDialogAssets.textTooltip);
            val_2.PrepareTooltip(direction:  direction, bodyPosition:  bodyPosition, message:  text);
            this.currentToolTip = val_2.gameObject;
            this.PrepareTooltip(touchable:  touchable, pos:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z});
        }
        private void OpenTooltip(Royal.Infrastructure.UiComponents.Touch.ITouchable touchable, UnityEngine.Vector3 pos, UnityEngine.GameObject toolTip)
        {
            this.audioManager.PlaySound(type:  2, offset:  0.04f);
            this.currentToolTip = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  toolTip);
            this.PrepareTooltip(touchable:  touchable, pos:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z});
        }
        private void PrepareTooltip(Royal.Infrastructure.UiComponents.Touch.ITouchable touchable, UnityEngine.Vector3 pos)
        {
            this.lastActionFrame = (long)UnityEngine.Time.frameCount;
            this.currentToolTip.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.currentButton = touchable;
            this.currentToolTip.transform.position = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.currentToolTip.transform, endValue:  1f, duration:  0.17f), ease:  27);
            this.isOpen = true;
        }
        private void CloseTooltip(Royal.Infrastructure.UiComponents.Touch.ITouchable touchable)
        {
            if(this.isOpen == false)
            {
                    return;
            }
            
            this.lastTouchedButton = touchable;
            this.lastClosedButton = this.currentButton;
            UnityEngine.Object.Destroy(obj:  this.currentToolTip);
            this.currentToolTip = 0;
            this.lastActionFrame = (long)UnityEngine.Time.frameCount;
            this.isOpen = false;
        }
        public void CloseTooltip()
        {
            if(this.currentButton == null)
            {
                    return;
            }
            
            this.CloseTooltip(touchable:  this.currentButton);
        }
        private void MouseUp()
        {
            if(this.lastActionFrame == (UnityEngine.Time.frameCount << ))
            {
                    return;
            }
            
            this.lastActionFrame = (long)UnityEngine.Time.frameCount;
            this.lastClosedButton = 0;
            this.currentButton = 0;
        }
    
    }

}
