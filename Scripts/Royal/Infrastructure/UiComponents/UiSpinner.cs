using UnityEngine;

namespace Royal.Infrastructure.UiComponents
{
    public class UiSpinner : MonoBehaviour
    {
        // Fields
        private const float Degree = -60;
        private const float Time = 0.07;
        private int counter;
        private bool started;
        private UnityEngine.WaitForSeconds waitForSeconds;
        
        // Methods
        private void Start()
        {
            this.started = true;
            this.waitForSeconds = new UnityEngine.WaitForSeconds(seconds:  0.07f);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.Rotate());
        }
        private void OnEnable()
        {
            if(this.started == false)
            {
                    return;
            }
            
            this.StopAllCoroutines();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.Rotate());
        }
        private void OnDisable()
        {
            this.StopAllCoroutines();
        }
        private System.Collections.IEnumerator Rotate()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new UiSpinner.<Rotate>d__8();
        }
        public void Show()
        {
            int val_4 = this.counter;
            val_4 = val_4 + 1;
            this.counter = val_4;
            if()
            {
                    return;
            }
            
            if(this.gameObject.activeSelf != false)
            {
                    return;
            }
            
            this.gameObject.SetActive(value:  true);
        }
        public void Hide()
        {
            int val_2 = this.counter;
            val_2 = val_2 - 1;
            this.counter = val_2;
            if(val_2 > 0)
            {
                    return;
            }
            
            this.counter = 0;
            this.gameObject.SetActive(value:  false);
        }
        public bool IsActive()
        {
            return this.gameObject.activeSelf;
        }
        public UiSpinner()
        {
        
        }
    
    }

}
