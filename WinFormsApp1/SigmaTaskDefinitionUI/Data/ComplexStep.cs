using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigma
{
    internal class ComplexStep : Step
    {
        public string Label { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public List<SubStep> SubSteps { get; set; } = new List<SubStep>();
    }
}
