using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigmaTaskDefinitionUI.UI
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // 指定要打开的 URL
                string url = "https://github.com/meiyg0927/Sigma-Task-Definition-Tool";

                // 使用默认浏览器打开 URL
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

                // 将链接标记为已访问
                linkLabel.LinkVisited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法打开链接。错误: " + ex.Message);
            }
        }
    }
}
