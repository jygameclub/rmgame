using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections
{
    public class SectionBar : MonoBehaviour
    {
        // Fields
        private const float BottomOffset = 0.602541;
        public const float LargeButtonWidth = 3.1;
        public const float SmallButtonWidth = 1.55;
        private const float SmallOffset = 0.775;
        private const float LargeOffset = 1.55;
        public const float Height = 2.2;
        public const float ButtonsOffset = 1;
        public Royal.Scenes.Home.Ui.Sections.SectionManager sectionManager;
        public UnityEngine.SpriteRenderer background;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        public Royal.Scenes.Home.Ui.Sections.SectionElement[] lines;
        public Royal.Scenes.Home.Ui.Sections.SectionButton[] buttons;
        public Royal.Scenes.Home.Ui.Sections.SectionElement highlight;
        public UnityEngine.SpriteRenderer socialButtonImage;
        public Royal.Infrastructure.UiComponents.Button.UiButton socialButton;
        
        // Methods
        private void Awake()
        {
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.sectionManager.add_OnSectionChange(value:  new System.Action<Royal.Scenes.Home.Ui.Sections.Section>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.SectionBar::<Awake>b__15_0(Royal.Scenes.Home.Ui.Sections.Section section)));
            this.AttachToBottom();
            this.ArrangeButtons(index:  2, animate:  false);
        }
        private void AttachToBottom()
        {
            if(this.cameraManager.IsDeviceWide() != false)
            {
                    UnityEngine.Vector2 val_2 = this.background.size;
                UnityEngine.Vector2 val_3 = UnityEngine.Vector2.right;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, d:  4f);
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
                this.background.size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            }
            
            UnityEngine.Vector3 val_7 = this.GetTargetPosition();
            this.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        public UnityEngine.Vector3 GetTargetPosition()
        {
            UnityEngine.Vector3 val_1 = this.cameraManager.GetSafeBottomCenterOfCamera();
            val_1.y = val_1.y + 1.9f;
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = 0f};
        }
        private void Init()
        {
            this.ArrangeButtons(index:  2, animate:  false);
        }
        public void ButtonClick(int index)
        {
            var val_1;
            if(index >= 5)
            {
                    val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  4, log:  "Section out of section bar range", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                return;
            }
            
            this.ArrangeButtons(index:  index, animate:  true);
        }
        private void ArrangeButtons(int index, bool animate)
        {
            float val_29 = 0f;
            label_15:
            if(0 >= this.buttons.Length)
            {
                goto label_2;
            }
            
            var val_1 = (index == 0) ? 1 : 0;
            val_29 = val_29 + (36597856 + index == 0 ? 1 : 0);
            if(animate != true)
            {
                    UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_29, y:  0f);
                UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
                this.buttons[0].transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            }
            
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_29, y:  0f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            animate = animate;
            val_29 = (36597856 + index == 0 ? 1 : 0) + val_29;
            var val_8 = 0 + 1;
            this.buttons[0].Highlight(highlight:  (index == 0) ? 1 : 0, animate:  animate);
            if(this.buttons != null)
            {
                goto label_15;
            }
            
            label_2:
            var val_33 = 0;
            float val_32 = 0f;
            label_31:
            if(val_33 >= this.lines.Length)
            {
                goto label_18;
            }
            
            var val_9 = (index == val_33) ? 1 : 0;
            Royal.Scenes.Home.Ui.Sections.SectionElement val_31 = this.lines[val_33];
            val_32 = val_32 + (36597848 + index == 0 ? 1 : 0);
            if(animate != false)
            {
                    if(val_31 != null)
            {
                goto label_21;
            }
            
            }
            
            UnityEngine.Vector3 val_12 = val_31.transform.localPosition;
            UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_32, y:  val_12.y);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
            val_31.transform.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            label_21:
            UnityEngine.Vector3 val_16 = val_31.transform.localPosition;
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_32, y:  val_16.y);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            val_33 = val_33 + 1;
            if(this.lines != null)
            {
                goto label_31;
            }
            
            label_18:
            if(animate != true)
            {
                    Royal.Scenes.Home.Ui.Sections.SectionButton val_34 = this.buttons[index];
                UnityEngine.Vector3 val_21 = this.highlight.transform.localPosition;
                UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  val_32, y:  val_21.y);
                UnityEngine.Vector3 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
                this.highlight.transform.localPosition = new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z};
            }
            
            Royal.Scenes.Home.Ui.Sections.SectionButton val_35 = this.buttons[index];
            UnityEngine.Vector3 val_25 = this.highlight.transform.localPosition;
            UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  val_32, y:  val_25.y);
            UnityEngine.Vector3 val_27 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y});
        }
        public float TopYPositionOfBottomUi()
        {
            UnityEngine.Vector3 val_1 = this.GetTargetPosition();
            float val_2 = 0.602541f;
            val_2 = val_1.y + val_2;
            return (float)val_2;
        }
        public Royal.Scenes.Home.Ui.Sections.SectionButton GetButtonByIndex(int index)
        {
            return (Royal.Scenes.Home.Ui.Sections.SectionButton)this.buttons[index];
        }
        public SectionBar()
        {
        
        }
        private void <Awake>b__15_0(Royal.Scenes.Home.Ui.Sections.Section section)
        {
            if(section != null)
            {
                    this.ButtonClick(index:  section.sectionType + 2);
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
