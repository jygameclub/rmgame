using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View
{
    public class CookieCollectData
    {
        // Fields
        public readonly Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemView itemView;
        public Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieGoalView goalView;
        
        // Methods
        public CookieCollectData(Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemView itemView)
        {
            this.itemView = itemView;
        }
    
    }

}
