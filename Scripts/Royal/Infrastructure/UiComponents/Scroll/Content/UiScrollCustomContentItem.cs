using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Scroll.Content
{
    public abstract class UiScrollCustomContentItem : UiScrollContentItem
    {
        // Fields
        public float size;
        public float spacing;
        private string <Id>k__BackingField;
        
        // Properties
        public string Id { get; set; }
        
        // Methods
        public string get_Id()
        {
            return (string)this.<Id>k__BackingField;
        }
        public void set_Id(string value)
        {
            this.<Id>k__BackingField = value;
        }
        protected UiScrollCustomContentItem()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
