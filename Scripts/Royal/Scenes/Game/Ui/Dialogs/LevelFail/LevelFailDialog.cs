using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.LevelFail
{
    public class LevelFailDialog : ABoosterSelectionDialog
    {
        // Fields
        private Royal.Player.Context.Units.LevelManager levelManager;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        public UnityEngine.Transform goalParent;
        public UnityEngine.Transform[] goals;
        public UnityEngine.SpriteRenderer[] icons;
        public UnityEngine.SpriteRenderer[] shadows;
        public UnityEngine.SpriteRenderer[] goalResults;
        public UnityEngine.SpriteRenderer[] goalShadows;
        public UnityEngine.Sprite checkIcon;
        public UnityEngine.Sprite redCrossIcon;
        public UnityEngine.Sprite checkShadow;
        public UnityEngine.Sprite redCrossShadow;
        public UnityEngine.Transform failPanel;
        public Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelEndBottomPanel levelEndBottomPanel;
        public TMPro.TextMeshPro button;
        private bool showBottomPanel;
        private Royal.Player.Context.Data.Session.UserActiveLevelData activeLevel;
        
        // Methods
        private void Awake()
        {
            this.activeLevel = Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze;
            this.levelEndBottomPanel.gameObject.SetActive(value:  false);
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            this.PrepareTitle(levelData:  this.activeLevel);
            this.PrepareButtonText();
            this.PrepareGoalResults();
            this.PrepareBoosters(origin:  3);
        }
        public override void OnShow(UnityEngine.Vector3 position)
        {
            if(this.activeLevel.number <= 31)
            {
                    if(this.activeLevel.IsLeague == false)
            {
                goto label_2;
            }
            
            }
            
            this.showBottomPanel = true;
            this.levelEndBottomPanel.Prepare(topPanel:  this.failPanel);
            UnityEngine.Vector3 val_3 = this.transform.position;
            goto label_5;
            label_2:
            this.showBottomPanel = false;
            label_5:
            this.OnShow(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        }
        protected override void AfterShowAnimation()
        {
            if(this.showBottomPanel == false)
            {
                    return;
            }
            
            this.levelEndBottomPanel.gameObject.SetActive(value:  true);
            this.levelEndBottomPanel.Show(delay:  0f);
        }
        public void OnRetryButton()
        {
            this.AutoSelectBoostersIfHasTime();
            bool val_2 = Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameManager>(id:  1).RestartGameWhenPossible();
            goto typeof(Royal.Scenes.Game.Ui.Dialogs.LevelFail.LevelFailDialog).__il2cppRuntimeField_250;
        }
        public void OnExitButton()
        {
            Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameManager>(id:  1).ExitGameWhenPossible();
        }
        private void PrepareGoalResults()
        {
            var val_3;
            var val_4;
            float val_32;
            var val_33;
            float val_34;
            Royal.Scenes.Game.Levels.Units.ItemAssetsLibrary val_35;
            var val_36;
            float val_37;
            if(this.levelManager == null)
            {
                    throw new NullReferenceException();
            }
            
            if(this.levelManager.goals == null)
            {
                    throw new NullReferenceException();
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = this.levelManager.goals.GetEnumerator();
            val_32 = -0.011f;
            val_33 = 0;
            val_34 = 1f;
            label_39:
            if(((-1859185920) & 1) == 0)
            {
                goto label_3;
            }
            
            if(this.goals == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_33 >= this.goals.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            if(this.icons == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_33 >= this.icons.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            if(this.shadows == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_33 >= this.shadows.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(this.itemFactory == null)
            {
                    throw new NullReferenceException();
            }
            
            val_35 = this.itemFactory.assetsLibrary;
            if(val_35 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Transform val_33 = this.goals[0];
            UnityEngine.SpriteRenderer val_34 = this.icons[0];
            UnityEngine.SpriteRenderer val_35 = this.shadows[0];
            if((val_35.GetItemGoalAsset(goalType:  val_3 + 16)) == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_34 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_34.sprite = val_5.iconSprite;
            UnityEngine.Transform val_6 = val_34.transform;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            val_35 = 0;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  val_5.iconScale);
            if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_6.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.iconOffset, y = V11.16B});
            val_35 = val_6;
            val_35.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            if(val_35 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_35.sprite = val_5.shadowSprite;
            UnityEngine.Transform val_10 = val_35.transform;
            val_35 = 0;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.shadowPosition, y = val_9.y});
            if(val_10 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_10.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            val_4 = 0;
            val_35.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.shadowScale, y = 0f});
            val_10.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            val_35 = this;
            if(this.goalResults == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_33 >= this.goalResults.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_36 = this.HasCompleted(goalType:  val_3 + 16);
            val_35 = this.goalResults[0];
            if(val_35 == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_14 = (val_36 != true) ? 160 : 168;
            val_35.sprite = null;
            if(this.goalShadows == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_33 >= this.goalShadows.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_35 = this.goalShadows[0];
            if(val_35 == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_15 = (val_36 != true) ? 176 : 184;
            val_35.sprite = null;
            if(this.goalShadows == null)
            {
                    throw new NullReferenceException();
            }
            
            val_35 = this.goalShadows[0];
            if(val_35 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Transform val_16 = val_35.transform;
            if(val_36 != false)
            {
                    val_4 = 0;
                UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  0f, y:  -0.025f);
            }
            else
            {
                    val_4 = 0;
                UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  0f, y:  val_32);
            }
            
            val_35 = 0;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
            if(val_16 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_35 = val_16;
            val_35.localPosition = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            if(val_33 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.GameObject val_20 = val_33.gameObject;
            if(val_20 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_20.SetActive(value:  true);
            val_33 = val_33 + 1;
            if(val_33 != this.goals.Length)
            {
                goto label_39;
            }
            
            label_3:
            val_4.Dispose();
            val_37 = 0f;
            if((val_33 - 2) <= 2)
            {
                    val_37 = mem[36532836 + (((val_33 + 1) - 2)) << 2];
                val_37 = 36532836 + (((val_33 + 1) - 2)) << 2;
            }
            
            var val_22 = (val_33 == 4) ? 1 : 0;
            if(this.goals == null)
            {
                    throw new NullReferenceException();
            }
            
            val_34 = mem[36530448 + val_33 == 0x4 ? 1 : 0];
            val_34 = 36530448 + val_33 == 0x4 ? 1 : 0;
            val_32 = val_37 + val_37;
            val_36 = 4;
            label_52:
            var val_23 = val_36 - 4;
            if(val_23 >= this.goals.Length)
            {
                goto label_42;
            }
            
            if(val_23 >= this.goals.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            UnityEngine.Transform val_36 = this.goals[0];
            if(val_36 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Transform val_24 = val_36.transform;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.right;
            float val_37 = (float)val_23;
            val_37 = val_32 * val_37;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  val_37);
            if(val_24 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_35 = val_24;
            val_35.localPosition = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z};
            if(this.goals == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_23 >= this.goals.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            UnityEngine.Transform val_38 = this.goals[0];
            if(val_38 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Transform val_27 = val_38.transform;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, d:  val_34);
            if(val_27 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_27.localScale = new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z};
            val_36 = val_36 + 1;
            if(this.goals != null)
            {
                goto label_52;
            }
            
            throw new NullReferenceException();
            label_42:
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.left;
            float val_39 = (float)val_33 - 1;
            val_39 = val_37 * val_39;
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, d:  val_39);
            if(this.goalParent == null)
            {
                    throw new NullReferenceException();
            }
            
            this.goalParent.localPosition = new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z};
        }
        private bool HasCompleted(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            var val_5;
            var val_6;
            var val_16;
            Royal.Scenes.Game.Levels.Units.GoalManager val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            if(this.goalManager == null)
            {
                    throw new NullReferenceException();
            }
            
            int val_1 = this.goalManager.GetGoalLeftCount(goalType:  goalType);
            var val_2 = (val_1 == 0) ? 1 : 0;
            if(goalType != 13)
            {
                goto label_2;
            }
            
            if(this.levelManager == null)
            {
                    throw new NullReferenceException();
            }
            
            if(this.levelManager.goals == null)
            {
                    throw new NullReferenceException();
            }
            
            Dictionary.Enumerator<TKey, TValue> val_3 = this.levelManager.goals.GetEnumerator();
            label_7:
            if(((-1858582336) & 1) == 0)
            {
                goto label_5;
            }
            
            if(val_5 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_5 + 16) != 22)
            {
                goto label_7;
            }
            
            if(val_1 == 0)
            {
                goto label_8;
            }
            
            val_18 = 0;
            goto label_9;
            label_5:
            val_18 = 0;
            val_19 = 223;
            goto label_10;
            label_8:
            val_17 = this.goalManager;
            if(val_17 == null)
            {
                    throw new NullReferenceException();
            }
            
            label_9:
            val_19 = 225;
            label_10:
            val_6.Dispose();
            var val_9 = 225 & 63;
            if(val_9 == 31)
            {
                    return (bool)(mem[229] == 225) ? (((this.goalManager.GetGoalLeftCount(goalType:  29)) == 0) ? 1 : 0) : ((val_1 == 0) ? 1 : 0);
            }
            
            if(val_9 == 33)
            {
                    val_16 = ((val_17.GetGoalLeftCount(goalType:  22)) == 0) ? 1 : 0;
                return (bool)(mem[229] == 225) ? (((this.goalManager.GetGoalLeftCount(goalType:  29)) == 0) ? 1 : 0) : ((val_1 == 0) ? 1 : 0);
            }
            
            val_20 = 0;
            goto label_15;
            label_2:
            val_18 = 0;
            val_20 = 0;
            label_15:
            if(goalType != 30)
            {
                    return (bool)(mem[229] == 225) ? (((this.goalManager.GetGoalLeftCount(goalType:  29)) == 0) ? 1 : 0) : ((val_1 == 0) ? 1 : 0);
            }
            
            if(this.levelManager == null)
            {
                    throw new NullReferenceException();
            }
            
            if(this.levelManager.goals == null)
            {
                    throw new NullReferenceException();
            }
            
            Dictionary.Enumerator<TKey, TValue> val_10 = this.levelManager.goals.GetEnumerator();
            label_26:
            if(((-1858582336) & 1) == 0)
            {
                goto label_24;
            }
            
            if(val_5 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_5 + 16) != 29)
            {
                goto label_26;
            }
            
            if(val_1 == 0)
            {
                goto label_27;
            }
            
            val_18 = 0;
            goto label_28;
            label_24:
            val_21 = 223;
            goto label_29;
            label_27:
            label_28:
            val_21 = 225;
            label_29:
            mem[229] = 225;
            val_6.Dispose();
            if(1 == 1)
            {
                    return (bool)(mem[229] == 225) ? (((this.goalManager.GetGoalLeftCount(goalType:  29)) == 0) ? 1 : 0) : ((val_1 == 0) ? 1 : 0);
            }
            
            return (bool)(mem[229] == 225) ? (((this.goalManager.GetGoalLeftCount(goalType:  29)) == 0) ? 1 : 0) : ((val_1 == 0) ? 1 : 0);
        }
        private float GoalDistanceForCount(int count)
        {
            if((count - 2) > 2)
            {
                    return 0f;
            }
            
            return (float)36532836 + ((count - 2)) << 2;
        }
        private void PrepareButtonText()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            UnityEngine.Transform val_1 = this.button.transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.098f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_1.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.button.enableAutoSizing = false;
            this.button.fontSize = 7f;
            this.button.lineSpacing = -25f;
        }
        private void PrepareBoosters()
        {
            this.PrepareBoosters(origin:  3);
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeInDuration = val_3;
            val_0.shouldCloseOnTouch = val_4;
            return val_0;
        }
        public override void CloseOnEscape()
        {
            this.OnExitButton();
        }
        public LevelFailDialog()
        {
        
        }
    
    }

}
