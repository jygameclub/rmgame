using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Tutorial.View
{
    public class HomeTutorialArrowView : MonoBehaviour
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
            UnityEngine.Color val_5 = UnityEngine.Color.white;
            if(val_6.Length < 1)
            {
                    return;
            }
            
            var val_8 = 0;
            do
            {
                this.GetComponentsInChildren<UnityEngine.SpriteRenderer>()[val_8].color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = 0f};
                val_8 = val_8 + 1;
            }
            while(val_8 < val_6.Length);
        
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
        public Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView SetPosition(UnityEngine.Vector3 position)
        {
            this.transform.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            return (Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView)this;
        }
        public Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView SetScale(float scale)
        {
            this.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            return (Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView)this;
        }
        public Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView SetSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            sortingData.sortEverything = sortingData.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything});
            return (Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView)this;
        }
        public Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView SetOrientation(Royal.Scenes.Game.Levels.Units.LevelTutorials.View.ArrowOrientation orientation)
        {
            float val_15;
            float val_16;
            float val_17;
            float val_18;
            var val_25;
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            val_15 = val_1.x;
            val_16 = val_1.y;
            val_17 = val_1.z;
            val_18 = val_1.w;
            if(orientation <= 3)
            {
                    var val_11 = 36587024 + (orientation) << 2;
                val_11 = val_11 + 36587024;
            }
            else
            {
                    this.transform.rotation = new UnityEngine.Quaternion() {};
                val_25 = null;
                val_25 = null;
                this.minPos = Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView.MoveDuration;
                mem[1152921519571515024] = Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView.MoveDuration.__il2cppRuntimeField_8;
                return (Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView)this;
            }
        
        }
        public void Show(float fadeDuration)
        {
            this.playAnimation = true;
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_2 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.arrowRenderer, endValue:  1f, duration:  fadeDuration), ease:  1);
            int val_6 = val_3.Length;
            if(val_6 < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            val_6 = val_6 & 4294967295;
            do
            {
                DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  null, endValue:  0.3f, duration:  fadeDuration), ease:  1);
                val_7 = val_7 + 1;
            }
            while(val_7 < (val_3.Length << ));
        
        }
        public HomeTutorialArrowView()
        {
            this.easer = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  4);
        }
        private static HomeTutorialArrowView()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView.MoveDuration = val_1.x;
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView.MoveDuration.__il2cppRuntimeField_4 = val_1.y;
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView.MoveDuration.__il2cppRuntimeField_8 = val_1.z;
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView.MaxRootYForUp = 0;
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView.MoveDuration.__il2cppRuntimeField_14 = 0;
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView.MaxRootYForDown = 0;
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView.MoveDuration.__il2cppRuntimeField_20 = 0;
        }
    
    }

}
