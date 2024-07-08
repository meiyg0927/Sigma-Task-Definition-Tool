using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigma
{
    internal class SubStep
    {
        public string Label { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public List<VirtualObjectDescriptor> VirtualObjects { get; set; } = new();

        public SubStep()
        {
            this.Label = string.Empty;
            this.Description = string.Empty;
        }

        public SubStep Clone()
        {
            SubStep newStep = new();
            newStep.Copy(this);
            return newStep;
        }

        public void Copy(SubStep source)//深拷贝
        {
            this.Label = source.Label;
            this.Description = source.Description;
            
            this.VirtualObjects.Clear();
            foreach(VirtualObjectDescriptor descriptor in source.VirtualObjects)
            {
                this.VirtualObjects.Add(new VirtualObjectDescriptor() 
                { Name = descriptor.Name, ModelType = descriptor.ModelType });
            }
        }
    }


    internal class VirtualObjectDescriptor
    {
        public string Name { get; set; } = string.Empty;

        public string ModelType { get; set; } = string.Empty;

    }
}
