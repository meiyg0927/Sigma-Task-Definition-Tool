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
            tabControlTask = new TabControl();
            tabPage1 = new TabPage();
            buttonUpdateTaskCancel = new Button();
            buttonUpdateTask = new Button();
            pictureTip1 = new PictureBox();
            label2 = new Label();
            buttonNewTask = new Button();
            tabPage2 = new TabPage();
            buttonUpdateGatherStepCancel = new Button();
            buttonUpdateGatherStep = new Button();
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
            buttonUpdateDoStepCancel = new Button();
            buttonUpdateDoStep = new Button();
            label8 = new Label();
            label7 = new Label();
            richTextDoDescription = new RichTextBox();
            buttonAddDoStep = new Button();
            label6 = new Label();
            richTextBox2 = new RichTextBox();
            pictureTip3 = new PictureBox();
            dateTimeDoDuring = new DateTimePicker();
            tabPage4 = new TabPage();
            buttonUpdateComplexStepCancel = new Button();
            buttonUpdateComplexStep = new Button();
            groupBox1 = new GroupBox();
            buttonSubStepMoveDown = new Button();
            buttonSubStepMoveUp = new Button();
            buttonRemoveSubStep = new Button();
            buttonEditSubStep = new Button();
            buttonAddSubStep = new Button();
            listBoxSubStep = new ListBox();
            label10 = new Label();
            richTextComplexDescription = new RichTextBox();
            label9 = new Label();
            richTextBox3 = new RichTextBox();
            pictureBox1 = new PictureBox();
            buttonAddComplexStep = new Button();
            treeView = new TreeView();
            contextMenuStripTreeView = new ContextMenuStrip(components);
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItemExpandAll = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItemEdit = new ToolStripMenuItem();
            imageList = new ImageList(components);
            buttonOutput = new Button();
            buttonNodeUp = new Button();
            buttonNodeDown = new Button();
            buttonNodeDelete = new Button();
            buttonMainClose = new Button();
            menuStrip = new MenuStrip();
            ToolStripMenuItemFile = new ToolStripMenuItem();
            ToolStripMenuItemHelp = new ToolStripMenuItem();
            ToolStripMenuItemHelpAbout = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControlTask.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTip1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureITips2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTip3).BeginInit();
            tabPage4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStripTreeView.SuspendLayout();
            menuStrip.SuspendLayout();
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
            // tabControlTask
            // 
            tabControlTask.Appearance = TabAppearance.FlatButtons;
            tabControlTask.Controls.Add(tabPage1);
            tabControlTask.Controls.Add(tabPage2);
            tabControlTask.Controls.Add(tabPage3);
            tabControlTask.Controls.Add(tabPage4);
            tabControlTask.Location = new Point(32, 66);
            tabControlTask.Name = "tabControlTask";
            tabControlTask.SelectedIndex = 0;
            tabControlTask.Size = new Size(787, 997);
            tabControlTask.TabIndex = 3;
            tabControlTask.SelectedIndexChanged += tabControlTask_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(buttonUpdateTaskCancel);
            tabPage1.Controls.Add(buttonUpdateTask);
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
            // buttonUpdateTaskCancel
            // 
            buttonUpdateTaskCancel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonUpdateTaskCancel.Location = new Point(399, 467);
            buttonUpdateTaskCancel.Name = "buttonUpdateTaskCancel";
            buttonUpdateTaskCancel.Size = new Size(271, 198);
            buttonUpdateTaskCancel.TabIndex = 7;
            buttonUpdateTaskCancel.Text = "取消";
            buttonUpdateTaskCancel.UseVisualStyleBackColor = true;
            buttonUpdateTaskCancel.Click += buttonUpdateTaskCancel_Click;
            // 
            // buttonUpdateTask
            // 
            buttonUpdateTask.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonUpdateTask.Location = new Point(64, 467);
            buttonUpdateTask.Name = "buttonUpdateTask";
            buttonUpdateTask.Size = new Size(271, 198);
            buttonUpdateTask.TabIndex = 6;
            buttonUpdateTask.Text = "更新";
            buttonUpdateTask.UseVisualStyleBackColor = true;
            buttonUpdateTask.Click += buttonUpdateTask_Click;
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
            tabPage2.Controls.Add(buttonUpdateGatherStepCancel);
            tabPage2.Controls.Add(buttonUpdateGatherStep);
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
            // buttonUpdateGatherStepCancel
            // 
            buttonUpdateGatherStepCancel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonUpdateGatherStepCancel.Location = new Point(609, 457);
            buttonUpdateGatherStepCancel.Name = "buttonUpdateGatherStepCancel";
            buttonUpdateGatherStepCancel.Size = new Size(133, 198);
            buttonUpdateGatherStepCancel.TabIndex = 18;
            buttonUpdateGatherStepCancel.Text = "取消";
            buttonUpdateGatherStepCancel.UseVisualStyleBackColor = true;
            buttonUpdateGatherStepCancel.Visible = false;
            buttonUpdateGatherStepCancel.Click += buttonUpdateGatherStepCancel_Click;
            // 
            // buttonUpdateGatherStep
            // 
            buttonUpdateGatherStep.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonUpdateGatherStep.Location = new Point(471, 457);
            buttonUpdateGatherStep.Name = "buttonUpdateGatherStep";
            buttonUpdateGatherStep.Size = new Size(132, 198);
            buttonUpdateGatherStep.TabIndex = 17;
            buttonUpdateGatherStep.Text = "更新";
            buttonUpdateGatherStep.UseVisualStyleBackColor = true;
            buttonUpdateGatherStep.Visible = false;
            buttonUpdateGatherStep.Click += buttonUpdateGatherStep_Click;
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
            tabPage3.BorderStyle = BorderStyle.FixedSingle;
            tabPage3.Controls.Add(buttonUpdateDoStepCancel);
            tabPage3.Controls.Add(buttonUpdateDoStep);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(richTextDoDescription);
            tabPage3.Controls.Add(buttonAddDoStep);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(richTextBox2);
            tabPage3.Controls.Add(pictureTip3);
            tabPage3.Controls.Add(dateTimeDoDuring);
            tabPage3.Location = new Point(4, 43);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(779, 950);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "执行类任务配置";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateDoStepCancel
            // 
            buttonUpdateDoStepCancel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonUpdateDoStepCancel.Location = new Point(584, 375);
            buttonUpdateDoStepCancel.Name = "buttonUpdateDoStepCancel";
            buttonUpdateDoStepCancel.Size = new Size(132, 198);
            buttonUpdateDoStepCancel.TabIndex = 25;
            buttonUpdateDoStepCancel.Text = "取消";
            buttonUpdateDoStepCancel.UseVisualStyleBackColor = true;
            buttonUpdateDoStepCancel.Visible = false;
            buttonUpdateDoStepCancel.Click += buttonUpdateDoStepCancel_Click;
            // 
            // buttonUpdateDoStep
            // 
            buttonUpdateDoStep.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonUpdateDoStep.Location = new Point(446, 375);
            buttonUpdateDoStep.Name = "buttonUpdateDoStep";
            buttonUpdateDoStep.Size = new Size(132, 198);
            buttonUpdateDoStep.TabIndex = 24;
            buttonUpdateDoStep.Text = "更新";
            buttonUpdateDoStep.UseVisualStyleBackColor = true;
            buttonUpdateDoStep.Visible = false;
            buttonUpdateDoStep.Click += buttonUpdateDoStep_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 36);
            label8.Name = "label8";
            label8.Size = new Size(314, 31);
            label8.TabIndex = 23;
            label8.Text = "执行任务时间（小时:分:秒）";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 194);
            label7.Name = "label7";
            label7.Size = new Size(158, 31);
            label7.TabIndex = 22;
            label7.Text = "执行任务描述";
            // 
            // richTextDoDescription
            // 
            richTextDoDescription.Location = new Point(39, 239);
            richTextDoDescription.Name = "richTextDoDescription";
            richTextDoDescription.Size = new Size(344, 454);
            richTextDoDescription.TabIndex = 21;
            richTextDoDescription.Text = "";
            // 
            // buttonAddDoStep
            // 
            buttonAddDoStep.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonAddDoStep.Location = new Point(446, 375);
            buttonAddDoStep.Name = "buttonAddDoStep";
            buttonAddDoStep.Size = new Size(271, 198);
            buttonAddDoStep.TabIndex = 20;
            buttonAddDoStep.Text = "加入指令";
            buttonAddDoStep.UseVisualStyleBackColor = true;
            buttonAddDoStep.Click += buttonAddDoStep_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.Location = new Point(151, 781);
            label6.Name = "label6";
            label6.Size = new Size(326, 31);
            label6.TabIndex = 19;
            label6.Text = "此页面配置执行类任务的信息";
            // 
            // richTextBox2
            // 
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            richTextBox2.Location = new Point(151, 827);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(591, 119);
            richTextBox2.TabIndex = 18;
            richTextBox2.Text = "1. 设置执行任务的时间\n2. 输入执行任务的具体描述\n3. 点击“加入指令”按钮，新增执行指令";
            // 
            // pictureTip3
            // 
            pictureTip3.Image = SigmaTaskDefinitionUI.Properties.Resources.Tips;
            pictureTip3.Location = new Point(27, 826);
            pictureTip3.Name = "pictureTip3";
            pictureTip3.Size = new Size(93, 75);
            pictureTip3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTip3.TabIndex = 17;
            pictureTip3.TabStop = false;
            // 
            // dateTimeDoDuring
            // 
            dateTimeDoDuring.CalendarFont = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dateTimeDoDuring.CustomFormat = "HH:mm:ss";
            dateTimeDoDuring.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dateTimeDoDuring.Format = DateTimePickerFormat.Custom;
            dateTimeDoDuring.Location = new Point(44, 79);
            dateTimeDoDuring.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimeDoDuring.Name = "dateTimeDoDuring";
            dateTimeDoDuring.Size = new Size(339, 54);
            dateTimeDoDuring.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BorderStyle = BorderStyle.FixedSingle;
            tabPage4.Controls.Add(buttonUpdateComplexStepCancel);
            tabPage4.Controls.Add(buttonUpdateComplexStep);
            tabPage4.Controls.Add(groupBox1);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(richTextComplexDescription);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(richTextBox3);
            tabPage4.Controls.Add(pictureBox1);
            tabPage4.Controls.Add(buttonAddComplexStep);
            tabPage4.Location = new Point(4, 43);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(779, 950);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "复杂任务配置";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateComplexStepCancel
            // 
            buttonUpdateComplexStepCancel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonUpdateComplexStepCancel.Location = new Point(602, 494);
            buttonUpdateComplexStepCancel.Name = "buttonUpdateComplexStepCancel";
            buttonUpdateComplexStepCancel.Size = new Size(132, 198);
            buttonUpdateComplexStepCancel.TabIndex = 31;
            buttonUpdateComplexStepCancel.Text = "取消";
            buttonUpdateComplexStepCancel.UseVisualStyleBackColor = true;
            buttonUpdateComplexStepCancel.Click += buttonUpdateComplexStepCancel_Click;
            // 
            // buttonUpdateComplexStep
            // 
            buttonUpdateComplexStep.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonUpdateComplexStep.Location = new Point(464, 494);
            buttonUpdateComplexStep.Name = "buttonUpdateComplexStep";
            buttonUpdateComplexStep.Size = new Size(132, 198);
            buttonUpdateComplexStep.TabIndex = 30;
            buttonUpdateComplexStep.Text = "更新";
            buttonUpdateComplexStep.UseVisualStyleBackColor = true;
            buttonUpdateComplexStep.Click += buttonUpdateComplexStep_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSubStepMoveDown);
            groupBox1.Controls.Add(buttonSubStepMoveUp);
            groupBox1.Controls.Add(buttonRemoveSubStep);
            groupBox1.Controls.Add(buttonEditSubStep);
            groupBox1.Controls.Add(buttonAddSubStep);
            groupBox1.Controls.Add(listBoxSubStep);
            groupBox1.Location = new Point(15, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(740, 430);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "子指令设置";
            // 
            // buttonSubStepMoveDown
            // 
            buttonSubStepMoveDown.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonSubStepMoveDown.Location = new Point(367, 240);
            buttonSubStepMoveDown.Name = "buttonSubStepMoveDown";
            buttonSubStepMoveDown.Size = new Size(68, 63);
            buttonSubStepMoveDown.TabIndex = 33;
            buttonSubStepMoveDown.Text = "▼";
            buttonSubStepMoveDown.UseVisualStyleBackColor = true;
            buttonSubStepMoveDown.Click += buttonSubStepMoveDown_Click;
            // 
            // buttonSubStepMoveUp
            // 
            buttonSubStepMoveUp.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonSubStepMoveUp.Location = new Point(367, 127);
            buttonSubStepMoveUp.Name = "buttonSubStepMoveUp";
            buttonSubStepMoveUp.Size = new Size(68, 68);
            buttonSubStepMoveUp.TabIndex = 32;
            buttonSubStepMoveUp.Text = "▲";
            buttonSubStepMoveUp.UseVisualStyleBackColor = true;
            buttonSubStepMoveUp.Click += buttonSubStepMoveUp_Click;
            // 
            // buttonRemoveSubStep
            // 
            buttonRemoveSubStep.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonRemoveSubStep.Location = new Point(448, 170);
            buttonRemoveSubStep.Name = "buttonRemoveSubStep";
            buttonRemoveSubStep.Size = new Size(271, 108);
            buttonRemoveSubStep.TabIndex = 30;
            buttonRemoveSubStep.Text = "删除子指令";
            buttonRemoveSubStep.UseVisualStyleBackColor = true;
            buttonRemoveSubStep.Click += buttonRemoveSubStep_Click;
            // 
            // buttonEditSubStep
            // 
            buttonEditSubStep.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonEditSubStep.Location = new Point(448, 305);
            buttonEditSubStep.Name = "buttonEditSubStep";
            buttonEditSubStep.Size = new Size(271, 108);
            buttonEditSubStep.TabIndex = 31;
            buttonEditSubStep.Text = "编辑子指令";
            buttonEditSubStep.UseVisualStyleBackColor = true;
            buttonEditSubStep.Click += buttonEditSubStep_Click;
            // 
            // buttonAddSubStep
            // 
            buttonAddSubStep.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonAddSubStep.Location = new Point(448, 37);
            buttonAddSubStep.Name = "buttonAddSubStep";
            buttonAddSubStep.Size = new Size(271, 103);
            buttonAddSubStep.TabIndex = 29;
            buttonAddSubStep.Text = "新建子指令";
            buttonAddSubStep.UseVisualStyleBackColor = true;
            buttonAddSubStep.Click += buttonAddSubStep_Click;
            // 
            // listBoxSubStep
            // 
            listBoxSubStep.FormattingEnabled = true;
            listBoxSubStep.Location = new Point(17, 37);
            listBoxSubStep.Name = "listBoxSubStep";
            listBoxSubStep.Size = new Size(344, 376);
            listBoxSubStep.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 452);
            label10.Name = "label10";
            label10.Size = new Size(158, 31);
            label10.TabIndex = 26;
            label10.Text = "复杂任务描述";
            // 
            // richTextComplexDescription
            // 
            richTextComplexDescription.Location = new Point(35, 494);
            richTextComplexDescription.Name = "richTextComplexDescription";
            richTextComplexDescription.Size = new Size(344, 198);
            richTextComplexDescription.TabIndex = 25;
            richTextComplexDescription.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label9.Location = new Point(151, 781);
            label9.Name = "label9";
            label9.Size = new Size(326, 31);
            label9.TabIndex = 24;
            label9.Text = "此页面配置复杂类任务的信息";
            // 
            // richTextBox3
            // 
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            richTextBox3.Location = new Point(151, 827);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(591, 119);
            richTextBox3.TabIndex = 23;
            richTextBox3.Text = "1. 通过新建、删除、编辑等按钮，建立多个子指令\n2. 子指令列表右面的上下箭头按钮可改变选中指令的先后顺序\n3. 输入复杂任务的具体描述\n4. 点击“加入指令”按钮，新增执行指令";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = SigmaTaskDefinitionUI.Properties.Resources.Tips;
            pictureBox1.Location = new Point(27, 826);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // buttonAddComplexStep
            // 
            buttonAddComplexStep.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonAddComplexStep.Location = new Point(463, 494);
            buttonAddComplexStep.Name = "buttonAddComplexStep";
            buttonAddComplexStep.Size = new Size(271, 198);
            buttonAddComplexStep.TabIndex = 21;
            buttonAddComplexStep.Text = "加入指令";
            buttonAddComplexStep.UseVisualStyleBackColor = true;
            buttonAddComplexStep.Click += buttonAddComplexStep_Click;
            // 
            // treeView
            // 
            treeView.ContextMenuStrip = contextMenuStripTreeView;
            treeView.ImageIndex = 0;
            treeView.ImageList = imageList;
            treeView.Location = new Point(839, 109);
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
            contextMenuStripTreeView.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripMenuItemExpandAll, toolStripSeparator2, toolStripMenuItemEdit });
            contextMenuStripTreeView.Name = "contextMenuStripTreeView";
            contextMenuStripTreeView.Size = new Size(233, 92);
            contextMenuStripTreeView.ItemClicked += contextMenuStripTreeView_ItemClicked;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(229, 6);
            // 
            // toolStripMenuItemExpandAll
            // 
            toolStripMenuItemExpandAll.Name = "toolStripMenuItemExpandAll";
            toolStripMenuItemExpandAll.Size = new Size(232, 38);
            toolStripMenuItemExpandAll.Text = "展开所有节点";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(229, 6);
            // 
            // toolStripMenuItemEdit
            // 
            toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            toolStripMenuItemEdit.Size = new Size(232, 38);
            toolStripMenuItemEdit.Text = "属性";
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
            imageList.Images.SetKeyName(4, "Complex.png");
            imageList.Images.SetKeyName(5, "Substep.png");
            // 
            // buttonOutput
            // 
            buttonOutput.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonOutput.Location = new Point(1609, 705);
            buttonOutput.Name = "buttonOutput";
            buttonOutput.Size = new Size(271, 198);
            buttonOutput.TabIndex = 5;
            buttonOutput.Text = "输出";
            buttonOutput.UseVisualStyleBackColor = true;
            buttonOutput.Click += buttonOutput_Click;
            // 
            // buttonNodeUp
            // 
            buttonNodeUp.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonNodeUp.Location = new Point(1561, 111);
            buttonNodeUp.Name = "buttonNodeUp";
            buttonNodeUp.Size = new Size(84, 82);
            buttonNodeUp.TabIndex = 6;
            buttonNodeUp.Text = "▲";
            buttonNodeUp.UseVisualStyleBackColor = true;
            buttonNodeUp.Click += buttonNodeUp_Click;
            // 
            // buttonNodeDown
            // 
            buttonNodeDown.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonNodeDown.Location = new Point(1561, 198);
            buttonNodeDown.Name = "buttonNodeDown";
            buttonNodeDown.Size = new Size(84, 82);
            buttonNodeDown.TabIndex = 7;
            buttonNodeDown.Text = "▼";
            buttonNodeDown.UseVisualStyleBackColor = true;
            buttonNodeDown.Click += buttonNodeDown_Click;
            // 
            // buttonNodeDelete
            // 
            buttonNodeDelete.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNodeDelete.Location = new Point(1561, 286);
            buttonNodeDelete.Name = "buttonNodeDelete";
            buttonNodeDelete.Size = new Size(84, 82);
            buttonNodeDelete.TabIndex = 8;
            buttonNodeDelete.Text = "✖";
            buttonNodeDelete.UseVisualStyleBackColor = true;
            buttonNodeDelete.Click += buttonNodeDelete_Click;
            // 
            // buttonMainClose
            // 
            buttonMainClose.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonMainClose.Location = new Point(1609, 920);
            buttonMainClose.Name = "buttonMainClose";
            buttonMainClose.Size = new Size(271, 143);
            buttonMainClose.TabIndex = 9;
            buttonMainClose.Text = "关闭";
            buttonMainClose.UseVisualStyleBackColor = true;
            buttonMainClose.Click += buttonMainClose_Click;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(32, 32);
            menuStrip.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemFile, ToolStripMenuItemHelp });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1920, 39);
            menuStrip.TabIndex = 10;
            menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            ToolStripMenuItemFile.Size = new Size(82, 35);
            ToolStripMenuItemFile.Text = "文件";
            // 
            // ToolStripMenuItemHelp
            // 
            ToolStripMenuItemHelp.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemHelpAbout });
            ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            ToolStripMenuItemHelp.Size = new Size(82, 35);
            ToolStripMenuItemHelp.Text = "帮助";
            // 
            // ToolStripMenuItemHelpAbout
            // 
            ToolStripMenuItemHelpAbout.Name = "ToolStripMenuItemHelpAbout";
            ToolStripMenuItemHelpAbout.Size = new Size(195, 44);
            ToolStripMenuItemHelpAbout.Text = "关于";
            ToolStripMenuItemHelpAbout.Click += toolStripMenuItemHelpAbout_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(0, 42);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1920, 10);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(menuStrip);
            Controls.Add(buttonMainClose);
            Controls.Add(buttonNodeDelete);
            Controls.Add(buttonNodeDown);
            Controls.Add(buttonNodeUp);
            Controls.Add(buttonOutput);
            Controls.Add(treeView);
            Controls.Add(tabControlTask);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "Form";
            Text = "Sigma指令生成工具";
            Load += Form1_Load;
            tabControlTask.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTip1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureITips2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTip3).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStripTreeView.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ButtonNewTask_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private TextBox textTaskName;
        private Label label1;
        private TabControl tabControlTask;
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
        private DateTimePicker dateTimeDoDuring;
        private Label label6;
        private RichTextBox richTextBox2;
        private PictureBox pictureTip3;
        private Label label8;
        private Label label7;
        private RichTextBox richTextDoDescription;
        private Button buttonAddDoStep;
        private Button buttonAddComplexStep;
        private Label label9;
        private RichTextBox richTextBox3;
        private PictureBox pictureBox1;
        private Label label10;
        private RichTextBox richTextComplexDescription;
        private GroupBox groupBox1;
        private Button buttonAddSubStep;
        private ListBox listBoxSubStep;
        private Button buttonRemoveSubStep;
        private Button buttonEditSubStep;
        private Button buttonSubStepMoveDown;
        private Button buttonSubStepMoveUp;
        private Button buttonUpdateGatherStep;
        private Button buttonUpdateDoStep;
        private Button buttonUpdateGatherStepCancel;
        private Button buttonUpdateDoStepCancel;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItemExpandAll;
        private Button buttonUpdateTaskCancel;
        private Button buttonUpdateTask;
        private Button buttonUpdateComplexStep;
        private Button buttonUpdateComplexStepCancel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem ToolStripMenuItemFile;
        private ToolStripMenuItem ToolStripMenuItemHelp;
        private ToolStripMenuItem ToolStripMenuItemHelpAbout;
        private TableLayoutPanel tableLayoutPanel1;
    }
}