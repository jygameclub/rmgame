using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public abstract class RoyalPassModel
    {
        // Fields
        public UnityEngine.Transform parent;
        public bool hasView;
        public Royal.Player.Context.Units.RoyalPassManager royalPassManager;
        private UnityEngine.Vector3 localScale;
        private UnityEngine.Vector3 localPosition;
        
        // Properties
        public abstract Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassView View { get; }
        
        // Methods
        public abstract Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassView get_View(); // 0
        public RoyalPassModel(UnityEngine.Transform parent)
        {
            this.parent = parent;
            this.royalPassManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
        }
        public virtual void Show()
        {
            this.hasView = true;
        }
        public virtual void Hide()
        {
            this.hasView = false;
        }
    
    }

}
