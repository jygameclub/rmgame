using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area05.Tasks.Books
{
    public class BookGroup : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform[] books;
        public UnityEngine.Transform[] bookShadows;
        public UnityEngine.Transform[] startPositions;
        private UnityEngine.Vector3[] targetPositions;
        public float interval;
        public float scaleDuration;
        public float moveDuration;
        
        // Methods
        public void Appear()
        {
            var val_17;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            this.targetPositions = new UnityEngine.Vector3[0];
            val_17 = 0;
            var val_28 = 4;
            do
            {
                if((val_28 - 4) >= this.books.Length)
            {
                    return;
            }
            
                .<>4__this = this;
                this.books[0].gameObject.SetActive(value:  true);
                this.bookShadows[0].gameObject.SetActive(value:  true);
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
                this.books[0].transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
                this.bookShadows[0].transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
                UnityEngine.Vector3 val_12 = this.books[0].transform.position;
                this.targetPositions[val_17] = val_12;
                this.targetPositions[val_17] = val_12.y;
                this.targetPositions[val_17] = val_12.z;
                UnityEngine.Vector3 val_14 = this.startPositions[0].position;
                this.books[0].transform.position = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
                .book = this.books[0];
                .bookShadow = this.bookShadows[0];
                .startPos = this.startPositions[0];
                DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  new BookGroup.<>c__DisplayClass7_0(), method:  System.Void BookGroup.<>c__DisplayClass7_0::<Appear>b__0()));
                DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  this.interval);
                val_28 = val_28 + 1;
                val_17 = val_17 + 12;
            }
            while(this.books != null);
            
            throw new NullReferenceException();
        }
        public void Placement()
        {
            var val_5 = 0;
            do
            {
                if(val_5 >= this.books.Length)
            {
                    return;
            }
            
                .<>4__this = this;
                .book = this.books[val_5];
                val_5 = val_5 + 1;
                var val_3 = 0 + 12;
                .targetPos = this.targetPositions[0];
                mem[1152921519730751104] = this.targetPositions[0];
                DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  DG.Tweening.DOTween.Sequence(), callback:  new DG.Tweening.TweenCallback(object:  new BookGroup.<>c__DisplayClass8_0(), method:  System.Void BookGroup.<>c__DisplayClass8_0::<Placement>b__0()));
            }
            while(this.books != null);
            
            throw new NullReferenceException();
        }
        public float TotalDuration()
        {
            if(this.books != null)
            {
                    float val_1 = (float)this.books.Length;
                val_1 = this.interval * val_1;
                val_1 = this.moveDuration + val_1;
                return (float)val_1;
            }
            
            throw new NullReferenceException();
        }
        public BookGroup()
        {
            this.interval = 0.066f;
            this.scaleDuration = 0.2f;
            this.moveDuration = 0.2f;
        }
    
    }

}
