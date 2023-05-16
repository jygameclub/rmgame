using UnityEngine;

namespace Royal.Scenes.Game.Ui.Bottom.Boosters
{
    public class InGameBoosterButton : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterLockedAssets boosterLockedAssets;
        public UnityEngine.Rendering.SortingGroup sortingGroup;
        public TMPro.TextMeshPro countText;
        public UnityEngine.GameObject addBooster;
        public UnityEngine.GameObject count;
        public UnityEngine.SpriteRenderer icon;
        public Royal.Infrastructure.UiComponents.Button.UiButton button;
        private Royal.Scenes.Game.Mechanics.Boosters.BoosterType <BoosterType>k__BackingField;
        private Royal.Infrastructure.UiComponents.Touch.ZIndex initialZIndex;
        private Royal.Scenes.Game.Mechanics.Sortings.SortingData initialSorting;
        private Royal.Player.Context.Data.Persistent.UserInventory inventory;
        private bool isInTutorial;
        private Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialFreeBoosterView freeBoosterText;
        private bool <IsSelected>k__BackingField;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Boosters.BoosterType BoosterType { get; set; }
        public bool IsSelected { get; set; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Boosters.BoosterType get_BoosterType()
        {
            return (Royal.Scenes.Game.Mechanics.Boosters.BoosterType)this.<BoosterType>k__BackingField;
        }
        private void set_BoosterType(Royal.Scenes.Game.Mechanics.Boosters.BoosterType value)
        {
            this.<BoosterType>k__BackingField = value;
        }
        public bool get_IsSelected()
        {
            return (bool)this.<IsSelected>k__BackingField;
        }
        private void set_IsSelected(bool value)
        {
            this.<IsSelected>k__BackingField = value;
        }
        public void Init(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type)
        {
            this.<BoosterType>k__BackingField = type;
            var val_6 = 0;
            if(mem[1152921505130418176] != null)
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    Royal.Infrastructure.UiComponents.Touch.ITouchable val_2 = 1152921505130381312 + ((mem[1152921505130418184]) << 4);
            }
            
            this.initialZIndex = this.GetComponentInChildren<Royal.Infrastructure.UiComponents.Touch.ITouchable>().ZIndex;
            int val_5 = this.sortingGroup.sortingOrder;
            mem[1152921519951987056] = 0;
            this.initialSorting = this.sortingGroup.sortingLayerID;
            this.inventory = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<Inventory>k__BackingField;
            this.PrepareButton();
            this.isInTutorial = false;
        }
        public void SendBackground()
        {
            var val_7 = null;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetBackgroundSorting();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.sortingGroup, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer + 4294967296, order = val_1.layer + 4294967296, sortEverything = (val_1.sortEverything != true) ? 1 : 0});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetBackgroundSorting();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(textMeshPro:  this.countText, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer + 8589934592, order = val_4.layer + 8589934592, sortEverything = (val_4.sortEverything != true) ? 1 : 0});
        }
        public void Unselect()
        {
            var val_5;
            bool val_6;
            this.<IsSelected>k__BackingField = false;
            this.PrepareButton();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.sortingGroup, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = this.initialSorting, order = this.initialSorting, sortEverything = false});
            val_5 = null;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetUiBoosterTextSorting();
            val_6 = val_1.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(textMeshPro:  this.countText, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_6});
            var val_4 = 0;
            if(mem[1152921505130418176] != null)
            {
                    val_4 = val_4 + 1;
                val_6 = 1;
            }
            else
            {
                    var val_5 = mem[1152921505130418184];
                val_5 = val_5 + 1;
                Royal.Infrastructure.UiComponents.Touch.ITouchable val_3 = 1152921505130381312 + val_5;
            }
            
            this.GetComponentInChildren<Royal.Infrastructure.UiComponents.Touch.ITouchable>().ZIndex = this.initialZIndex;
        }
        public void Select()
        {
            UnityEngine.Object val_6;
            var val_7;
            bool val_8;
            this.<IsSelected>k__BackingField = true;
            this.count.SetActive(value:  false);
            this.countText.enabled = false;
            val_6 = 0;
            if(this.freeBoosterText != val_6)
            {
                    val_6 = 0;
                this.freeBoosterText.Hide();
            }
            
            val_7 = null;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetUiSorting();
            val_8 = val_2.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.sortingGroup, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_8});
            var val_5 = 0;
            if(mem[1152921505130418176] != null)
            {
                    val_5 = val_5 + 1;
                val_8 = 1;
            }
            else
            {
                    var val_6 = mem[1152921505130418184];
                val_6 = val_6 + 1;
                Royal.Infrastructure.UiComponents.Touch.ITouchable val_4 = 1152921505130381312 + val_6;
            }
            
            this.GetComponentInChildren<Royal.Infrastructure.UiComponents.Touch.ITouchable>().ZIndex = -5;
        }
        public void PrepareButton()
        {
            if((Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.IsUnlocked(boosterType:  this.<BoosterType>k__BackingField)) == false)
            {
                goto label_1;
            }
            
            this.EnableButton();
            if(this.isInTutorial == false)
            {
                goto label_2;
            }
            
            this.count.SetActive(value:  false);
            this.countText.enabled = false;
            this.addBooster.SetActive(value:  false);
            if(this.freeBoosterText == 0)
            {
                    return;
            }
            
            this.freeBoosterText.ShowWithoutBlack();
            return;
            label_1:
            this.count.SetActive(value:  false);
            this.countText.enabled = false;
            this.addBooster.SetActive(value:  false);
            this.icon.sprite = this.boosterLockedAssets.inGameLockIcon;
            UnityEngine.Transform val_3 = this.icon.transform;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.9f);
            val_3.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            val_3.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            this.DisableButton();
            return;
            label_2:
            int val_7 = this.inventory.GetBooster(type:  this.<BoosterType>k__BackingField);
            if(val_7 != 0)
            {
                    this.count.SetActive(value:  true);
                this.countText.enabled = true;
                this.addBooster.SetActive(value:  false);
                this.countText.text = val_7.ToString();
                return;
            }
            
            this.count.SetActive(value:  false);
            this.countText.enabled = false;
            this.addBooster.SetActive(value:  true);
        }
        public void AddFreeText(Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialFreeBoosterView freeText)
        {
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialFreeBoosterView val_7 = this.freeBoosterText;
            if(val_7 != 0)
            {
                    val_7 = this.freeBoosterText.gameObject;
                UnityEngine.Object.Destroy(obj:  val_7);
            }
            
            this.isInTutorial = true;
            this.freeBoosterText = freeText;
            freeText.transform.SetParent(p:  this.sortingGroup.transform);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.freeBoosterText.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            this.PrepareButton();
        }
        public void HighlightForTutorial(bool showFreeText)
        {
            var val_7;
            var val_8;
            val_7 = null;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialBlackSorting();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.sortingGroup, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer + 42949672960, order = val_1.layer + 42949672960, sortEverything = (val_1.sortEverything != true) ? 1 : 0});
            var val_7 = 0;
            if(mem[1152921505130418176] != null)
            {
                    val_7 = val_7 + 1;
                val_8 = 1;
            }
            else
            {
                    var val_8 = mem[1152921505130418184];
                val_8 = val_8 + 1;
                Royal.Infrastructure.UiComponents.Touch.ITouchable val_5 = 1152921505130381312 + val_8;
            }
            
            this.GetComponentInChildren<Royal.Infrastructure.UiComponents.Touch.ITouchable>().ZIndex = 9;
            if(this.freeBoosterText == 0)
            {
                    return;
            }
            
            if(showFreeText != false)
            {
                    this.freeBoosterText.Show();
                return;
            }
            
            this.freeBoosterText.Hide();
        }
        public void DeHighlightForTutorial()
        {
            var val_3;
            if((this.<IsSelected>k__BackingField) != false)
            {
                    return;
            }
            
            this.PrepareButton();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.sortingGroup, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = this.initialSorting, order = this.initialSorting, sortEverything = false});
            var val_3 = 0;
            if(mem[1152921505130418176] != null)
            {
                    val_3 = val_3 + 1;
                val_3 = 1;
            }
            else
            {
                    var val_4 = mem[1152921505130418184];
                val_4 = val_4 + 1;
                Royal.Infrastructure.UiComponents.Touch.ITouchable val_2 = 1152921505130381312 + val_4;
            }
            
            this.GetComponentInChildren<Royal.Infrastructure.UiComponents.Touch.ITouchable>().ZIndex = this.initialZIndex;
        }
        public void DisableButton()
        {
            this.button.colliderBox.enabled = false;
        }
        private void EnableButton()
        {
            this.button.colliderBox.enabled = true;
        }
        public bool TrySelect()
        {
            var val_3;
            if((this.inventory.GetBooster(type:  this.<BoosterType>k__BackingField)) <= 0)
            {
                    return (bool)(this.isInTutorial == true) ? 1 : 0;
            }
            
            val_3 = 1;
            return (bool)(this.isInTutorial == true) ? 1 : 0;
        }
        public void Used()
        {
            if(this.isInTutorial != false)
            {
                    Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).BoosterUse(boosterType:  this.<BoosterType>k__BackingField);
            }
            else
            {
                    this.inventory.UseBooster(type:  this.<BoosterType>k__BackingField, delta:  1);
            }
            
            this.isInTutorial = false;
            if(this.freeBoosterText != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.freeBoosterText.gameObject);
                this.freeBoosterText = 0;
            }
            
            this.PrepareButton();
        }
        public void BoughtBooster()
        {
            this.PrepareButton();
        }
        public void RemoveFreeText()
        {
            this.isInTutorial = false;
            if(this.freeBoosterText != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.freeBoosterText.gameObject);
            }
            
            this.PrepareButton();
        }
        public InGameBoosterButton()
        {
        
        }
    
    }

}
