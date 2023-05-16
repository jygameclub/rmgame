using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections
{
    public class SectionButton : SectionElement
    {
        // Fields
        public float HighlightedScale;
        public UnityEngine.Vector2 HighlightedPosition;
        public float Overshoot;
        public float TextOvershoot;
        public Royal.Infrastructure.Utils.Animation.ManualEasingType TextEase;
        public float TextScale;
        public float IconDuration;
        public float TextDuration;
        public Royal.Infrastructure.Utils.Animation.ManualEasingType IconEasing;
        public UnityEngine.Transform icon;
        public TMPro.TextMeshPro text;
        public UnityEngine.BoxCollider2D boxCollider;
        private UnityEngine.Vector3 iconTargetScale;
        private UnityEngine.Vector3 iconStartScale;
        private UnityEngine.Vector3 textTargetScale;
        private UnityEngine.Vector3 textStartScale;
        private float iconProgress;
        private float textProgress;
        private bool highlighted;
        
        // Methods
        protected override void Awake()
        {
            mem[1152921518948406928] = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  32574);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.textTargetScale = val_2;
            mem[1152921518948407028] = val_2.y;
            mem[1152921518948407032] = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  this.TextScale);
            this.textStartScale = val_4;
            mem[1152921518948407040] = val_4.y;
            mem[1152921518948407044] = val_4.z;
        }
        protected override void Update()
        {
            this.Update();
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.iconProgress + val_1;
            float val_2 = UnityEngine.Mathf.Clamp(value:  val_1, min:  0f, max:  this.IconDuration);
            this.iconProgress = val_2;
            val_2 = val_2 / this.IconDuration;
            UnityEngine.Vector3 val_5 = Royal.Infrastructure.Utils.Math.VectorExtensions.Lerp(a:  new UnityEngine.Vector3() {x = this.iconStartScale, y = this.Overshoot, z = this.IconDuration}, b:  new UnityEngine.Vector3() {x = this.iconTargetScale}, t:  ManualEasing.Back.Out(t:  val_2, overshootAmplitude:  this.Overshoot), extrapolate:  true);
            this.icon.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            float val_6 = UnityEngine.Time.deltaTime;
            val_6 = this.textProgress + val_6;
            float val_7 = UnityEngine.Mathf.Clamp(value:  val_6, min:  0f, max:  this.TextDuration);
            this.textProgress = val_7;
            val_7 = val_7 / this.TextDuration;
            UnityEngine.Vector3 val_10 = Royal.Infrastructure.Utils.Math.VectorExtensions.Lerp(a:  new UnityEngine.Vector3() {x = this.textStartScale, y = this.TextOvershoot, z = this.TextDuration}, b:  new UnityEngine.Vector3() {x = this.textTargetScale}, t:  ManualEasing.Back.Out(t:  val_7, overshootAmplitude:  this.TextOvershoot), extrapolate:  true);
            this.text.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        public void Highlight(bool highlight, bool animate)
        {
            float val_15;
            UnityEngine.Vector2 val_18;
            float val_19;
            var val_20;
            if(highlight != false)
            {
                    val_15 = this.HighlightedScale;
            }
            else
            {
                    val_15 = 1f;
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(d:  val_15, a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            this.iconTargetScale = val_2;
            mem[1152921518948700636] = val_2.y;
            mem[1152921518948700640] = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            this.iconStartScale = val_3;
            mem[1152921518948700648] = val_3.y;
            mem[1152921518948700652] = val_3.z;
            if(highlight != false)
            {
                    val_18 = this.HighlightedPosition;
            }
            else
            {
                    UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
                val_18 = val_5.x;
                val_19 = val_5.y;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_18, y = val_19});
            this.icon.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            this.text.gameObject.SetActive(value:  highlight);
            if((this.highlighted == true) || (animate == false))
            {
                goto label_17;
            }
            
            this.iconProgress = 0f;
            this.textProgress = 0f;
            val_20 = this.text.transform;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  this.TextScale);
            if(val_20 != null)
            {
                goto label_21;
            }
            
            label_17:
            this.iconProgress = this.IconDuration;
            val_20 = this.text.transform;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
            label_21:
            val_20.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            this.highlighted = highlight;
        }
        public override void ChooseTarget(UnityEngine.Vector3 target)
        {
            this.ResetProgress();
            mem[1152921518948853488] = target.x;
            mem[1152921518948853492] = target.y;
            mem[1152921518948853496] = target.z;
            this.boxCollider.transform.localPosition = new UnityEngine.Vector3() {x = target.x, y = target.y, z = target.z};
        }
        private void Reset()
        {
            this.icon = this.GetComponentInChildren<UnityEngine.SpriteRenderer>(includeInactive:  true).transform.parent;
            this.text = this.GetComponentInChildren<TMPro.TextMeshPro>(includeInactive:  true);
            this.boxCollider = this.transform.parent.GetComponentInChildren<UnityEngine.BoxCollider2D>(includeInactive:  true);
        }
        public SectionButton()
        {
            this.HighlightedScale = 1.2f;
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  0f, y:  0.52f);
            this.TextEase = 27;
            this.TextDuration = 0.2f;
            this.IconEasing = 27;
            this.HighlightedPosition = val_1.x;
            this.Overshoot = 3f;
            this.TextOvershoot = 2f;
            this.TextScale = 0.7f;
            this.IconDuration = 0.2f;
            mem[1152921518949146088] = 1061997773;
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
