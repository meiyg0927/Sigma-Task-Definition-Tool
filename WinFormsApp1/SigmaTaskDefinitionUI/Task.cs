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
using SigmaTaskDefinitionUI.Data;

#pragma warning disable IDE1006

namespace Sigma
{
    internal class Option
    {
        public static readonly bool bflag = true;         
    }

    //This class is the bridge/interface between UI & Data
    internal class SigmaTask
    {
        //注意：Task里面的Steps是不包括SubStep的；SubStep是ComplexStep的成员变量，因为它不继承Step，所以不记录在Task的Steps里面
        private readonly TaskCollection _data = new();
        
        //Step
        public static Step? addGatherStep(List<string> objects)
        {
            GatherStep step = new() { Objects = objects };
            return step;
        }

        public static bool updateGatherStep(Step? step, List<string> objects)
        {
            if (step != null && step is GatherStep stepG)
            {
                stepG.Objects = objects;
                return true;
            }

            return false;
        }

        public static Step? addDoStep(string description, TimeSpan ts)
        {
            DoStep step = new() { Description=description, TimerDuration=ts };
            return step;
        }

        public static bool updateDoStep(Step? step, string description, TimeSpan ts)
        {
            if (step != null && step is DoStep stepD)
            {
                stepD.Description = description;
                stepD.TimerDuration = ts;

                return true;
            }

            return false;
        }

        public static Step? addComplexStep(string description)
        {
            ComplexStep step = new() { Description = description };
            step.Description = description;
            return step;
        }

        public static bool updateComplexStep(Step? step, string description)
        {
            if(step != null && step is ComplexStep stepC)
            {
                stepC.Description = description;
                return true;
            }
            return false;
        }

        public bool AssembleSteps(TreeView? tree)
        {
            if (tree == null) return false;

            _data.Tasks.Clear();

            foreach (TreeNode node_task in tree.Nodes)
            {
                //Task_Level
                //...
                Task task = new();
                task.Steps.Clear();

                TreeNodeTaskData? task_data = TreeNodeManage.Instance.GetTreeNodeTaskData(node_task);
                
                if (task_data == null) continue;

                task.Name = task_data.head == null ? "" : task_data.head.Name;
                task.Description = task_data.head == null ? "" : task_data.head.Description;

                for (int index = 0; index < node_task.Nodes.Count; index++)
                {
                    //Step_Level
                    TreeNode node_step = node_task.Nodes[index];
                    TreeNodeData? data = TreeNodeManage.Instance.GetTreeNodeData(node_step);
                    if (data != null)
                    {
                        switch (data.type)
                        {
                            case TreeNodeType.GATHER:
                                if (data.step is GatherStep stepG)
                                {
                                    task.Steps.Add(stepG);
                                }
                                break;
                            case TreeNodeType.DO:
                                if (data.step is DoStep stepD)
                                {
                                    task.Steps.Add(stepD);
                                }
                                break;
                            case TreeNodeType.COMPLEX:
                                if (data.step is ComplexStep stepC)
                                {
                                    stepC.SubSteps.Clear();

                                    for (int i = 0; i < node_step.Nodes.Count; i++)
                                    {
                                        //SubStep_Level
                                        TreeNodeData? data_substep = TreeNodeManage.Instance.GetTreeNodeData(node_step.Nodes[i]);
                                        if (data_substep != null && data_substep.subStep != null && data_substep.subStep is SubStep subStep)
                                        {
                                            stepC.SubSteps.Add(subStep);
                                        }
                                    }

                                    task.Steps.Add(stepC);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }

                _data.Tasks.Add(task);

                //break; //只做一层Task
            }

            return true;
        }
    
        //Method
        public void CalculateLabel()
        {
            foreach (Task task in _data.Tasks)
            {
                int index = 0;
                foreach (Step step in task.Steps)
                {
                    if (step is GatherStep stepG)
                    {
                        stepG.Label = index.ToString();
                    }
                    else
                    if (step is DoStep stepD)
                    {
                        stepD.Label = index.ToString();
                    }
                    else
                    if (step is ComplexStep stepC)
                    {
                        stepC.Label = index.ToString();

                        int index_sub = 0;
                        foreach (SubStep sub_step in stepC.SubSteps)
                        {
                            sub_step.Label = index_sub.ToString();
                            index_sub++;
                        }
                    }

                    index++;
                }
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

            string serialized = JsonConvert.SerializeObject(_data, type, serializerSettings);

            Debug.WriteLine("=== Serialize Tasks START ===");
            Debug.WriteLine(serialized);
            Debug.WriteLine("=== Serialize Tasks END ===");

            return serialized;
        }

        public void Dump()
        {
            Debug.WriteLine("=== Dump Tasks START ===");
            Debug.WriteLine("=== Dump Tasks END ===");
        }
    }
}
