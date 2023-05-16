using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.DrillItem.Strategy
{
    public abstract class DrillStrategy
    {
        // Fields
        protected readonly Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView view;
        protected readonly Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        protected readonly Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        protected readonly Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager sfxManager;
        protected readonly Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillDirection direction;
        
        // Methods
        protected DrillStrategy(Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView view, Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory, Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillDirection direction)
        {
            val_1 = new System.Object();
            this.view = view;
            this.itemFactory = val_1;
            this.direction = direction;
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.sfxManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22);
        }
        public virtual void Play(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Matches.Cell14 cellsOnPath, Royal.Scenes.Game.Mechanics.Matches.Cell14 cellsOnDrill, Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillTracerParticles particles)
        {
            if((cellsOnDrill.<Count>k__BackingField) < 1)
            {
                    return;
            }
            
            var val_1 = 0;
            do
            {
                cellsOnDrill.<Count>k__BackingField.ExplodeAll(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = exploder.point.x}, id = exploder.id});
                val_1 = val_1 + 1;
            }
            while(val_1 < (cellsOnDrill.<Count>k__BackingField));
        
        }
    
    }

}
