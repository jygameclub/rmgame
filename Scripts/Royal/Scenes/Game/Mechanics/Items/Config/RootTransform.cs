using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.Config
{
    public class RootTransform : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform root;
        private UnityEngine.Transform view;
        private Royal.Scenes.Game.Mechanics.Fall.FallSquash fallSquash;
        private Royal.Scenes.Game.Mechanics.Items.Config.ItemView itemView;
        private bool hasFallSquash;
        private bool <IsHidden>k__BackingField;
        private int waitFrame;
        private bool isInImpact;
        private float impactSpeed;
        private float impactStartSpeed;
        private float impactFinishSpeed;
        private float impactTotalDistance;
        private UnityEngine.Vector3 impactStartPosition;
        private UnityEngine.Vector3 impactTargetPosition;
        
        // Properties
        public bool IsHidden { get; set; }
        
        // Methods
        public bool get_IsHidden()
        {
            return (bool)this.<IsHidden>k__BackingField;
        }
        private void set_IsHidden(bool value)
        {
            this.<IsHidden>k__BackingField = value;
        }
        private void Awake()
        {
            this.hasFallSquash = UnityEngine.Object.op_Inequality(x:  this.fallSquash, y:  0);
        }
        private void Update()
        {
            float val_18;
            float val_19;
            if(this.isInImpact == false)
            {
                    return;
            }
            
            int val_18 = this.waitFrame;
            val_18 = val_18 - 1;
            if()
            {
                    this.waitFrame = val_18;
                return;
            }
            
            UnityEngine.Vector3 val_1 = this.root.localPosition;
            val_18 = val_1.x;
            val_19 = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_18, y = val_1.y, z = val_19}, b:  new UnityEngine.Vector3() {x = this.impactTargetPosition, y = V12.16B, z = V11.16B});
            float val_4 = UnityEngine.Mathf.Lerp(a:  this.impactFinishSpeed, b:  this.impactStartSpeed, t:  val_2.x / this.impactTotalDistance);
            this.impactSpeed = val_4;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = val_18, y = val_1.y, z = val_19}, target:  new UnityEngine.Vector3() {x = this.impactTargetPosition, y = this.impactFinishSpeed, z = val_2.x}, maxDistanceDelta:  val_4 * UnityEngine.Time.deltaTime);
            this.root.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            UnityEngine.Vector3 val_8 = this.root.localPosition;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(v1:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, v2:  new UnityEngine.Vector3() {x = this.impactTargetPosition, y = this.impactFinishSpeed, z = val_2.x})) == false)
            {
                    return;
            }
            
            val_19 = this.impactTargetPosition;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_19, y = val_18, z = val_1.y}, rhs:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z})) != false)
            {
                    this.isInImpact = false;
                UnityEngine.Vector3 val_13 = this.itemView.transform.localPosition;
                val_18 = val_13.y;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_15 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  (int)val_18, isReverseSort:  this.itemView & 1);
                this.itemView = 1;
                bool val_16 = val_15.sortEverything & 4294967295;
                this.itemView = 1;
                this.Reset(force:  false);
            }
            
            this.waitFrame = 3;
            this.impactStartSpeed = this.impactFinishSpeed;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
            this.impactTargetPosition = val_17;
            mem[1152921523802195380] = val_17.y;
            mem[1152921523802195384] = val_17.z;
        }
        public void Impact(float xDiff, float yDiff, float firstSpeed, float lastSpeed)
        {
            float val_5;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemView val_6;
            val_5 = xDiff;
            val_6 = this;
            if(this.isInImpact == true)
            {
                    return;
            }
            
            this.isInImpact = true;
            this.waitFrame = 0;
            this.impactStartSpeed = firstSpeed;
            this.impactFinishSpeed = lastSpeed;
            UnityEngine.Vector3 val_1 = this.root.localPosition;
            this.impactStartPosition = val_1;
            mem[1152921523802340136] = val_1.y;
            val_1.x = val_1.x + val_5;
            val_1.y = val_1.y + yDiff;
            mem[1152921523802340140] = val_1.z;
            val_5 = 0f;
            this.impactTargetPosition = val_5;
            mem[1152921523802340148] = 0f;
            mem[1152921523802340152] = 0f;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.impactStartPosition, y = V12.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = val_5, y = 0f, z = 0f});
            this.impactTotalDistance = val_2.x;
            val_6 = this.itemView;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetImpactSorting(diff:  (int)firstSpeed);
            val_6 = 1;
            bool val_4 = val_3.sortEverything & 4294967295;
            val_6 = 0;
        }
        public void Init(Royal.Scenes.Game.Mechanics.Items.Config.ItemView item)
        {
            this.itemView = item;
            this.Reset(force:  true);
        }
        public void Reset(bool force = False)
        {
            if((force != true) && (this.isInImpact != false))
            {
                    return;
            }
            
            this.isInImpact = false;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.root.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.root.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            this.root.localRotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
        }
        public UnityEngine.Vector3 GetPosition()
        {
            if(this.root != null)
            {
                    return this.root.localPosition;
            }
            
            throw new NullReferenceException();
        }
        public void SetPosition(UnityEngine.Vector3 vector)
        {
            if(this.root != null)
            {
                    this.root.localPosition = new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z};
                return;
            }
            
            throw new NullReferenceException();
        }
        public UnityEngine.Vector3 GetScale()
        {
            if(this.root != null)
            {
                    return this.root.localScale;
            }
            
            throw new NullReferenceException();
        }
        public void SetScale(UnityEngine.Vector3 vector)
        {
            if(this.root != null)
            {
                    this.root.localScale = new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z};
                return;
            }
            
            throw new NullReferenceException();
        }
        public UnityEngine.Quaternion GetRotation()
        {
            if(this.root != null)
            {
                    return this.root.localRotation;
            }
            
            throw new NullReferenceException();
        }
        public void SetRotation(UnityEngine.Quaternion quaternion)
        {
            if(this.root != null)
            {
                    this.root.localRotation = new UnityEngine.Quaternion() {x = quaternion.x, y = quaternion.y, z = quaternion.z, w = quaternion.w};
                return;
            }
            
            throw new NullReferenceException();
        }
        public void AddChild(UnityEngine.Transform child)
        {
            if(child != null)
            {
                    child.SetParent(parent:  this.root, worldPositionStays:  false);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void HideView()
        {
            this.<IsHidden>k__BackingField = true;
            this.view.gameObject.SetActive(value:  false);
        }
        public void ShowView()
        {
            this.<IsHidden>k__BackingField = false;
            this.view.gameObject.SetActive(value:  true);
        }
        public void UpdateFallState(Royal.Scenes.Game.Mechanics.Fall.FallState newState, float currentSpeed, float maxSpeed)
        {
            if(this.hasFallSquash == false)
            {
                    return;
            }
            
            if(this.fallSquash != null)
            {
                    this.fallSquash.UpdateState(newState:  newState, currentSpeed:  currentSpeed, maxSpeed:  maxSpeed);
                return;
            }
            
            throw new NullReferenceException();
        }
        public RootTransform()
        {
        
        }
    
    }

}
