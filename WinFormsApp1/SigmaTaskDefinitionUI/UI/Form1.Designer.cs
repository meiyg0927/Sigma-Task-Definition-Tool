namespace WinFormsApp1
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textTaskName = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonNewTask = new Button();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            treeView = new TreeView();
            buttonOutput = new Button();
            buttonNodeUp = new Button();
            buttonNodeDown = new Button();
            buttonNodeDelete = new Button();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(72, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 540);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task Type";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(22, 98);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(195, 35);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(22, 57);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(195, 35);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textTaskName
            // 
            textTaskName.Location = new Point(53, 335);
            textTaskName.Name = "textTaskName";
            textTaskName.Size = new Size(662, 38);
            textTaskName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 281);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 2;
            label1.Text = "任务名称";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(32, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(787, 997);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonNewTask);
            tabPage1.Controls.Add(textTaskName);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(8, 45);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(771, 944);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "步骤 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonNewTask
            // 
            buttonNewTask.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonNewTask.Location = new Point(240, 467);
            buttonNewTask.Name = "buttonNewTask";
            buttonNewTask.Size = new Size(271, 198);
            buttonNewTask.TabIndex = 3;
            buttonNewTask.Text = "创建";
            buttonNewTask.UseVisualStyleBackColor = true;
            buttonNewTask.Click += buttonNewTask_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(8, 45);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(771, 944);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "步骤 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(8, 45);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(771, 944);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "步骤 3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(8, 45);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(771, 944);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "步骤 4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // treeView
            // 
            treeView.Location = new Point(839, 75);
            treeView.Name = "treeView";
            treeView.Size = new Size(716, 944);
            treeView.TabIndex = 4;
            treeView.NodeMouseClick += treeView_NodeMouseClick;
            // 
            // buttonOutput
            // 
            buttonOutput.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonOutput.Location = new Point(1598, 460);
            buttonOutput.Name = "buttonOutput";
            buttonOutput.Size = new Size(271, 198);
            buttonOutput.TabIndex = 5;
            buttonOutput.Text = "输出";
            buttonOutput.UseVisualStyleBackColor = true;
            buttonOutput.Click += buttonOutput_Click;
            // 
            // buttonNodeUp
            // 
            buttonNodeUp.Location = new Point(1561, 75);
            buttonNodeUp.Name = "buttonNodeUp";
            buttonNodeUp.Size = new Size(50, 46);
            buttonNodeUp.TabIndex = 6;
            buttonNodeUp.Text = "▲";
            buttonNodeUp.UseVisualStyleBackColor = true;
            // 
            // buttonNodeDown
            // 
            buttonNodeDown.Location = new Point(1561, 127);
            buttonNodeDown.Name = "buttonNodeDown";
            buttonNodeDown.Size = new Size(50, 46);
            buttonNodeDown.TabIndex = 7;
            buttonNodeDown.Text = "▼";
            buttonNodeDown.UseVisualStyleBackColor = true;
            // 
            // buttonNodeDelete
            // 
            buttonNodeDelete.Font = new Font("Arial", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNodeDelete.Location = new Point(1561, 179);
            buttonNodeDelete.Name = "buttonNodeDelete";
            buttonNodeDelete.Size = new Size(50, 46);
            buttonNodeDelete.TabIndex = 8;
            buttonNodeDelete.Text = "✕";
            buttonNodeDelete.UseVisualStyleBackColor = true;
            buttonNodeDelete.Click += buttonNodeDelete_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(buttonNodeDelete);
            Controls.Add(buttonNodeDown);
            Controls.Add(buttonNodeUp);
            Controls.Add(buttonOutput);
            Controls.Add(treeView);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form";
            Text = "Sigma指令生成工具";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void ButtonNewTask_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private TextBox textTaskName;
        private Label label1;
        private RadioButton radioButton2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button buttonNewTask;
        private TreeView treeView;
        private Button buttonOutput;
        private Button buttonNodeUp;
        private Button buttonNodeDown;
        private Button buttonNodeDelete;
    }
}