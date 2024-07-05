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
            if (string.IsNullOrWhiteSpace(s)) return false;

            _data.Name = s.Trim();
            return true;
        }

        public bool Initialize()
        {
            _data.Name = string.Empty;
            _data.Description = string.Empty;

            foreach (Step step in _data.Steps)
            {
                if (step is ComplexStep stepC)//如果是ComplexStep，需要清空内部的SubStep
                {
                    stepC.SubSteps.Clear();
                }
            }

            _data.Steps.Clear();
            return true;
        }
        
        //Step
        public Step? addGatherStep(List<string> objects)
        {
            if(_data.Steps == null) return null;

            GatherStep step = new GatherStep();
            step.Objects = objects;
            _data.Steps.Add(step);

            return step;
        }

        public Step? addDoStep(string description, TimeSpan ts)
        {
            if (_data.Steps == null) return null;

            DoStep step = new DoStep();
            step.Description = description;
            step.TimerDuration = ts;
            _data.Steps.Add(step);

            return step;
        }

        public Step? addComplexStep(string description)
        {
            if (_data.Steps == null) { return null; }

            ComplexStep step = new ComplexStep();
            step.Description = description;
            _data.Steps.Add(step);

            return step;
        }

        public bool RemoveStep(Step? step)
        {
            if (step == null) return false;

            if (step is ComplexStep stepC)//如果是ComplexStep，需要清空内部的SubStep
            {
               stepC.SubSteps.Clear();
            }
            
            return _data.Steps.Remove(step);
        }

        public bool RemoveSubStep(Step? complexStep, SubStep? subStep)
        { 
            if (subStep == null || complexStep == null) return false;

            if (complexStep is ComplexStep complexStepC)
            { 
                return complexStepC.SubSteps.Remove(subStep);
            }
            return false;
        }

        //Method
        public void CalculateLabel()
        {
            int index = 0;
            foreach (Step step in _data.Steps)
            {
                if (step is GatherStep stepG)
                {
                    stepG.Label = index.ToString();
                }
                else
                if(step is DoStep stepD)
                {
                   stepD.Label = index.ToString();
                }
                else
                if(step is ComplexStep stepC)
                {
                    stepC.Label = index.ToString();

                    int index_sub = 0;
                    foreach(SubStep sub_step in stepC.SubSteps)
                    {
                        sub_step.Label = index_sub.ToString();
                        index_sub++;
                    }
                }

                index++;
             }
        }
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
