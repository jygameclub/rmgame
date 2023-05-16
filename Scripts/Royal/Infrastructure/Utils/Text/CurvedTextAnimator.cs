using UnityEngine;

namespace Royal.Infrastructure.Utils.Text
{
    public class CurvedTextAnimator : MonoBehaviour
    {
        // Fields
        public Royal.Infrastructure.Utils.Text.CurvedSingleText[] texts;
        private int frameDelay;
        
        // Methods
        public void Start()
        {
            this.Init(frameDelayBetweenChars:  2);
        }
        public void Init(int frameDelayBetweenChars = 2)
        {
            this.frameDelay = frameDelayBetweenChars;
            if(this.texts.Length < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                this.texts[val_2].Init();
                val_2 = val_2 + 1;
            }
            while(val_2 < this.texts.Length);
        
        }
        public void EnableUpdateForCurvedTexts()
        {
            if(this.texts.Length < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                this.texts[val_2] = 1;
                val_2 = val_2 + 1;
            }
            while(val_2 < this.texts.Length);
        
        }
        public void StartAnimation(bool isReversed = False)
        {
            int val_4 = this.texts.Length;
            if(val_4 < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            val_4 = val_4 & 4294967295;
            do
            {
                UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.AnimateText(textMesh:  null, isReversed:  isReversed));
                val_5 = val_5 + 1;
            }
            while(val_5 < (this.texts.Length << ));
        
        }
        private System.Collections.IEnumerator AnimateText(Royal.Infrastructure.Utils.Text.CurvedSingleText textMesh, bool isReversed)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .textMesh = textMesh;
            .isReversed = isReversed;
            return (System.Collections.IEnumerator)new CurvedTextAnimator.<AnimateText>d__6();
        }
        private System.Collections.IEnumerator AnimateCharacter(Royal.Infrastructure.Utils.Text.CurvedSingleText textMesh, int index)
        {
            .<>1__state = 0;
            .textMesh = textMesh;
            .index = index;
            return (System.Collections.IEnumerator)new CurvedTextAnimator.<AnimateCharacter>d__7();
        }
        public CurvedTextAnimator()
        {
            this.frameDelay = 2;
        }
    
    }

}
