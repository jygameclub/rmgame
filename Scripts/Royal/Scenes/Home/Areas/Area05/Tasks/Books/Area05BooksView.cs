using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area05.Tasks.Books
{
    public class Area05BooksView : AreaTaskView
    {
        // Fields
        public UnityEngine.SpriteRenderer[] bookShadows;
        public Royal.Scenes.Home.Areas.Area05.Tasks.Books.BookGroup[] bookGroups;
        public UnityEngine.Animator stairsAnimator;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.DisableBooks();
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area05.Tasks.Books.Area05BooksView::BookAppear()));
            Royal.Scenes.Home.Areas.Area05.Tasks.Books.BookGroup val_9 = this.bookGroups[0];
            float val_10 = (float)this.bookGroups[0].books.Length;
            val_10 = this.bookGroups[0].interval * val_10;
            val_10 = this.bookGroups[0].moveDuration + val_10;
            val_10 = val_10 * 5f;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  val_10);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.4f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area05.Tasks.Books.Area05BooksView::PlayStairs()));
            return val_1;
        }
        public override void EndAnimation()
        {
            this.EndAnimation();
            this.stairsAnimator.enabled = false;
        }
        private void BookAppear()
        {
            Royal.Scenes.Home.Areas.Area05.Tasks.Books.BookGroup val_12;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            var val_14 = 0;
            label_10:
            if(val_14 >= (this.bookGroups.Length << ))
            {
                goto label_4;
            }
            
            .bookGroup = this.bookGroups[val_14];
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  new Area05BooksView.<>c__DisplayClass6_0(), method:  System.Void Area05BooksView.<>c__DisplayClass6_0::<BookAppear>b__0()));
            float val_13 = (float)(Area05BooksView.<>c__DisplayClass6_0)[1152921519727113312].bookGroup.books.Length;
            val_13 = ((Area05BooksView.<>c__DisplayClass6_0)[1152921519727113312].bookGroup.interval) * val_13;
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  val_13);
            val_14 = val_14 + 1;
            if(this.bookGroups != null)
            {
                goto label_10;
            }
            
            label_4:
            val_12 = this.bookGroups[0];
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            float val_15 = this.bookGroups[0].interval;
            val_15 = val_15 * 5f;
            val_15 = val_15 * (float)this.bookGroups[0].books.Length;
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_6, interval:  val_15);
            var val_17 = 0;
            do
            {
                if(val_17 >= this.bookGroups.Length)
            {
                    return;
            }
            
                Area05BooksView.<>c__DisplayClass6_1 val_8 = null;
                val_12 = val_8;
                val_8 = new Area05BooksView.<>c__DisplayClass6_1();
                .bookGroup = this.bookGroups[val_17];
                DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_6, callback:  new DG.Tweening.TweenCallback(object:  val_8, method:  System.Void Area05BooksView.<>c__DisplayClass6_1::<BookAppear>b__2()));
                DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_6, interval:  (Area05BooksView.<>c__DisplayClass6_1)[1152921519727334496].bookGroup.moveDuration);
                val_17 = val_17 + 1;
            }
            while(this.bookGroups != null);
            
            throw new NullReferenceException();
        }
        private void PlayStairs()
        {
            this.stairsAnimator.gameObject.SetActive(value:  true);
            this.stairsAnimator.enabled = true;
            this.stairsAnimator.Play(stateNameHash:  0, layer:  0, normalizedTime:  0f);
        }
        private void DisableBooks()
        {
            var val_4 = 0;
            label_5:
            if(val_4 >= this.bookShadows.Length)
            {
                goto label_1;
            }
            
            this.bookShadows[val_4].gameObject.SetActive(value:  false);
            val_4 = val_4 + 1;
            if(this.bookShadows != null)
            {
                goto label_5;
            }
            
            label_1:
            UnityEngine.GameObject val_2 = this.stairsAnimator.gameObject;
            val_2.SetActive(value:  false);
            var val_6 = 0;
            do
            {
                if(val_6 >= (this.bookGroups.Length << ))
            {
                    return;
            }
            
                val_2.DisableBookGroup(group:  this.bookGroups[val_6]);
                val_6 = val_6 + 1;
            }
            while(this.bookGroups != null);
            
            throw new NullReferenceException();
        }
        private void DisableBookGroup(Royal.Scenes.Home.Areas.Area05.Tasks.Books.BookGroup group)
        {
            if(group.books.Length < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                group.books[val_3].gameObject.SetActive(value:  false);
                val_3 = val_3 + 1;
            }
            while(val_3 < group.books.Length);
        
        }
        public Area05BooksView()
        {
        
        }
    
    }

}
