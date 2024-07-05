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
        }
    }
}
