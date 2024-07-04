using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigma
{
    [Serializable]
    internal class GatherStep : Step
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatherStep"/> class.
        /// </summary>

        public string Label { get; set; } = string.Empty;

        public string Verb { get; set; } = string.Empty;

        public string Noun { get; set; } = string.Empty;

        public List<string> Objects { get; set; } = new List<string>();

        public GatherStep()
        {
            this.Label = string.Empty;
            this.Verb = "Gather";
            this.Noun = "Objects";
        }
    }
}
