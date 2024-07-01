﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigmaTaskDefinitionUI
{
    public partial class FormOutput : Form
    {
        public FormOutput()
        {
            InitializeComponent();
        }

        private void FormOutput_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            //Save Json file
            SavetoFlie();

            this.Close ();
        }

        public string strJson
        {
            get { return richTextBox.Text; }
            set { richTextBox.Text = value; }
        }

        private void SavetoFlie()
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\" + "sigma.state.diamond.tasklibrary.json", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            StringBuilder exdata;
            try
            {

                {
                    exdata = new System.Text.StringBuilder();
                    exdata.Append(richTextBox.Text);
                    fs.SetLength(0); //full overwrite previous content
                    sw.Write(exdata);
                }
                Debug.WriteLine("Tsigma.state.diamond.tasklibrary.json 保存完毕!");
                MessageBox.Show("sigma.state.diamond.tasklibrary.json 保存完毕!","", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
               // Console.WriteLine("存储文件时发生错误：" + ex.Message);
                Debug.WriteLine("存储文件时发生错误：" + ex.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }
    }
}
