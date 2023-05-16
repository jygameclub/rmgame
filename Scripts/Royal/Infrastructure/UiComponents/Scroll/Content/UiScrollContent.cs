using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Scroll.Content
{
    public class UiScrollContent : MonoBehaviour
    {
        // Fields
        private System.Action OnContentChanged;
        public float startOffset;
        public float rowSize;
        public float spacing;
        public float endOffset;
        protected Royal.Infrastructure.UiComponents.Scroll.Direction direction;
        protected UnityEngine.Bounds maskBounds;
        private float size;
        
        // Properties
        public float Size { get; set; }
        
        // Methods
        public void add_OnContentChanged(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnContentChanged, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnContentChanged != 1152921527520700008);
            
            return;
            label_2:
        }
        public void remove_OnContentChanged(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnContentChanged, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnContentChanged != 1152921527520836584);
            
            return;
            label_2:
        }
        public float get_Size()
        {
            return (float)this.size;
        }
        protected void set_Size(float value)
        {
            this.size = value;
            if(this.OnContentChanged == null)
            {
                    return;
            }
            
            this.OnContentChanged.Invoke();
        }
        public void Init(Royal.Infrastructure.UiComponents.Scroll.Direction direct, UnityEngine.Bounds bounds)
        {
            this.direction = direct;
            mem[1152921527521201268] = bounds.m_Extents.y;
            this.maskBounds = bounds.m_Center.x;
        }
        public virtual void Clear()
        {
            var val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  4, log:  "This is a fixed size content.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public virtual void AddData(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data)
        {
            var val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  4, log:  "This is a fixed size content.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public virtual void OnContentMoved(float newLocation)
        {
        
        }
        public UiScrollContent()
        {
        
        }
    
    }

}
