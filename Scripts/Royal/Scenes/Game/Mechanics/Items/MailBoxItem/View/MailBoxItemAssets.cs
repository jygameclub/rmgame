using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View
{
    public class MailBoxItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailGoalView GetGoalPrefab()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailTracerParticles GetTracerPrefab()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        public UnityEngine.AudioClip GetMailCloseSfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetMailExitSfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            int val_4 = amount;
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxItemView>(go:  this.GetViewPrefab(), amount:  val_4);
            val_4 = val_4 << 1;
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailGoalView>(go:  this.GetGoalPrefab(), amount:  val_4);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailTracerParticles>(go:  this.GetTracerPrefab(), amount:  val_4);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailGoalView>(go:  this.GetGoalPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailTracerParticles>(go:  this.GetTracerPrefab());
        }
        public MailBoxItemAssets()
        {
        
        }
    
    }

}
