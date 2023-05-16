using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassScrollContent : UiExpandableScrollContent
    {
        // Fields
        public UnityEngine.Transform currentStepTopSeparator;
        public UnityEngine.Transform currentStepBottomSeparator;
        public UnityEngine.SpriteRenderer[] currentStepHighlights;
        public UnityEngine.GameObject currentStep;
        public int poolCount;
        private System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData> dataList;
        public System.Collections.Generic.Dictionary<int, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem> pool;
        private int minIndex;
        private int maxIndex;
        public bool isCurrentStepHighlightSet;
        public const float FirstRowSize = 1.6;
        private const float LastRowSize = 5;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPopup royalPassPopup;
        private Royal.Player.Context.Units.RoyalPassManager royalPassManager;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private bool isMoveAnimationCompleted;
        
        // Methods
        private void Awake()
        {
            this.royalPassManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.dataList = new System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData>();
            this.pool = new System.Collections.Generic.Dictionary<System.Int32, Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem>(capacity:  this.poolCount);
            float val_11 = this.cameraManager.cameraWidth;
            val_11 = val_11 * 140f;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_11, y:  1f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            this.currentStepTopSeparator.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            float val_12 = this.cameraManager.cameraWidth;
            UnityEngine.Vector2 val_9;
            val_12 = val_12 * 140f;
            val_9 = new UnityEngine.Vector2(x:  val_12, y:  1f);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            this.currentStepBottomSeparator.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            this.minIndex = -4294967296;
            this.maxIndex = -1;
        }
        public override void AddData(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data)
        {
            if((this.dataList.Contains(item:  data)) != false)
            {
                    return;
            }
            
            this.dataList.Add(item:  data);
            int val_7 = this.poolCount;
            int val_8 = this.maxIndex;
            val_7 = val_7 - 1;
            if(val_8 < val_7)
            {
                    val_8 = val_8 + 1;
                this.maxIndex = val_8;
                Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_3 = UnityEngine.Object.Instantiate<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem>(original:  X22, parent:  this.transform);
                Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_9 = val_3;
                if(val_3 != null)
            {
                    val_9 = this.royalPassPopup;
            }
            
                float val_4 = this.GetPositionByIndex(index:  47587328);
                this.PopulateData(item:  val_9, position:  val_4, index:  this.maxIndex);
            }
            
            if(data == null)
            {
                goto label_10;
            }
            
            var val_5 = (null == null) ? 1.6f : 5f;
            if(null == null)
            {
                goto label_13;
            }
            
            if(null != null)
            {
                goto label_12;
            }
            
            goto label_13;
            label_10:
            label_12:
            label_13:
            val_4 = val_4 + (S1 + S2);
            this.Size = val_4;
        }
        public void SetRoyalPassPopup(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPopup royalPassPopup)
        {
            this.royalPassPopup = royalPassPopup;
        }
        private float GetSizeForType(bool isFirstRow, bool isLastRow)
        {
            return (float)S0 + ((isFirstRow != true) ? 1.6f : 5f);
        }
        public override void OnContentMoved(float newLocation)
        {
            float val_1 = S9 + S10;
            val_1 = newLocation / val_1;
            int val_4 = (UnityEngine.Mathf.RoundToInt(f:  val_1)) - (((this.poolCount < 0) ? (this.poolCount + 1) : this.poolCount) >> 1);
            int val_5 = System.Math.Max(val1:  0, val2:  val_4);
            val_4 = (val_5 + this.poolCount) - 1;
            int val_8 = System.Math.Min(val1:  this.dataList - 1, val2:  val_4);
            if((val_5 > this.minIndex) && (val_8 > this.maxIndex))
            {
                    do
            {
                this.SwapIndex(from:  this.minIndex, to:  this.maxIndex + 1);
                int val_10 = this.minIndex + 1;
                this.minIndex = val_10;
                this.maxIndex = this.maxIndex + 1;
            }
            while(val_5 > val_10);
            
                return;
            }
            
            if(val_5 >= this.minIndex)
            {
                    return;
            }
            
            if(val_8 >= this.maxIndex)
            {
                    return;
            }
            
            do
            {
                this.SwapIndex(from:  this.maxIndex, to:  this.minIndex - 1);
                int val_13 = this.minIndex - 1;
                this.minIndex = val_13;
                this.maxIndex = this.maxIndex - 1;
            }
            while(val_5 < val_13);
        
        }
        private void SwapIndex(int from, int to)
        {
            int val_5 = from;
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_1 = 0;
            if((this.pool.TryGetValue(key:  val_5 = from, value: out  val_1)) == false)
            {
                    return;
            }
            
            System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData> val_5 = this.dataList;
            val_5 = val_5 - 1;
            if(val_5 < to)
            {
                    return;
            }
            
            bool val_3 = this.pool.Remove(key:  val_5);
            val_5 = val_1;
            this.PopulateData(item:  val_5, position:  this.GetPositionByIndex(index:  to), index:  to);
        }
        private float GetPositionByIndex(int index)
        {
            float val_7;
            float val_8;
            bool val_7 = true;
            if(val_7 <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + (index << 3);
            if(((true + (index) << 3) + 32) != 0)
            {
                    if(((true + (index) << 3) + 32) == null)
            {
                goto label_4;
            }
            
            }
            
            val_7 = 0f;
            goto label_5;
            label_4:
            val_7 = 0.68f;
            label_5:
            if(W10 <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_3 = S8 + 1.6f;
            var val_5 = 36528128 + (((long)(int)(index)) << 3);
            if(((36528128 + ((long)(int)(index)) << 3) + 32) != 0)
            {
                    var val_6 = (((36528128 + ((long)(int)(index)) << 3) + 32) == null) ? 1.75f : 0f;
            }
            else
            {
                    val_8 = 0f;
            }
            
            val_3 = val_3 + ((S8 + S10) * ((float)index - 1));
            val_3 = val_7 + val_3;
            val_3 = val_3 + val_8;
            return (float)val_3;
        }
        private void MoveNextIndex(int delta)
        {
            int val_1 = this.minIndex;
            val_1 = V1.2S + val_1;
            this.minIndex = val_1;
        }
        private void PopulateData(Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem item, float position, int index)
        {
            var val_1 = 1152921519174974272;
            this.pool.set_Item(key:  index, value:  item);
            if(val_1 <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (index << 3);
            this.PopulateData(item:  item, position:  position, data:  (1152921519174974272 + (index) << 3) + 32);
        }
        public override void Clear()
        {
            if((this.maxIndex & 2147483648) == 0)
            {
                    var val_5 = 0;
                do
            {
                if((this.pool.TryGetValue(key:  0, value: out  0)) != false)
            {
                    UnityEngine.Object.Destroy(obj:  val_1.gameObject);
                bool val_4 = this.pool.Remove(key:  0);
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 <= this.maxIndex);
            
            }
            
            this.dataList.Clear();
            this.Size = 0f;
            this.minIndex = -4294967296;
            this.maxIndex = -1;
        }
        public int GetStepIndex(int step)
        {
            var val_1;
            bool val_1 = true;
            val_1 = 0;
            label_7:
            if(val_1 >= val_1)
            {
                goto label_2;
            }
            
            val_1 = val_1 & 4294967295;
            if(val_1 >= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            if(((((true & 4294967295) + 0) + 32) != 0) && ((((true & 4294967295) + 0) + 32) == null))
            {
                    ((true & 4294967295) + 0) + 32.System.IDisposable.Dispose();
                if((((true & 4294967295) + 0) + 32) == step)
            {
                    return (int)val_1;
            }
            
            }
            
            val_1 = val_1 + 1;
            if(this.dataList != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_2:
            val_1 = 0;
            return (int)val_1;
        }
        public void AnimateStepUps(System.Collections.Generic.List<int> enabledSteps, System.Action onComplete)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.AnimateStepUpsCoroutine(enabledSteps:  enabledSteps, onComplete:  onComplete));
        }
        private System.Collections.IEnumerator AnimateStepUpsCoroutine(System.Collections.Generic.List<int> enabledSteps, System.Action onComplete)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .enabledSteps = enabledSteps;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new RoyalPassScrollContent.<AnimateStepUpsCoroutine>d__30();
        }
        private System.Collections.IEnumerator PlayToggleStepAnimations(UnityEngine.Vector3 targetSeparatorScale, UnityEngine.Vector3 initialSeparatorScale, UnityEngine.Vector3 targetTopSeparatorPosition, UnityEngine.Vector3 initialSeparatorPosition, UnityEngine.Vector3 targetBottomSeparatorPosition, float targetHighlightAlpha, float initialHighlightAlpha, System.Collections.Generic.List<int> enabledSteps, System.Action onComplete)
        {
            var val_2;
            var val_3;
            var val_4;
            .<>1__state = 0;
            .<>4__this = this;
            .targetSeparatorScale = targetSeparatorScale;
            mem[1152921519272060188] = targetSeparatorScale.y;
            mem[1152921519272060192] = targetSeparatorScale.z;
            .initialSeparatorScale = initialSeparatorScale;
            mem[1152921519272060200] = initialSeparatorScale.y;
            mem[1152921519272060204] = initialSeparatorScale.z;
            .targetTopSeparatorPosition = targetTopSeparatorPosition;
            mem[1152921519272060212] = val_4;
            mem[1152921519272060216] = targetTopSeparatorPosition.y;
            .initialSeparatorPosition = targetTopSeparatorPosition.z;
            mem[1152921519272060224] = val_3;
            mem[1152921519272060228] = initialSeparatorPosition.x;
            .targetBottomSeparatorPosition = initialSeparatorPosition.y;
            mem[1152921519272060236] = val_2;
            mem[1152921519272060240] = initialSeparatorPosition.z;
            .targetHighlightAlpha = targetBottomSeparatorPosition.x;
            .initialHighlightAlpha = targetBottomSeparatorPosition.y;
            .enabledSteps = enabledSteps;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new RoyalPassScrollContent.<PlayToggleStepAnimations>d__31();
        }
        private void InitStepUpAnimation(int step)
        {
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_2 = 0;
            int val_1 = this.GetStepIndex(step:  step);
            if(val_1 == 1)
            {
                    return;
            }
            
            bool val_3 = this.pool.TryGetValue(key:  val_1, value: out  val_2);
            if(val_2 == 0)
            {
                    return;
            }
            
            val_2.InitStepUpAnimation();
        }
        private void FinishStepUpAnimation(int step)
        {
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_2 = 0;
            int val_1 = this.GetStepIndex(step:  step);
            if(val_1 == 1)
            {
                    return;
            }
            
            bool val_3 = this.pool.TryGetValue(key:  val_1, value: out  val_2);
            if(val_2 == 0)
            {
                    return;
            }
            
            val_2.FinishStepUpAnimation();
        }
        private float GetSeparatorPositionY(int step, float def)
        {
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_2 = 0;
            int val_1 = this.GetStepIndex(step:  step);
            if(val_1 == 1)
            {
                    return (float)def;
            }
            
            bool val_3 = this.pool.TryGetValue(key:  val_1, value: out  val_2);
            if(val_2 == 0)
            {
                    return (float)def;
            }
            
            def = val_2.GetSeparatorPositionY();
            return (float)def;
        }
        private bool UpdateRowProgressByTopSeparator(int step, float yPositionOfTopSeparator, bool isLastAnimatingStepWithTwoAnimations)
        {
            var val_8;
            int val_1 = this.GetStepIndex(step:  step);
            if(val_1 != 1)
            {
                    bool val_3 = this.pool.TryGetValue(key:  val_1, value: out  0);
                val_8 = 0 & 0;
                return (bool)val_8;
            }
            
            val_8 = 0;
            return (bool)val_8;
        }
        private void UpdateRowPatchAlphaByRatio(int step, float ratio)
        {
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_2 = 0;
            int val_1 = this.GetStepIndex(step:  step);
            if(val_1 == 1)
            {
                    return;
            }
            
            bool val_3 = this.pool.TryGetValue(key:  val_1, value: out  val_2);
            if(val_2 == 0)
            {
                    return;
            }
            
            val_2.UpdateRowPatchAlphaByRatio(ratio:  ratio);
        }
        private void PlayBankStepReachedAnimations()
        {
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_3 = 0;
            bool val_4 = this.pool.TryGetValue(key:  this.royalPassManager.GetSafeStepIndex() + 1, value: out  val_3);
            if(val_3 == 0)
            {
                    return;
            }
            
            val_3.PlayBankStepReachedAnimations();
        }
        public void AnimateSafeCoinIncrement(UnityEngine.Vector3 initialPosition)
        {
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_3 = 0;
            bool val_4 = this.pool.TryGetValue(key:  this.royalPassManager.GetSafeStepIndex() + 1, value: out  val_3);
            if(val_3 == 0)
            {
                    return;
            }
            
            val_3.AnimateSafeCoinIncrement(initialPosition:  new UnityEngine.Vector3() {x = initialPosition.x, y = initialPosition.y, z = initialPosition.z});
        }
        public void AnimateGoldUnlocks()
        {
            Dictionary.Enumerator<TKey, TValue> val_1 = this.pool.GetEnumerator();
            label_6:
            if((1781248200 & 1) == 0)
            {
                goto label_2;
            }
            
            if(0 == 0)
            {
                goto label_6;
            }
            
            0.AnimateGoldUnlocks();
            goto label_6;
            label_2:
            0.Dispose();
        }
        public void AnimateJustClaimed(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassClaimData justClaimedStep)
        {
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_2 = 0;
            int val_1 = this.GetStepIndex(step:  justClaimedStep.step);
            if(val_1 == 1)
            {
                    return;
            }
            
            bool val_3 = this.pool.TryGetValue(key:  val_1, value: out  val_2);
            if(val_2 == 0)
            {
                    return;
            }
            
            val_2.AnimateJustClaimed(isFree:  (justClaimedStep.step != 0) ? 1 : 0);
        }
        public void SetCurrentStepHighlightTransform()
        {
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem val_3 = 0;
            bool val_4 = this.pool.TryGetValue(key:  this.GetStepIndex(step:  this.royalPassManager.GetStep()), value: out  val_3);
            UnityEngine.GameObject val_6 = this.currentStep.gameObject;
            if(val_3 == 0)
            {
                    val_6.SetActive(value:  false);
                this.isCurrentStepHighlightSet = false;
                return;
            }
            
            val_6.SetActive(value:  true);
            this.isCurrentStepHighlightSet = true;
            this = this.currentStep.transform;
            UnityEngine.Vector3 val_9 = val_3.transform.position;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  0.09f);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            this.position = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        }
        public RoyalPassScrollContent()
        {
        
        }
    
    }

}
