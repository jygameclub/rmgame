using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.FreeLives
{
    public class FreeLifeRow : UiScrollContentItem
    {
        // Fields
        public Royal.Infrastructure.UiComponents.Button.UiScrollButton addButton;
        public TMPro.TextMeshPro nameText;
        public UnityEngine.Transform heartTransform;
        private Royal.Scenes.Home.Ui.Dialogs.FreeLives.FreeLifeRowData rowData;
        
        // Methods
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
            this.rowData = data;
            this.addButton = maskBounds.m_Extents.y;
            this.addButton = maskBounds.m_Center.x;
            this.nameText.text = this.rowData.senderName;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetDialogScrollContentSorting();
            bool val_2 = val_1.sortEverything & 4294967295;
            if(val_3.Length < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            do
            {
                this.GetComponentsInChildren<UnityEngine.SpriteRenderer>(includeInactive:  true)[val_5].maskInteraction = 1;
                val_5 = val_5 + 1;
            }
            while(val_5 < val_3.Length);
        
        }
        public override void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sorting)
        {
        
        }
        public void AddLife()
        {
            UnityEngine.Vector3 val_1 = this.heartTransform.position;
            this.rowData.livesDialog.AddLifeWithAnimation(lifeRow:  this, lifeId:  this.rowData.lifeId, position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public FreeLifeRow()
        {
        
        }
    
    }

}
