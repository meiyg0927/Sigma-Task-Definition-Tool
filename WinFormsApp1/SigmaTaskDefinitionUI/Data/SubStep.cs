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
            foreach (VirtualObjectDescriptor descriptor in source.VirtualObjects)
            {
                this.VirtualObjects.Add(descriptor.Clone());
            }
        }
    }


    internal class VirtualObjectDescriptor
    {
        public string Name { get; set; } = string.Empty;

        public string ModelType { get; set; } = string.Empty;

        public SpatialPoseDescriptor? SpatialPose { get; set; } = null;

        public VirtualObjectDescriptor Clone()
        {
            VirtualObjectDescriptor newDescriptor = new VirtualObjectDescriptor();
            newDescriptor.Copy(this);
            return newDescriptor;
        }

        public void Copy(VirtualObjectDescriptor descriptor) //深拷贝
        {
            this.Name = descriptor.Name;
            this.ModelType = descriptor.ModelType;
  
            if(descriptor.SpatialPose != null)
            {
                if (descriptor.SpatialPose is AtKnownSpatialLocation atkSpatialPose)
                {
                    if (this.SpatialPose != null && this.SpatialPose is AtKnownSpatialLocation atkSpatialPose2)
                    {
                        atkSpatialPose2.SpatialLocationName = atkSpatialPose.SpatialLocationName;
                    }
                    else
                    {
                        this.SpatialPose = new AtKnownSpatialLocation(atkSpatialPose.SpatialLocationName); 
                    }
                }
                else
                {
                    if (this.SpatialPose == null) this.SpatialPose = new();
                }
            }
            else 
            { 
                this.SpatialPose = null; 
            }
        }
    }

    internal class SpatialPoseDescriptor
    {

    }
    internal class AtKnownSpatialLocation : SpatialPoseDescriptor
    {
        public AtKnownSpatialLocation()
        {
        }

        public AtKnownSpatialLocation(string spatialLocationName)
        {
            SpatialLocationName = new string(spatialLocationName);
        }

        public string SpatialLocationName { get; set; } = string.Empty;
    }
}
