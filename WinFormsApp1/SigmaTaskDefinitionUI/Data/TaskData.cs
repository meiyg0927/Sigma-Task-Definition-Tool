using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SigmaTaskDefinitionUI.Data
{
    #region TaskData
    internal class TaskData
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IList<Step>? Steps { get; set; }
    }
    #endregion

    #region Step
    internal class Step
    {
        public string Label { get; set; } = string.Empty;

        public Step() { }
    }
    #endregion
}
