using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Booster
{
    public class BoosterManager : IGameContextUnit, IContextUnit
    {
        // Fields
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Mechanics.Boosters.Hammer.HammerBooster hammerBooster;
        private Royal.Scenes.Game.Mechanics.Boosters.Arrow.ArrowBooster arrowBooster;
        private Royal.Scenes.Game.Mechanics.Boosters.Cannon.CannonBooster cannonBooster;
        private Royal.Scenes.Game.Mechanics.Boosters.JesterHat.JesterHatBooster jesterHatBooster;
        private Royal.Scenes.Game.Ui.Cloche.ClocheView clocheView;
        private Royal.Scenes.Game.Mechanics.Boosters.BoosterType selectedBooster;
        private int clocheBoosterCount;
        private int prelevelBoosterCount;
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> cellsToSelect;
        private int cellsToSelectIndex;
        private System.Action<Royal.Scenes.Game.Mechanics.Boosters.BoosterType> OnBoosterSelected;
        private System.Action<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, bool> OnBoosterDeselected;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 17;
        }
        public void add_OnBoosterSelected(System.Action<Royal.Scenes.Game.Mechanics.Boosters.BoosterType> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnBoosterSelected, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnBoosterSelected != 1152921524125430768);
            
            return;
            label_2:
        }
        public void remove_OnBoosterSelected(System.Action<Royal.Scenes.Game.Mechanics.Boosters.BoosterType> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnBoosterSelected, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnBoosterSelected != 1152921524125567344);
            
            return;
            label_2:
        }
        public void add_OnBoosterDeselected(System.Action<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, bool> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnBoosterDeselected, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnBoosterDeselected != 1152921524125703928);
            
            return;
            label_2:
        }
        public void remove_OnBoosterDeselected(System.Action<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, bool> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnBoosterDeselected, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnBoosterDeselected != 1152921524125840504);
            
            return;
            label_2:
        }
        public void Bind()
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.hammerBooster = new Royal.Scenes.Game.Mechanics.Boosters.Hammer.HammerBooster();
            this.arrowBooster = new Royal.Scenes.Game.Mechanics.Boosters.Arrow.ArrowBooster();
            this.cannonBooster = new Royal.Scenes.Game.Mechanics.Boosters.Cannon.CannonBooster();
            this.jesterHatBooster = new Royal.Scenes.Game.Mechanics.Boosters.JesterHat.JesterHatBooster();
        }
        public void UseBooster(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint cellPoint)
        {
            Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_4 = this.selectedBooster;
            val_4 = val_4 - 4;
            if(val_4 <= 3)
            {
                    var val_5 = 36587916 + ((this.selectedBooster - 4)) << 2;
                val_5 = val_5 + 36587916;
            }
            else
            {
                    this.OnDeselectBooster(boosterType:  this.selectedBooster, used:  true);
            }
        
        }
        public void OnSelectBooster(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            this.selectedBooster = boosterType;
            if(this.OnBoosterSelected == null)
            {
                    return;
            }
            
            this.OnBoosterSelected.Invoke(obj:  boosterType);
        }
        public void OnDeselectBooster(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType, bool used)
        {
            this.selectedBooster = 0;
            if(this.OnBoosterDeselected == null)
            {
                    return;
            }
            
            used = used;
            this.OnBoosterDeselected.Invoke(arg1:  boosterType, arg2:  used);
        }
        public void Clear(bool gameExit)
        {
            var val_1;
            this.selectedBooster = 0;
            UnityEngine.Object.Destroy(obj:  this.clocheView);
            if(gameExit != false)
            {
                    this.OnBoosterSelected = 0;
                this.OnBoosterDeselected = 0;
            }
            
            val_1 = null;
            val_1 = null;
            Royal.Scenes.Game.Ui.GameUi.__il2cppRuntimeField_byval_arg + 24.LevelRestart();
        }
        public bool IsBoosterSelected()
        {
            return (bool)(this.selectedBooster != 0) ? 1 : 0;
        }
        public void AddBoostersBeforeLevelStart(System.Action onComplete)
        {
            if(IsStory == false)
            {
                goto label_6;
            }
            
            label_9:
            onComplete.Invoke();
            return;
            label_6:
            this.CalculateBoosterCounts(sessionData:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<SessionData>k__BackingField);
            if(this.clocheBoosterCount != this.prelevelBoosterCount)
            {
                goto label_8;
            }
            
            if(onComplete != null)
            {
                goto label_9;
            }
            
            throw new NullReferenceException();
            label_8:
            UnityEngine.Coroutine val_3 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.AddBoostersToGrid(onComplete:  onComplete));
        }
        private void CalculateBoosterCounts(Royal.Player.Context.Data.Session.UserSessionData sessionData)
        {
            this.clocheBoosterCount = (sessionData.activeLevel.cloche.before == 0) ? 0 : (sessionData.activeLevel.cloche.before + 1);
            this.prelevelBoosterCount = 0;
            if(sessionData.prelevelSelection.ShouldUseRocket != false)
            {
                    int val_5 = this.prelevelBoosterCount;
                val_5 = val_5 + 1;
                this.prelevelBoosterCount = val_5;
            }
            
            if(sessionData.prelevelSelection.ShouldUseTnt != false)
            {
                    int val_6 = this.prelevelBoosterCount;
                val_6 = val_6 + 1;
                this.prelevelBoosterCount = val_6;
            }
            
            if(sessionData.prelevelSelection.ShouldUseLightBall == false)
            {
                    return;
            }
            
            int val_7 = this.prelevelBoosterCount;
            val_7 = val_7 + 1;
            this.prelevelBoosterCount = val_7;
        }
        private System.Collections.IEnumerator AddBoostersToGrid(System.Action onComplete)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new BoosterManager.<AddBoostersToGrid>d__27();
        }
        private System.Collections.IEnumerator AddClocheBoosters(int cloche, System.Action onComplete)
        {
            .<>1__state = 0;
            .cloche = cloche;
            .<>4__this = this;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new BoosterManager.<AddClocheBoosters>d__28();
        }
        private System.Collections.IEnumerator AddSelectedBoosters(Royal.Player.Context.Data.User user)
        {
            .<>1__state = 0;
            .user = user;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new BoosterManager.<AddSelectedBoosters>d__29();
        }
        private System.Collections.IEnumerator CreateSpecialItem(Royal.Player.Context.Data.User user, Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .user = user;
            .tiledId = tiledId;
            return (System.Collections.IEnumerator)new BoosterManager.<CreateSpecialItem>d__30();
        }
        private bool IsThereMorePrelevelBooster()
        {
            var val_2;
            if(this.cellsToSelect > this.cellsToSelectIndex)
            {
                    if(this.prelevelBoosterCount <= 0)
            {
                    return (bool)(this.clocheBoosterCount > 0) ? 1 : 0;
            }
            
                val_2 = 1;
                return (bool)(this.clocheBoosterCount > 0) ? 1 : 0;
            }
            
            val_2 = 0;
            return (bool)(this.clocheBoosterCount > 0) ? 1 : 0;
        }
        public void UpdateBoosters()
        {
            null = null;
            Royal.Scenes.Game.Ui.GameUi.__il2cppRuntimeField_byval_arg + 24.UpdateBoosters();
        }
        public void UpdateBoostersAfterPurchase(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            null = null;
            Royal.Scenes.Game.Ui.GameUi.__il2cppRuntimeField_byval_arg + 24.OnBuyBoosterAfterPurchaseCompleted(boosterType:  boosterType);
        }
        public BoosterManager()
        {
        
        }
    
    }

}
