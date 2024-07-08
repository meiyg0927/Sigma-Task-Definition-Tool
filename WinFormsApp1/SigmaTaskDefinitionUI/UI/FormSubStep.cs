using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sigma;
using UISubStep = Sigma.SubStep;
using UIVO = Sigma.VirtualObjectDescriptor;
using SigmaTaskDefinitionUI.UI;

#pragma warning disable IDE1006

namespace SigmaTaskDefinitionUI
{
    public partial class FormSubStep : Form
    {
        private UISubStep _inValue = new();
        private UISubStep _retValue = new();

        private readonly List<UIVO> VODataList = new();

        private readonly FormVirtualObject frmVO = new();

        readonly int NAME_MODEL_MAX = 20; //listBoxVO 控件显示的 VirtualObject Name 最长字符数

        internal UISubStep inValue
        {
            get { return _inValue; }
            set { _inValue = value; }
        }
        internal UISubStep retValue
        {
            get { return _retValue; }
            set { _retValue = value; }
        }

        public FormSubStep()
        {
            InitializeComponent();
        }

        private void FormSubStep_Load(object sender, EventArgs e)
        {
            richTextSubStepDescription.Text = _inValue.Description;
            CenterToParent();
        }

        private void buttonSubStepOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextSubStepDescription.Text))
            {
                MessageBox.Show("请输入子任务描述", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                retValue.Description = richTextSubStepDescription.Text.Trim();
                //richTextSubStepDescription.Text = string.Empty;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonSubStepCancel_Click(object sender, EventArgs e)
        {
            //richTextSubStepDescription.Text = string.Empty;
            _inValue.Description = string.Empty;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonAddVirtualObject_Click(object sender, EventArgs e)
        {
            //frmSubStep.inValue.Copy(new UISubStep());
            frmVO.inValue = new();
            if (DialogResult.OK == frmVO.ShowDialog())
            {
                VirtualObjectDescriptor data = new()
                { ModelType = frmVO.retValue.ModelType, Name = frmVO.retValue.Name };

                VODataList.Add(data);

                string str = data.Name;
                if (str.Length > NAME_MODEL_MAX) str = str.Substring(0, NAME_MODEL_MAX);
                listBoxVO.Items.Add(str);
            }
        }

        private void buttonRemoveVirtualObject_Click(object sender, EventArgs e)
        {
            if (listBoxVO.SelectedItem != null)
            {
                VODataList.RemoveAt(listBoxVO.SelectedIndex);
                listBoxVO.Items.Remove(listBoxVO.SelectedItem);
            }
        }

        private void buttonEditVirtualObject_Click(object sender, EventArgs e)
        {
            if (listBoxVO.SelectedItem != null)
            {
                int SelectedIndex = listBoxVO.SelectedIndex;

                frmVO.inValue.Name = VODataList.ElementAt(SelectedIndex).Name;
                frmVO.inValue.ModelType = VODataList.ElementAt(SelectedIndex).ModelType;

                if (DialogResult.OK == frmVO.ShowDialog())
                {
                    VODataList[SelectedIndex].Name = frmVO.retValue.Name;
                    VODataList[SelectedIndex].ModelType = frmVO.retValue.ModelType;

                    string updated_str = frmVO.retValue.Name;
                    if (updated_str.Length > NAME_MODEL_MAX) updated_str = updated_str.Substring(0, NAME_MODEL_MAX);
                    listBoxVO.Items[SelectedIndex] = updated_str;
                }
            }
            else { MessageBox.Show("请先点选一个模型再选择编辑", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonSubStepMoveUp_Click(object sender, EventArgs e)
        {
            int SelectedIndex = listBoxVO.SelectedIndex;
            WinFormsApp1.Form.Func_MoveListBoxItemOptimized(listBoxVO, SelectedIndex, SelectedIndex - 1);
            Func_MoveVODataInList(SelectedIndex, SelectedIndex - 1);
        }

        private void buttonSubStepMoveDown_Click(object sender, EventArgs e)
        {
            int SelectedIndex = listBoxVO.SelectedIndex;
            WinFormsApp1.Form.Func_MoveListBoxItemOptimized(listBoxVO, SelectedIndex, SelectedIndex + 1);
            Func_MoveVODataInList(SelectedIndex, SelectedIndex + 1);
        }

        private void Func_MoveVODataInList(int fromIndex, int toIndex)
        {
            WinFormsApp1.Form.Func_MoveItemInList<UIVO>(VODataList, fromIndex, toIndex);
        }
    }
}
