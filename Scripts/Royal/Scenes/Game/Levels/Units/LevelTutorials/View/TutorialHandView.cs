using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.View
{
    public class TutorialHandView : MonoBehaviour
    {
        // Fields
        private static readonly int Default;
        private static readonly int SwipeLeft;
        private static readonly int SwipeDown;
        private static readonly int SwipeRight;
        private static readonly int TapAnimation;
        public UnityEngine.Animator tutorialHandAnimator;
        public Spine.Unity.SkeletonMecanim tutorialMecanim;
        public UnityEngine.Transform root;
        public Royal.Scenes.Game.Levels.Units.LevelTutorials.View.HandAnimationType animType;
        private bool didStartGoingDown;
        
        // Methods
        private void Awake()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialBlackSorting();
            val_2.sortEverything = val_2.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything}, offset:  10);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
        }
        public Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView SetPosition(UnityEngine.Vector3 position)
        {
            this.transform.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView)this;
        }
        public Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView PlayAnimation(Royal.Scenes.Game.Levels.Units.LevelTutorials.View.HandAnimationType handAnimationType)
        {
            this.animType = handAnimationType;
            if(handAnimationType <= 4)
            {
                    var val_7 = 36588296 + (handAnimationType) << 2;
                val_7 = val_7 + 36588296;
            }
            else
            {
                    throw new System.ArgumentOutOfRangeException(paramName:  "handAnimationType", actualValue:  ???, message:  0);
            }
        
        }
        private void PlayAnimationForState(int animId)
        {
            this.tutorialHandAnimator.Play(stateNameHash:  animId, layer:  0, normalizedTime:  0f);
            this.tutorialHandAnimator.Update(deltaTime:  UnityEngine.Time.deltaTime);
            this.tutorialMecanim.Update();
        }
        public TutorialHandView()
        {
        
        }
        private static TutorialHandView()
        {
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView.Default = UnityEngine.Animator.StringToHash(name:  "Base Layer.default");
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView.SwipeLeft = UnityEngine.Animator.StringToHash(name:  "Base Layer.swipe_left");
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView.SwipeDown = UnityEngine.Animator.StringToHash(name:  "Base Layer.swipe_down");
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView.SwipeRight = UnityEngine.Animator.StringToHash(name:  "Base Layer.swipe_right");
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialHandView.TapAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.tap_animation_2");
        }
    
    }

}
