using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area05.Tasks.ChessTable
{
    public class Area05ChessTableView : AreaTaskView
    {
        // Fields
        public UnityEngine.Transform table;
        public UnityEngine.SpriteRenderer tableShadow;
        public UnityEngine.SpriteRenderer chairShadow;
        public UnityEngine.Transform board;
        public UnityEngine.Transform[] pieces;
        public UnityEngine.Transform[] chairs;
        
        // Methods
        public override void PrepareAnimation()
        {
            this.PrepareAnimation();
            this.board.gameObject.SetActive(value:  false);
            this.table.gameObject.SetActive(value:  false);
            this.tableShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.chairShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            var val_6 = 0;
            label_13:
            if(val_6 >= this.pieces.Length)
            {
                goto label_8;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.pieces[val_6].localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            val_6 = val_6 + 1;
            if(this.pieces != null)
            {
                goto label_13;
            }
            
            label_8:
            var val_8 = 0;
            do
            {
                if(val_8 >= this.chairs.Length)
            {
                    return;
            }
            
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
                this.chairs[val_8].localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
                val_8 = val_8 + 1;
            }
            while(this.chairs != null);
            
            throw new NullReferenceException();
        }
        public override DG.Tweening.Sequence PlayAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            this.AnimateTable(seq:  val_1);
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.3f);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.3f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaTaskView::PlayDefaultAnimationSound()));
            this.AnimateBoard(seq:  val_1);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            var val_9 = 0;
            label_6:
            if(val_9 >= (this.pieces.Length << ))
            {
                goto label_4;
            }
            
            Royal.Scenes.Home.Areas.Area05.Tasks.ChessTable.Area05ChessTableView.AnimatePiece(seq:  val_1, piece:  this.pieces[val_9]);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.1f);
            val_9 = val_9 + 1;
            if(this.pieces != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_4:
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.2f);
            this.AnimateChairs(seq:  val_1);
            return val_1;
        }
        private void AnimateTable(DG.Tweening.Sequence seq)
        {
            UnityEngine.Transform val_1 = this.table.transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.table.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.5f);
            val_1.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.table.gameObject.SetActive(value:  true);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  seq, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.table.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.1f));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Join(s:  seq, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.tableShadow, endValue:  1f, duration:  0.15f), delay:  0.2f));
            DG.Tweening.Sequence val_15 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_15, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.table.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.15f, snapping:  false), ease:  1));
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_15, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.table.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.05f, snapping:  false), ease:  1));
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_15, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.table.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.05f, snapping:  false), ease:  1));
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Insert(s:  seq, atPosition:  0.1f, t:  val_15);
        }
        private void AnimateBoard(DG.Tweening.Sequence seq)
        {
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  seq, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area05.Tasks.ChessTable.Area05ChessTableView::<AnimateBoard>b__9_0()));
        }
        private static void AnimatePiece(DG.Tweening.Sequence seq, UnityEngine.Transform piece)
        {
            .piece = piece;
            UnityEngine.Vector3 val_2 = piece.localPosition;
            .initialPosition = val_2;
            mem[1152921519724818428] = val_2.y;
            mem[1152921519724818432] = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.3f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            (Area05ChessTableView.<>c__DisplayClass10_0)[1152921519724818400].piece.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  seq, callback:  new DG.Tweening.TweenCallback(object:  new Area05ChessTableView.<>c__DisplayClass10_0(), method:  System.Void Area05ChessTableView.<>c__DisplayClass10_0::<AnimatePiece>b__0()));
        }
        private void AnimateChairs(DG.Tweening.Sequence seq)
        {
            UnityEngine.Transform val_20 = this.chairs[0];
            UnityEngine.Transform val_21 = this.chairs[1];
            UnityEngine.Vector3 val_1 = val_20.localPosition;
            UnityEngine.Vector3 val_2 = val_21.localPosition;
            val_20.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_21.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  seq, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_20, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.2f), ease:  27, overshoot:  1f));
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Join(s:  seq, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_21, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.2f), ease:  27, overshoot:  1f));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  seq, interval:  0.1f);
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  seq, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_20, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.25f, snapping:  false), ease:  4));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Join(s:  seq, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.chairShadow, endValue:  1f, duration:  0.25f));
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Join(s:  seq, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_21, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.25f, snapping:  false), ease:  4));
        }
        public Area05ChessTableView()
        {
        
        }
        private void <AnimateBoard>b__9_0()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.board.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            this.board.gameObject.SetActive(value:  true);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.board, endValue:  1f, duration:  0.15f), ease:  27);
        }
    
    }

}
