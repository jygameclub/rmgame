using UnityEngine;

namespace Royal.Scenes.Game.Ui.Top
{
    public class TopUi : MonoBehaviour
    {
        // Fields
        private const float Height = 4;
        public UnityEngine.SpriteRenderer[] panels;
        public UnityEngine.SpriteRenderer[] headers;
        public UnityEngine.SpriteRenderer background;
        public TMPro.TextMeshPro targetTitle;
        public TMPro.TextMeshPro moveText;
        public TMPro.TextMeshPro movesTitle;
        public UnityEngine.GameObject targetGo;
        public UnityEngine.GameObject movesGo;
        public Royal.Scenes.Game.Ui.Top.King.KingUi kingUi;
        public UnityEngine.Rendering.SortingGroup sortingGroup;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        
        // Methods
        private void Awake()
        {
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.moveManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            this.targetTitle.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Target");
            this.InitialPosition();
            this.moveManager.add_OnMoveChanged(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Top.TopUi::OnMoveChanged(int leftMoves)));
            this.OnMoveChanged(leftMoves:  this.moveManager.<LeftMoves>k__BackingField);
            this.ArrangeMovesTitle();
        }
        private void Start()
        {
            this.PrepareForBonusLevel();
        }
        private void ArrangeMovesTitle()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isSpanish == false)
            {
                    return;
            }
            
            this.movesTitle.fontSize = 3.2f;
            this.movesTitle.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this = this.movesTitle.GetComponent<Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve>();
            if(this != 0)
            {
                    this = 1065353216;
            }
            
            this.ForceUpdate();
        }
        private void PrepareForBonusLevel()
        {
            var val_11;
            float val_12;
            float val_13;
            float val_14;
            this.targetTitle.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "BonusUiReward");
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese != false)
            {
                    this.targetTitle.fontSizeMax = S0 + (-0.5f);
                UnityEngine.Transform val_3 = this.targetTitle.transform;
                val_11 = val_3;
                UnityEngine.Vector3 val_4 = val_3.position;
                val_12 = val_4.x;
                val_13 = val_4.y;
                val_14 = val_4.z;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            }
            else
            {
                    UnityEngine.Transform val_6 = this.targetTitle.transform;
                val_11 = val_6;
                UnityEngine.Vector3 val_7 = val_6.position;
                val_12 = val_7.x;
                val_13 = val_7.y;
                val_14 = val_7.z;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.down;
            }
            
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  0.022f);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            val_11.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        private void PrepareForLeagueLevel()
        {
            null = null;
            this.kingUi.PrepareForLeagueLevel();
            this.PrepareForSpecialLevel(specialLevelAssets:  Royal.Scenes.Game.Context.GameContext.<Controller>k__BackingField.GetLeagueLevelAssets());
        }
        private void PrepareForHardLevel(sbyte difficulty)
        {
            null = null;
            this.kingUi.PrepareForHardLevel(difficulty:  difficulty);
            this.PrepareForSpecialLevel(specialLevelAssets:  Royal.Scenes.Game.Context.GameContext.<Controller>k__BackingField.GetHardLevelAssets(difficulty:  difficulty));
        }
        private void PrepareForSpecialLevel(Royal.Scenes.Game.Ui.SpecialLevelAssets specialLevelAssets)
        {
            this.background.sprite = specialLevelAssets.topBackground;
            var val_2 = 0;
            label_6:
            if(val_2 >= this.panels.Length)
            {
                goto label_3;
            }
            
            this.panels[val_2].sprite = specialLevelAssets.goalPanelContainer;
            val_2 = val_2 + 1;
            if(this.panels != null)
            {
                goto label_6;
            }
            
            label_3:
            var val_4 = 0;
            do
            {
                if(val_4 >= this.headers.Length)
            {
                    return;
            }
            
                this.headers[val_4].sprite = specialLevelAssets.goalPanelBanner;
                val_4 = val_4 + 1;
            }
            while(this.headers != null);
            
            throw new NullReferenceException();
        }
        private void ChangeTargetTextAsReward()
        {
            var val_14;
            float val_15;
            float val_16;
            float val_17;
            I2.Loc.LocalizedString val_1 = I2.Loc.LocalizedString.op_Implicit(term:  "BonusUiReward");
            string val_14 = 0;
            this.targetTitle.text = I2.Loc.LocalizedString.op_Implicit(s:  new I2.Loc.LocalizedString() {mRTL_IgnoreArabicFix = false, mRTL_ConvertNumbers = false, m_DontLocalizeParameters = false});
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese != false)
            {
                    val_14 = val_14 + (-0.5f);
                this.targetTitle.fontSizeMax = val_14;
                UnityEngine.Transform val_5 = this.targetTitle.transform;
                val_14 = val_5;
                UnityEngine.Vector3 val_6 = val_5.position;
                val_15 = val_6.x;
                val_16 = val_6.y;
                val_17 = val_6.z;
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
            }
            else
            {
                    UnityEngine.Transform val_8 = this.targetTitle.transform;
                val_14 = val_8;
                UnityEngine.Vector3 val_9 = val_8.position;
                val_15 = val_9.x;
                val_16 = val_9.y;
                val_17 = val_9.z;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.down;
            }
            
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  0.022f);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_17}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            val_14.position = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            this.targetTitle.GetComponentInChildren<Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve>().ForceUpdate();
        }
        public void AnimateTargetTextAsReward()
        {
            UnityEngine.Vector3 val_3 = this.targetTitle.transform.localScale;
            Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve val_4 = this.targetTitle.GetComponentInChildren<Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve>();
            .textProCurve = val_4;
            val_4 = 1;
            (TopUi.<>c__DisplayClass21_0)[1152921519886526192].textProCurve.ForceUpdate();
            this.ChangeTargetTextAsReward();
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.targetTitle.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.targetTitle.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.25f), ease:  27), action:  new DG.Tweening.TweenCallback(object:  new TopUi.<>c__DisplayClass21_0(), method:  System.Void TopUi.<>c__DisplayClass21_0::<AnimateTargetTextAsReward>b__0()));
        }
        private void InitialPosition()
        {
            if(this.cameraManager.IsDeviceWide() != false)
            {
                    UnityEngine.Vector2 val_2 = this.background.size;
                UnityEngine.Vector2 val_3 = UnityEngine.Vector2.right;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, d:  4f);
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
                this.background.size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            }
            
            float val_7 = 0.5f;
            val_7 = this.cameraManager.cameraHeight * val_7;
            float val_8 = 4f;
            val_8 = val_7 + val_8;
            this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            sortingData.sortEverything = sortingData.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.sortingGroup, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything});
            this.sortingGroup.enabled = true;
        }
        public void ResetSorting()
        {
            if(this.sortingGroup != null)
            {
                    this.sortingGroup.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public void PrepareTransformAnimation(DG.Tweening.Sequence seq)
        {
            UnityEngine.Vector3 val_1 = this.cameraManager.GetSafeTopCenterOfCamera();
            float val_7 = val_1.y;
            val_7 = val_7 + (-0.1f);
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22).PlaySfx(type:  149, offset:  0.04f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_7, z = 0f}, duration:  0.3f, snapping:  false), ease:  27);
            val_5 = 1073741824;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  seq, atPosition:  0f, t:  val_5);
        }
        private void OnMoveChanged(int leftMoves)
        {
            this.moveText.text = leftMoves.ToString();
        }
        public void ChangeTargetPanelParent(UnityEngine.Transform parent, Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            this.targetGo.transform.SetParent(p:  parent.transform);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.targetGo.AddComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything & 4294967295});
        }
        public void ResetTargetPanelParent()
        {
            UnityEngine.Object.Destroy(obj:  this.targetGo.GetComponent<UnityEngine.Rendering.SortingGroup>());
            this.targetGo.transform.SetParent(p:  this.transform);
        }
        public void ChangeKingPanelParent(UnityEngine.Transform parent, Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            if(this.kingUi != null)
            {
                    sortingData.sortEverything = sortingData.sortEverything & 4294967295;
                this.kingUi.ChangeKingPanelParent(parent:  parent, sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything});
                return;
            }
            
            throw new NullReferenceException();
        }
        public void ResetKingPanelParent()
        {
            this.kingUi.ResetKingPanelParent(parent:  this.transform);
        }
        public void ChangeMovesPanelParent(UnityEngine.Transform parent, Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            this.movesGo.transform.SetParent(p:  parent.transform);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.movesGo.AddComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything & 4294967295});
        }
        public void ResetMovesPanelParent()
        {
            UnityEngine.Object.Destroy(obj:  this.movesGo.GetComponent<UnityEngine.Rendering.SortingGroup>());
            this.movesGo.transform.SetParent(p:  this.transform);
        }
        public UnityEngine.Vector3 GetBottomOfTopUi()
        {
            return this.background.transform.position;
        }
        public TopUi()
        {
        
        }
    
    }

}
