using UnityEngine;

namespace Royal.Infrastructure.Contexts.Units.App.BackButton
{
    public class BackButtonListener
    {
        // Fields
        private Royal.Infrastructure.Utils.Counters.EnableCounter enableCounter;
        private System.Collections.Generic.List<Royal.Infrastructure.Contexts.Units.App.BackButton.IBackable> backables;
        private Royal.Infrastructure.UiComponents.Dialog.DialogManager dialogManager;
        
        // Methods
        public BackButtonListener()
        {
            this.enableCounter = new Royal.Infrastructure.Utils.Counters.EnableCounter();
            this.backables = new System.Collections.Generic.List<Royal.Infrastructure.Contexts.Units.App.BackButton.IBackable>(capacity:  5);
        }
        public void Bind()
        {
            this.dialogManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            System.Action val_3 = static_value_02DC1B30;
            val_3 = new System.Action(object:  this, method:  public System.Void Royal.Infrastructure.Contexts.Units.App.BackButton.BackButtonListener::Reset());
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Game.Context.GameContext>(id:  11).add_OnActivate(value:  val_3);
            System.Action val_5 = static_value_02DC1B30;
            val_5 = new System.Action(object:  this, method:  public System.Void Royal.Infrastructure.Contexts.Units.App.BackButton.BackButtonListener::Reset());
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.HomeContext>(id:  10).add_OnActivate(value:  val_5);
        }
        public void ManualUpdate()
        {
            if(this.enableCounter.IsEnabled() == false)
            {
                    return;
            }
            
            if((UnityEngine.Input.GetKeyDown(key:  27)) == false)
            {
                    return;
            }
            
            this.PressBack();
        }
        private void PressBack()
        {
            System.Collections.Generic.List<Royal.Infrastructure.Contexts.Units.App.BackButton.IBackable> val_3 = this.backables;
            if(W9 == 0)
            {
                goto label_2;
            }
            
            if(this.dialogManager.hasActiveDialog == true)
            {
                goto label_4;
            }
            
            val_3 = val_3 + ((W9 - 1) << 3);
            var val_4 = 0;
            if(mem[1152921505146552320] == null)
            {
                goto label_7;
            }
            
            val_4 = val_4 + 1;
            goto label_9;
            label_2:
            label_4:
            this.dialogManager.PressBack();
            return;
            label_7:
            Royal.Infrastructure.Contexts.Units.App.BackButton.BackButtonListener val_2 = 1152921505146515456 + ((mem[1152921505146552328]) << 4);
            label_9:
            this.PressBack();
        }
        public void AddBackable(Royal.Infrastructure.Contexts.Units.App.BackButton.IBackable backable)
        {
            if((this.backables.Contains(item:  backable)) != false)
            {
                    return;
            }
            
            this.backables.Add(item:  backable);
        }
        public void RemoveBackable(Royal.Infrastructure.Contexts.Units.App.BackButton.IBackable backable)
        {
            if((this.backables.Contains(item:  backable)) == false)
            {
                    return;
            }
            
            bool val_2 = this.backables.Remove(item:  backable);
        }
        public void Reset()
        {
            if(this.enableCounter != null)
            {
                    this.enableCounter.Reset();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void Enable()
        {
            if(this.enableCounter != null)
            {
                    this.enableCounter.Enable();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void Disable()
        {
            if(this.enableCounter != null)
            {
                    this.enableCounter.Disable();
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
