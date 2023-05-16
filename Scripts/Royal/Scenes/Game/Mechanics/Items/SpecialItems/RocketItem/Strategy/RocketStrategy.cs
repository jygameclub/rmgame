using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy
{
    public abstract class RocketStrategy
    {
        // Fields
        protected readonly Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView view;
        protected readonly Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemAssets itemAssets;
        protected readonly Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        protected readonly Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        protected readonly Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager sfxManager;
        
        // Methods
        protected RocketStrategy(Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView view, Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemAssets itemAssets, Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory)
        {
            val_1 = new System.Object();
            this.view = view;
            this.itemAssets = itemAssets;
            this.itemFactory = val_1;
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.sfxManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22);
        }
        public abstract void SetSprites(); // 0
        public abstract void PlayCreationAnimation(float startTime = 0, bool playSound = True); // 0
        public abstract bool IsCreationAnimationPlaying(); // 0
        public abstract void Play(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> firstList, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> secondList); // 0
        protected Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemParticles GetParticles(UnityEngine.Transform parent, UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemParticles val_1 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemParticles>(poolId:  8, activate:  true);
            val_1.SetParticlePosition(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            val_1.circleParticle.Play();
            UnityEngine.Transform val_2 = val_1.transform;
            val_2.SetParent(p:  parent);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_2.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            return val_1;
        }
    
    }

}
