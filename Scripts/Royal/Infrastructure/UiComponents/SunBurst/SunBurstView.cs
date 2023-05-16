using UnityEngine;

namespace Royal.Infrastructure.UiComponents.SunBurst
{
    public class SunBurstView : MonoBehaviour
    {
        // Fields
        public string meshName;
        public int count;
        public UnityEngine.Color innerColor;
        public UnityEngine.Color middleColor;
        public UnityEngine.Color outerColor;
        public float length;
        public float middlePosition;
        public float rayAngle;
        public UnityEngine.Transform rayContainer;
        public UnityEngine.SpriteRenderer readMask;
        public UnityEngine.SpriteRenderer writeMask;
        public UnityEngine.Rendering.SortingGroup sortingGroup;
        public UnityEngine.Material sunMaterial;
        
        // Methods
        public SunBurstView()
        {
            this.count = 12;
            this.innerColor = 0;
            this.middleColor = 0;
            this.outerColor = 0;
            this.length = 4f;
            this.middlePosition = 0.5f;
            this.rayAngle = 15f;
        }
    
    }

}
