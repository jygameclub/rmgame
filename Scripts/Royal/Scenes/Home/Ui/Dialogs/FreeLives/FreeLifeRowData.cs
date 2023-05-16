using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.FreeLives
{
    public class FreeLifeRowData : IUiScrollContentData
    {
        // Fields
        public readonly string senderName;
        public readonly long lifeId;
        public readonly Royal.Scenes.Home.Ui.Dialogs.FreeLives.FreeLivesDialog livesDialog;
        
        // Methods
        public FreeLifeRowData(Royal.Scenes.Home.Ui.Dialogs.FreeLives.FreeLivesDialog livesDialog, string senderName, long lifeId)
        {
            val_1 = new System.Object();
            this.lifeId = lifeId;
            this.livesDialog = livesDialog;
            this.senderName = val_1;
        }
    
    }

}
