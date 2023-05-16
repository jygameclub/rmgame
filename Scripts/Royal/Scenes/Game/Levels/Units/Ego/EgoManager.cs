using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Ego
{
    public class EgoManager : IGameContextUnit, IContextUnit
    {
        // Fields
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameStateManager;
        private Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private int currentStep;
        private Royal.Scenes.Game.Levels.Units.Ego.EgoPackage[] egoPackages;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 32;
        }
        public void Bind()
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.gameStateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.moveManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            Royal.Scenes.Game.Levels.Units.Ego.EgoPackage[] val_5 = new Royal.Scenes.Game.Levels.Units.Ego.EgoPackage[5];
            this.egoPackages = val_5;
            val_5[0] = new Royal.Scenes.Game.Levels.Units.Ego.EgoPackage(price:  132, moves:  5, rocketCount:  0, tntCount:  0, lightballCount:  0, firstItemType:  0, secondItemType:  0);
            this.egoPackages = new Royal.Scenes.Game.Levels.Units.Ego.EgoPackage(price:  108, moves:  5, rocketCount:  1, tntCount:  0, lightballCount:  0, firstItemType:  2, secondItemType:  0);
            this.egoPackages = new Royal.Scenes.Game.Levels.Units.Ego.EgoPackage(price:  84, moves:  5, rocketCount:  1, tntCount:  1, lightballCount:  0, firstItemType:  2, secondItemType:  4);
            this.egoPackages = new Royal.Scenes.Game.Levels.Units.Ego.EgoPackage(price:  60, moves:  5, rocketCount:  0, tntCount:  1, lightballCount:  1, firstItemType:  4, secondItemType:  5);
            this.egoPackages = new Royal.Scenes.Game.Levels.Units.Ego.EgoPackage(price:  36, moves:  5, rocketCount:  0, tntCount:  0, lightballCount:  2, firstItemType:  5, secondItemType:  5);
        }
        private void ResetEgoStep()
        {
            this.currentStep = 0;
        }
        public void MoveToNextEgoStep()
        {
            int val_1 = this.currentStep;
            val_1 = val_1 + 1;
            this.currentStep = val_1;
        }
        public Royal.Scenes.Game.Levels.Units.Ego.EgoPackage GetEgoPackage()
        {
            return (Royal.Scenes.Game.Levels.Units.Ego.EgoPackage)this.egoPackages[UnityEngine.Mathf.Clamp(value:  this.currentStep, min:  0, max:  this.egoPackages.Length - 1)];
        }
        public int GetCurrentStep()
        {
            return (int)this.currentStep;
        }
        public bool CanPlayOn()
        {
            Royal.Scenes.Game.Levels.Units.Ego.EgoPackage val_1 = this.GetEgoPackage();
            return HasEnoughCoins(delta:  val_1.<Price>k__BackingField);
        }
        public void PlayOn(bool isRoyalPassPackage)
        {
            System.Collections.IEnumerator val_9;
            int val_10;
            val_9 = this;
            string val_4 = "Ego-"("Ego-") + System.Math.Min(val1:  (Royal.Player.Context.Data.Session.__il2cppRuntimeField_48 + 1)>>0&0xFFFFFFFF, val2:  this.egoPackages.Length)(System.Math.Min(val1:  (Royal.Player.Context.Data.Session.__il2cppRuntimeField_48 + 1)>>0&0xFFFFFFFF, val2:  this.egoPackages.Length));
            if(isRoyalPassPackage != false)
            {
                    val_10 = 0;
            }
            else
            {
                    val_10 = val_1.<Price>k__BackingField;
            }
            
            if((SpendCoins(spendingData:  new Royal.Player.Context.Data.Session.SpendingData())) == false)
            {
                    return;
            }
            
            Royal.Player.Context.Data.Session.__il2cppRuntimeField_48 = (Royal.Player.Context.Data.Session.__il2cppRuntimeField_48 + 1);
            this.gameStateManager.SetStateToPlay();
            this.moveManager.SetMaxMoves(moves:  val_1.<Moves>k__BackingField);
            this.audioManager.ResumeGameMusic();
            val_9 = this.PutEgoItemsToGrid(package:  this.GetEgoPackage());
            UnityEngine.Coroutine val_8 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  val_9);
        }
        private System.Collections.IEnumerator PutEgoItemsToGrid(Royal.Scenes.Game.Levels.Units.Ego.EgoPackage package)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .package = package;
            return (System.Collections.IEnumerator)new EgoManager.<PutEgoItemsToGrid>d__15();
        }
        public void CancelOffer()
        {
            if(this.gameStateManager != null)
            {
                    this.gameStateManager.SetStateToFail();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void Clear(bool gameExit)
        {
            if(this.gameStateManager.IsWin() != true)
            {
                    if(this.gameStateManager.IsFail() != true)
            {
                    if(this.gameStateManager.IsNoGame() == false)
            {
                    return;
            }
            
            }
            
            }
            
            this.currentStep = 0;
        }
        public EgoManager()
        {
            this.currentStep = 0;
        }
    
    }

}
