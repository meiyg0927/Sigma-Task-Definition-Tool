using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SigmaTaskDefinitionUI.Data;

namespace SigmaTaskDefinitionUI
{
    //This class is the bridge/interface between UI & Data
    internal class SigmaTask
    {
        private TaskData _data = new TaskData { Steps = new List<Step>(), Description = "This is the game I love" };

        //TaskName
        public string getTaskName() { return _data.Name; }
        public bool setTaskName(string s)
        {
            s.Trim();

            if (string.IsNullOrEmpty(s)) return false;

            _data.Name = s;
            return true;
        }

        bool isTaskNameNullOrEmpty() { return string.IsNullOrEmpty(_data.Name); }
        
        //Step
        public bool addStep()
        {
            if (_data.Steps.Count == 0)
            {
                Step step = new Step();
                step.Label = "Label0";
                _data.Steps.Add(step);
            }
            return true;
        }

        //Method
        public string JsonSerialize()
        {
            var options = new JsonSerializerOptions { WriteIndented = true }; //, PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            string serialized = JsonSerializer.Serialize(_data, options);

            Debug.WriteLine("--- Serialize TaskData START ---");
            Debug.WriteLine(serialized);
            Debug.WriteLine("--- Serialize TaskData END ---");

            return serialized;
        }

        public void Dump()
        {
            Debug.WriteLine("--- Dump TaskData START ---");
            Debug.WriteLine("Task Name: " + _data.Name);
            Debug.WriteLine("--- Dump TaskData END ---");
        }
    }
}
