using UnityEngine;

namespace Royal.Scenes.Home.Areas.Scripts
{
    public class WaveHandler : MonoBehaviour
    {
        // Fields
        public UnityEngine.Animator animator;
        
        // Methods
        private void Awake()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Game.Context.GameContext>(id:  11).add_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.WaveHandler::StopAnimation()));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.HomeContext>(id:  10).add_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.WaveHandler::PlayAnimation()));
        }
        private void PlayAnimation()
        {
            if(this.animator != null)
            {
                    this.animator.speed = 1f;
                return;
            }
            
            throw new NullReferenceException();
        }
        private void StopAnimation()
        {
            if(this.animator != null)
            {
                    this.animator.speed = 0f;
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnDestroy()
        {
            null = null;
            if((Royal.Scenes.Start.Context.ApplicationContext.<IsActive>k__BackingField) == false)
            {
                    return;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Game.Context.GameContext>(id:  11).remove_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.WaveHandler::StopAnimation()));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.HomeContext>(id:  10).remove_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.WaveHandler::PlayAnimation()));
        }
        public WaveHandler()
        {
        
        }
    
    }

}
