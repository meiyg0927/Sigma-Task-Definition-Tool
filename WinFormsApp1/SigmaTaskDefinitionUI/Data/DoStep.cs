using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigma
{
    [Serializable]
    internal class DoStep : Step
    {
        public string Label { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the step description.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the timer duration.
        /// </summary>
        public TimeSpan TimerDuration { get; set; }

        public DoStep() 
        {
            Label = string.Empty;
            Description = string.Empty;
            TimerDuration = TimeSpan.Zero;
        }
    }
}
