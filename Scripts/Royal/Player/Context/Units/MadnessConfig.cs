using UnityEngine;

namespace Royal.Player.Context.Units
{
    public class MadnessConfig
    {
        // Fields
        public int version;
        public Royal.Player.Context.Units.MadnessStep[] steps;
        
        // Methods
        public int GetTotalSteps()
        {
            if(this.steps != null)
            {
                    return (int)this.steps.Length;
            }
            
            throw new NullReferenceException();
        }
        public Royal.Player.Context.Units.MadnessStep GetConfig(int step)
        {
            Royal.Player.Context.Units.MadnessStep val_1;
            if(this.steps.Length >= 1)
            {
                    var val_1 = 0;
                do
            {
                val_1 = this.steps[val_1];
                if(this.steps[0x0][0].s == step)
            {
                    return (Royal.Player.Context.Units.MadnessStep)val_1;
            }
            
                val_1 = val_1 + 1;
            }
            while(val_1 < this.steps.Length);
            
            }
            
            val_1 = 0;
            return (Royal.Player.Context.Units.MadnessStep)val_1;
        }
        public MadnessConfig()
        {
        
        }
    
    }

}
