using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.View
{
    public class TutorialArrowView : MonoBehaviour
    {
        // Fields
        private static readonly UnityEngine.Vector3 MinRoot;
        private static readonly UnityEngine.Vector3 MaxRootYForUp;
        private static readonly UnityEngine.Vector3 MaxRootYForDown;
        private const float MoveDuration = 0.6;
        private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer easer;
        public UnityEngine.Transform root;
        public UnityEngine.Transform shadowRoot;
        public UnityEngine.Sprite arrowUpSprite;
        public UnityEngine.Sprite arrowDownSprite;
        public UnityEngine.SpriteRenderer arrowRenderer;
        private Royal.Scenes.Game.Levels.Units.LevelTutorials.View.ArrowOrientation arrowOrientation;
        private UnityEngine.Vector3 minPos;
        private UnityEngine.Vector3 maxPos;
        private float elapsedTime;
        private bool isMovingAway;
        private bool playAnimation;
        
        // Methods
        private void Awake()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialBlackSorting();
            val_2.sortEverything = val_2.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything}, offset:  10);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
        }
        private void Update()
        {
            if(this.playAnimation == false)
            {
                    return;
            }
            
            this.PlayAnimation();
        }
        private void PlayAnimation()
        {
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = val_1 * ((this.isMovingAway == false) ? -1f : 1f);
            val_1 = this.elapsedTime + val_1;
            this.elapsedTime = val_1;
            val_1 = val_1 / 0.6f;
            float val_4 = UnityEngine.Mathf.Clamp01(value:  this.easer.Invoke(t:  val_1));
            if(((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_4, b:  0f, precision:  0.001f)) != false) && (this.isMovingAway != true))
            {
                    this.isMovingAway = true;
            }
            
            if(((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_4, b:  1f, precision:  0.001f)) != false) && (this.isMovingAway != false))
            {
                    this.isMovingAway = false;
            }
            
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.minPos, y = V13.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = this.maxPos, y = V11.16B, z = 0.001f}, t:  val_4);
            this.root.transform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        public Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView SetPosition(UnityEngine.Vector3 position)
        {
            this.transform.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView)this;
        }
        public Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView SetScale(float scale)
        {
            this.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView)this;
        }
        public Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView SetSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            sortingData.sortEverything = sortingData.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything});
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView)this;
        }
        public Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView SetOrientation(Royal.Scenes.Game.Levels.Units.LevelTutorials.View.ArrowOrientation arrowOrientation)
        {
            float val_12;
            float val_13;
            float val_14;
            float val_15;
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            if(arrowOrientation <= 3)
            {
                    var val_12 = 36588316 + (arrowOrientation) << 2;
                val_12 = val_1.x;
                val_13 = val_1.y;
                val_14 = val_1.z;
                val_12 = val_12 + 36588316;
                val_15 = val_1.w;
            }
            else
            {
                    throw new System.ArgumentOutOfRangeException(paramName:  "arrowOrientation", actualValue:  ???, message:  0);
            }
        
        }
        public TutorialArrowView()
        {
            this.easer = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  4);
            this.isMovingAway = true;
        }
        private static TutorialArrowView()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView.MoveDuration = val_1.x;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView.MoveDuration.__il2cppRuntimeField_4 = val_1.y;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView.MoveDuration.__il2cppRuntimeField_8 = val_1.z;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView.MaxRootYForUp = 0;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView.MoveDuration.__il2cppRuntimeField_14 = 0;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView.MaxRootYForDown = 0;
            Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialArrowView.MoveDuration.__il2cppRuntimeField_20 = 0;
        }
    
    }

}
