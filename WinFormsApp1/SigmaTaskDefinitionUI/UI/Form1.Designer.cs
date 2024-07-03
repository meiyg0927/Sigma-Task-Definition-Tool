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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            textTaskName = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureTip1 = new PictureBox();
            label2 = new Label();
            buttonNewTask = new Button();
            tabPage2 = new TabPage();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            buttonRemoveGatherList = new Button();
            buttonAddGatherList = new Button();
            buttonAddGatherStep = new Button();
            textBoxGatherObjectBack = new TextBox();
            label4 = new Label();
            listBoxGatherObject = new ListBox();
            pictureITips2 = new PictureBox();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            treeView = new TreeView();
            contextMenuStripTreeView = new ContextMenuStrip(components);
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItemEdit = new ToolStripMenuItem();
            imageList = new ImageList(components);
            buttonOutput = new Button();
            buttonNodeUp = new Button();
            buttonNodeDown = new Button();
            buttonNodeDelete = new Button();
            buttonMainClose = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTip1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureITips2).BeginInit();
            contextMenuStripTreeView.SuspendLayout();
            SuspendLayout();
            // 
            // textTaskName
            // 
            textTaskName.Location = new Point(37, 132);
            textTaskName.Name = "textTaskName";
            textTaskName.Size = new Size(662, 38);
            textTaskName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 78);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 2;
            label1.Text = "任务名称";
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
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
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(pictureTip1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(buttonNewTask);
            tabPage1.Controls.Add(textTaskName);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 43);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(779, 950);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "任务总体配置";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureTip1
            // 
            pictureTip1.Image = SigmaTaskDefinitionUI.Properties.Resources.Tips;
            pictureTip1.Location = new Point(64, 825);
            pictureTip1.Name = "pictureTip1";
            pictureTip1.Size = new Size(93, 75);
            pictureTip1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTip1.TabIndex = 5;
            pictureTip1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(176, 849);
            label2.Name = "label2";
            label2.Size = new Size(302, 31);
            label2.TabIndex = 4;
            label2.Text = "此页面设置任务的总体信息";
            // 
            // buttonNewTask
            // 
            buttonNewTask.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonNewTask.Location = new Point(240, 467);
            buttonNewTask.Name = "buttonNewTask";
            buttonNewTask.Size = new Size(271, 198);
            buttonNewTask.TabIndex = 3;
            buttonNewTask.Text = "新建任务";
            buttonNewTask.UseVisualStyleBackColor = true;
            buttonNewTask.Click += buttonNewTask_Click;
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(buttonRemoveGatherList);
            tabPage2.Controls.Add(buttonAddGatherList);
            tabPage2.Controls.Add(buttonAddGatherStep);
            tabPage2.Controls.Add(textBoxGatherObjectBack);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(listBoxGatherObject);
            tabPage2.Controls.Add(pictureITips2);
            tabPage2.Location = new Point(4, 43);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(779, 950);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "收集类任务配置";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(151, 781);
            label3.Name = "label3";
            label3.Size = new Size(326, 31);
            label3.TabIndex = 16;
            label3.Text = "此页面配置收集类任务的信息";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            richTextBox1.Location = new Point(151, 827);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(591, 119);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "1. 写入收集物品名称\n2. 点击“物品加入”按钮，可以把名称添加到列表中\n3. 点击“物品去除”按钮，可以把列表中选中的物品去除\n4. 点击“加入指令”按钮，新增收集指令，收集对象为列表中的所有物体";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 201);
            label5.Name = "label5";
            label5.Size = new Size(158, 31);
            label5.TabIndex = 14;
            label5.Text = "收集物品列表";
            // 
            // buttonRemoveGatherList
            // 
            buttonRemoveGatherList.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonRemoveGatherList.Location = new Point(471, 248);
            buttonRemoveGatherList.Name = "buttonRemoveGatherList";
            buttonRemoveGatherList.Size = new Size(271, 147);
            buttonRemoveGatherList.TabIndex = 13;
            buttonRemoveGatherList.Text = "物品去除";
            buttonRemoveGatherList.UseVisualStyleBackColor = true;
            buttonRemoveGatherList.Click += buttonRemoveGatherList_Click;
            // 
            // buttonAddGatherList
            // 
            buttonAddGatherList.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonAddGatherList.Location = new Point(471, 85);
            buttonAddGatherList.Name = "buttonAddGatherList";
            buttonAddGatherList.Size = new Size(271, 147);
            buttonAddGatherList.TabIndex = 12;
            buttonAddGatherList.Text = "物品加入";
            buttonAddGatherList.UseVisualStyleBackColor = true;
            buttonAddGatherList.Click += buttonAddGatherList_Click;
            // 
            // buttonAddGatherStep
            // 
            buttonAddGatherStep.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonAddGatherStep.Location = new Point(471, 457);
            buttonAddGatherStep.Name = "buttonAddGatherStep";
            buttonAddGatherStep.Size = new Size(271, 198);
            buttonAddGatherStep.TabIndex = 11;
            buttonAddGatherStep.Text = "加入指令";
            buttonAddGatherStep.UseVisualStyleBackColor = true;
            buttonAddGatherStep.Click += buttonAddGatherStep_Click;
            // 
            // textBoxGatherObjectBack
            // 
            textBoxGatherObjectBack.Location = new Point(27, 85);
            textBoxGatherObjectBack.Name = "textBoxGatherObjectBack";
            textBoxGatherObjectBack.Size = new Size(380, 38);
            textBoxGatherObjectBack.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 36);
            label4.Name = "label4";
            label4.Size = new Size(158, 31);
            label4.TabIndex = 10;
            label4.Text = "收集物品名称";
            // 
            // listBoxGatherObject
            // 
            listBoxGatherObject.FormattingEnabled = true;
            listBoxGatherObject.Location = new Point(27, 248);
            listBoxGatherObject.Name = "listBoxGatherObject";
            listBoxGatherObject.Size = new Size(380, 407);
            listBoxGatherObject.TabIndex = 8;
            // 
            // pictureITips2
            // 
            pictureITips2.Image = SigmaTaskDefinitionUI.Properties.Resources.Tips;
            pictureITips2.Location = new Point(27, 826);
            pictureITips2.Name = "pictureITips2";
            pictureITips2.Size = new Size(93, 75);
            pictureITips2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureITips2.TabIndex = 7;
            pictureITips2.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 43);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(779, 950);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "执行类任务配置";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 43);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(779, 950);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "复杂任务配置";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // treeView
            // 
            treeView.ContextMenuStrip = contextMenuStripTreeView;
            treeView.ImageIndex = 0;
            treeView.ImageList = imageList;
            treeView.Location = new Point(839, 73);
            treeView.Name = "treeView";
            treeView.SelectedImageIndex = 0;
            treeView.ShowNodeToolTips = true;
            treeView.Size = new Size(716, 950);
            treeView.TabIndex = 4;
            treeView.NodeMouseClick += treeView_NodeMouseClick;
            // 
            // contextMenuStripTreeView
            // 
            contextMenuStripTreeView.ImageScalingSize = new Size(32, 32);
            contextMenuStripTreeView.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripMenuItemEdit });
            contextMenuStripTreeView.Name = "contextMenuStripTreeView";
            contextMenuStripTreeView.Size = new Size(301, 92);
            contextMenuStripTreeView.ItemClicked += contextMenuStripTreeView_ItemClicked;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(297, 6);
            // 
            // toolStripMenuItemEdit
            // 
            toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            toolStripMenuItemEdit.Size = new Size(300, 38);
            toolStripMenuItemEdit.Text = "编辑";
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "Error.png");
            imageList.Images.SetKeyName(1, "Task.png");
            imageList.Images.SetKeyName(2, "Eyes.png");
            imageList.Images.SetKeyName(3, "Do.png");
            imageList.Images.SetKeyName(4, "Combo.png");
            imageList.Images.SetKeyName(5, "Substep.png");
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
            // buttonMainClose
            // 
            buttonMainClose.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonMainClose.Location = new Point(1598, 899);
            buttonMainClose.Name = "buttonMainClose";
            buttonMainClose.Size = new Size(271, 120);
            buttonMainClose.TabIndex = 9;
            buttonMainClose.Text = "关闭";
            buttonMainClose.UseVisualStyleBackColor = true;
            buttonMainClose.Click += buttonMainClose_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(buttonMainClose);
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
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTip1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureITips2).EndInit();
            contextMenuStripTreeView.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void ButtonNewTask_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private TextBox textTaskName;
        private Label label1;
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
        private Label label2;
        private PictureBox pictureTip1;
        private Button buttonMainClose;
        private PictureBox pictureITips2;
        private TextBox textBoxGatherObjectBack;
        private Label label4;
        private ListBox listBoxGatherObject;
        private Button buttonAddGatherStep;
        private Label label5;
        private Button buttonRemoveGatherList;
        private Button buttonAddGatherList;
        private RichTextBox richTextBox1;
        private Label label3;
        private ImageList imageList;
        private ContextMenuStrip contextMenuStripTreeView;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItemEdit;
    }
}