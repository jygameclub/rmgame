using UnityEngine;

namespace Royal.Scenes.Game.Ui.Bottom.Boosters
{
    public class InGameBoosterManager : UiPanel, IBackable
    {
        // Fields
        public Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterSelectionBlocker boosterSelectionBlocker;
        public Royal.Scenes.Game.Ui.Bottom.Boosters.InGameBoosterButton arrow;
        public Royal.Scenes.Game.Ui.Bottom.Boosters.InGameBoosterButton cannon;
        public Royal.Scenes.Game.Ui.Bottom.Boosters.InGameBoosterButton hammer;
        public Royal.Scenes.Game.Ui.Bottom.Boosters.InGameBoosterButton jesterHat;
        public UnityEngine.GameObject[] uiElements;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameStateManager;
        private Royal.Scenes.Game.Ui.Bottom.Boosters.InGameBoosterButton selectedBooster;
        private Royal.Scenes.Game.Levels.Units.Booster.BoosterManager boosterManager;
        private Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        private Royal.Scenes.Game.Levels.Units.LevelTutorials.LevelTutorialManager levelTutorialManager;
        private Royal.Infrastructure.UiComponents.Touch.ZIndex initialPanelHiderZIndex;
        private float infoPanelYPosition;
        private Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterInfo.BoosterInfoView currentBoosterInfoView;
        private Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterUseBackground currentBoosterUseBackground;
        private Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterToBuy;
        private UnityEngine.ParticleSystem boosterSelectParticles;
        
        // Methods
        public void Awake()
        {
            float val_13;
            this.gameStateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.boosterManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Booster.BoosterManager>(contextId:  17);
            this.moveManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            this.levelTutorialManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelTutorials.LevelTutorialManager>(contextId:  21);
            UnityEngine.Vector3 val_6 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).GetSafeTopCenterOfCamera();
            val_13 = val_6.y;
            UnityEngine.Vector3 val_8 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2).GetGridTopCenterMaxPosition();
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsIos != false)
            {
                    int val_10 = UnityEngine.Screen.height;
                UnityEngine.Rect val_11 = UnityEngine.Screen.safeArea;
                if(val_11.m_XMin < 0)
            {
                    float val_13 = 0.3f;
                val_13 = val_13 + val_13;
            }
            
            }
            
            val_13 = val_13 - val_8.y;
            val_13 = val_13 * 0.5f;
            val_13 = val_8.y + val_13;
            this.infoPanelYPosition = val_13;
            this.PrepareBoosters();
            this.boosterManager.add_OnBoosterDeselected(value:  new System.Action<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Bottom.Boosters.InGameBoosterManager::OnBoosterDeselected(Royal.Scenes.Game.Mechanics.Boosters.BoosterType booster, bool used)));
            this.initialPanelHiderZIndex = this.boosterSelectionBlocker;
            this.boosterSelectionBlocker.Disable();
        }
        public void OnBuyBoosterAfterPurchaseCompleted(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            this.UpdateBoosters();
            this.currentBoosterUseBackground = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterUseBackground>(original:  UnityEngine.Resources.Load<Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterUseBackground>(path:  "boosterUseBackground")).Init(isAboveBoard:  (boosterType == 7) ? 1 : 0);
            this.boosterToBuy = boosterType;
            this.OnBuyBoosterCompleted();
        }
        private void OnBuyBoosterCompleted()
        {
            if((GetBooster(type:  this.boosterToBuy)) >= 1)
            {
                    Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_3 = this.boosterToBuy;
                val_3 = val_3 - 4;
                var val_4 = 36596520 + ((this.boosterToBuy - 4)) << 2;
                val_4 = val_4 + 36596520;
            }
            else
            {
                    UnityEngine.Object.Destroy(obj:  this.currentBoosterUseBackground.gameObject);
                this.boosterToBuy = 0;
            }
        
        }
        private void PrepareBoosters()
        {
            this.arrow.Init(type:  5);
            this.cannon.Init(type:  6);
            this.hammer.Init(type:  4);
            this.jesterHat.Init(type:  7);
        }
        public void UpdateBoosters()
        {
            this.arrow.PrepareButton();
            this.cannon.PrepareButton();
            this.hammer.PrepareButton();
            this.jesterHat.PrepareButton();
        }
        public void ToggleBoosterSelection(string type)
        {
            Royal.Scenes.Game.Ui.Bottom.Boosters.InGameBoosterButton val_16;
            Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_4 = 0;
            if(this.gameStateManager.HasAnyOperation() == true)
            {
                    return;
            }
            
            if(this.gameStateManager.IsPlaying() == false)
            {
                    return;
            }
            
            if(this.moveManager.HasMoves() == false)
            {
                    return;
            }
            
            bool val_5 = System.Enum.TryParse<Royal.Scenes.Game.Mechanics.Boosters.BoosterType>(value:  type, ignoreCase:  true, result: out  val_4);
            if(this.selectedBooster == 0)
            {
                    val_16 = this.hammer;
            }
            else
            {
                    if((this.selectedBooster.<BoosterType>k__BackingField) != val_4)
            {
                    return;
            }
            
                this.DeselectBooster();
                return;
            }
            
            if(val_4 == 4)
            {
                    if(this.levelTutorialManager.IsHammerTutorialStep1() != false)
            {
                    this.SelectBoosterForForcedTutorial(booster:  val_4);
                return;
            }
            
            }
            
            Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterUseBackground val_10 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterUseBackground>(original:  UnityEngine.Resources.Load<Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterUseBackground>(path:  "boosterUseBackground"));
            Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_16 = val_4;
            val_16 = this.IsBlackAboveBoard(selectedBooster:  val_16);
            Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterUseBackground val_12 = val_10.Init(isAboveBoard:  val_16);
            this.currentBoosterUseBackground = val_10;
            if(mem[this.jesterHat].TrySelect() != false)
            {
                    this.SelectBooster(booster:  val_4);
                return;
            }
            
            this.boosterToBuy = val_4;
            Royal.Scenes.Home.Ui.Dialogs.BuyBooster.ShowBuyBoosterDialogAction val_13 = new Royal.Scenes.Home.Ui.Dialogs.BuyBooster.ShowBuyBoosterDialogAction(type:  val_4, origin:  0);
            val_13.add_OnComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Bottom.Boosters.InGameBoosterManager::OnBuyBoosterCompleted()));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  val_13);
        }
        private bool IsBlackAboveBoard(Royal.Scenes.Game.Mechanics.Boosters.BoosterType selectedBooster)
        {
            var val_3;
            if(selectedBooster == 7)
            {
                goto label_4;
            }
            
            if(selectedBooster == 6)
            {
                goto label_1;
            }
            
            if(selectedBooster == 5)
            {
                    if(this.levelTutorialManager.IsArrowTutorialStep1() == true)
            {
                goto label_4;
            }
            
            }
            
            label_7:
            val_3 = 0;
            return (bool)val_3;
            label_1:
            if(this.levelTutorialManager.IsCannonTutorialStep1() == false)
            {
                goto label_7;
            }
            
            label_4:
            val_3 = 1;
            return (bool)val_3;
        }
        private void ShowBoosterSelectParticles()
        {
            UnityEngine.ParticleSystem val_3 = UnityEngine.Object.Instantiate<UnityEngine.ParticleSystem>(original:  UnityEngine.Resources.Load<UnityEngine.ParticleSystem>(path:  "InGameBoosterSelectParticles"), parent:  this.transform);
            this.boosterSelectParticles = val_3;
            val_3.gameObject.SetActive(value:  true);
            this.boosterSelectParticles.Play();
            UnityEngine.Vector3 val_7 = this.selectedBooster.transform.position;
            this.boosterSelectParticles.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        private void SelectBooster(Royal.Scenes.Game.Mechanics.Boosters.BoosterType booster)
        {
            this.boosterSelectionBlocker.Enable();
            this.CreateBoosterInfoPanel(booster:  booster);
            if((booster - 4) <= 3)
            {
                    var val_3 = 36596552 + ((booster - 4)) << 2;
                val_3 = val_3 + 36596552;
            }
            else
            {
                    this.selectedBooster = mem[this.jesterHat];
                this.SendUiToBackgroundExceptSelectedBooster();
                this.ShowBoosterSelectParticles();
                this.boosterManager.OnSelectBooster(boosterType:  this.selectedBooster.<BoosterType>k__BackingField);
                Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            }
        
        }
        private void SelectBoosterForForcedTutorial(Royal.Scenes.Game.Mechanics.Boosters.BoosterType booster)
        {
            if((booster - 4) <= 3)
            {
                    var val_2 = 36596584 + ((booster - 4)) << 2;
                val_2 = val_2 + 36596584;
            }
            else
            {
                    this.selectedBooster = mem[this.jesterHat];
                this.ShowBoosterSelectParticles();
                this.boosterManager.OnSelectBooster(boosterType:  this.selectedBooster.<BoosterType>k__BackingField);
                this.selectedBooster.DisableButton();
            }
        
        }
        public void DeselectBooster()
        {
            if(this.selectedBooster == 0)
            {
                    return;
            }
            
            this.boosterManager.OnDeselectBooster(boosterType:  this.selectedBooster.<BoosterType>k__BackingField, used:  false);
        }
        private void OnBoosterDeselected(Royal.Scenes.Game.Mechanics.Boosters.BoosterType booster, bool used)
        {
            if(used != false)
            {
                    Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_1 = booster - 4;
                var val_9 = 36596616 + ((booster - 4)) << 2;
                val_9 = val_9 + 36596616;
            }
            else
            {
                    this.boosterSelectionBlocker.Disable();
                if(this.currentBoosterInfoView != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.currentBoosterInfoView.gameObject);
            }
            
                if(this.currentBoosterUseBackground != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.currentBoosterUseBackground.gameObject);
            }
            
                this.ResetSorting();
                if(this.boosterSelectParticles != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.boosterSelectParticles.gameObject);
                this.boosterSelectParticles = 0;
            }
            
                this.selectedBooster = 0;
                Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_8 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            }
        
        }
        private void SendUiToBackgroundExceptSelectedBooster()
        {
            var val_4 = 0;
            label_8:
            if(val_4 >= this.uiElements.Length)
            {
                goto label_2;
            }
            
            UnityEngine.Rendering.SortingGroup val_1 = this.uiElements[val_4].GetComponent<UnityEngine.Rendering.SortingGroup>();
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetBackgroundSorting();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  val_1, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = false});
            val_1.enabled = true;
            val_4 = val_4 + 1;
            if(this.uiElements != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
            label_2:
            this.hammer.SendBackground();
            this.arrow.SendBackground();
            this.cannon.SendBackground();
            this.jesterHat.SendBackground();
            this.selectedBooster.Select();
            goto typeof(Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterSelectionBlocker).__il2cppRuntimeField_1E0;
        }
        private void ResetSorting()
        {
            var val_3 = 0;
            label_6:
            if(val_3 >= this.uiElements.Length)
            {
                goto label_2;
            }
            
            this.uiElements[val_3].GetComponent<UnityEngine.Rendering.SortingGroup>().enabled = false;
            val_3 = val_3 + 1;
            if(this.uiElements != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_2:
            this.hammer.Unselect();
            this.arrow.Unselect();
            this.cannon.Unselect();
            this.jesterHat.Unselect();
            goto typeof(Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterSelectionBlocker).__il2cppRuntimeField_1E0;
        }
        private Royal.Scenes.Game.Ui.Bottom.Boosters.InGameBoosterButton GetObject(Royal.Scenes.Game.Mechanics.Boosters.BoosterType booster)
        {
            if((booster - 4) > 3)
            {
                    return 0;
            }
            
            var val_2 = 36596536 + ((booster - 4)) << 2;
            val_2 = val_2 + 36596536;
            goto (36596536 + ((booster - 4)) << 2 + 36596536);
        }
        private void CreateBoosterInfoPanel(Royal.Scenes.Game.Mechanics.Boosters.BoosterType booster)
        {
            if((booster - 4) <= 3)
            {
                    var val_6 = 36596600 + ((booster - 4)) << 2;
                val_6 = val_6 + 36596600;
            }
            else
            {
                    this.currentBoosterUseBackground.add_OnTouched(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Bottom.Boosters.InGameBoosterManager::OnBoosterUseBackgroundTouched()));
            }
        
        }
        private void OnBoosterUseBackgroundTouched()
        {
            this.DeselectBooster();
        }
        public void LevelRestart()
        {
            this.hammer.RemoveFreeText();
            this.arrow.RemoveFreeText();
            this.cannon.RemoveFreeText();
            this.jesterHat.RemoveFreeText();
        }
        public void PressBack()
        {
            this.DeselectBooster();
        }
        public InGameBoosterManager()
        {
        
        }
    
    }

}
