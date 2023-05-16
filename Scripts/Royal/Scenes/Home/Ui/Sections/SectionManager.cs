using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections
{
    public class SectionManager : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Home.Ui.Sections.Section[] sections;
        private System.Action<Royal.Scenes.Home.Ui.Sections.Section> OnSectionChange;
        private Royal.Scenes.Home.Ui.Sections.Section currentSection;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private float cameraWidth;
        
        // Properties
        private Royal.Scenes.Home.Ui.Sections.Section EpisodesSection { get; }
        private Royal.Scenes.Home.Ui.Sections.Section LeaderboardSection { get; }
        private Royal.Scenes.Home.Ui.Sections.Section HomeSection { get; }
        private Royal.Scenes.Home.Ui.Sections.Section SocialSection { get; }
        private Royal.Scenes.Home.Ui.Sections.Section SettingsSection { get; }
        
        // Methods
        private Royal.Scenes.Home.Ui.Sections.Section get_EpisodesSection()
        {
            return (Royal.Scenes.Home.Ui.Sections.Section)this.sections[0];
        }
        private Royal.Scenes.Home.Ui.Sections.Section get_LeaderboardSection()
        {
            return (Royal.Scenes.Home.Ui.Sections.Section)this.sections[1];
        }
        private Royal.Scenes.Home.Ui.Sections.Section get_HomeSection()
        {
            return (Royal.Scenes.Home.Ui.Sections.Section)this.sections[2];
        }
        private Royal.Scenes.Home.Ui.Sections.Section get_SocialSection()
        {
            return (Royal.Scenes.Home.Ui.Sections.Section)this.sections[3];
        }
        private Royal.Scenes.Home.Ui.Sections.Section get_SettingsSection()
        {
            return (Royal.Scenes.Home.Ui.Sections.Section)this.sections[4];
        }
        public void add_OnSectionChange(System.Action<Royal.Scenes.Home.Ui.Sections.Section> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnSectionChange, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnSectionChange != 1152921518951545712);
            
            return;
            label_2:
        }
        public void remove_OnSectionChange(System.Action<Royal.Scenes.Home.Ui.Sections.Section> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnSectionChange, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnSectionChange != 1152921518951682288);
            
            return;
            label_2:
        }
        private void Start()
        {
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.InitSections();
        }
        private void InitSections()
        {
            this.cameraWidth = this.cameraManager.cameraWidth;
            this.EpisodesSection.Init(cameraWidth:  this.cameraWidth, type:  -2);
            this.LeaderboardSection.Init(cameraWidth:  this.cameraWidth, type:  0);
            this.HomeSection.Init(cameraWidth:  this.cameraWidth, type:  0);
            this.SocialSection.Init(cameraWidth:  this.cameraWidth, type:  1);
            this.SettingsSection.Init(cameraWidth:  this.cameraWidth, type:  2);
            this.ChangeSection(section:  this.HomeSection);
        }
        public void ButtonClick(Royal.Scenes.Home.Ui.Sections.Section section)
        {
            this.ChangeSection(section:  section);
        }
        public void ChangeSection(Royal.Scenes.Home.Ui.Sections.SectionType type)
        {
            this.ChangeSection(section:  this.GetSectionFromType(type:  type));
        }
        private void ChangeSection(Royal.Scenes.Home.Ui.Sections.Section section)
        {
            if(this.currentSection != 0)
            {
                goto label_3;
            }
            
            this.currentSection = section;
            if(section != null)
            {
                goto label_4;
            }
            
            label_3:
            if(this.currentSection.sectionType == section.sectionType)
            {
                    return;
            }
            
            this.currentSection = section;
            label_4:
            if(this.OnSectionChange == null)
            {
                    return;
            }
            
            this.OnSectionChange.Invoke(obj:  section);
        }
        public bool AtSection(Royal.Scenes.Home.Ui.Sections.SectionType type)
        {
            if(this.currentSection != null)
            {
                    return (bool)(this.currentSection.sectionType == type) ? 1 : 0;
            }
            
            throw new NullReferenceException();
        }
        public UnityEngine.Vector3 LeftMostSectionPosition()
        {
            return this.EpisodesSection.transform.position;
        }
        public UnityEngine.Vector3 RightMostSectionPosition()
        {
            return this.SettingsSection.transform.position;
        }
        public void FocusToNearestSection()
        {
            Royal.Scenes.Home.Ui.Sections.Section val_6;
            var val_7;
            UnityEngine.Vector3 val_1 = this.cameraManager.GetPosition();
            val_6 = 0;
            val_7 = 4;
            label_12:
            if((val_7 - 4) >= this.sections.Length)
            {
                goto label_3;
            }
            
            UnityEngine.Vector3 val_4 = this.sections[0].transform.position;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) < 0)
            {
                    val_6 = this.sections[0];
            }
            
            val_7 = val_7 + 1;
            if(this.sections != null)
            {
                goto label_12;
            }
            
            throw new NullReferenceException();
            label_3:
            if(val_6 == 0)
            {
                    return;
            }
            
            this.ChangeSection(section:  val_6);
        }
        public void FocusToLeftSection()
        {
            Royal.Scenes.Home.Ui.Sections.SectionType val_1 = this.currentSection.sectionType;
            val_1 = val_1 + 1;
            if(<0)
            {
                    return;
            }
            
            this.ChangeSection(section:  this.sections[val_1]);
        }
        public void FocusToRightSection()
        {
            Royal.Scenes.Home.Ui.Sections.SectionType val_1 = this.currentSection.sectionType;
            val_1 = val_1 + 3;
            if(val_1 >= this.sections.Length)
            {
                    return;
            }
            
            this.ChangeSection(section:  this.sections[val_1]);
        }
        public Royal.Scenes.Home.Ui.Sections.Section GetSectionFromType(Royal.Scenes.Home.Ui.Sections.SectionType type)
        {
            if((type + 2) > 4)
            {
                    return this.HomeSection;
            }
            
            var val_2 = 36597888 + ((type + 2)) << 2;
            val_2 = val_2 + 36597888;
            goto (36597888 + ((type + 2)) << 2 + 36597888);
        }
        public SectionManager()
        {
        
        }
    
    }

}
