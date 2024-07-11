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

#pragma warning disable IDE1006

namespace Sigma
{
    //This class is the bridge/interface between UI & Data
    internal class SigmaTask
    {
        //注意：Task里面的Steps是不包括SubStep的；SubStep是ComplexStep的成员变量，因为它不继承Step，所以不记录在Task的Steps里面
        private readonly Task _data = new() { Description = "This is the Sigma Task Data" };
        private readonly TaskCollection _serialize_data = new();

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

            GatherStep step = new() { Objects = objects };
            _data.Steps.Add(step);

            return step;
        }

        public bool updateGatherStep(Step? step, List<string> objects)
        {
            if (_data.Steps == null || step == null) return false;

            if (step is GatherStep stepG)
            {
                stepG.Objects = objects;
                return true;
            }

            return false;
        }

        public Step? addDoStep(string description, TimeSpan ts)
        {
            if (_data.Steps == null) return null;

            DoStep step = new() { Description=description, TimerDuration=ts };
            _data.Steps.Add(step);

            return step;
        }

        public bool updateDoStep(Step? step, string description, TimeSpan ts)
        {
            if (_data.Steps == null || step == null) return false;

            if (step is DoStep stepD)
            {
                stepD.Description = description;
                stepD.TimerDuration = ts;

                return true;
            }

            return false;
        }

        public Step? addComplexStep(string description, List<SubStep> subSteps)
        {
            if (_data.Steps == null) { return null; }

            ComplexStep step = new() { Description = description };
            step.Description = description;
            foreach (SubStep subStep in subSteps)
            {
                SubStep newStep = subStep.Clone();
                step.SubSteps.Add(newStep);
            }
            _data.Steps.Add(step);

            return step;
        }

        public bool updateComplexStep(Step? step, string description, List<SubStep> subSteps)
        {
            if (_data.Steps == null || step == null) return false;

            if(step is ComplexStep stepC)
            {
                stepC.Description = description;
                stepC.SubSteps.Clear();
                foreach (SubStep subStep in subSteps) //SubStep不更新，直接删除重新赋值
                {
                    SubStep newStep = subStep.Clone();
                    stepC.SubSteps.Add(newStep);
                }

                return true;
            }

            return false;
        }
        public bool updateSubStepinComplexStep(Step? complex_step, SubStep? subStep, SubStep? updated_data)
        {
            if (_data.Steps == null || complex_step == null || subStep == null || updated_data == null) { return false; }

            if (complex_step is ComplexStep stepC && stepC.SubSteps.Contains(subStep))
            {
                int index = stepC.SubSteps.IndexOf(subStep);
                if (index >= 0)
                { 
                    stepC.SubSteps[index].Copy(updated_data);
                    return true;
                }
            }

            return false;
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

        public bool SwapStep(Step? step1, Step? step2)
        {
            if(step1 == null || step2 == null) return false;

            int index1 = _data.Steps.IndexOf(step1);
            int index2 = _data.Steps.IndexOf(step2);

            if (index1 == index2 || index1 < 0 || index2 < 0) return false;

            _data.Steps[index1] = step2;
            _data.Steps[index2] = step1;

            return true;
        }

        public bool SwapSubStep(Step? complexStep, SubStep? step1, SubStep? step2)
        {
            if (complexStep == null || step1 == null || step2 == null) return false;

            if (complexStep is ComplexStep stepC)
            {
                int index1 = stepC.SubSteps.IndexOf(step1);
                int index2 = stepC.SubSteps.IndexOf(step2);

                if(index1 == index2 || index1 < 0 || index2 < 0) return false;

                stepC.SubSteps[index1] = step2;
                stepC.SubSteps[index2] = step1;
            }

            return true;
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
            Type type = typeof(TaskCollection);
            if (_serialize_data.Tasks.Count > 0)
            {
                _serialize_data.Tasks[0] = _data;//只支持一个Task
            }
            else
            {
                _serialize_data.Tasks.Add(_data);
            }
            string serialized = JsonConvert.SerializeObject(_serialize_data, type, serializerSettings);

            Debug.WriteLine("=== Serialize Tasks START ===");
            Debug.WriteLine(serialized);
            Debug.WriteLine("=== Serialize Tasks END ===");

            return serialized;
        }

        public void Dump()
        {
            Debug.WriteLine("=== Dump Tasks START ===");
            Debug.WriteLine("Task Name: " + _data.Name);
            Debug.WriteLine("=== Dump Tasks END ===");
        }
    }
}
