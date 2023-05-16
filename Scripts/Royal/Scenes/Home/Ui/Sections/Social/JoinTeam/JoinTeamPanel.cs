using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.JoinTeam
{
    public class JoinTeamPanel : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject reachLevel21;
        public UnityEngine.GameObject joinTeamTutorial;
        public UnityEngine.GameObject joinTeamButton;
        public UnityEngine.SpriteRenderer tutorialCharacters;
        public UnityEngine.SpriteRenderer reach21Characters;
        public UnityEngine.TextAsset tutorialCharactersAsset;
        public UnityEngine.RectTransform freeLivesTextRect;
        public UnityEngine.RectTransform freeRewardTextRect;
        public TMPro.TextMeshPro freeRewardText;
        public UnityEngine.RectTransform tutorialFreeLivesTextRect;
        public UnityEngine.RectTransform tutorialFreeRewardTextRect;
        public TMPro.TextMeshPro tutorialFreeLivesText;
        public TMPro.TextMeshPro tutorialFreeRewardText;
        public UnityEngine.RectTransform joinTeamButtonText;
        private UnityEngine.Sprite characters;
        private System.Action OnJoinButtonClicked;
        
        // Methods
        public void add_OnJoinButtonClicked(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnJoinButtonClicked, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnJoinButtonClicked != 1152921518994892864);
            
            return;
            label_2:
        }
        public void remove_OnJoinButtonClicked(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnJoinButtonClicked, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnJoinButtonClicked != 1152921518995029440);
            
            return;
            label_2:
        }
        public void ArrangePanel(bool isTutorial)
        {
            UnityEngine.RectTransform val_30;
            var val_31;
            var val_32;
            float val_33;
            var val_34;
            val_30 = this;
            if(this.characters == 0)
            {
                    UnityEngine.Sprite val_2 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  this.tutorialCharactersAsset, width:  197, height:  121, format:  4);
                this.characters = val_2;
                this.tutorialCharacters.sprite = val_2;
                this.reach21Characters.sprite = this.characters;
            }
            
            if(isTutorial != false)
            {
                    this.reachLevel21.SetActive(value:  false);
                this.ArrangeTutorialPanel();
                val_31 = 1;
            }
            else
            {
                    this.reachLevel21.SetActive(value:  true);
                val_31 = 0;
            }
            
            this.joinTeamTutorial.SetActive(value:  false);
            val_32 = null;
            val_32 = null;
            Royal.Scenes.Home.Ui.Sections.Section val_3 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  1);
            val_33 = val_3.topUi.BottomYPositionOfTopUi();
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_8 = this.transform.position;
            this.transform.position = new UnityEngine.Vector3() {x = val_8.x, y = val_33 + (-0.36f), z = val_8.z};
            Royal.Infrastructure.Contexts.Units.CameraManager val_11 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            val_34 = val_11;
            if(val_11.IsDeviceTall() == false)
            {
                goto label_31;
            }
            
            UnityEngine.Transform val_13 = this.transform;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
            goto label_35;
            label_31:
            val_34 = this.transform;
            if(val_34.IsDeviceWide() == false)
            {
                goto label_36;
            }
            
            if(isTutorial == false)
            {
                goto label_37;
            }
            
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.one;
            goto label_40;
            label_36:
            if(isTutorial == false)
            {
                goto label_41;
            }
            
            val_33 = 0.95f;
            goto label_49;
            label_37:
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.one;
            if(val_34 != null)
            {
                goto label_46;
            }
            
            label_41:
            val_33 = 0.975f;
            label_49:
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
            label_40:
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  val_33);
            label_46:
            label_35:
            val_34.localScale = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
            this.freeRewardText.alignment = (Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == true) ? (513 + 1) : 513;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman != false)
            {
                    val_33 = 0.81f;
                UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  5.056334f, y:  val_33);
                this.freeRewardTextRect.sizeDelta = new UnityEngine.Vector2() {x = val_22.x, y = val_22.y};
                UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  1.302f, y:  -11.595f);
                UnityEngine.Vector3 val_24 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y});
                this.freeRewardTextRect.localPosition = new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z};
                UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  3.75592f, y:  val_33);
                this.freeLivesTextRect.sizeDelta = new UnityEngine.Vector2() {x = val_25.x, y = val_25.y};
                val_30 = this.freeLivesTextRect;
                UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  0.64f, y:  -10.503f);
            }
            else
            {
                    if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese == false)
            {
                    return;
            }
            
                UnityEngine.Vector2 val_27 = new UnityEngine.Vector2(x:  3.11f, y:  1.110554f);
                this.freeRewardTextRect.sizeDelta = new UnityEngine.Vector2() {x = val_27.x, y = val_27.y};
                val_30 = this.freeRewardTextRect;
                UnityEngine.Vector2 val_28 = new UnityEngine.Vector2(x:  0.31f, y:  -11.55f);
            }
            
            UnityEngine.Vector3 val_29 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_28.x, y = val_28.y});
            val_30.localPosition = new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z};
        }
        private void ArrangeTutorialPanel()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  2.7f, y:  0.9f);
            this.tutorialFreeRewardTextRect.sizeDelta = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
            this.tutorialFreeRewardTextRect.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.tutorialFreeRewardText.alignment = 2;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  2.7f, y:  0.9f);
            this.tutorialFreeLivesTextRect.sizeDelta = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            this.tutorialFreeLivesTextRect.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.tutorialFreeLivesText.alignment = 2;
            this = this.joinTeamButtonText;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  3.15f, y:  1.192754f);
            this.sizeDelta = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
        public void JoinTeam()
        {
            if(this.OnJoinButtonClicked == null)
            {
                    return;
            }
            
            this.OnJoinButtonClicked.Invoke();
        }
        public void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            sortingData.sortEverything = sortingData.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything});
        }
        public JoinTeamPanel()
        {
        
        }
    
    }

}
