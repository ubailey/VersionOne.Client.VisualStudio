using System;
using System.ComponentModel;
using System.Drawing;
using VersionOne.VisualStudio.DataLayer;
using VersionOne.VisualStudio.DataLayer.Entities;

namespace VersionOne.VisualStudio.VSPackage.Descriptors {
    public class IconDescriptor : PropertyDescriptor {
        public IconDescriptor(string name) : base(name, null) { }

        public override bool CanResetValue(object component) {
            return false;
        }

        public override object GetValue(object component) {
            Workitem item = component as Workitem;
            if (item != null) {
                switch (item.TypePrefix) {
                    case Entity.TaskPrefix:
                        return Resources.Task_Icon;
                    case Entity.StoryPrefix:
                        return Resources.Story_Icon;
                    case Entity.TestPrefix:
                        return Resources.Test_Icon;
                    case Entity.DefectPrefix:
                        return Resources.Defect_Icon;
                }
            }
            return null;
        }

        public override void ResetValue(object component) {
            throw new NotImplementedException();
        }

        public override void SetValue(object component, object value) {
            throw new NotImplementedException();
        }

        public override bool ShouldSerializeValue(object component) {
            return false;
        }

        public override Type ComponentType {
            get { return typeof(Workitem); }
        }

        public override bool IsReadOnly {
            get { return true; }
        }

        public override Type PropertyType {
            get { return typeof(Image); }
        }
    }
}