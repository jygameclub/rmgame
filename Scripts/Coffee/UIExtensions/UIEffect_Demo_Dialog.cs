using UnityEngine;

namespace Coffee.UIExtensions
{
    public class UIEffect_Demo_Dialog : MonoBehaviour
    {
        // Fields
        private UnityEngine.Animator m_Animator;
        
        // Methods
        public void Open()
        {
            this.gameObject.SetActive(value:  true);
        }
        public void Close()
        {
            this.m_Animator.SetTrigger(name:  "Close");
        }
        public void Closed()
        {
            this.gameObject.SetActive(value:  false);
        }
        public UIEffect_Demo_Dialog()
        {
        
        }
    
    }

}
