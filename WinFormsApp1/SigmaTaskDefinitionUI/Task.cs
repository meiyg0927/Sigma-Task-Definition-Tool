using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace Sigma
{
    //This class is the bridge/interface between UI & Data
    internal class SigmaTask
    {
        private TaskData _data = new TaskData { Description = "This is the Sigma Task Data" };

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
        public Step? addGatherStep(List<string> objects)
        {
            if(_data.Steps == null) return null;

            GatherStep step = new GatherStep();
            step.Objects = objects;
            _data.Steps.Add(step);

            return step;
        }

        //Method
        public string JsonSerialize()
        {
            //var options = new JsonSerializerOptions { WriteIndented = true }; //, PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            //string serialized = JsonSerializer.Serialize(_data, options);

            // 配置 JSON.NET 序列化器
            var serializerSettings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented
            };
            Type type = typeof(TaskData);
            string serialized = JsonConvert.SerializeObject(_data, type, serializerSettings);

            Debug.WriteLine("=== Serialize TaskData START ===");
            Debug.WriteLine(serialized);
            Debug.WriteLine("=== Serialize TaskData END ===");

            return serialized;
        }

        public void Dump()
        {
            Debug.WriteLine("=== Dump TaskData START ===");
            Debug.WriteLine("Task Name: " + _data.Name);
            Debug.WriteLine("=== Dump TaskData END ===");
        }
    }
}
