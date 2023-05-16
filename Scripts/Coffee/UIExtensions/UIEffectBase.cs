using UnityEngine;

namespace Coffee.UIExtensions
{
    public abstract class UIEffectBase : BaseMeshEffect, IParameterTexture
    {
        // Fields
        protected static readonly UnityEngine.Vector2[] splitedCharacterPosition;
        protected static readonly System.Collections.Generic.List<UnityEngine.UIVertex> tempVerts;
        private int m_Version;
        protected UnityEngine.Material m_EffectMaterial;
        private int <parameterIndex>k__BackingField;
        
        // Properties
        public int parameterIndex { get; set; }
        public virtual Coffee.UIExtensions.ParameterTexture ptex { get; }
        public UnityEngine.UI.Graphic targetGraphic { get; }
        public UnityEngine.Material effectMaterial { get; }
        
        // Methods
        public int get_parameterIndex()
        {
            return (int)this.<parameterIndex>k__BackingField;
        }
        public void set_parameterIndex(int value)
        {
            this.<parameterIndex>k__BackingField = value;
        }
        public virtual Coffee.UIExtensions.ParameterTexture get_ptex()
        {
            return 0;
        }
        public UnityEngine.UI.Graphic get_targetGraphic()
        {
            this.Initialize();
            return (UnityEngine.UI.Graphic)this;
        }
        public UnityEngine.Material get_effectMaterial()
        {
            return (UnityEngine.Material)this.m_EffectMaterial;
        }
        public virtual void ModifyMaterial()
        {
            this.Initialize();
            if(this.isActiveAndEnabled != false)
            {
                
            }
        
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            if(this != null)
            {
                    this.Register(target:  this);
            }
            
            this.SetVerticesDirty();
            goto typeof(Coffee.UIExtensions.UIEffectBase).__il2cppRuntimeField_350;
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            this.SetVerticesDirty();
            if(this == null)
            {
                    return;
            }
            
            this.Unregister(target:  this);
        }
        protected virtual void SetDirty()
        {
            this.SetVerticesDirty();
        }
        protected override void OnDidApplyAnimationProperties()
        {
            goto typeof(Coffee.UIExtensions.UIEffectBase).__il2cppRuntimeField_350;
        }
        protected UIEffectBase()
        {
        
        }
        private static UIEffectBase()
        {
            UnityEngine.Vector2[] val_1 = new UnityEngine.Vector2[4];
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.up;
            val_1[0] = val_2;
            val_1[0] = val_2.y;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.one;
            val_1[1] = val_3;
            val_1[1] = val_3.y;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.right;
            val_1[2] = val_4;
            val_1[2] = val_4.y;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            val_1[3] = val_5;
            val_1[3] = val_5.y;
            Coffee.UIExtensions.UIEffectBase.splitedCharacterPosition = val_1;
            Coffee.UIExtensions.UIEffectBase.tempVerts = new System.Collections.Generic.List<UnityEngine.UIVertex>();
        }
    
    }

}
