using UnityEngine;

namespace Royal.Player.Context.Data.Session
{
    public class UserPrelevelBoosterSelectionData
    {
        // Fields
        private bool rocketSelected;
        private bool tntSelected;
        private bool lightBallSelected;
        private bool rocketHasTime;
        private bool tntHasTime;
        private bool lightBallHasTime;
        
        // Properties
        public bool ShouldUseRocket { get; }
        public bool ShouldUseTnt { get; }
        public bool ShouldUseLightBall { get; }
        
        // Methods
        public bool get_ShouldUseRocket()
        {
            if(this.rocketSelected == false)
            {
                    return (bool)(this.rocketHasTime == true) ? 1 : 0;
            }
            
            return true;
        }
        public bool get_ShouldUseTnt()
        {
            if(this.tntSelected == false)
            {
                    return (bool)(this.tntHasTime == true) ? 1 : 0;
            }
            
            return true;
        }
        public bool get_ShouldUseLightBall()
        {
            if(this.lightBallSelected == false)
            {
                    return (bool)(this.lightBallHasTime == true) ? 1 : 0;
            }
            
            return true;
        }
        public bool IsSelected(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type)
        {
            bool val_2;
            if(type == 3)
            {
                goto label_0;
            }
            
            if(type == 2)
            {
                goto label_1;
            }
            
            if(type != 1)
            {
                    return false;
            }
            
            val_2 = this.rocketSelected;
            return (bool)(val_2 == true) ? 1 : 0;
            label_0:
            val_2 = this.lightBallSelected;
            return (bool)(val_2 == true) ? 1 : 0;
            label_1:
            val_2 = this.tntSelected;
            return (bool)(val_2 == true) ? 1 : 0;
        }
        public void ToggleForTime(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type, bool hasTime)
        {
            if(type == 3)
            {
                goto label_0;
            }
            
            if(type == 2)
            {
                goto label_1;
            }
            
            if(type != 1)
            {
                    return;
            }
            
            this.rocketHasTime = hasTime;
            return;
            label_0:
            this.lightBallHasTime = hasTime;
            return;
            label_1:
            this.tntHasTime = hasTime;
        }
        public void Toggle(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type)
        {
            if(type == 3)
            {
                goto label_0;
            }
            
            if(type == 2)
            {
                goto label_1;
            }
            
            if(type != 1)
            {
                    return;
            }
            
            bool val_1 = this.rocketSelected;
            val_1 = val_1 ^ 1;
            this.rocketSelected = val_1;
            return;
            label_0:
            bool val_2 = this.lightBallSelected;
            val_2 = val_2 ^ 1;
            this.lightBallSelected = val_2;
            return;
            label_1:
            bool val_3 = this.tntSelected;
            val_3 = val_3 ^ 1;
            this.tntSelected = val_3;
        }
        public void Reset()
        {
            this.tntHasTime = false;
            this.lightBallHasTime = false;
            this.rocketSelected = false;
            this.tntSelected = false;
            this.lightBallSelected = false;
            this.rocketHasTime = false;
        }
        public UserPrelevelBoosterSelectionData()
        {
        
        }
    
    }

}
