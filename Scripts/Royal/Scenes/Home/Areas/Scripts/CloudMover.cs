using UnityEngine;

namespace Royal.Scenes.Home.Areas.Scripts
{
    public class CloudMover : MonoBehaviour
    {
        // Fields
        public UnityEngine.Animator[] cloudAnimators;
        
        // Methods
        private void Awake()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Game.Context.GameContext>(id:  11).add_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.CloudMover::StopClouds()));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.HomeContext>(id:  10).add_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.CloudMover::PlayClouds()));
        }
        private void PlayClouds()
        {
            var val_2 = 0;
            do
            {
                if(val_2 >= this.cloudAnimators.Length)
            {
                    return;
            }
            
                this.cloudAnimators[val_2].speed = 1f;
                val_2 = val_2 + 1;
            }
            while(this.cloudAnimators != null);
            
            throw new NullReferenceException();
        }
        private void StopClouds()
        {
            var val_2 = 0;
            do
            {
                if(val_2 >= this.cloudAnimators.Length)
            {
                    return;
            }
            
                this.cloudAnimators[val_2].speed = 0f;
                val_2 = val_2 + 1;
            }
            while(this.cloudAnimators != null);
            
            throw new NullReferenceException();
        }
        private void OnDestroy()
        {
            null = null;
            if((Royal.Scenes.Start.Context.ApplicationContext.<IsActive>k__BackingField) == false)
            {
                    return;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Game.Context.GameContext>(id:  11).remove_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.CloudMover::StopClouds()));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.HomeContext>(id:  10).remove_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.CloudMover::PlayClouds()));
        }
        public CloudMover()
        {
        
        }
    
    }

}
