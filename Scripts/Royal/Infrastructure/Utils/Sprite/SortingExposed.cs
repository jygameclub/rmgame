using UnityEngine;

namespace Royal.Infrastructure.Utils.Sprite
{
    public class SortingExposed : MonoBehaviour
    {
        // Fields
        private string <SortingLayerName>k__BackingField;
        private int <SortingOrder>k__BackingField;
        private UnityEngine.Renderer myRenderer;
        
        // Properties
        public string SortingLayerName { get; set; }
        public int SortingOrder { get; set; }
        
        // Methods
        public string get_SortingLayerName()
        {
            return (string)this.<SortingLayerName>k__BackingField;
        }
        private void set_SortingLayerName(string value)
        {
            this.<SortingLayerName>k__BackingField = value;
        }
        public int get_SortingOrder()
        {
            return (int)this.<SortingOrder>k__BackingField;
        }
        private void set_SortingOrder(int value)
        {
            this.<SortingOrder>k__BackingField = value;
        }
        private void Awake()
        {
            UnityEngine.Renderer val_1 = this.GetComponent<UnityEngine.Renderer>();
            this.myRenderer = val_1;
            this.<SortingLayerName>k__BackingField = val_1.sortingLayerName;
            this.<SortingOrder>k__BackingField = this.myRenderer.sortingOrder;
        }
        public void UpdateSorting(string sortingLayer, int sortingOrder)
        {
            this.<SortingLayerName>k__BackingField = sortingLayer;
            this.<SortingOrder>k__BackingField = sortingOrder;
            this.myRenderer.sortingLayerName = sortingLayer;
            this.myRenderer.sortingOrder = this.<SortingOrder>k__BackingField;
        }
        public SortingExposed()
        {
        
        }
    
    }

}
