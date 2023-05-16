using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Area
{
    public sealed class AreaDialogTaskRow : UiScrollContentItem
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.Area.SpendStarView spendStarPrefab;
        public UnityEngine.GameObject checkVisual;
        public Royal.Infrastructure.UiComponents.Button.UiScrollButton buildButton;
        public TMPro.TextMeshPro taskText;
        public TMPro.TextMeshPro priceText;
        public UnityEngine.SpriteRenderer taskIcon;
        public UnityEngine.ParticleSystem checkParticles;
        public UnityEngine.Rendering.SortingGroup sortingGroup;
        private Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialogTaskRowData dialogTaskData;
        private Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialog areaDialog;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper assetBundleHelper;
        
        // Methods
        private void Awake()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.assetBundleHelper = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper>(id:  8);
        }
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
            if(data != null)
            {
                    this.dialogTaskData = data;
                this.areaDialog = Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialogTaskRowData.__il2cppRuntimeField_typeHierarchyDepth;
                this.buildButton = maskBounds.m_Extents.y;
                this.buildButton = maskBounds.m_Center.x;
                this.PrepareTextsAndButtons();
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetDialogScrollContentSorting();
                bool val_2 = val_1.sortEverything & 4294967295;
                return;
            }
            
            this.dialogTaskData = data;
            throw new NullReferenceException();
        }
        private void PrepareTextsAndButtons()
        {
            var val_9;
            UnityEngine.SpriteRenderer val_10;
            val_9 = this;
            this.taskText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  this.dialogTaskData.config.LocalizedStringKey(areaId:  129259600));
            val_10 = this.taskIcon;
            val_10.sprite = this.GetTaskSprite(areaNo:  129259600, taskId:  this.dialogTaskData.config.id);
            this.priceText.text = this.dialogTaskData.config.price.ToString();
            if(this.dialogTaskData.isHidden == false)
            {
                    return;
            }
            
            mem[1152921519538991560] = 1;
            int val_9 = val_6.Length;
            if(val_9 >= 1)
            {
                    val_9 = val_9 & 4294967295;
                do
            {
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  null, alpha:  0f);
                val_10 = 0 + 1;
            }
            while(val_10 < (val_6.Length << ));
            
            }
            
            int val_10 = val_8.Length;
            val_9 = this.gameObject.GetComponentsInChildren<TMPro.TextMeshPro>();
            if(val_10 < 1)
            {
                    return;
            }
            
            var val_11 = 0;
            val_10 = val_10 & 4294967295;
            do
            {
                Royal.Infrastructure.Utils.Text.TextMeshProExtensions.ChangeAlpha(tmp:  null, alpha:  0f);
                val_11 = val_11 + 1;
            }
            while(val_11 < (val_8.Length << ));
        
        }
        private UnityEngine.Sprite GetTaskSprite(int areaNo, int taskId)
        {
            if((areaNo - 1) > 27)
            {
                    return UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "Icons/"("Icons/") + Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper.GetTaskIconName(areaNo:  areaNo, taskId:  taskId)(Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper.GetTaskIconName(areaNo:  areaNo, taskId:  taskId)));
            }
            
            return this.assetBundleHelper.LoadTaskIcon(areaNo:  areaNo, taskId:  taskId);
        }
        public override void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sorting)
        {
            this.sortingGroup.sortingLayerID = sorting.layer;
            sorting.layer = sorting.layer >> 32;
            this.sortingGroup.sortingOrder = sorting.layer;
        }
        public void Build()
        {
            if((this.areaDialog.<LastCompletedTaskAnimationStarted>k__BackingField) != false)
            {
                    return;
            }
            
            if((HasEnoughStars(delta:  this.dialogTaskData.config.price)) != false)
            {
                    this.PlaySpendStarAnimation(price:  this.dialogTaskData.config.price);
                return;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Star.ShowStarDialogAction(dialogType:  0));
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialog).__il2cppRuntimeField_250;
        }
        public void AnimateLastBuild(int toIndex, System.Action onComplete)
        {
            this.buildButton.gameObject.SetActive(value:  false);
            UnityEngine.Coroutine val_3 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  this.AnimateAfterDelay(toIndex:  toIndex, onComplete:  onComplete));
        }
        private System.Collections.IEnumerator AnimateAfterDelay(int toIndex, System.Action onComplete)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .toIndex = toIndex;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new AreaDialogTaskRow.<AnimateAfterDelay>d__19();
        }
        private void PlaySpendStarAnimation(int price)
        {
            var val_7;
            if(this.areaDialog.buildStarted == true)
            {
                    return;
            }
            
            this.areaDialog.BuildStarted = true;
            float val_7 = (float)UnityEngine.Mathf.Max(a:  1, b:  price - 1);
            val_7 = 0.6f / val_7;
            float val_3 = UnityEngine.Mathf.Min(a:  0.2f, b:  val_7);
            if(price < 1)
            {
                    return;
            }
            
            val_7 = 0;
            var val_8 = 0;
            do
            {
                val_3 = val_3 * 0f;
                this.Invoke(methodName:  (((-price) + val_8) == 1) ? "InstantiateAndSpendLastStar" : "InstantiateAndSpendStar", time:  val_3);
                if(val_7 <= 3)
            {
                    val_7 = val_7 + 1;
                this.Invoke(methodName:  "PlayAreaTaskThrowSound", time:  0f * 0.2f);
            }
            
                val_8 = val_8 + 1;
            }
            while((-price) != val_8);
        
        }
        private void InstantiateAndSpendStar()
        {
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.Area.SpendStarView>(original:  this.spendStarPrefab).Play(hitTrans:  this.buildButton.transform, count:  0, onComplete:  0);
        }
        private void InstantiateAndSpendLastStar()
        {
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.Area.SpendStarView>(original:  this.spendStarPrefab).Play(hitTrans:  this.buildButton.transform, count:  this.dialogTaskData.config.price, onComplete:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialogTaskRow::<InstantiateAndSpendLastStar>b__22_0()));
        }
        private void PlayAreaTaskThrowSound()
        {
            this.Invoke(methodName:  "PlayAreaTaskStarSound", time:  0.15f);
        }
        private void PlayAreaTaskStarSound()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  5, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        public AreaDialogTaskRow()
        {
        
        }
        private void <InstantiateAndSpendLastStar>b__22_0()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.AreaTask.ShowAreaTaskAnimationDialogAction(areaTaskId:  this.dialogTaskData.taskData, areaTaskPrice:  this.dialogTaskData.config.price));
            this.areaDialog = 0;
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialog).__il2cppRuntimeField_250;
        }
    
    }

}
