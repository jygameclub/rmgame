using UnityEngine;
private sealed class SettingsSection.<>c__DisplayClass32_0
{
    // Fields
    public Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
    public Royal.Scenes.Home.Ui.Sections.Settings.SettingsSection <>4__this;
    public System.Action <>9__1;
    
    // Methods
    public SettingsSection.<>c__DisplayClass32_0()
    {
    
    }
    internal void <ToggleFacebookConnect>b__0()
    {
        System.Action val_6;
        if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsConnectedFacebook()) != false)
        {
                val_6 = this.<>9__1;
            if(val_6 == null)
        {
                System.Action val_4 = null;
            val_6 = val_4;
            val_4 = new System.Action(object:  this, method:  System.Void SettingsSection.<>c__DisplayClass32_0::<ToggleFacebookConnect>b__1());
            this.<>9__1 = val_6;
        }
        
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Confirm.ShowConfirmDialogAction(title:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "AreYouSure?"), message:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "DisconnectFacebook?"), onConfirm:  val_4));
            return;
        }
        
        this.<>4__this.loginService.ConnectWithFacebook(origin:  0);
    }
    internal void <ToggleFacebookConnect>b__1()
    {
        this.<>4__this.loginService.DisconnectWithFacebook();
    }

}
