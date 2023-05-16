using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SwitchItem.View
{
    public class SwitchItemAssets : ItemAssets
    {
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemView GetViewPrefab()
        {
            if(0 == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemExplodeParticles GetExplodeParticles()
        {
            if(185636 == 0)
            {
                    return 185636;
            }
            
            return 185636;
        }
        private Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchGoalView GetGoalView()
        {
            if(1073741824 == 0)
            {
                    return 1073741824;
            }
            
            return 1073741824;
        }
        public UnityEngine.Sprite GetStateSprite(bool state)
        {
            bool val_1 = state;
            bool val_2 = state;
            var val_3 = X8 + (((state & 1)) << 3);
            return (UnityEngine.Sprite)(X8 + ((state & 1)) << 3) + 32;
        }
        protected override void CreateItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool, int amount)
        {
            int val_4 = amount;
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemView>(go:  this.GetViewPrefab(), amount:  val_4);
            val_4 = val_4 << 1;
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemExplodeParticles>(go:  this.GetExplodeParticles(), amount:  val_4);
            pool.CreatePool<Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchGoalView>(go:  this.GetGoalView(), amount:  val_4);
        }
        protected override void ClearItemPools(Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool pool)
        {
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemView>(go:  this.GetViewPrefab());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemExplodeParticles>(go:  this.GetExplodeParticles());
            pool.ClearPool<Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchGoalView>(go:  this.GetGoalView());
        }
        public UnityEngine.AudioClip GetBowtieBreak1Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 32;
        }
        public UnityEngine.AudioClip GetBowtieBreak2Sfx()
        {
            return (UnityEngine.AudioClip)X8 + 40;
        }
        public UnityEngine.AudioClip GetBowtieClosingSfx()
        {
            return (UnityEngine.AudioClip)X8 + 48;
        }
        public UnityEngine.AudioClip GetBowtieOpeningSfx()
        {
            return (UnityEngine.AudioClip)X8 + 56;
        }
        public SwitchItemAssets()
        {
        
        }
    
    }

}
