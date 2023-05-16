using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View
{
    public class MailCollectData
    {
        // Fields
        public readonly Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxItemView itemView;
        public Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailGoalView goalView;
        
        // Methods
        public MailCollectData(Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxItemView itemView)
        {
            this.itemView = itemView;
        }
    
    }

}
