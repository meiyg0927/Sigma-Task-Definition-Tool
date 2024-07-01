using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SigmaTaskDefinitionUI
{
    #region TaskData
    internal class TaskData
    {
        public string Name { get; set; } = String.Empty;
    }
    #endregion

    #region SigmaTask
    internal class SigmaTask
    {
        private TaskData _data = new TaskData();
        public string getTaskName() { return _data.Name; }
        public bool setTaskName(string s) 
        {
            s.Trim();
            
            if (string.IsNullOrEmpty(s)) 
                return false; 
            
            _data.Name = s; 
            return true; 
        }
            

        bool isTaskNameNullOrEmpty() { return string.IsNullOrEmpty(_data.Name); }

        public void Dump()
        {
            Debug.WriteLine("--- Dump TaskData START ---");
            Debug.WriteLine("Task Name: " + _data.Name);
            Debug.WriteLine("--- Dump TaskData END ---");
        }

        public string JsonSerialize()
        {
            var serialized = JsonSerializer.Serialize(_data);

            Debug.WriteLine("--- Serialize TaskData START ---");
            Debug.WriteLine(serialized);
            Debug.WriteLine("--- Serialize TaskData END ---");

            return serialized;
        }

        #endregion
    }
}
