using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Sigma
{
    internal class TaskCollection
    {
        public List<Task> Tasks { get; set; } = new();
    }

    internal class Task
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        //public IList<Step>? Steps { get; set; }
        public List<Step> Steps { get; set; } = new();
    }
}
