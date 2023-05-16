using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel
{
    public class UserInfoPanel : TopSectionUi
    {
        // Fields
        public static UnityEngine.Vector3 coinInfoViewPosition;
        public Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.CoinInfoView coinInfoView;
        public Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.LifeInfoView lifeInfoView;
        public Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.StarInfoView starInfoView;
        public UnityEngine.GameObject basic;
        public Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessBar.MadnessBarInfoView madnessBarInfoView;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Vector3 val_2 = this.GetTargetPosition();
            this.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector3 val_4 = this.coinInfoView.transform.position;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.UserInfoPanel.coinInfoViewPosition = val_4.x;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.UserInfoPanel.coinInfoViewPosition.__il2cppRuntimeField_4 = val_4.y;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.UserInfoPanel.coinInfoViewPosition.__il2cppRuntimeField_8 = val_4.z;
        }
        public override void Init(float cameraWidth)
        {
        
        }
        public void ChangeSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            UnityEngine.Rendering.SortingGroup val_5 = this.basic.GetComponent<UnityEngine.Rendering.SortingGroup>();
            if(val_5 == 0)
            {
                    val_5 = this.basic.AddComponent<UnityEngine.Rendering.SortingGroup>();
            }
            
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  val_5, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything & 4294967295});
        }
        public void ResetSorting()
        {
            UnityEngine.Rendering.SortingGroup val_1 = this.basic.GetComponent<UnityEngine.Rendering.SortingGroup>();
            if(val_1 == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  val_1);
        }
        public UnityEngine.Vector3 GetOffsetForIcons()
        {
            if(this.madnessBarInfoView.isActive == false)
            {
                    return UnityEngine.Vector3.zero;
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.down;
            return UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  1.316f);
        }
        public UserInfoPanel()
        {
        
        }
    
    }

}
