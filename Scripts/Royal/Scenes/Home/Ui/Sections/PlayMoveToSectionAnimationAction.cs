using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections
{
    public class PlayMoveToSectionAnimationAction : AnimationAction
    {
        // Fields
        private readonly Royal.Scenes.Home.Ui.Sections.SectionType moveToSection;
        private readonly int <Type>k__BackingField;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return (int)this.<Type>k__BackingField;
        }
        public PlayMoveToSectionAnimationAction(Royal.Scenes.Home.Ui.Sections.SectionType sectionType, int type = 2)
        {
            this.moveToSection = sectionType;
            this.<Type>k__BackingField = type;
        }
        protected override float GetDurationForNextAction()
        {
            return 0.5f;
        }
        public override void Execute()
        {
            var val_1;
            this.Execute();
            val_1 = null;
            val_1 = null;
            Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField.ChangeSection(section:  this.moveToSection);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
