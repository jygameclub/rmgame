using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Prelevel
{
    public class PrelevelDialog : ABoosterSelectionDialog
    {
        // Fields
        public UnityEngine.Transform goalParent;
        public UnityEngine.Transform[] goals;
        public UnityEngine.SpriteRenderer[] icons;
        public UnityEngine.SpriteRenderer[] shadows;
        public TMPro.TextMeshPro[] counts;
        public UnityEngine.RectTransform rewardAmountText;
        public Royal.Scenes.Game.Ui.Cloche.ClocheProgress clocheProgress;
        public UnityEngine.GameObject playButton;
        private System.Action OnBoosterClicked;
        private Royal.Player.Context.Units.LevelManager levelManager;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Infrastructure.UiComponents.Touch.ZIndex initialBoosterButtonZIndex;
        private Royal.Scenes.Home.Context.Units.Tutorial.View.HomeClocheTutorial clocheTutorial;
        
        // Methods
        public void add_OnBoosterClicked(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnBoosterClicked, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnBoosterClicked != 1152921519322256216);
            
            return;
            label_2:
        }
        public void remove_OnBoosterClicked(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnBoosterClicked, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnBoosterClicked != 1152921519322392792);
            
            return;
            label_2:
        }
        private void Awake()
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            Royal.Player.Context.Units.LevelManager val_2 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            this.levelManager = val_2;
            val_2.LevelLoad();
            this.PrepareTitle(levelData:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze);
            this.ArrangeComponents();
            if(IsLeague != true)
            {
                    this.PrepareGoals();
            }
            
            this.PrepareBoosters();
            add_OnClicked(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Prelevel.PrelevelDialog::<Awake>b__15_0()));
            add_OnClicked(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Prelevel.PrelevelDialog::<Awake>b__15_1()));
            add_OnClicked(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Prelevel.PrelevelDialog::<Awake>b__15_2()));
        }
        private void ArrangeComponents()
        {
            if(this.rewardAmountText == 0)
            {
                    return;
            }
            
            this = this.rewardAmountText;
            this.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public void ResetBoosterButtonsZIndex()
        {
            this.ChangeBoosterButtonsZIndex(newZIndex:  this.initialBoosterButtonZIndex);
        }
        public void ChangeBoosterButtonsZIndex(Royal.Infrastructure.UiComponents.Touch.ZIndex newZIndex)
        {
            X8 + 32 = newZIndex;
            X8 + 32 + 32 = newZIndex;
            X8 + 32 + 32 + 32 = newZIndex;
        }
        public void PrepareClocheForTutorial(Royal.Scenes.Home.Context.Units.Tutorial.View.HomeClocheTutorial tutorial)
        {
            this.clocheTutorial = tutorial;
            if(val_1.Length < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                this.clocheProgress.GetComponentsInChildren<Royal.Infrastructure.UiComponents.Button.UiButton>()[val_3] = -15;
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1.Length);
        
        }
        private void PrepareGoals()
        {
            var val_6;
            var val_7;
            var val_29;
            float val_30;
            Royal.Scenes.Game.Levels.Units.ItemAssetsLibrary val_31;
            TMPro.TextMeshPro val_32;
            UnityEngine.Vector2 val_33;
            float val_34;
            if(this.clocheProgress == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.GameObject val_1 = this.clocheProgress.gameObject;
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_1.SetActive(value:  false);
            if(this.goalParent == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Transform val_2 = this.goalParent.parent;
            if(val_2 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.GameObject val_3 = val_2.gameObject;
            if(val_3 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_3.SetActive(value:  true);
            if(this.levelManager == null)
            {
                    throw new NullReferenceException();
            }
            
            if(this.levelManager.goals == null)
            {
                    throw new NullReferenceException();
            }
            
            Dictionary.Enumerator<TKey, TValue> val_4 = this.levelManager.goals.GetEnumerator();
            val_29 = 0;
            val_30 = 1f;
            label_41:
            if((1831929264 & 1) == 0)
            {
                goto label_8;
            }
            
            if(this.goals == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_29 >= this.goals.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            if(this.icons == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_29 >= this.icons.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            if(this.shadows == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_29 >= this.shadows.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            if(this.itemFactory == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_7 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_31 = this.itemFactory.assetsLibrary;
            if(val_31 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Transform val_30 = this.goals[0];
            UnityEngine.SpriteRenderer val_31 = this.icons[0];
            UnityEngine.SpriteRenderer val_32 = this.shadows[0];
            Royal.Scenes.Game.Mechanics.Goal.GoalAsset val_8 = val_31.GetItemGoalAsset(goalType:  val_7 + 16);
            val_32 = val_8;
            if(val_8 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_31 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_31.sprite = val_8.iconSprite;
            UnityEngine.Transform val_9 = val_31.transform;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            val_31 = 0;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  val_8.iconScale);
            if(val_9 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_9.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            val_33 = val_8.iconOffset;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_33, y = V9.16B});
            val_31 = val_9;
            val_31.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            if(val_32 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_32.sprite = val_8.shadowSprite;
            UnityEngine.Transform val_13 = val_32.transform;
            val_31 = 0;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8.shadowPosition, y = val_12.y});
            if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_13.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            val_6 = 0;
            val_32.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8.shadowScale, y = 0f});
            val_31 = val_13;
            val_31.localScale = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            if((val_7 + 20) != 0)
            {
                    if(this.counts == null)
            {
                    throw new NullReferenceException();
            }
            
                if(val_29 >= this.counts.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
                val_32 = this.counts[0];
                if(val_32 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_32.text = val_7 + 20.ToString();
            }
            else
            {
                    if(this.counts == null)
            {
                    throw new NullReferenceException();
            }
            
                if(val_29 >= this.counts.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
                val_31 = this.counts[0];
                if(val_31 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_31.text = "0";
                if(this.counts == null)
            {
                    throw new NullReferenceException();
            }
            
                val_31 = this.counts[0];
                val_15.x = val_15.x * 1.1f;
                val_31.fontSize = val_15.x;
            }
            
            if(val_30 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.GameObject val_17 = val_30.gameObject;
            if(val_17 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_17.SetActive(value:  true);
            val_29 = val_29 + 1;
            if(this.goals == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_29 != this.goals.Length)
            {
                goto label_41;
            }
            
            label_8:
            val_6.Dispose();
            val_34 = 0f;
            if((val_29 - 2) <= 2)
            {
                    val_34 = mem[36530648 + (((val_29 + 1) - 2)) << 2];
                val_34 = 36530648 + (((val_29 + 1) - 2)) << 2;
            }
            
            var val_19 = (val_29 == 4) ? 1 : 0;
            if(this.goals == null)
            {
                    throw new NullReferenceException();
            }
            
            val_30 = mem[36530448 + val_29 == 0x4 ? 1 : 0];
            val_30 = 36530448 + val_29 == 0x4 ? 1 : 0;
            val_33 = val_34 + val_34;
            val_32 = 4;
            label_54:
            var val_20 = val_32 - 4;
            if(val_20 >= this.goals.Length)
            {
                goto label_44;
            }
            
            if(val_20 >= this.goals.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            UnityEngine.Transform val_33 = this.goals[0];
            if(val_33 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Transform val_21 = val_33.transform;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.right;
            float val_34 = (float)val_20;
            val_34 = val_33 * val_34;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  val_34);
            if(val_21 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_31 = val_21;
            val_31.localPosition = new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z};
            if(this.goals == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_20 >= this.goals.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            UnityEngine.Transform val_35 = this.goals[0];
            if(val_35 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Transform val_24 = val_35.transform;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  val_30);
            if(val_24 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_24.localScale = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z};
            val_32 = val_32 + 1;
            if(this.goals != null)
            {
                goto label_54;
            }
            
            throw new NullReferenceException();
            label_44:
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.left;
            float val_36 = (float)val_29 - 1;
            val_36 = val_34 * val_36;
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, d:  val_36);
            if(this.goalParent == null)
            {
                    throw new NullReferenceException();
            }
            
            this.goalParent.localPosition = new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z};
        }
        private float GoalDistanceForCount(int count)
        {
            if((count - 2) > 2)
            {
                    return 0f;
            }
            
            return (float)36530648 + ((count - 2)) << 2;
        }
        private void PrepareBoosters()
        {
            this.PrepareBoosters(origin:  2);
            this.initialBoosterButtonZIndex = X8 + 32 + 24;
        }
        public override void OnShow(UnityEngine.Vector3 position)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  0.235f);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            this.OnShow(position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager>(id:  3).ShowPrelevelTutorialIfNeeded(prelevelDialog:  this);
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_3;
            float val_4;
            bool val_5;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            bool val_1 = (this.clocheTutorial == 0) ? 1 : 0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_2 = this.GetConfig();
            val_0.shouldCloseOnEscape = val_1;
            val_0.shouldCloseOnTouch = val_1;
            val_0.shouldHideBackground = val_3;
            val_0.backgroundFadeInDuration = val_4;
            val_0.shouldCloseOnSwipe = val_5;
            return val_0;
        }
        public void Play()
        {
            this.AutoSelectBoostersIfHasTime();
            this.levelManager.LevelStart();
        }
        public void UpdateBoostersCountText()
        {
            this.UpdateCountText(selected:  false);
            this.UpdateCountText(selected:  false);
            this.UpdateCountText(selected:  false);
        }
        public UnityEngine.Vector3 GetBoostersCenterPosition()
        {
            return this.transform.position;
        }
        public UnityEngine.Vector3 GetPlayButtonPosition()
        {
            return this.playButton.transform.position;
        }
        public void OnClocheButtonClick()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Cloche.ShowClocheInfoDialogAction());
            if(this.clocheTutorial != null)
            {
                    bool val_3 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetBool(key:  "ClocheTutorialShowed", value:  true);
                this.clocheTutorial.CloseClocheTutorial();
                this.clocheTutorial = 0;
                if(val_4.Length >= 1)
            {
                    var val_6 = 0;
                do
            {
                val_6 = val_6 + 1;
                this.clocheProgress.GetComponentsInChildren<Royal.Infrastructure.UiComponents.Button.UiButton>()[val_6] = this.initialBoosterButtonZIndex;
            }
            while(val_6 < val_4.Length);
            
            }
            
            }
        
        }
        public override void OnClose(System.Action dialogClosed)
        {
            if(this.clocheTutorial != null)
            {
                    this.clocheTutorial.CloseClocheTutorial();
                this.clocheTutorial = 0;
            }
            
            this.OnClose(dialogClosed:  dialogClosed);
        }
        public PrelevelDialog()
        {
            val_1 = new Royal.Infrastructure.UiComponents.Dialog.UiDialog();
        }
        private void <Awake>b__15_0()
        {
            if(this.OnBoosterClicked == null)
            {
                    return;
            }
            
            this.OnBoosterClicked.Invoke();
        }
        private void <Awake>b__15_1()
        {
            if(this.OnBoosterClicked == null)
            {
                    return;
            }
            
            this.OnBoosterClicked.Invoke();
        }
        private void <Awake>b__15_2()
        {
            if(this.OnBoosterClicked == null)
            {
                    return;
            }
            
            this.OnBoosterClicked.Invoke();
        }
    
    }

}
