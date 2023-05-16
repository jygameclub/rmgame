using UnityEngine;

namespace Royal.Scenes.Game.Ui.Bottom
{
    public class BottomUi : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Game.Ui.Bottom.Boosters.InGameBoosterManager inGameBoosterManager;
        public UnityEngine.SpriteRenderer[] frames;
        public UnityEngine.SpriteRenderer[] settingsBackgrounds;
        public UnityEngine.SpriteRenderer[] settingsShadows;
        public UnityEngine.SpriteRenderer veryLeftShadow;
        public UnityEngine.SpriteRenderer veryRightShadow;
        private const float Height = 2.2;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        
        // Methods
        private void Awake()
        {
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            if(IsLeague != false)
            {
                    this.PrepareForLeagueLevel();
            }
            else
            {
                    if(IsHard != false)
            {
                    this.PrepareForHardLevel(difficulty:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_2C>>0&0xFF);
            }
            
            }
            
            this.InitialPosition();
        }
        private void PrepareForLeagueLevel()
        {
            null = null;
            this.PrepareForSpecialLevel(specialLevelAssets:  Royal.Scenes.Game.Context.GameContext.<Controller>k__BackingField.GetLeagueLevelAssets());
        }
        private void PrepareForHardLevel(sbyte difficulty)
        {
            null = null;
            this.PrepareForSpecialLevel(specialLevelAssets:  Royal.Scenes.Game.Context.GameContext.<Controller>k__BackingField.GetHardLevelAssets(difficulty:  difficulty));
        }
        private void PrepareForSpecialLevel(Royal.Scenes.Game.Ui.SpecialLevelAssets specialLevelAssets)
        {
            var val_2 = 0;
            label_5:
            if(val_2 >= this.frames.Length)
            {
                goto label_1;
            }
            
            this.frames[val_2].sprite = specialLevelAssets.bottomBackground;
            val_2 = val_2 + 1;
            if(this.frames != null)
            {
                goto label_5;
            }
            
            label_1:
            var val_4 = 0;
            label_12:
            if(val_4 >= this.settingsBackgrounds.Length)
            {
                goto label_8;
            }
            
            this.settingsBackgrounds[val_4].sprite = specialLevelAssets.circleButton;
            val_4 = val_4 + 1;
            if(this.settingsBackgrounds != null)
            {
                goto label_12;
            }
            
            label_8:
            if(this.settingsBackgrounds.Length < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            do
            {
                this.settingsShadows[val_6].color = new UnityEngine.Color() {r = specialLevelAssets.shadowColor};
                val_6 = val_6 + 1;
            }
            while(val_6 < this.settingsBackgrounds.Length);
        
        }
        private void InitialPosition()
        {
            if(this.cameraManager.IsDeviceWide() != false)
            {
                    UnityEngine.SpriteRenderer val_20 = this.frames[0];
                UnityEngine.Vector2 val_2 = val_20.size;
                UnityEngine.Vector2 val_3 = UnityEngine.Vector2.right;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, d:  2f);
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
                val_20.size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
                UnityEngine.SpriteRenderer val_21 = this.frames[((-4294967296) + ((this.frames.Length) << 32)) >> 29];
                UnityEngine.Vector2 val_7 = val_21.size;
                UnityEngine.Vector2 val_8 = UnityEngine.Vector2.right;
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, d:  2f);
                UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, b:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
                val_21.size = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
                UnityEngine.Vector2 val_11 = this.veryLeftShadow.size;
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.right;
                UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, d:  2f);
                UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, b:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
                this.veryLeftShadow.size = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
                UnityEngine.Vector2 val_15 = this.veryRightShadow.size;
                UnityEngine.Vector2 val_16 = UnityEngine.Vector2.right;
                UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}, d:  2f);
                UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, b:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
                this.veryRightShadow.size = new UnityEngine.Vector2() {x = val_18.x, y = val_18.y};
            }
            
            float val_22 = -0.5f;
            val_22 = this.cameraManager.cameraHeight * val_22;
            val_22 = val_22 + (-1.1f);
            this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public void PrepareTransformAnimation(DG.Tweening.Sequence seq)
        {
            UnityEngine.Vector3 val_1 = this.cameraManager.GetSafeBottomCenterOfCamera();
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y + 1.9f, z = 0f}, duration:  0.3f, snapping:  false), ease:  27);
            val_5 = 1073741824;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  seq, atPosition:  0f, t:  val_5);
        }
        public void HideForCannonBooster()
        {
            float val_4 = this.cameraManager.cameraHeight;
            float val_5 = -1.1f;
            val_4 = val_4 * (-0.5f);
            val_5 = val_4 + val_5;
            DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.3f, snapping:  false), ease:  26) = 1069547520;
        }
        public void ShowAfterCannonBooster()
        {
            UnityEngine.Vector3 val_1 = this.cameraManager.GetSafeBottomCenterOfCamera();
            DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y + 1.9f, z = 0f}, duration:  0.4f, snapping:  false), ease:  27) = 1069547520;
        }
        public UnityEngine.Vector3 GetTopCenterPosition()
        {
            return this.transform.position;
        }
        public BottomUi()
        {
        
        }
    
    }

}
